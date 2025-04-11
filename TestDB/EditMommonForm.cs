using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TestDB
{
    public partial class EditMommonForm : Form
    {
        private readonly OracleConnection _conn;
        private readonly bool _isEdit;
        private readonly string _mamh;

        public EditMommonForm(OracleConnection conn, bool isEdit,
            string mamh = null, string mahp = null,
            string magv = null, string hk = null, string nam = null)
        {
            InitializeComponent();
            _conn = conn;
            _isEdit = isEdit;
            _mamh = mamh;

            if (_isEdit)
            {
                txtMAHP.Text = mahp;
                txtMAGV.Text = magv;
                txtHK.Text = hk;
                txtNAM.Text = nam;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var cmdText = _isEdit
                    ? "UPDATE QLDH.QLDH_MOMON SET MAHP=:mahp, MAGV=:magv, HK=:hk, NAM=:nam WHERE MAMM=:mamh"
                    : "INSERT INTO QLDH.QLDH_MOMON (MAMM, MAHP, MAGV, HK, NAM) VALUES (SEQ_MAMM.NEXTVAL, :mahp, :magv, :hk, :nam)";

                using (var cmd = new OracleCommand(cmdText, _conn))
                {
                    if (_isEdit) cmd.Parameters.Add("mamh", _mamh);
                    cmd.Parameters.Add("mahp", txtMAHP.Text);
                    cmd.Parameters.Add("magv", txtMAGV.Text);
                    cmd.Parameters.Add("hk", txtHK.Text);
                    cmd.Parameters.Add("nam", txtNAM.Text);

                    if (_conn.State != ConnectionState.Open) _conn.Open();
                    cmd.ExecuteNonQuery();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void EditMommonForm_Load(object sender, EventArgs e)
        {

        }
    }
}