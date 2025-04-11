using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class GiaoDienNVPDT : Form
    {
        private readonly OracleConnection _conn;
        private DataTable _dataTable;

        public GiaoDienNVPDT(string connectionString)
        {
            InitializeComponent();
            _conn = new OracleConnection(connectionString);
            LoadData();
            ConfigureGrid();
        }

        private void LoadData()
        {
            try
            {
                _conn.Open();
                var adapter = new OracleDataAdapter("SELECT * FROM QLDH.QLDH_MOMON", _conn);
                _dataTable = new DataTable();
                adapter.Fill(_dataTable);
                dataGridView1.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        private void ConfigureGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new EditMommonForm(_conn, isEdit: false);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var selectedRow = dataGridView1.SelectedRows[0];
            var addForm = new EditMommonForm(_conn, isEdit: true,
                mamh: selectedRow.Cells["MAMM"].Value.ToString(),
                mahp: selectedRow.Cells["MAHP"].Value.ToString(),
                magv: selectedRow.Cells["MAGV"].Value.ToString(),
                hk: selectedRow.Cells["HK"].Value.ToString(),
                nam: selectedRow.Cells["NAM"].Value.ToString());

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var confirm = MessageBox.Show("Xác nhận xóa bản ghi này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _conn.Open();
                var cmd = new OracleCommand(
                    "DELETE FROM QLDH.QLDH_MOMON WHERE MAMM = :mamh", _conn);
                cmd.Parameters.Add("mamh",
                    dataGridView1.SelectedRows[0].Cells["MAMM"].Value.ToString());
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}