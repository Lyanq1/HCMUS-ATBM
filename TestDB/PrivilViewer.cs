﻿using System;
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
    public partial class PrivilViewer : Form
    {
        public PrivilViewer()
        {
            InitializeComponent();
        }

        private void PrivilViewer_Load(object sender, EventArgs e)
        {
            LoadUsersAndRoles();
            string query = "SELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, GRANTABLE  FROM DBA_TAB_PRIVS where owner = 'QLDH'";

            try
            {
                OracleCommand cmd = new OracleCommand(query, LoginUI.con); // kết nối dùng chung
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
                catch (OracleException ex)
            {
                MessageBox.Show("Lỗi khi truy vấn quyền: " + ex.Message);
            }

            try
            {
                // Bạn có thể sửa lại câu truy vấn này để tách riêng user và role nếu muốn
                string query2 = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%'";

                OracleCommand cmd1 = new OracleCommand(query2, LoginUI.con); // kết nối dùng chung
                OracleDataAdapter adapter = new OracleDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi khi load user/role: " + ex.Message);
            }
        }
        
        private void LoadUsersAndRoles()
        {
            try
            {
                // Bạn có thể sửa lại câu truy vấn này để tách riêng user và role nếu muốn
                string query = "SELECT USERNAME FROM DBA_USERS UNION SELECT ROLE FROM DBA_ROLES";

                OracleCommand cmd = new OracleCommand(query, LoginUI.con);
                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }

                reader.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi khi load user/role: " + ex.Message);
            }


        }

        private void btnViewPrivileges_Click_1(object sender, EventArgs e)
        {
           
                string selectedName = comboBox1.SelectedItem.ToString().ToUpper();

                string query = $@"
                SELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, GRANTABLE 
                FROM DBA_TAB_PRIVS 
                WHERE GRANTEE = '{selectedName}'";

                try
                {
                    OracleCommand cmd = new OracleCommand(query, LoginUI.con); // kết nối dùng chung
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn quyền: " + ex.Message);
                }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT GRANTEE, OWNER, TABLE_NAME, PRIVILEGE, GRANTABLE  FROM DBA_TAB_PRIVS where owner = 'QLDH'";

            try
            {
                OracleCommand cmd = new OracleCommand(query, LoginUI.con); // kết nối dùng chung
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi khi truy vấn quyền: " + ex.Message);
            }

            try
            {
                // Bạn có thể sửa lại câu truy vấn này để tách riêng user và role nếu muốn
                string query2 = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDH_%' OR TABLE_NAME LIKE 'V_QLDH_%'";

                OracleCommand cmd1 = new OracleCommand(query2, LoginUI.con); // kết nối dùng chung
                OracleDataAdapter adapter = new OracleDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Lỗi khi load user/role: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
