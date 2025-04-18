using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class GiaoDienTRGDV : Form
    {
        private readonly OracleConnection _conn;

        public GiaoDienTRGDV(string connectionString)
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
                var query = @"SELECT m.* 
                            FROM QLDH.QLDH_MOMON m
                            JOIN QLDH.QLDH_NHANVIEN nv ON m.MAGV = nv.MANLD
                            WHERE nv.MADV = (SELECT MADV FROM QLDH.QLDH_DONVI WHERE TRGDV = USER)";

                var adapter = new OracleDataAdapter(query, _conn);
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
    }
}
