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
        public static OracleConnection conNow;
        public static string current_user;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conNow = LoginUI.con;
                OracleCommand selectUser = conNow.CreateCommand();
                selectUser.CommandText = "select sys_context('userenv', 'current_user') from dual";
                OracleDataReader reader = selectUser.ExecuteReader();
                if (reader.Read())
                {
                    label3.Text = "Welcome " + reader.GetString(0).ToUpper() + ",";
                }
                reader.Close();


                string query = "SELECT USERNAME, CREATED, LAST_LOGIN FROM dba_users ORDER BY last_login"; 

                OracleDataAdapter adapter = new OracleDataAdapter(query, conNow);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewUsers.DataSource = dt;
 
                string query2 = "SELECT ROLE, PASSWORD_REQUIRED AS PASSWORD_REQ,authentication_type,common FROM dba_roles ORDER BY ROLE";
                OracleDataAdapter adapter2 = new OracleDataAdapter(query2, conNow);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dataGridViewRoles.DataSource = dt2;
                
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

        private void button1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button8_Click(object sender, EventArgs e) { }
        private void iconButton1_Click(object sender, EventArgs e) 
        {
            //LoadFormIntoPanel(new DBAUI());
        }
        private void iconPictureBox1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        // Day la gridview cua USEr
        private void dataGridViewRoles_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        //Logout_btn
        private void iconButton7_Click(object sender, EventArgs e)
        {
            try
            {
                LoginUI.con.Dispose();
                LoginUI.con.Close();
                OracleConnection.ClearPool(conNow);


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

        //Exit_btn
        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            LoginUI.con.Dispose();
            LoginUI.con.Close();
            OracleConnection.ClearPool(conNow);

            Application.Exit();
        }

        //tab_user_privil
        private void iconButton2_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new UserPrivileges());
        }

        private void rolePriviTab_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new RolePrivileges());

        }
        private void objPriviTab_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new ObjectPrivileges());

        }
        // Phương thức cập nhật danh sách users và roles sau khi insert và delete
        private void LoadUsersAndRoles()
        {
            try
            {
                // Load Users
                string userQuery = @"SELECT USERNAME, CREATED, LAST_LOGIN FROM dba_users ORDER BY last_login";
                OracleDataAdapter userAdapter = new OracleDataAdapter(userQuery, conNow);
                DataTable dtUsers = new DataTable();
                userAdapter.Fill(dtUsers);
                dataGridViewUsers.DataSource = dtUsers;

                // Load Roles
                string roleQuery = @"SELECT ROLE, PASSWORD_REQUIRED AS PASSWORD_REQ,authentication_type,common FROM dba_roles ORDER BY ROLE";
                OracleDataAdapter roleAdapter = new OracleDataAdapter(roleQuery, conNow);
                DataTable dtRoles = new DataTable();
                roleAdapter.Fill(dtRoles);
                dataGridViewRoles.DataSource = dtRoles;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        

        //cai nay la edit user
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn user cần chỉnh sửa!");
                return;
            }
            string selectedUser = dataGridViewUsers.SelectedRows[0].Cells["USERNAME"].Value.ToString();

            var editForm = new CreateEditUserRoleForm (conNow, "USER", selectedUser);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles();
            }

        }

        //Create user button
        private void button3_Click(object sender, EventArgs e)
        {
            // Hiển thị form tạo mới với chế độ USER hoặc ROLE
            var createForm = new CreateEditUserRoleForm (conNow, "USER"); // Thay "USER" bằng "ROLE" nếu tạo role
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles(); // Refresh danh sách sau khi tạo
            }
        }

        //Delete user
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn user cần xóa!");
                return;
            }

            string username = dataGridViewUsers.SelectedRows[0].Cells["USERNAME"].Value.ToString();

            // Xác nhận xóa
            var confirmResult = MessageBox.Show($"Bạn chắc chắn muốn xóa user '{username}'?",
                                              "Xác nhận xóa",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                // Kiểm tra kết nối
                

                // Sử dụng parameterized query
                string query = $"DROP USER {username} CASCADE";
                using (var cmd = new OracleCommand(query, conNow))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Đã xóa user '{username}' thành công!");
                    LoadUsersAndRoles();
                }
            }
            catch (OracleException ex) when (ex.Number == 1942) // ORA-01942: user does not exist
            {
                MessageBox.Show($"User '{username}' không tồn tại!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi Oracle: {ex.Message}\nMã lỗi: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //edit roles
        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        //create roles
        private void button6_Click_1(object sender, EventArgs e)
        {
            // Hiển thị form tạo mới với chế độ USER hoặc ROLE
            var createForm = new CreateEditUserRoleForm(conNow, "ROLE"); // Thay "USER" bằng "ROLE" nếu tạo role
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles(); // Refresh danh sách sau khi tạo
            }
        }

        //delete roles
        private void button5_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không, giả sử bạn có DataGridView hiển thị list Role (dataGridViewRoles)
            if (dataGridViewRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn role cần xóa!");
                return;
            }

            // Lấy tên Role từ cột "ROLENAME". Cột này cần phải khớp với tên được đặt khi load dữ liệu của role
            string roleName = dataGridViewRoles.SelectedRows[0].Cells["ROLE"].Value.ToString();

            // Hiển thị hộp thoại xác nhận xóa
            var confirmResult = MessageBox.Show($"Bạn chắc chắn muốn xóa role '{roleName}'?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
               

                // Tạo câu lệnh DROP ROLE
                string query = $"DROP ROLE {roleName}";
                using (var cmd = new OracleCommand(query, conNow))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Đã xóa role '{roleName}' thành công!");
                    LoadUsersAndRoles(); // Cập nhật lại danh sách role
                }
            }
            catch (OracleException ex)
            {
                // Nếu có lỗi Oracle, báo lỗi ra.
                MessageBox.Show($"Lỗi Oracle: {ex.Message}\nMã lỗi: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
            }
        }

        private void revokePrivilTab_Click(object sender, EventArgs e)
        {

        }
    }
}
