using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Oracle.ManagedDataAccess.Client;


namespace TestDB
{
    public partial class SinhVien_table : UserControl
    {
        public SinhVien_table()
        {
            InitializeComponent();
        }

        private void SinhVien_table_Load(object sender, EventArgs e)
        {
            string query = "SELECT * from QLDH.QLDH_SINHVIEN";

            OracleDataAdapter adapter = new OracleDataAdapter(query, LoginUI.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {


            string sdt = txtSDT.Text.Trim();
            string dchi = txtDChi.Text.Trim();

            if (string.IsNullOrWhiteSpace(sdt) && string.IsNullOrWhiteSpace(dchi))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin để cập nhật.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(sdt))
            {
                string query1 = "UPDATE QLDH.QLDH_SINHVIEN SET DT = :sdt WHERE MASV = :masv";
                using (OracleCommand cmd = new OracleCommand(query1, LoginUI.con))
                {
                    cmd.Parameters.Add(":sdt", OracleDbType.Varchar2).Value = sdt;
                    cmd.Parameters.Add(":masv", OracleDbType.Varchar2).Value = LoginUI.userUser;
                    cmd.ExecuteNonQuery();
                }
            }

            if (!string.IsNullOrWhiteSpace(dchi))
            {
                string query2 = "UPDATE QLDH.QLDH_SINHVIEN SET DCHI = :dchi WHERE MASV = :masv";
                using (OracleCommand cmd = new OracleCommand(query2, LoginUI.con))
                {
                    cmd.Parameters.Add(":dchi", OracleDbType.Varchar2).Value = dchi;
                    cmd.Parameters.Add(":masv", OracleDbType.Varchar2).Value = LoginUI.userUser;
                    cmd.ExecuteNonQuery();
                }
            }

            string query = "SELECT * from QLDH.QLDH_SINHVIEN";

            OracleDataAdapter adapter = new OracleDataAdapter(query, LoginUI.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            MessageBox.Show("Cập nhật thành công!");

        }
        


        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
