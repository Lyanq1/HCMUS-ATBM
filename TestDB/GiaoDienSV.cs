using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class GiaoDienSV : Form
    {
        private readonly OracleConnection _conn;

        public GiaoDienSV(string connectionString)
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
            finally
            {
                _conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // Hoặc this.Close() nếu chỉ đóng form này
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}