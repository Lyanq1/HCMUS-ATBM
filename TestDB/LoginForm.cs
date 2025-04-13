using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string connectionString = $@"Data Source=localhost:1521/XEPDB1;User Id={username};Password={password}";

            try
            {
                using (var con = new OracleConnection(connectionString))
                {
                    con.Open();

                    // Kiểm tra nếu là DBA
                    if (username.ToUpper() == "QLDH")
                    {
                        var dbaForm = new Form1();
                        dbaForm.Show();
                        this.Hide();
                        return;
                    }

                    // Xác định vai trò
                    string role = "";
                    var cmd = new OracleCommand("SELECT VAITRO FROM QLDH.QLDH_NHANVIEN WHERE MANLD = :username", con);
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();
                    }
                    else
                    {
                        cmd.CommandText = "SELECT MASV FROM QLDH.QLDH_SINHVIEN WHERE MASV = :username"; // Sửa thành :username
                        cmd.Parameters.Clear(); // Xóa tham số cũ
                        cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                        if (cmd.ExecuteScalar() != null) role = "SV";
                        else throw new Exception("Người dùng không tồn tại");
                    }

                    Form roleForm;
                    switch (role)
                    {
                        case "GV":
                            roleForm = new GiaoDienGV(connectionString);
                            break;
                        case "NV PĐT":
                            roleForm = new GiaoDienNVPDT(connectionString);
                            break;
                        case "TRGĐV":
                            roleForm = new GiaoDienTRGDV(connectionString);
                            break;
                        case "SV":
                            roleForm = new GiaoDienSV(connectionString);
                            break;
                        default:
                            throw new Exception("Vai trò không hợp lệ");
                    }

                    roleForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}