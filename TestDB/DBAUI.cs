using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class DBAUI : Form
    {
        private OracleConnection con;
        private string connectionString = @"Data Source=localhost:1521/XEPDB1;User Id=QLDH;Password=123";
        public DBAUI()
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

        // ROLE
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

        // USER
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Hiển thị form tạo mới với chế độ USER hoặc ROLE
            var createForm = new CreateEditUserRoleForm(con, "USER"); // Thay "USER" bằng "ROLE" nếu tạo role
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersAndRoles(); // Refresh danh sách sau khi tạo
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
            if (textBox2.ForeColor == Color.Silver && textBox2.Text != "Search for users")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa tìm kiếm
            string searchTerm = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập tên user!");
                return;
            }

            try
            {
                // Mở kết nối nếu chưa mở
                if (con.State != ConnectionState.Open)
                    con.Open();

                // Sử dụng parameterized query
                string query = @"
            SELECT USERNAME, CREATED, ACCOUNT_STATUS 
            FROM dba_users 
            WHERE UPPER(USERNAME) LIKE :searchTerm 
            ORDER BY USERNAME";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.Parameters.Add("searchTerm", OracleDbType.Varchar2).Value = $"%{searchTerm.ToUpper()}%";

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Đổ dữ liệu vào DataTable

                // Gán DataTable vào DataGridView và refresh
                dataGridViewUsers.DataSource = dt;
                dataGridViewUsers.Refresh();

                // Thông báo nếu không có kết quả
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy user chứa '{searchTerm}'");
                }
            }
            catch (OracleException ex) when (ex.Number == 942) // ORA-00942: Không có quyền
            {
                MessageBox.Show("Không có quyền truy cập dba_users!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
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
            LoadUsersAndRoles();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
