namespace TestDB
{
    partial class GIAOVIENUI
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
            this.NhanVienTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moMon_table1 = new TestDB.MoMon_table();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.sinhVien_table2 = new TestDB.SinhVien_table();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.dangKy_table1 = new TestDB.DangKy_table();
            this.button1 = new System.Windows.Forms.Button();
            this.NhanVienTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabSinhVien.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienTab
            // 
            this.NhanVienTab.Controls.Add(this.tabPage1);
            this.NhanVienTab.Controls.Add(this.tabPage2);
            this.NhanVienTab.Controls.Add(this.tabSinhVien);
            this.NhanVienTab.Controls.Add(this.tabDangKy);
            this.NhanVienTab.Location = new System.Drawing.Point(15, 29);
            this.NhanVienTab.Margin = new System.Windows.Forms.Padding(4);
            this.NhanVienTab.Name = "NhanVienTab";
            this.NhanVienTab.SelectedIndex = 0;
            this.NhanVienTab.Size = new System.Drawing.Size(771, 393);
            this.NhanVienTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(763, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.moMon_table1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(763, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mở Môn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moMon_table1
            // 
            this.moMon_table1.Location = new System.Drawing.Point(0, 0);
            this.moMon_table1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.moMon_table1.Name = "moMon_table1";
            this.moMon_table1.Size = new System.Drawing.Size(771, 397);
            this.moMon_table1.TabIndex = 0;
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Controls.Add(this.sinhVien_table2);
            this.tabSinhVien.Location = new System.Drawing.Point(4, 22);
            this.tabSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Size = new System.Drawing.Size(763, 367);
            this.tabSinhVien.TabIndex = 2;
            this.tabSinhVien.Text = "Sinh viên";
            this.tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // sinhVien_table2
            // 
            this.sinhVien_table2.Location = new System.Drawing.Point(0, 0);
            this.sinhVien_table2.Name = "sinhVien_table2";
            this.sinhVien_table2.Size = new System.Drawing.Size(769, 372);
            this.sinhVien_table2.TabIndex = 0;
            // 
            // tabDangKy
            // 
            this.tabDangKy.Controls.Add(this.dangKy_table1);
            this.tabDangKy.Location = new System.Drawing.Point(4, 22);
            this.tabDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Size = new System.Drawing.Size(763, 367);
            this.tabDangKy.TabIndex = 3;
            this.tabDangKy.Text = "Đăng Ký";
            this.tabDangKy.UseVisualStyleBackColor = true;
            // 
            // dangKy_table1
            // 
            this.dangKy_table1.Location = new System.Drawing.Point(2, 2);
            this.dangKy_table1.Margin = new System.Windows.Forms.Padding(1);
            this.dangKy_table1.Name = "dangKy_table1";
            this.dangKy_table1.Size = new System.Drawing.Size(766, 372);
            this.dangKy_table1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GIAOVIENUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NhanVienTab);
            this.Name = "GIAOVIENUI";
            this.Text = "GIAOVIENUI";
            this.Load += new System.EventHandler(this.GIAOVIENUI_Load);
            this.NhanVienTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabSinhVien.ResumeLayout(false);
            this.tabDangKy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl NhanVienTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MoMon_table moMon_table1;
        private System.Windows.Forms.TabPage tabSinhVien;
        private SinhVien_table sinhVien_table2;
        private System.Windows.Forms.TabPage tabDangKy;
        private DangKy_table dangKy_table1;
        private System.Windows.Forms.Button button1;
    }
}