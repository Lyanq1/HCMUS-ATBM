using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class GiaoDienNVPDT : Form
    {
        private readonly string _connectionString;

        public GiaoDienNVPDT(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            ConfigureGrid();
            this.Load += GiaoDienNVPDT_Load; // Đăng ký sự kiện Load
        }

        private void ConfigureGrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #region Data Loading
        private async void GiaoDienNVPDT_Load(object sender, EventArgs e)
        {
            await LoadDataAsync(); // Tải dữ liệu khi form đã load xong
        }

        private async Task LoadDataAsync()
        {
            try
            {
                using (var conn = new OracleConnection(_connectionString))
                {
                    await conn.OpenAsync();

                    using (var cmd = new OracleCommand("SELECT * FROM QLDH.QLDH_MOMON", conn))
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);

                        // Cập nhật UI an toàn
                        if (dataGridView1.IsHandleCreated)
                        {
                            dataGridView1.Invoke((MethodInvoker)delegate
                            {
                                dataGridView1.DataSource = dt;
                                dataGridView1.Refresh();
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
            }
        }
        #endregion

        #region CRUD Operations
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMommonForm(_connectionString);
            addForm.Show(); // Sử dụng Show() thay vì ShowDialog()

            addForm.FormClosed += async (s, args) =>
            {
                await LoadDataAsync(); // Tải lại dữ liệu sau khi thêm
            };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var selectedRow = dataGridView1.SelectedRows[0];
            var editForm = new EditMommonForm(
                _connectionString,
                selectedRow.Cells["MAMM"].Value.ToString(),
                selectedRow.Cells["MAHP"].Value.ToString(),
                selectedRow.Cells["MAGV"].Value.ToString(),
                selectedRow.Cells["HK"].Value.ToString(),
                selectedRow.Cells["NAM"].Value.ToString()
            );

            editForm.Show(); // Sử dụng Show() thay vì ShowDialog()

            editForm.FormClosed += async (s, args) =>
            {
                await LoadDataAsync(); // Tải lại dữ liệu sau khi chỉnh sửa
            };
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var confirmResult = MessageBox.Show("Xác nhận xóa bản ghi?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                var mamm = dataGridView1.SelectedRows[0].Cells["MAMM"].Value.ToString();

                using (var conn = new OracleConnection(_connectionString))
                using (var cmd = new OracleCommand(
                    "DELETE FROM QLDH.QLDH_MOMON WHERE MAMM = :mamm",
                    conn))
                {
                    cmd.Parameters.Add("mamm", OracleDbType.Varchar2).Value = mamm;
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

                await LoadDataAsync();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa dữ liệu: {ex.Message}");
            }
        }
        #endregion

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
