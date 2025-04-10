using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();   // VD: GV001
            string password = txtPassword.Text.Trim();   // VD: 123

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {
                // Dùng username và password người dùng nhập để kết nối
                string connStr = $"User Id={username};Password={password};Data Source=localhost:1521/XEPDB1;";
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    // Lấy vai trò từ bảng (nếu muốn hiển thị lên app)
                    string query = "SELECT VAITRO FROM QLDH.QLDH_NHANVIEN WHERE MANLD = SYS_CONTEXT('USERENV','SESSION_USER')";

                    OracleCommand cmd = new OracleCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    string vaitro = result?.ToString() ?? "Không rõ";
                    MessageBox.Show($"Đăng nhập thành công với vai trò: {vaitro}");

                    RBAC mainForm = new RBAC(username, vaitro, connStr); // truyền cả connStr nếu cần dùng lại
                    mainForm.Show();
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
