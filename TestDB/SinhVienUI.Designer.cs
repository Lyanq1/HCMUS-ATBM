namespace TestDB
{
    partial class SinhVienUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.sinhVien_table1 = new TestDB.SinhVien_table();
            this.tabMoMon = new System.Windows.Forms.TabPage();
            this.moMon_SinhVien1 = new TestDB.MoMon_SinhVien();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.dangKy_table1 = new TestDB.DangKy_table();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSinhVien.SuspendLayout();
            this.tabMoMon.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSinhVien);
            this.tabControl1.Controls.Add(this.tabMoMon);
            this.tabControl1.Controls.Add(this.tabDangKy);
            this.tabControl1.Location = new System.Drawing.Point(8, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Controls.Add(this.sinhVien_table1);
            this.tabSinhVien.Location = new System.Drawing.Point(4, 22);
            this.tabSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Padding = new System.Windows.Forms.Padding(2);
            this.tabSinhVien.Size = new System.Drawing.Size(776, 362);
            this.tabSinhVien.TabIndex = 0;
            this.tabSinhVien.Text = "Sinh Viên";
            this.tabSinhVien.UseVisualStyleBackColor = true;
            this.tabSinhVien.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // sinhVien_table1
            // 
            this.sinhVien_table1.Location = new System.Drawing.Point(5, 0);
            this.sinhVien_table1.Name = "sinhVien_table1";
            this.sinhVien_table1.Size = new System.Drawing.Size(774, 363);
            this.sinhVien_table1.TabIndex = 0;
            // 
            // tabMoMon
            // 
            this.tabMoMon.Controls.Add(this.moMon_SinhVien1);
            this.tabMoMon.Location = new System.Drawing.Point(4, 22);
            this.tabMoMon.Margin = new System.Windows.Forms.Padding(2);
            this.tabMoMon.Name = "tabMoMon";
            this.tabMoMon.Padding = new System.Windows.Forms.Padding(2);
            this.tabMoMon.Size = new System.Drawing.Size(776, 362);
            this.tabMoMon.TabIndex = 1;
            this.tabMoMon.Text = "Mở Môn";
            this.tabMoMon.UseVisualStyleBackColor = true;
            // 
            // moMon_SinhVien1
            // 
            this.moMon_SinhVien1.Location = new System.Drawing.Point(5, 14);
            this.moMon_SinhVien1.Name = "moMon_SinhVien1";
            this.moMon_SinhVien1.Size = new System.Drawing.Size(768, 343);
            this.moMon_SinhVien1.TabIndex = 0;
            // 
            // tabDangKy
            // 
            this.tabDangKy.Controls.Add(this.dangKy_table1);
            this.tabDangKy.Location = new System.Drawing.Point(4, 22);
            this.tabDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Size = new System.Drawing.Size(776, 362);
            this.tabDangKy.TabIndex = 2;
            this.tabDangKy.Text = "Đăng Ký";
            this.tabDangKy.UseVisualStyleBackColor = true;
            // 
            // dangKy_table1
            // 
            this.dangKy_table1.Location = new System.Drawing.Point(2, 2);
            this.dangKy_table1.Margin = new System.Windows.Forms.Padding(1);
            this.dangKy_table1.Name = "dangKy_table1";
            this.dangKy_table1.Size = new System.Drawing.Size(769, 363);
            this.dangKy_table1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinhVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SinhVienUI";
            this.Text = "SinhVienUI";
            this.Load += new System.EventHandler(this.SinhVienUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSinhVien.ResumeLayout(false);
            this.tabMoMon.ResumeLayout(false);
            this.tabDangKy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSinhVien;
        private System.Windows.Forms.TabPage tabMoMon;
        private System.Windows.Forms.TabPage tabDangKy;
        private DangKy_table dangKy_table1;
        private SinhVien_table sinhVien_table1;
        private System.Windows.Forms.Button button1;
        private MoMon_SinhVien moMon_SinhVien1;
    }
}