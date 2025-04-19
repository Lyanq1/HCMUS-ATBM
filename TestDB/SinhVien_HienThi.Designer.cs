namespace TestDB
{
    partial class SinhVien_HienThi
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
            this.btnexit = new System.Windows.Forms.Button();
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
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(135, 123);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lbTTSV
            // 
            this.lbTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTTSV.Location = new System.Drawing.Point(10, 174);
            this.lbTTSV.Name = "lbTTSV";
            this.lbTTSV.Size = new System.Drawing.Size(200, 30);
            this.lbTTSV.TabIndex = 14;
            this.lbTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // lbDChi
            // 
            this.lbDChi.AutoSize = true;
            this.lbDChi.Location = new System.Drawing.Point(15, 58);
            this.lbDChi.Name = "lbDChi";
            this.lbDChi.Size = new System.Drawing.Size(41, 13);
            this.lbDChi.TabIndex = 13;
            this.lbDChi.Text = "Địa Chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(15, 13);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(29, 13);
            this.lbSDT.TabIndex = 12;
            this.lbSDT.Text = "SĐT";
            // 
            // txtDChi
            // 
            this.txtDChi.Location = new System.Drawing.Point(15, 74);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(357, 20);
            this.txtDChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(15, 29);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(131, 20);
            this.txtSDT.TabIndex = 10;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(15, 123);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 9;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 230);
            this.dataGridView1.TabIndex = 8;
            // 
            // SinhVien_HienThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lbTTSV);
            this.Controls.Add(this.lbDChi);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.txtDChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SinhVien_HienThi";
            this.Text = "SinhVien_HienThi";
            this.Load += new System.EventHandler(this.SinhVien_HienThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbTTSV;
        private System.Windows.Forms.Label lbDChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}