using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDB
{
    public partial class NhanVienUI : Form
    {
        public NhanVienUI()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void nhanvien_table1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMINUI dba = new ADMINUI();
            dba.Show();
        }

        private void moMon_table1_Load(object sender, EventArgs e)
        {

        }

        private void moMon_table1_Load(object sender, EventArgs e)
        {


        private void tabSV_Click(object sender, EventArgs e)
        {

        }
    }
}
