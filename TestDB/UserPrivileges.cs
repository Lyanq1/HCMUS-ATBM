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
        private void UserPrivileges_Load(object sender, EventArgs e)
        {
            con = LoginUI.con;
            //string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%' ";

            //OracleDataAdapter da = new OracleDataAdapter(sql, con);
            //DataTable dt1 = new DataTable();
            //da.Fill(dt1);
            //dataGridView1.DataSource = dt1;
            ////data_grid_view1 = dataGridView1;

            //string sql1 = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'QLDH_%' ";

            //OracleDataAdapter da1 = new OracleDataAdapter(sql1, con);
            //DataTable dt2 = new DataTable();
            //da.Fill(dt2);
            //dataGridView2.DataSource = dt2;
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

        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Username hoặc Role");
                    return;
                }
                else
                {
                    var cmd = new OracleCommand();

                    cmd.Connection = con;
                    cmd.CommandText = "QLDH.check_user_role_exist";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    //cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                    if (result_roleuser != "1" && result_roleuser != "2")
                    {
                        result.Text = "Không tồn tại";
                        return;
                    }
                    else
                    {
                        Username.Enabled = false;
                        Privi.Enabled = true;
                        //table.Enabled = true;
                        //column.Enabled = true;


                        if (result_roleuser == "1")
                        {
                            result.Text = "Đây là User";
                            withGrantOption.Enabled = true;
                        }
                        else
                        {
                            result.Text = "Đây là Role";
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username.Clear();
            Username.Enabled = true;
            result.Text = "Not checked";
            Privi.SelectedIndex = -1;
            Privi.Enabled = false;
            table.SelectedIndex = -1;
            table.Enabled = false;
            for (int i = 0; i < column.Items.Count; i++)
            {
                column.SetItemChecked(i, false);
            }
            column.Enabled = false;
            withGrantOption.Checked = false;
            withGrantOption.Enabled = false;
        }
    }
}
