using Oracle.ManagedDataAccess.Client;
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

namespace TestDB
{
    public partial class MoMon_table : UserControl
    {
        private string _connectionString;
        private bool _isNVPDT;

        // Constructor cho Designer (không tham số)
        public MoMon_table()
        {
            InitializeComponent();
            ConfigureGrid(); // Cấu hình grid nhưng CHƯA phân quyền
        }

        // Constructor chính (có tham số)
        public MoMon_table(string connectionString, bool isNVPDT) : this()
        {
            _connectionString = connectionString;
            _isNVPDT = isNVPDT;
            ConfigurePermissions(); // Phân quyền sau khi có tham số
        }

        private void ConfigurePermissions()
        {
            // Ẩn hiện nút theo role NVPDT
            btnAdd.Visible = _isNVPDT;
            btnEdit.Visible = _isNVPDT;
            btnDelete.Visible = _isNVPDT;
            btnRefresh.Visible = _isNVPDT;
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

        private async void MoMon_table_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                using (var conn = new OracleConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    var adapter = new OracleDataAdapter("SELECT * FROM QLDH.QLDH_MOMON", conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.Invoke((MethodInvoker)delegate
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
            }
        }

        // Xử lý sự kiện các nút
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddMommonForm(_connectionString);
            addForm.Show();
            addForm.FormClosed += async (s, args) => await LoadDataAsync();
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
            editForm.Show();
            editForm.FormClosed += async (s, args) => await LoadDataAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            try
            {
                using (var conn = new OracleConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    var cmd = new OracleCommand(
                        "DELETE FROM QLDH.QLDH_MOMON WHERE MAMM = :mamm",
                        conn
                    );
                    cmd.Parameters.Add("mamm", OracleDbType.Varchar2).Value =
                        dataGridView1.SelectedRows[0].Cells["MAMM"].Value.ToString();

                    await cmd.ExecuteNonQueryAsync();
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa: {ex.Message}");
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OLSForm olsForm = new OLSForm();
            olsForm.Show();
        }
    }
}


