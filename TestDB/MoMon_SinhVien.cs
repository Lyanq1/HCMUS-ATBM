using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDB;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class MoMon_SinhVien : UserControl
    {
        public MoMon_SinhVien()
        {
            InitializeComponent();
        }
        public static OracleConnection conNow = LoginUI.con;
        private void MoMon_SinhVien_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit(); // Hoặc this.Close() nếu chỉ đóng form này
        }
        private void LoadData()
        {
            try
            {

                string sql = "SELECT * FROM QLDH.QLDH_MOMON";

                OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            OLSForm olsForm = new OLSForm();
            olsForm.Show();
        }
    }

}





