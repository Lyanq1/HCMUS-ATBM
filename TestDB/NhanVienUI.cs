using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDB
{
    public partial class NhanVienUI : Form
    {
        private string _connectionString;
        private bool _isNVPDT;

        // Constructor nhận tham số từ Login
        public NhanVienUI(string connectionString, bool isNVPDT)
        {
            InitializeComponent(); // KHỞI TẠO CONTROL TỪ DESIGNER TRƯỚC

            _connectionString = connectionString;
            _isNVPDT = isNVPDT;

            // Gọi hàm cấu hình MoMon_table ĐỘNG
            RebuildMoMonTableWithPermissions();
        }

        private void RebuildMoMonTableWithPermissions()
        {
            // Xóa control cũ (nếu có)
            tabPage2.Controls.Clear();

            // Tạo mới MoMon_table với tham số
            var moMonTable = new MoMon_table(_connectionString, _isNVPDT);
            moMonTable.Dock = DockStyle.Fill;

            // Thêm vào tabPage2
            tabPage2.Controls.Add(moMonTable);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void nhanvien_table1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void moMon_table1_Load(object sender, EventArgs e)
        {

        }
    }
}
