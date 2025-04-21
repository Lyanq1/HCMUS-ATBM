using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Oracle.ManagedDataAccess.Client;


namespace TestDB
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }
        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        public static OracleConnection con;
        public static String userUser;
        public static String passUser;
        public static String roleUser;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            }
            if (Password.Text.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            }
            if (Role.Text.Length == 0)
            {
                MessageBox.Show("VAI TRÒ không được để trống.");
                return;
            }
            try
            {
                string connectionString = "";
                connectionString = @"DATA SOURCE = localhost:1521/XEPDB1; User Id=" + Username.Text + ";Password=" + Password.Text;

                con = new OracleConnection();
                con.ConnectionString = connectionString;
                con.Open();

                userUser = Username.Text;
                passUser = Password.Text;

                if (Role.Text == "ADMIN")
                {

                    //OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    //command.ExecuteNonQuery();
                    MessageBox.Show("Connect với Oracle thành công");
                    ADMINUI dba = new ADMINUI();
                    dba.Show();
                }
                else if (Role.Text == "Sinh Viên") // Thêm case riêng cho sinh viên
                {
                    // Kiểm tra có phải sinh viên
                    OracleCommand cmd = new OracleCommand(
                        "SELECT MASV FROM QLDH.QLDH_SINHVIEN WHERE MASV = :username",
                        con
                    );
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = Username.Text;

                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Đăng nhập sinh viên thành công");
                        GiaoDienSV svForm = new GiaoDienSV(connectionString);
                        svForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên này");
                        con.Close();
                        return;
                    }
                }
                else if (Role.Text == "Nhân Viên")
                {
                    MessageBox.Show("Connect nhân viên thành công");
                    string roleUser = "";
                    string username = Username.Text;

                    // Kiểm tra NHÂN VIÊN
                    OracleCommand cmd = new OracleCommand(
                        "SELECT VAITRO FROM QLDH.QLDH_NHANVIEN WHERE MANLD = :username",
                        con
                    );
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        roleUser = result.ToString();
                    }

                    // Xác định form tương ứng dựa trên role
                    Form roleForm;
                    switch (roleUser)
                    {
                        case "NV PĐT":
                            roleForm = new NhanVienUI(connectionString, true, roleUser, username);
                            break;
                        case "GV":
                        case "TRGĐV":
                        case "NV TCHC":
                            roleForm = new NhanVienUI(connectionString, false, roleUser, username);
                            break;
                        default:
                            MessageBox.Show("Vai trò không hợp lệ");
                            con.Close();
                            return;
                    }

                    roleForm.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
