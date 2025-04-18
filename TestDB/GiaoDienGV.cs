using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class GiaoDienGV : Form
    {
        private readonly OracleConnection _conn;

        public GiaoDienGV(string connectionString)
        {
            InitializeComponent();
            _conn = new OracleConnection(connectionString);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _conn.Open();
                var adapter = new OracleDataAdapter("SELECT * FROM QLDH.QLDH_MOMON", _conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void GiaoDienGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            _conn?.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
