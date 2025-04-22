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
            this.tabMoMon = new System.Windows.Forms.TabPage();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.moMon_table1 = new TestDB.MoMon_table();
            this.dangKy_table1 = new TestDB.DangKy_table();
            this.tabControl1.SuspendLayout();
            this.tabMoMon.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSinhVien);
            this.tabControl1.Controls.Add(this.tabMoMon);
            this.tabControl1.Controls.Add(this.tabDangKy);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 597);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Location = new System.Drawing.Point(4, 29);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinhVien.Size = new System.Drawing.Size(1168, 564);
            this.tabSinhVien.TabIndex = 0;
            this.tabSinhVien.Text = "Sinh Viên";
            this.tabSinhVien.UseVisualStyleBackColor = true;
            this.tabSinhVien.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabMoMon
            // 
            this.tabMoMon.Controls.Add(this.moMon_table1);
            this.tabMoMon.Location = new System.Drawing.Point(4, 29);
            this.tabMoMon.Name = "tabMoMon";
            this.tabMoMon.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoMon.Size = new System.Drawing.Size(1168, 564);
            this.tabMoMon.TabIndex = 1;
            this.tabMoMon.Text = "Mở Môn";
            this.tabMoMon.UseVisualStyleBackColor = true;
            // 
            // tabDangKy
            // 
            this.tabDangKy.Controls.Add(this.dangKy_table1);
            this.tabDangKy.Location = new System.Drawing.Point(4, 29);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Size = new System.Drawing.Size(1168, 564);
            this.tabDangKy.TabIndex = 2;
            this.tabDangKy.Text = "Đăng Ký";
            this.tabDangKy.UseVisualStyleBackColor = true;
            // 
            // moMon_table1
            // 
            this.moMon_table1.Location = new System.Drawing.Point(6, 0);
            this.moMon_table1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moMon_table1.Name = "moMon_table1";
            this.moMon_table1.Size = new System.Drawing.Size(1156, 557);
            this.moMon_table1.TabIndex = 0;
            // 
            // dangKy_table1
            // 
            this.dangKy_table1.Location = new System.Drawing.Point(3, 3);
            this.dangKy_table1.Name = "dangKy_table1";
            this.dangKy_table1.Size = new System.Drawing.Size(1153, 558);
            this.dangKy_table1.TabIndex = 0;
            // 
            // SinhVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Name = "SinhVienUI";
            this.Text = "SinhVienUI";
            this.tabControl1.ResumeLayout(false);
            this.tabMoMon.ResumeLayout(false);
            this.tabDangKy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSinhVien;
        private System.Windows.Forms.TabPage tabMoMon;
        private System.Windows.Forms.TabPage tabDangKy;
        private MoMon_table moMon_table1;
        private DangKy_table dangKy_table1;
    }
}