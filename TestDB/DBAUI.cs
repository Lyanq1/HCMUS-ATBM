using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class DBAUI : Form
    {
        public DBAUI()
        {
            InitializeComponent();
        }
        public static OracleConnection con;
        public static string current_user;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                // Chuỗi kết nối tới Oracle CDB
                string username,password;
                string connectionString = @"Data Source=localhost:1521/XEPDB1;User Id=QLDH;Password=123";
                con = new OracleConnection();
                con.ConnectionString = connectionString;
                con.Open();
                OracleCommand selectUser = con.CreateCommand();
                selectUser.CommandText = "select sys_context('userenv', 'current_user') from dual";
                OracleDataReader reader = selectUser.ExecuteReader();
                reader.Read();
                label3.Text = "Welcome " + reader.GetString(0).ToUpper() + ",";

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT USERNAME, CREATED, LAST_LOGIN FROM dba_users ORDER BY username"; 

                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewUsers.DataSource = dt;
 

                    string query2 = "select * from QLDH_DONVI";
                    OracleDataAdapter adapter2 = new OracleDataAdapter(query2, conn);
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    dataGridViewRoles.DataSource = dt2;
 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối hoặc truy vấn: " + ex.Message);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search for roles")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }    
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search for roles";
                textBox1.ForeColor = Color.Silver;
            }
        }
        private void LoadFormIntoPanel(Form form)
        {
            panel5.Controls.Clear(); // Xóa form cũ
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel5.Controls.Add(form);
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                MessageBox.Show("Vui lòng kết nối đến cơ sở dữ liệu trước");
                return;
            }

            // Mở form quản lý Role
            //EditRoleForm roleForm = new EditRoleForm();
            //roleForm.ShowDialog();

            // Sau khi form đóng, tải lại dữ liệu (nếu cần)
            LoadData();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            try
            {
                LoginUI.con.Dispose();
                LoginUI.con.Close();
                OracleConnection.ClearPool(con);


                MessageBox.Show("Đóng kết nối và đăng xuất thành công");

                LoginUI login = new LoginUI();
                login.Show();
                this.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            LoginUI.con.Dispose();
            LoginUI.con.Close();
            OracleConnection.ClearPool(con);

            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new UserPrivileges());
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if (dataGridViewUsers.SelectedRows.Count == 0) return;
            //string selectedUser = dataGridViewUsers.SelectedRows[0].Cells["USERNAME"].Value.ToString();

            //var editForm = new CreateEditUserRoleForm(con, "USER", selectedUser);
            //if (editForm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadUsersAndRoles();
            //}

        }

        // Day la gridview cua USEr
        private void dataGridViewRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Create user button
        private void button3_Click(object sender, EventArgs e)
        {
            //// Hiển thị form tạo mới với chế độ USER hoặc ROLE
            //var createForm = new CreateEditUserRoleForm(con, "USER"); // Thay "USER" bằng "ROLE" nếu tạo role
            //if (createForm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadUsersAndRoles(); // Refresh danh sách sau khi tạo
            //}
        }
    }
}
