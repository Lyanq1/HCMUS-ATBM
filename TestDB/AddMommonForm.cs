using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class AddMommonForm : Form
    {
        private readonly string _connectionString;

        public AddMommonForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new OracleConnection(_connectionString))
                using (var cmd = new OracleCommand(
                    "INSERT INTO QLDH.QLDH_MOMON (MAMM, MAHP, MAGV, HK, NAM) " +
                    "VALUES (:mamm, :mahp, :magv, :hk, :nam)", conn))
                {
                    cmd.Parameters.Add("mamm", OracleDbType.Varchar2).Value = txtMAMM.Text;
                    cmd.Parameters.Add("mahp", OracleDbType.Varchar2).Value = txtMAHP.Text;
                    cmd.Parameters.Add("magv", OracleDbType.Varchar2).Value = txtMAGV.Text;
                    cmd.Parameters.Add("hk", OracleDbType.Int32).Value = int.Parse(txtHK.Text);
                    cmd.Parameters.Add("nam", OracleDbType.Int32).Value = int.Parse(txtNAM.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm mới thành công!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void AddMommonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Đặt kết quả là Cancel
            Close(); // Đóng form
        }
    }
}
