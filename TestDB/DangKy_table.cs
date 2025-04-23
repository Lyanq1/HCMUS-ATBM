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
        private string manld;
        private string vaitro;
        string connStr = LoginUI.con.ConnectionString;

        public DangKy_table()
        {
            InitializeComponent();
            ConfigureGrid();

        }
        public static OracleConnection conNow = LoginUI.con;
        private void DangKy_table_Load(object sender, EventArgs e)
        {
            string query = "select * from QLDH.QLDH_DANGKY";

            OracleDataAdapter adapter = new OracleDataAdapter(query, conNow);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMANV.Text = row.Cells["MASV"].Value.ToString();
                txtHOTEN.Text = row.Cells["MAMM"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NGAYBATDAUHK"].Value);
                txtLuong.Text = row.Cells["DIEMTH"].Value.ToString();
                txtPHUCAP.Text = row.Cells["DIEMQT"].Value.ToString();
                txtVAITRO.Text = row.Cells["DIEMCK"].Value.ToString();
                txtMADV.Text = row.Cells["DIEMTK"].Value.ToString();
            

            //else if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //    txtMANV.Text = row.Cells["MANLD"].Value.ToString();
            //    txtHOTEN.Text = row.Cells["HOTEN"].Value.ToString();
            //    dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NGSINH"].Value);
            //    comboBox1.Text = row.Cells["PHAI"].Value.ToString();
            //    txtLuong.Text = row.Cells["LUONG"].Value.ToString();
            //    txtPHUCAP.Text = row.Cells["PHUCAP"].Value.ToString();
            //    txtĐT.Text = row.Cells["DT"].Value.ToString();
            //    txtVAITRO.Text = row.Cells["VAITRO"].Value.ToString();
            //    txtMADV.Text = row.Cells["MADV"].Value.ToString();
            //}
        }

        private void PhanQuyenGiaoDien()
        {
            if (vaitro == "NV PĐT")
            {
                // Nhân sự PĐT có toàn quyền CRUD
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdateAll.Enabled = true;

                // Hiển thị các trường cần thiết
                txtMANV.ReadOnly = true; // Không cho phép sửa mã nhân viên
                txtHOTEN.Visible = true;
                txtLuong.Visible = true;
                txtPHUCAP.Visible = true;
                txtVAITRO.Visible = true;
                txtMADV.Visible = true;
            }
            else if (vaitro == "NVCB")
            {
                // Chỉ hiển thị các trường cần thiết cho NVCB
                txtHOTEN.Visible = false;
                txtLuong.Visible = false;
                txtPHUCAP.Visible = false;
                txtVAITRO.Visible = false;
                txtMADV.Visible = false;
                txtMANV.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdateAll.Visible = false;

                dateTimePicker1.Visible = false;

                btnUpdatePhone.Enabled = true;

            }
            else if (vaitro == "GV")
            {
                // Chỉ hiển thị các trường cần thiết cho TRGĐV
                txtHOTEN.Visible = false;
                txtLuong.Visible = false;
                txtPHUCAP.Visible = false;
                txtVAITRO.Visible = false;
                txtMADV.Visible = false;
                txtMANV.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdateAll.Visible = false;

                dateTimePicker1.Visible = false;

                btnUpdatePhone.Enabled = true;
            }
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(@"
            UPDATE QLDH.QLDH_DANGKY
            SET 
                NGAYBATDAUHK = :NGSINH,
                DIEMTH = :luong,
                DIEMQT = :phucap,
                DIEMCK = :vaitro,
                DIEMTK = :madv
            WHERE MASV = :MASV", conn);

                cmd.Parameters.Add("hoten", txtHOTEN.Text);
                cmd.Parameters.Add("NGSINH", dateTimePicker1.Value);

                cmd.Parameters.Add("luong", txtLuong.Text);
                cmd.Parameters.Add("phucap", txtPHUCAP.Text);

                cmd.Parameters.Add("vaitro", txtVAITRO.Text);
                cmd.Parameters.Add("madv", txtMADV.Text);
                cmd.Parameters.Add("MASV", txtMANV.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }
    }
}
