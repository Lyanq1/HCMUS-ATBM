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
            string query = "SELECT * from QuanLyDH.QLDH_SINHVIEN";

            OracleDataAdapter adapter = new OracleDataAdapter(query, LoginUI.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

            if (txtDChi.Text.ToString() == null)
            {

                string query1 = "Update QuanLyDH.QLDH_SINHVIEN set DT = " + txtSDT.Text.ToString() + " where MaSV = " + LoginUI.userUser;
                var cmd = new OracleCommand(query1, LoginUI.con);
                cmd.ExecuteNonQuery();
            }
            else if (txtSDT.Text.ToString() == null)
            {
                string query2 = "Update QuanLyDH.QLDH_SINHVIEN set DCHI = " + txtDChi.Text.ToString() + " where MaSV = " + LoginUI.userUser;
                var cmd = new OracleCommand(query2, LoginUI.con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string query1 = "Update QuanLyDH.QLDH_SINHVIEN set DT = " + txtSDT.Text.ToString() + " where MaSV = " + LoginUI.userUser;
                string query2 = "Update QuanLyDH.QLDH_SINHVIEN set DCHI = " + txtDChi.Text.ToString() + " where MaSV = " + LoginUI.userUser;
                var cmd1 = new OracleCommand(query1, LoginUI.con);
                cmd1.ExecuteNonQuery();
                var cmd2 = new OracleCommand(query2, LoginUI.con);
                cmd2.ExecuteNonQuery();
            }
            string query = "SELECT * from QuanLyDH.QLDH_SINHVIEN";

            OracleDataAdapter adapter = new OracleDataAdapter(query, LoginUI.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        /*private void btnChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
            
                // Nếu có số điện thoại nhập vào
                if (!string.IsNullOrWhiteSpace(txtSDT.Text.ToString()))
                {
                    string query1 = "UPDATE QuanLyDH.QLDH_SINHVIEN SET DT = :sdt WHERE MaSV = :masv";
                    using (var cmd1 = new OracleCommand(query1, LoginUI.con))
                    {
                        cmd1.Parameters.Add(new OracleParameter("sdt", txtSDT.Text));
                        cmd1.Parameters.Add(new OracleParameter("masv", LoginUI.userUser));
                        cmd1.ExecuteNonQuery();
                    }
                }

                // Nếu có địa chỉ nhập vào
                if (!string.IsNullOrWhiteSpace(txtDChi.Text))
                {
                    string query2 = "UPDATE QuanLyDH.QLDH_SINHVIEN SET DCHI = :dchi WHERE MaSV = :masv";
                    using (var cmd2 = new OracleCommand(query2, LoginUI.con))
                    {
                        cmd2.Parameters.Add(new OracleParameter("dchi", txtDChi.Text));
                        cmd2.Parameters.Add(new OracleParameter("masv", LoginUI.userUser));
                        cmd2.ExecuteNonQuery();
                    }
                }

                // Load lại dữ liệu
                string query = "SELECT * from QuanLyDH.QLDH_SINHVIEN";
                OracleDataAdapter adapter = new OracleDataAdapter(query, LoginUI.con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
