using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class EditMommonForm : Form
    {
        private readonly string _connectionString;
        private readonly string _originalMamm;

        public EditMommonForm(
            string connectionString,
            string mamm,
            string mahp,
            string magv,
            string hk,
            string nam)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _originalMamm = mamm;

            // Hiển thị dữ liệu
            txtMAMM.Text = mamm;
            txtMAHP.Text = mahp;
            txtMAGV.Text = magv;
            txtHK.Text = hk;
            txtNAM.Text = nam;

            // Khóa các trường không được sửa
            txtMAMM.ReadOnly = true;
            txtHK.ReadOnly = true;
            txtNAM.ReadOnly = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate dữ liệu
                if (string.IsNullOrWhiteSpace(txtMAHP.Text) || string.IsNullOrWhiteSpace(txtMAGV.Text))
                    throw new Exception("Vui lòng nhập đầy đủ MAHP và MAGV");

                // Thực hiện cập nhật trong Task để tránh block UI
                await Task.Run(async () =>
                {
                    using (var conn = new OracleConnection(_connectionString))
                    using (var cmd = new OracleCommand(
                        "UPDATE QLDH.QLDH_MOMON " +
                        "SET MAHP = :mahp, MAGV = :magv " +
                        "WHERE MAMM = :mamm",
                        conn))
                    {
                        cmd.Parameters.Add("mahp", OracleDbType.Varchar2).Value = txtMAHP.Text.Trim();
                        cmd.Parameters.Add("magv", OracleDbType.Varchar2).Value = txtMAGV.Text.Trim();
                        cmd.Parameters.Add("mamm", OracleDbType.Varchar2).Value = _originalMamm;

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                });

                // Thông báo và đóng form
                MessageBox.Show("Cập nhật thành công!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi Oracle: {ex.Message}\nMã lỗi: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void EditMommonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Đặt kết quả là Cancel
            Close(); // Đóng form
        }
    }
}
