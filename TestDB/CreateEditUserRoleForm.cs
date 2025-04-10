using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class CreateEditUserRoleForm : Form
    {
        private readonly OracleConnection _connection;
        private readonly string _mode; // "USER" hoặc "ROLE"
        private string _editTarget;

        public CreateEditUserRoleForm(OracleConnection connection, string mode)
        {
            InitializeComponent();
            _connection = connection;
            _mode = mode;
            Text = $"Tạo mới {mode}";
            lblPassword.Visible = txtPassword.Visible = (mode == "USER");
        }

        public CreateEditUserRoleForm(OracleConnection connection, string mode, string editTarget = null)
        {
            InitializeComponent();
            _connection = connection;
            _mode = mode;
            _editTarget = editTarget;

            // Thiết lập form cho chế độ chỉnh sửa
            if (!string.IsNullOrEmpty(_editTarget))
            {
                Text = $"Chỉnh sửa {_mode}";
                txtName.Text = _editTarget;
                txtName.Enabled = false; // Không cho phép sửa tên
            }
            else
            {
                Text = $"Tạo mới {_mode}";
            }

            // Ẩn phần mật khẩu nếu là ROLE
            lblPassword.Visible = txtPassword.Visible = (_mode == "USER");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cmd = new OracleCommand())
                {
                    cmd.Connection = _connection;

                    // Lấy tên từ giao diện (bắt buộc cho cả USER và ROLE)
                    string name = txtName.Text.Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Vui lòng nhập tên!");
                        return;
                    }

                    // Nếu đang trong chế độ chỉnh sửa (Edit) hoặc tạo mới thì xử lý theo mode
                    if (!string.IsNullOrEmpty(_editTarget))
                    {
                        // Trường hợp Edit: Chỉ hỗ trợ Edit cho USER (ví dụ thay đổi mật khẩu)
                        if (_mode == "USER")
                        {
                            string newPassword = txtPassword.Text.Trim();
                            if (string.IsNullOrEmpty(newPassword))
                            {
                                MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                                return;
                            }

                            // Nếu bạn có thêm logic xác thực mật khẩu cũ thì đặt ở đây
                            // Ví dụ: kiểm tra bằng cách mở kết nối với tên user và mật khẩu cũ

                            cmd.CommandText = $"ALTER USER {_editTarget} IDENTIFIED BY {newPassword}";
                        }
                        else
                        {
                            // Nếu _mode là ROLE, hầu như không cần chỉnh sửa Role qua ALTER ROLE (nếu có thuộc tính cần sửa cũng xử lý tương tự)
                            MessageBox.Show("Chức năng chỉnh sửa ROLE chưa được hỗ trợ.");
                            return;
                        }
                    }
                    else
                    {
                        // Trường hợp tạo mới (Create new)
                        if (_mode == "USER")
                        {
                            // Chế độ tạo mới user
                            string password = txtPassword.Text.Trim();
                            if (string.IsNullOrEmpty(password))
                            {
                                MessageBox.Show("Vui lòng nhập mật khẩu!");
                                return;
                            }
                            cmd.CommandText = $"CREATE USER {name} IDENTIFIED BY {password}";
                        }
                        else if (_mode == "ROLE")
                        {
                            // Chế độ tạo mới role, không có mật khẩu
                            cmd.CommandText = $"CREATE ROLE {name}";
                        }
                    }

                    // Thực hiện lệnh DDL
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thao tác thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
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


        private void CreateEditUserRoleForm_Load(object sender, EventArgs e)
        {

        }

    }
}

