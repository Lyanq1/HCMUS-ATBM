using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class Form1 : Form
    {
        private OracleConnection con;
        private string connectionString = @"Data Source=localhost:1521/XEPDB1;User Id=QLDH;Password=123";

        public Form1()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
            con.Open();
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.MultiSelect = false;
            dataGridViewRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoles.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsersAndRoles();
        }
        // Phương thức cập nhật danh sách users và roles
        private void LoadUsersAndRoles()
        {
            try
            {
                // Load Users
                string userQuery = @"SELECT USERNAME AS USERNAME, CREATED, ACCOUNT_STATUS AS STATUS 
                                   FROM dba_users 
                                   ORDER BY USERNAME";
                OracleDataAdapter userAdapter = new OracleDataAdapter(userQuery, con);
                DataTable dtUsers = new DataTable();
                userAdapter.Fill(dtUsers);
                dataGridViewUsers.DataSource = dtUsers;

                // Load Roles
                string roleQuery = @"SELECT ROLE AS ROLENAME, PASSWORD_REQUIRED AS PASSWORD_REQ 
                                    FROM dba_roles 
                                    ORDER BY ROLE";
                OracleDataAdapter roleAdapter = new OracleDataAdapter(roleQuery, con);
                DataTable dtRoles = new DataTable();
                roleAdapter.Fill(dtRoles);
                dataGridViewRoles.DataSource = dtRoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // Xử lý nút tạo mới role
        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            // Hiển thị form tạo mới với chế độ USER hoặc ROLE
            var createForm = new CreateEditUserRoleForm(con, "ROLE"); // Thay "USER" bằng "ROLE" nếu tạo role
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles(); // Refresh danh sách sau khi tạo
            }
        }

        // Xử lý nút xóa role
        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không, giả sử bạn có DataGridView hiển thị list Role (dataGridViewRoles)
            if (dataGridViewRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn role cần xóa!");
                return;
            }

            // Lấy tên Role từ cột "ROLENAME". Cột này cần phải khớp với tên được đặt khi load dữ liệu của role
            string roleName = dataGridViewRoles.SelectedRows[0].Cells["ROLENAME"].Value.ToString();

            // Hiển thị hộp thoại xác nhận xóa
            var confirmResult = MessageBox.Show($"Bạn chắc chắn muốn xóa role '{roleName}'?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                // Kiểm tra và mở kết nối nếu chưa mở
                if (con.State != ConnectionState.Open)
                    con.Open();

                // Tạo câu lệnh DROP ROLE
                string query = $"DROP ROLE {roleName}";
                using (var cmd = new OracleCommand(query, con))
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


        // Xử lý nút cấp quyền
        private void btnGrant_Click(object sender, EventArgs e)
        {
            var frm = new GrantRevokeForm(con, isGrant: true);
            frm.ShowDialog();
        }

        // Xử lý nút xem thông tin quyền
        private void btnViewPermissions_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0) return;

            var userName = dataGridViewUsers.SelectedRows[0].Cells["NAME"].Value.ToString();
            var frm = new PermissionInfoForm(con, userName);
            frm.ShowDialog();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
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
                if (con.State != ConnectionState.Open)
                    con.Open();

                // Sử dụng parameterized query
                string query = $"DROP USER {username} CASCADE";
                using (var cmd = new OracleCommand(query, con))
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0) return;

            string selectedUser = dataGridViewUsers.SelectedRows[0].Cells["USERNAME"].Value.ToString();

            var editForm = new CreateEditUserRoleForm(con, "USER", selectedUser);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles();
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Hiển thị form tạo mới với chế độ USER hoặc ROLE
            var createForm = new CreateEditUserRoleForm(con, "USER"); // Thay "USER" bằng "ROLE" nếu tạo role
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles(); // Refresh danh sách sau khi tạo
            }
        }
    }
}
