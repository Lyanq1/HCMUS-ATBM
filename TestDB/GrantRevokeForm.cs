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
    public partial class GrantRevokeForm : Form
    {
        private readonly OracleConnection _connection;
        private readonly bool _isGrant;

        public GrantRevokeForm(OracleConnection connection, bool isGrant)
        {
            InitializeComponent();
            _connection = connection;
            _isGrant = isGrant;
            Text = _isGrant ? "Cấp quyền" : "Thu hồi quyền";
            LoadData();
        }

        private void LoadData()
        {
            // Load users và roles
            var adapter = new OracleDataAdapter(
                "SELECT USERNAME FROM dba_users UNION SELECT ROLE FROM dba_roles", _connection);
            var dt = new DataTable();
            adapter.Fill(dt);
            cmbGrantee.DataSource = dt;
            cmbGrantee.DisplayMember = "USERNAME";

            // Load đối tượng CSDL
            adapter = new OracleDataAdapter(
                "SELECT OBJECT_NAME FROM dba_objects WHERE OWNER = 'QLDH'", _connection);
            dt = new DataTable();
            adapter.Fill(dt);
            cmbObject.DataSource = dt;
            cmbObject.DisplayMember = "OBJECT_NAME";
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                var grantOption = chkWithGrant.Checked ? " WITH GRANT OPTION" : "";
                var query = _isGrant
                    ? $"GRANT {cmbPrivilege.Text} ON {cmbObject.Text} TO {cmbGrantee.Text}{grantOption}"
                    : $"REVOKE {cmbPrivilege.Text} ON {cmbObject.Text} FROM {cmbGrantee.Text}";

                using (var cmd = new OracleCommand(query, _connection))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thao tác thành công!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện: " + ex.Message);
            }
        }

        private void GrantRevokeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
