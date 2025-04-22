using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace TestDB
{
    public partial class OLSForm : Form
    {
        // Biến lưu thông tin người dùng hiện tại
        private string currentUsername;
        private string currentRole;

        public OLSForm()
        {
            InitializeComponent();

            // Lấy thông tin người dùng từ form đăng nhập
            currentUsername = LoginUI.userUser;
            currentRole = LoginUI.roleUser;

            // Đặt tiêu đề form theo vai trò
            this.Text = $"Hệ thống thông báo - {currentRole}";
        }

        private void OLSForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người dùng
            lblCurrentUser.Text = $"Người dùng: {currentUsername}";

            if (currentRole == "ADMIN")
            {
                lblCurrentUser.ForeColor = Color.Red; // Đổi màu chữ cho ADMIN
                lblRole.Text = "Vai trò: Quản trị hệ thống";
            }
            else if (currentRole == "Nhân Viên")
            {
                try
                {
                    OracleConnection conn = LoginUI.con;
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string sql = "SELECT VAITRO FROM QLDH.qldh_nhanvien WHERE manld = :manld";
                    OracleCommand cmd = new OracleCommand(sql, conn);
                    cmd.Parameters.Add(new OracleParameter("manld", currentUsername));
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                        lblRole.Text = $"Vai trò: {result.ToString()}";
                    else
                        lblRole.Text = "Vai trò: Nhân viên";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblRole.Text = "Vai trò: Lỗi";
                }
            }

            else if (currentRole == "Sinh Viên")
            {
                lblRole.Text = "Vai trò: Sinh viên";
            }
            else
            {
                lblRole.Text = "Vai trò: Không xác định";
            }
            // Gán nhãn OLS cho người dùng dựa trên vai trò
            //AssignUserOLSLabel();
        }

        //private void AssignUserOLSLabel()
        //{
        //    try
        //    {
        //        // Lấy kết nối từ LoginUI
        //        OracleConnection conn = LoginUI.con;

        //        // Kiểm tra trạng thái kết nối
        //        if (conn.State == ConnectionState.Closed)
        //            conn.Open();

        //        // Truy vấn thông tin để xác định nhãn phù hợp
        //        string userQuery = "";
        //        string userLabel = "";

        //        if (currentRole == "ADMIN")
        //        {
        //            // Admin được phép truy cập tất cả — gán nhãn mức cao nhất
        //            userLabel = "TDV:T,L,H,HC:CS1,CS2";
        //        }
        //        else if (currentRole == "Nhân Viên")
        //        {
        //            // Nhân viên: kiểm tra vai trò là trưởng hay nhân viên thường
        //            userQuery = "SELECT NV.VAITRO, DV.LOAIDV, DV.MADV, NV.COSOLV " +
        //                        "FROM NHANVIEN NV " +
        //                        "JOIN DONVI DV ON NV.MADV = DV.MADV " +
        //                        "WHERE NV.MANV = :username";

        //            OracleCommand cmd = new OracleCommand(userQuery, conn);
        //            cmd.Parameters.Add(new OracleParameter("username", currentUsername));

        //            OracleDataReader reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                string vaiTro = reader["VAITRO"].ToString();
        //                string loaiDV = reader["LOAIDV"].ToString();
        //                string maDV = reader["MADV"].ToString();
        //                string coSo = reader["COSOLV"].ToString();

        //                // Xác định lĩnh vực theo mã đơn vị
        //                string compartment = "";
        //                if (maDV == "TOAN" || maDV.Contains("TOAN"))
        //                    compartment = "T";
        //                else if (maDV == "LY" || maDV.Contains("LY"))
        //                    compartment = "L";
        //                else if (maDV == "HOA" || maDV.Contains("HOA"))
        //                    compartment = "H";
        //                else // Các phòng ban hành chính
        //                    compartment = "HC";

        //                // Xác định cơ sở làm việc
        //                string location = "";
        //                if (coSo == "1")
        //                    location = "CS1";
        //                else if (coSo == "2")
        //                    location = "CS2";
        //                else
        //                    location = "CS1,CS2"; // Cả hai cơ sở

        //                // Gán nhãn theo vai trò
        //                if (vaiTro == "TRGDV")
        //                    userLabel = $"TDV:{compartment}:{location}";
        //                else
        //                    userLabel = $"NV:{compartment}:{location}";
        //            }
        //            reader.Close();
        //        }
        //        else if (currentRole == "Sinh Viên")
        //        {
        //            // Sinh viên: lấy thông tin khoa và cơ sở
        //            userQuery = "SELECT KHOA, COSO " +
        //                        "FROM SINHVIEN " +
        //                        "WHERE MASV = :username";

        //            OracleCommand cmd = new OracleCommand(userQuery, conn);
        //            cmd.Parameters.Add(new OracleParameter("username", currentUsername));

        //            OracleDataReader reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                string khoa = reader["KHOA"].ToString();
        //                string coSo = reader["COSO"].ToString();

        //                // Xác định lĩnh vực theo khoa
        //                string compartment = "";
        //                if (khoa == "TOAN" || khoa.Contains("TOAN"))
        //                    compartment = "T";
        //                else if (khoa == "LY" || khoa.Contains("LY"))
        //                    compartment = "L";
        //                else if (khoa == "HOA" || khoa.Contains("HOA"))
        //                    compartment = "H";
        //                else
        //                    compartment = ""; // Không xác định khoa

        //                // Xác định cơ sở
        //                string location = "";
        //                if (coSo == "1")
        //                    location = "CS1";
        //                else if (coSo == "2")
        //                    location = "CS2";
        //                else
        //                    location = "CS1,CS2"; // Cả hai cơ sở

        //                userLabel = $"SV:{compartment}:{location}";
        //            }
        //            reader.Close();
        //        }

        //        // Gán nhãn OLS cho phiên làm việc
        //        if (!string.IsNullOrEmpty(userLabel))
        //        {
        //            // Gọi hàm gán nhãn OLS
        //            string setLabelSql = "BEGIN SA_SESSION.SET_LABEL('THONGBAO_POLICY', :label); END;";
        //            OracleCommand setLabelCmd = new OracleCommand(setLabelSql, conn);
        //            setLabelCmd.Parameters.Add(new OracleParameter("label", userLabel));
        //            setLabelCmd.ExecuteNonQuery();

        //            lblStatus.Text = $"Đã gán nhãn '{userLabel}' cho người dùng.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi gán nhãn OLS: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        lblStatus.Text = "Có lỗi xảy ra khi gán nhãn.";
        //    }
        //}

        private void btnShowNotifications_Click(object sender, EventArgs e)
        {
            // Xóa danh sách thông báo cũ
            lstNotifications.Items.Clear();

            try
            {
                // Lấy kết nối từ LoginUI
                OracleConnection conn = LoginUI.con;

                // Mở kết nối nếu chưa mở
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Truy vấn bảng THONGBAO — OLS sẽ tự động lọc theo nhãn của người dùng
                string query = "SELECT ID, NOIDUNG FROM ADMIN_OLS.THONGBAO";

                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị danh sách thông báo
                foreach (DataRow row in dt.Rows)
                {
                    lstNotifications.Items.Add($"{row["ID"]}: {row["NOIDUNG"]}");
                }

                lblStatus.Text = $"Đã tìm thấy {dt.Rows.Count} thông báo phù hợp.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi truy xuất thông báo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Có lỗi xảy ra.";
            }
        }
    }
}
