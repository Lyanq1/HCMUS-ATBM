﻿namespace TestDB
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
            this.nhanvien_table1 = new TestDB.Nhanvien_table();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moMon_table1 = new TestDB.MoMon_table();
            this.exit = new System.Windows.Forms.Button();
            this.tabSV = new System.Windows.Forms.TabPage();
            this.sinhVien_table1 = new TestDB.SinhVien_table();
            this.NhanVienTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienTab
            // 
            this.NhanVienTab.Controls.Add(this.tabPage1);
            this.NhanVienTab.Controls.Add(this.tabPage2);
            this.NhanVienTab.Controls.Add(this.tabSV);
            this.NhanVienTab.Location = new System.Drawing.Point(9, 18);
            this.NhanVienTab.Name = "NhanVienTab";
            this.NhanVienTab.SelectedIndex = 0;
            this.NhanVienTab.Size = new System.Drawing.Size(775, 413);
            this.NhanVienTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nhanvien_table1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(767, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // nhanvien_table1
            // 
            this.nhanvien_table1.Location = new System.Drawing.Point(2, 0);
            this.nhanvien_table1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.nhanvien_table1.Name = "nhanvien_table1";
            this.nhanvien_table1.Size = new System.Drawing.Size(769, 395);
            this.nhanvien_table1.TabIndex = 0;
            this.nhanvien_table1.Load += new System.EventHandler(this.nhanvien_table1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.moMon_table1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(767, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mở Môn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moMon_table1
            // 
            this.moMon_table1.Location = new System.Drawing.Point(0, 0);
            this.moMon_table1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.moMon_table1.Name = "moMon_table1";
            this.moMon_table1.Size = new System.Drawing.Size(771, 397);
            this.moMon_table1.TabIndex = 0;
            this.moMon_table1.Load += new System.EventHandler(this.moMon_table1_Load);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(726, 427);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(57, 21);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tabSV
            // 
            this.tabSV.Controls.Add(this.sinhVien_table1);
            this.tabSV.Location = new System.Drawing.Point(4, 22);
            this.tabSV.Name = "tabSV";
            this.tabSV.Size = new System.Drawing.Size(767, 387);
            this.tabSV.TabIndex = 2;
            this.tabSV.Text = "Sinh Viên";
            this.tabSV.UseVisualStyleBackColor = true;
            this.tabSV.Click += new System.EventHandler(this.tabSV_Click);
            // 
            // sinhVien_table1
            // 
            this.sinhVien_table1.Location = new System.Drawing.Point(0, 0);
            this.sinhVien_table1.Name = "sinhVien_table1";
            this.sinhVien_table1.Size = new System.Drawing.Size(761, 381);
            this.sinhVien_table1.TabIndex = 0;
            // 
            // NhanVienUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.NhanVienTab);
            this.Name = "NhanVienUI";
            this.Text = "NhanVien";
            this.NhanVienTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl NhanVienTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Nhanvien_table nhanvien_table1;
        private MoMon_table moMon_table1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TabPage tabSV;
        private SinhVien_table sinhVien_table1;
    }
}