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
        private string _vaiTro;
        private string _username;

        // Constructor nhận tham số từ Login
        public NhanVienUI(string connectionString, bool isNVPDT, string vaiTro, string username)
        {
            InitializeComponent(); // KHỞI TẠO CONTROL TỪ DESIGNER TRƯỚC

            _connectionString = connectionString;
            _isNVPDT = isNVPDT;
            _vaiTro = vaiTro;
            _username = username;

            // Thêm control NHANVIEN vào tabPage1
            InitNhanVienTab();

            // Gọi hàm cấu hình MoMon_table ĐỘNG
            RebuildMoMonTableWithPermissions();
        }

        private void InitNhanVienTab()
        {
            tabPage1.Controls.Clear();

            var nhanVienTable = new Nhanvien_table(
                connStr: _connectionString,
                vaitro: _vaiTro,
                manld: _username
            );
            nhanVienTable.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(nhanVienTable);
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
