using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Documents;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class UserPrivileges : Form
    {
        public UserPrivileges()
        {
            InitializeComponent();
        }
        public static OracleConnection con;
        public static string result_roleuser;
        // Cần thêm tên của user DBA đăng nhập cho việc access bảng dễ hơn
        //OracleCommand selectUser = con.CreateCommand();
        //selectUser.CommandText = "select sys_context('userenv', 'current_user') from dual";
        //        OracleDataReader reader = selectUser.ExecuteReader();
        //reader.Read();
        //        label3.Text = "Welcome " + reader.GetString(0).ToUpper() + ",";
        private void UserPrivileges_Load(object sender, EventArgs e)
        {
            con = LoginUI.con;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Privi.Text.ToString() != "")
            {
                table.Enabled = true;
            }
            if (Privi.Text.ToString() == "UPDATE" || Privi.Text.ToString() == "SELECT")
            {
                column.Enabled = true;
            }
            else
            {
                column.Enabled = false;
                for (int i = 0; i < column.Items.Count; i++)
                {
                    column.SetItemChecked(i, false);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int count_column = column.Items.Count;
                for (int i = count_column - 1; i >= 0; i--)
                {
                    column.Items.RemoveAt(i);
                }
                string query = "select COLUMN_NAME from dba_tab_columns where table_name = \'" + table.Text.ToString() + '\'';
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    column.Items.Add(row["column_name"].ToString());
                }
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Grant_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text.Length == 0) {
                    MessageBox.Show("Vui lòng nhập vào tên username");
                }

                if (Privi.Text.Length == 0) {
                    MessageBox.Show("Vui lòng nhập vào quyền cần gán");
                }

                if (table.Text.Length == 0) {
                    MessageBox.Show("Vui lòng chọn bảng");

                }
                
                if (column.Items.Count == 0) { //Nếu đã chọn được bảng
                    if ((Privi.Text.ToString() == "SELECT" || Privi.Text.ToString() == "UPDATE") && column.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn thuộc tính cần gán");

                    }
                }

                var cmd = new OracleCommand();
                cmd.Connection = con;
                string withgrantoption_ = (withGrantOption.Checked) ? "WITH GRANT OPTION" : "";

                // Lấy ra các cột cần được grant
                string column_list = "";
                for (int i = 0; i < column.Items.Count; i++)
                {
                     if (column.GetItemChecked(i) == true)
                    {
                        column_list += column.Items[i].ToString() + ',';
                    }    
                }    
                if (column_list.Length > 0)
                {
                    // Xóa dấu , cuối chuỗi
                    column_list = column_list.Substring(0, column_list.Length - 1);
                }

                // Lấy tên schema
                OracleCommand get_schema_name = con.CreateCommand();
                get_schema_name.CommandText = "select owner from dba_tables where table_name = \'" + table.Text.ToString() + '\'';
                OracleDataReader reader = get_schema_name.ExecuteReader();
                reader.Read();
                string schema_name = reader.GetString(0);

                // Xử lý các trường hợp grant
                if (Privi.Text.ToString() == "SELECT")
                {
                    // Gọi proc
                    cmd.CommandText = "QLDH.grant_select_privi";
                    cmd.CommandType = CommandType.StoredProcedure;
                    //column_name in varchar2,
                    //schema_name in varchar2,
                    //table_name in varchar2,
                    //user_name in varchar2,
                    //withgrantoption in varchar2

                    cmd.Parameters.Add("privi_name", Privi.Text.ToString());
                    cmd.Parameters.Add("column_name", column_list);
                    cmd.Parameters.Add("schema_name", schema_name);
                    cmd.Parameters.Add("table_name", table.Text.ToString());
                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%'";

                    OracleDataAdapter da = new OracleDataAdapter(sql, con);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }

                else if (Privi.Text.ToString() == "UPDATE")
                {
                    cmd.CommandText = "QLDH.grant_update_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("table_name", table.Text.ToString());
                    cmd.Parameters.Add("column_name", column_list);
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'QLDH_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, con);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }

                else if (Privi.Text.ToString() == "INSERT")
                {
                    cmd.CommandText = "QLDH.grant_insert_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("table_name", table.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, con);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                else if (Privi.Text.ToString() == "DELETE")
                {
                    cmd.CommandText = "QLDH.grant_delete_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("table_name", table.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, con);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }

                MessageBox.Show("Cấp quyền cho " + ((result_roleuser == "1") ? "user " : "role ") + Username.Text.ToString() + " thành công");
                

            }   
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
