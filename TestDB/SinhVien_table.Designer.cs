﻿namespace TestDB
{
    partial class SinhVien_table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTTSV = new System.Windows.Forms.Label();
            this.lbDChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTTSV
            // 
            this.lbTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTTSV.Location = new System.Drawing.Point(-2, 165);
            this.lbTTSV.Name = "lbTTSV";
            this.lbTTSV.Size = new System.Drawing.Size(200, 30);
            this.lbTTSV.TabIndex = 22;
            this.lbTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // lbDChi
            // 
            this.lbDChi.AutoSize = true;
            this.lbDChi.Location = new System.Drawing.Point(3, 49);
            this.lbDChi.Name = "lbDChi";
            this.lbDChi.Size = new System.Drawing.Size(41, 13);
            this.lbDChi.TabIndex = 21;
            this.lbDChi.Text = "Địa Chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(3, 4);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(29, 13);
            this.lbSDT.TabIndex = 20;
            this.lbSDT.Text = "SĐT";
            // 
            // txtDChi
            // 
            this.txtDChi.Location = new System.Drawing.Point(3, 65);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(357, 20);
            this.txtDChi.TabIndex = 19;
            this.txtDChi.TextChanged += new System.EventHandler(this.txtDChi_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(3, 20);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(131, 20);
            this.txtSDT.TabIndex = 18;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(3, 114);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 17;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 16;
            // 
            // SinhVien_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTTSV);
            this.Controls.Add(this.lbDChi);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.txtDChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SinhVien_table";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.SinhVien_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTTSV;
        private System.Windows.Forms.Label lbDChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
