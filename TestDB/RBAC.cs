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
                    MessageBox.Show("Vai trò không hợp lệ.");
                    return;
                }

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void PhanQuyenGiaoDien()
        {
            // Mặc định tắt tất cả các nút
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdateAll.Enabled = false;
            btnUpdatePhone.Enabled = false;

            if (vaitro == "NVCB" || vaitro == "GV" || vaitro.StartsWith("NV "))
            {
                btnUpdatePhone.Enabled = true;
            }

            if (vaitro == "NV TCHC")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdateAll.Enabled = true;
            }
        }

        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputBox("Cập nhật số điện thoại", "Nhập số điện thoại mới:"))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string newPhone = inputForm.InputText;

                    using (OracleConnection conn = new OracleConnection(connStr))
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand("UPDATE QLDH_NHANVIEN SET DT = :dt WHERE MANLD = :manld", conn);
                        cmd.Parameters.Add("dt", newPhone);
                        cmd.Parameters.Add("manld", manld);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật số điện thoại thành công!");
                        LoadDataTheoVaiTro();
                    }
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Mở form thêm nhân viên hoặc thêm trực tiếp
            MessageBox.Show("Thêm mới nhân viên - chưa triển khai.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            string id = dataGridView1.SelectedRows[0].Cells["MANLD"].Value.ToString();

            var confirm = MessageBox.Show("Xóa nhân viên " + id + "?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("DELETE FROM QLDH_NHANVIEN WHERE MANLD = :id", conn);
                    cmd.Parameters.Add("id", id);
                    cmd.ExecuteNonQuery();
                    LoadDataTheoVaiTro();
                }
            }
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            // Ví dụ cập nhật toàn bộ dòng được chọn (cần thêm các textbox để nhập)
            MessageBox.Show("Cập nhật toàn bộ - chưa triển khai.");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
