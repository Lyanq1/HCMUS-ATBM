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
    public partial class PermissionInfoForm : Form
    {
        public PermissionInfoForm(OracleConnection connection, string userName)
        {
            InitializeComponent();
            LoadPermissions(connection, userName);
        }

        private void LoadPermissions(OracleConnection connection, string userName)
        {
            var query = $@"SELECT PRIVILEGE, OBJECT_NAME, GRANTABLE 
                         FROM dba_tab_privs 
                         WHERE GRANTEE = '{userName}'
                         UNION
                         SELECT PRIVILEGE, 'ROLE' AS OBJECT_NAME, '' 
                         FROM dba_role_privs 
                         WHERE GRANTEE = '{userName}'";

            var adapter = new OracleDataAdapter(query, connection);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}