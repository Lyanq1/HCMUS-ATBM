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
    public partial class RolePrivileges : Form
    {
        public RolePrivileges()
        {
            InitializeComponent();
            view_user_role();
        }
        public static OracleConnection conNow = LoginUI.con;
        public static DataGridView data_grid_view1;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void RolePrivileges_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void view_user_role()
        {

            string sql = "select * from dba_role_privs";

            OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            data_grid_view1 = dataGridView1;

        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (userRole.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống User/Role");
                    return;
                }

                if (grantedRole.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống Role cần gán");
                    return;
                }

                var cmd = new OracleCommand();
                string adminOption = (withAdminOption.Checked) ? "WITH ADMIN OPTION" : "";
                
                cmd.Connection = conNow;
                cmd.CommandText = "QLDH.grant_role";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("user_role", userRole.Text.ToString());
                cmd.Parameters.Add("granted_role", grantedRole.Text.ToString());
                cmd.Parameters.Add("withAdminOption", adminOption );
                cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                var result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                if (result_roleuser == "-1")
                {
                    MessageBox.Show("User/Role cần cấp role không tồn tại");
                }
                else if (result_roleuser == "-2")
                {
                    MessageBox.Show("Role cần cấp cho User không tồn tại");
                }
                else
                {
                    MessageBox.Show("Cấp role " + grantedRole.Text.ToString() + " cho user/role " + userRole.Text.ToString() + " thành công");


                    string sql = "select * from dba_role_privs";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }   
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            revokeForm revoke = new revokeForm();
            revoke.Show();
        }
    }
}
