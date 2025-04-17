using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class ObjectPrivileges : Form
    {
        public ObjectPrivileges()
        {
            InitializeComponent();
        }
        public static OracleConnection conNow;
        public static string result_roleuser;


        private void ObjectPrivileges_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                column.Items.Clear(); // xóa column cũ

                string query = "";
                string selectedType = table.Text.ToString();
                if (selectedType == "Table")
                {
                    query = "SELECT table_name FROM all_tables WHERE owner = 'QLDH'";
                }
                else if (selectedType == "View")
                {
                    query = "SELECT view_name AS table_name FROM all_views WHERE owner = 'QLDH'";
                }
                else if (selectedType == "StoreProcedure")
                {
                    query = "SELECT object_name as table_name FROM all_objects WHERE object_type = 'PROCEDURE' AND owner = 'QLDH'";
                    
                }
                else if (selectedType == "Function")
                {
                    query = "SELECT object_name as table_name FROM all_objects WHERE object_type = 'FUNCTION' AND owner = 'QLDH'";
                }

                OracleDataAdapter adapter = new OracleDataAdapter(query, conNow);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                foreach (DataRow row in dataTable.Rows)
                {
                    column.Items.Add(row[0].ToString());
                }


            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void label3_Click(object sender, EventArgs e) { }

        private void Privi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Grant_Click(object sender, EventArgs e)
        {
            try
            {
                string object_name = "";
                if (Username.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập vào tên username");
                }

                if (Privi.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập vào quyền cần gán");
                }

                if (table.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn một object");

                }

                for (int i = 0; i < column.Items.Count; i++)
                {
                    if (column.GetItemChecked(i))
                    {
                        object_name = column.Items[i].ToString();
                        break;
                    }
                }

                var cmd = new OracleCommand();
                cmd.Connection = conNow;
                string withgrantoption_ = (withGrantOption.Checked) ? "WITH GRANT OPTION" : "";

                // Lấy tên schema
                OracleCommand get_schema_name = conNow.CreateCommand();
                if (conNow.State != ConnectionState.Open)
                    conNow.Open();
                get_schema_name.CommandText = "select owner from dba_objects where OBJECT_NAME = \'" + object_name + '\'';
                OracleDataReader reader = get_schema_name.ExecuteReader();
                string schema_name = "";
                reader.Read();
                
                schema_name = reader.GetString(0);
                reader.Close();

                // Xử lý các trường hợp grant
                if (Privi.Text.ToString() == "SELECT")
                {
                    // Gọi proc
                    cmd.CommandText = "QLDH.grant_object_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("privi_name", Privi.Text.ToString());
                    cmd.Parameters.Add("schema_name", schema_name);
                    cmd.Parameters.Add("object_name", object_name);
                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%'";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }

                else if (Privi.Text.ToString() == "UPDATE")
                {
                    cmd.CommandText = "QLDH.grant_object_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("privi_name", Privi.Text.ToString());
                    cmd.Parameters.Add("schema_name", schema_name);
                    cmd.Parameters.Add("object_name", object_name);
                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }

                else if (Privi.Text.ToString() == "INSERT")
                {
                    cmd.CommandText = "QLDH.grant_object_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("privi_name", Privi.Text.ToString());
                    cmd.Parameters.Add("schema_name", schema_name);
                    cmd.Parameters.Add("object_name", object_name);
                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }
                else if (Privi.Text.ToString() == "DELETE")
                {
                    cmd.CommandText = "QLDH.grant_object_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("privi_name", Privi.Text.ToString());
                    cmd.Parameters.Add("schema_name", schema_name);
                    cmd.Parameters.Add("object_name", object_name);
                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                }

                if (Privi.Text.ToString() == "EXECUTE")
                {
                    cmd.CommandText = "QLDH.grant_execute_privi";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_name", Username.Text.ToString());
                    cmd.Parameters.Add("object_name", object_name);
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    // Cập nhật lại danh sách quyền
                    string sql = "select * from DBA_TAB_PRIVS where PRIVILEGE='EXECUTE' and grantor = 'QLDH'";
                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
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

                    cmd.Connection = conNow;
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
            catch { 
                
            }

        }

        private void column_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Bỏ check các item khác
                for (int i = 0; i < column.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        column.SetItemChecked(i, false);
                    }
                }
            }
        }
        private void column_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}  
