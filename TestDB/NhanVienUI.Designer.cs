namespace TestDB
{
    partial class NhanVienUI
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
            this.tabSV = new System.Windows.Forms.TabPage();
            this.sinhVien_table1 = new TestDB.SinhVien_table();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NhanVienTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienTab
            // 
            this.NhanVienTab.Controls.Add(this.tabPage1);
            this.NhanVienTab.Controls.Add(this.tabPage2);
            this.NhanVienTab.Location = new System.Drawing.Point(18, 43);
            this.NhanVienTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NhanVienTab.Name = "NhanVienTab";
            this.NhanVienTab.SelectedIndex = 0;
            this.NhanVienTab.Size = new System.Drawing.Size(1157, 605);
            this.NhanVienTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1148, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.moMon_table1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1149, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mở Môn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moMon_table1
            // 
            this.moMon_table1.Location = new System.Drawing.Point(0, 0);
            this.moMon_table1.Name = "moMon_table1";
            this.moMon_table1.Size = new System.Drawing.Size(1156, 611);
            this.moMon_table1.TabIndex = 0;
            this.moMon_table1.Load += new System.EventHandler(this.moMon_table1_Load);
            // 
            // tabSV
            // 
            this.tabSV.Controls.Add(this.sinhVien_table1);
            this.tabSV.Location = new System.Drawing.Point(4, 22);
            this.tabSV.Margin = new System.Windows.Forms.Padding(2);
            this.tabSV.Name = "tabSV";
            this.tabSV.Size = new System.Drawing.Size(573, 310);
            this.tabSV.TabIndex = 2;
            this.tabSV.Text = "Sinh Viên";
            this.tabSV.UseVisualStyleBackColor = true;
            this.tabSV.Click += new System.EventHandler(this.tabSV_Click);
            // 
            // sinhVien_table1
            // 
            this.sinhVien_table1.Location = new System.Drawing.Point(0, 0);
            this.sinhVien_table1.Margin = new System.Windows.Forms.Padding(2);
            this.sinhVien_table1.Name = "sinhVien_table1";
            this.sinhVien_table1.Size = new System.Drawing.Size(571, 310);
            this.sinhVien_table1.TabIndex = 0;
            this.sinhVien_table1.Load += new System.EventHandler(this.sinhVien_table1_Load);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1089, 657);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 32);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xem thông báo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // NhanVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.NhanVienTab);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NhanVienUI";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVienUI_Load);
            this.NhanVienTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabSV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl NhanVienTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
       // private Nhanvien_table nhanvien_table1;
        private MoMon_table moMon_table1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TabPage tabSV;
        private SinhVien_table sinhVien_table1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}