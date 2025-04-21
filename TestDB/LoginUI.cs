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
                else if (Role.Text == "Nhân Viên")
                {
                    MessageBox.Show("Connect nhân viên thành công");
                    //OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    //command.ExecuteNonQuery();
                    //string sqlRole = "";
                    //if (role.Text != "Nhân sự" && role.Text != "Trưởng phòng" && role.Text != "Quản lý")
                    //{
                    //    sqlRole = "SELECT VAITRO FROM QLDA.V_QLDA_NHANVIEN WHERE MANV = :manv";
                    //}
                    //else
                    //{
                    //    sqlRole = "SELECT VAITRO FROM QLDA.V_QLDA_NHANVIEN_NS WHERE MANV = :manv";
                    //}
                    //OracleCommand command_role = new OracleCommand(sqlRole, con);
                    //command_role.Parameters.Add(new OracleParameter("manv", username.Text));
                    //OracleDataReader dr = command_role.ExecuteReader();
                    //if (dr.Read())
                    //{
                    //    roleUser = dr.GetString(0);
                    //    if (role.Text != roleUser)
                    //    {
                    //        MessageBox.Show("Role không khớp với User");
                    //        con.Dispose();
                    //        con.Close();
                    //        OracleConnection.ClearPool(con);
                    //        return;
                    //    }
                    //}
                    ////this.Hide();

                    //MessageBox.Show("Connect với Oracle thành công");
                    // Xác định roleUser từ CSDL (giống code cũ)
                    // Xác định xem có phải NVPDT không
                    string roleUser = "";
                    string username = Username.Text;// Lấy mã nhân viên từ username

                    OracleCommand cmd = new OracleCommand(
                        "SELECT VAITRO FROM QLDH.QLDH_NHANVIEN WHERE MANLD = :username",
                        con
                    );
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        roleUser = result.ToString();
                        bool isNVPDT = (roleUser == "NV PĐT");

                        var roleForm = new NhanVienUI(
                            connectionString,
                            isNVPDT,
                            roleUser,
                            username
                        );
                        roleForm.Show();
                    }
                  
                    //switch (roleUser)
                    //{
                    //    case "Nhân viên":
                    //        NVUI.Text = "NHÂN VIÊN";
                    //        break;
                    //    case "Quản lý":
                    //        NVUI.Text = "QUẢN LÝ";
                    //        break;
                    //    case "Trưởng phòng":
                    //        NVUI.Text = "TRƯỞNG PHÒNG";
                    //        break;
                    //    case "Tài chính":
                    //        NVUI.Text = "TÀI CHÍNH";
                    //        break;
                    //    case "Nhân sự":
                    //        NVUI.Text = "NHÂN SỰ";
                    //        break;
                    //    case "Trưởng dự án":
                    //        NVUI.Text = "TRƯỞNG DỰ ÁN";
                    //        break;
                    //    case "Giám đốc":
                    //        NVUI.Text = "GIÁM ĐỐC";
                    //        break;
                    //}

                    //NVUI.Show();
                    //dr.Close();
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
