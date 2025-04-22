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
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestDB
{
    public partial class NhanVienUI : Form
    {
        public static OracleConnection con;
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

       

        private void tabSV_Click(object sender, EventArgs e)
        {

        }

        private void sinhVien_table1_Load(object sender, EventArgs e)
        {

        }

        private void NhanVienUI_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GrantOLSPermissions();
            OLSForm olsForm = new OLSForm();
            olsForm.Show();
        }

        private void dangKy_table1_Load(object sender, EventArgs e)
        {

        }

        private void tabDangKy_Click(object sender, EventArgs e)
        {

        }

        private void tabSinhVien_Click(object sender, EventArgs e)
        {

        }
        //private void GrantOLSPermissions()
        //{
        //    try
        //    {
        //        // Check if the user already has permission to the THONGBAO table
        //        // If not, grant the necessary permissions
        //        string checkPermissionQuery = @"
        //    SELECT COUNT(*) 
        //    FROM DBA_TAB_PRIVS 
        //    WHERE GRANTEE = :username 
        //    AND TABLE_NAME = 'THONGBAO' 
        //    AND PRIVILEGE = 'SELECT'"
        //        ;

        //        OracleCommand checkCmd = new OracleCommand(checkPermissionQuery, con);
        //        checkCmd.Parameters.Add(new OracleParameter("username", LoginUI.userUser));

        //        int permissionCount = Convert.ToInt32(checkCmd.ExecuteScalar());

        //        // If user doesn't have permissions, grant them using ADMIN_OLS account
        //        if (permissionCount == 0)
        //        {
        //            // We need to connect as ADMIN_OLS to grant permissions
        //            OracleConnection adminCon = new OracleConnection();
        //            adminCon.ConnectionString = @"DATA SOURCE = localhost:1521/XEPDB1; User Id=OLS_ADMIN;Password=123";
        //            adminCon.Open();

        //            // Grant SELECT on THONGBAO table
        //            string grantSelectQuery = $"GRANT SELECT ON THONGBAO TO {LoginUI.userUser}";
        //            OracleCommand grantCmd = new OracleCommand(grantSelectQuery, adminCon);
        //            grantCmd.ExecuteNonQuery();

        //            // Grant inherit privileges
        //            string grantInheritQuery = $"GRANT INHERIT PRIVILEGES ON USER OLS_ADMIN TO {LoginUI.userUser}";
        //            OracleCommand inheritCmd = new OracleCommand(grantInheritQuery, adminCon);
        //            inheritCmd.ExecuteNonQuery();

        //            // Close the admin connection
        //            adminCon.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi cấp quyền: {ex.Message}");
        //    }
        //}
    }
}
