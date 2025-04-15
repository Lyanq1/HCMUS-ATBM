using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class RBAC : Form
    {
        private string manld;
        private string vaitro;
        string connStr;
        //private string connectionString = "User Id=QLDH;Password=123;Data Source=localhost:1521/XEPDB1;";

        public RBAC(string manld, string vaitro, string connStr)
        {
            InitializeComponent();
            this.manld = manld;
            this.vaitro = vaitro;
            this.connStr = connStr;
        }


        private void RBAC_Load(object sender, EventArgs e)
        {
            LoadDataTheoVaiTro(); // Load dữ liệu khi form mở
            PhanQuyenGiaoDien();  // Phân quyền giao diện nếu cần
        }


        private void LoadDataTheoVaiTro()
        {
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                if (vaitro == "NVCB")
                {
                    cmd.CommandText = "SELECT * FROM QLDH.NVCB_VIEW";
                }
                else if (vaitro == "TRGĐV")
                {
                    cmd.CommandText = "SELECT * FROM QLDH.TRGDV_VIEW";
                }
                else if (vaitro == "NV TCHC")
                {
                    cmd.CommandText = "SELECT * FROM QLDH.QLDH_NHANVIEN";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM QLDH.NVCB_VIEW";
                }

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void PhanQuyenGiaoDien()
        {
            if (vaitro == "NV TCHC")
            {
                // Nhân sự hành chính có toàn quyền CRUD
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdateAll.Enabled = true;

                // Hiển thị các trường cần thiết
                txtMANV.ReadOnly = true; // Không cho phép sửa mã nhân viên
                txtHOTEN.Visible = true;
                txtLuong.Visible = true;
                txtPHUCAP.Visible = true;
                txtĐT.Visible = true;
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
                comboBox1.Visible = false;
                dateTimePicker1.Visible = false;

                btnUpdatePhone.Enabled = true;
                txtĐT.Visible = true;
            }
            else if (vaitro == "TRGĐV")
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
                comboBox1.Visible = false;
                dateTimePicker1.Visible = false;

                btnUpdatePhone.Enabled = true;
                txtĐT.Visible = true;
            }
        }


        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã nhân viên đang chọn có phải là của user đang đăng nhập hay không
            if (txtMANV.Text.Trim() != manld)
            {
                MessageBox.Show("Bạn chỉ được phép cập nhật số điện thoại của chính mình.");
                return;
            }

            // Lấy giá trị số điện thoại mới từ TextBox trên form, chẳng hạn txtDT
            string newPhone = txtĐT.Text.Trim();

            // Kiểm tra dữ liệu hợp lệ (ví dụ: không để trống)
            if (string.IsNullOrEmpty(newPhone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return;
            }

            // Cập nhật cơ sở dữ liệu
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("UPDATE QLDH.QLDH_NHANVIEN SET DT = :dt WHERE MANLD = :manld", conn);
                cmd.Parameters.Add("dt", newPhone);
                cmd.Parameters.Add("manld", manld);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật số điện thoại thành công!");
                // Sau khi cập nhật thành công, gọi lại LoadDataTheoVaiTro() để refresh dữ liệu trên DataGridView
                LoadDataTheoVaiTro();
            }   
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(@"
            INSERT INTO QLDH.QLDH_NHANVIEN (MANLD, HOTEN, PHAI, NGSINH, LUONG, PHUCAP, DT, VAITRO, MADV)
            VALUES (:manld, :hoten, :phai, :ngsinh, :luong, :phucap, :dt, :vaitro, :madv)", conn);

                cmd.Parameters.Add("manld", txtMANV.Text);
                cmd.Parameters.Add("hoten", txtHOTEN.Text);
                cmd.Parameters.Add("phai", comboBox1.Text);
                cmd.Parameters.Add("ngsinh", dateTimePicker1.Value);
                cmd.Parameters.Add("luong", txtLuong.Text);
                cmd.Parameters.Add("phucap", txtPHUCAP.Text);
                cmd.Parameters.Add("dt", txtĐT.Text);
                cmd.Parameters.Add("vaitro", txtVAITRO.Text);
                cmd.Parameters.Add("madv", txtMADV.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadDataTheoVaiTro(); // Refresh lại lưới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                return;
            }

            // Nếu không phải vai trò có quyền xóa
            if (vaitro != "NV TCHC")
            {
                MessageBox.Show("Bạn không có quyền xóa nhân viên.");
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["MANLD"].Value.ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {id}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (OracleConnection conn = new OracleConnection(connStr))
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("DELETE FROM QLDH.QLDH_NHANVIEN WHERE MANLD = :id", conn);
                        cmd.Parameters.Add("id", id);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên để xóa.");
                        }
                        LoadDataTheoVaiTro(); // Refresh lại lưới
                    }
                }
                catch (OracleException ex)
                {
                    // Gợi ý: Có thể thiếu quyền DELETE hoặc bị trigger chặn
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(@"
            UPDATE QLDH.QLDH_NHANVIEN
            SET HOTEN = :hoten,
                NGSINH = :NGSINH,
                PHAI = :phai,
                LUONG = :luong,
                PHUCAP = :phucap,
                DT = :dt,
                VAITRO = :vaitro,
                MADV = :madv
            WHERE MANLD = :manld", conn);

                cmd.Parameters.Add("hoten", txtHOTEN.Text);
                cmd.Parameters.Add("NGSINH", dateTimePicker1.Value); 
                cmd.Parameters.Add("phai", comboBox1.Text);
                cmd.Parameters.Add("luong", txtLuong.Text);
                cmd.Parameters.Add("phucap", txtPHUCAP.Text);
                cmd.Parameters.Add("dt", txtĐT.Text);
                cmd.Parameters.Add("vaitro", txtVAITRO.Text);
                cmd.Parameters.Add("madv", txtMADV.Text);
                cmd.Parameters.Add("manld", txtMANV.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDataTheoVaiTro();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vaitro == "TRGĐV")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMANV.Text = row.Cells["MANLD"].Value.ToString();
                txtHOTEN.Text = row.Cells["HOTEN"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                comboBox1.Text = row.Cells["PHAI"].Value.ToString();
                //txtLuong.Text = row.Cells["LUONG"].Value.ToString();
                //txtPHUCAP.Text = row.Cells["PHUCAP"].Value.ToString();
                txtĐT.Text = row.Cells["DT"].Value.ToString();
                txtVAITRO.Text = row.Cells["VAITRO"].Value.ToString();
                txtMADV.Text = row.Cells["MADV"].Value.ToString();
            }

            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMANV.Text = row.Cells["MANLD"].Value.ToString();
                txtHOTEN.Text = row.Cells["HOTEN"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                comboBox1.Text = row.Cells["PHAI"].Value.ToString();
                txtLuong.Text = row.Cells["LUONG"].Value.ToString();
                txtPHUCAP.Text = row.Cells["PHUCAP"].Value.ToString();
                txtĐT.Text = row.Cells["DT"].Value.ToString();
                txtVAITRO.Text = row.Cells["VAITRO"].Value.ToString();
                txtMADV.Text = row.Cells["MADV"].Value.ToString();
            }


        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMANV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHOTEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPHUCAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtĐT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVAITRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMADV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMANV.Clear();
            txtHOTEN.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            txtLuong.Clear();
            txtPHUCAP.Clear();
            txtĐT.Clear();
            txtVAITRO.Clear();
            txtMADV.Clear();
        }
    }
}
