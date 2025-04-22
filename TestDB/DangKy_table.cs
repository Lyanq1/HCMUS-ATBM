using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace TestDB
{
    public partial class DangKy_table : UserControl
    {
        public DangKy_table()
        {
            InitializeComponent();
        }

        private void DangKy_table_Load(object sender, EventArgs e)
        {
            //string query = "select * from QLDH.QLDH_DANGKY;";

            //OracleDataAdapter adapter = new OracleDataAdapter(query, LoginUI.con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //dataGridView1.DataSource = dt;

        }
    }
}
