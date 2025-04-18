namespace TestDB
{
    partial class AddMommonForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMAMM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMAHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMAGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNAM = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAMM:";
            // 
            // txtMAMM
            // 
            this.txtMAMM.Location = new System.Drawing.Point(160, 21);
            this.txtMAMM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAMM.Name = "txtMAMM";
            this.txtMAMM.Size = new System.Drawing.Size(265, 22);
            this.txtMAMM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAHP:";
            // 
            // txtMAHP
            // 
            this.txtMAHP.Location = new System.Drawing.Point(160, 70);
            this.txtMAHP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAHP.Name = "txtMAHP";
            this.txtMAHP.Size = new System.Drawing.Size(265, 22);
            this.txtMAHP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "MAGV:";
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(160, 119);
            this.txtMAGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(265, 22);
            this.txtMAGV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "HK:";
            // 
            // txtHK
            // 
            this.txtHK.Location = new System.Drawing.Point(160, 169);
            this.txtHK.Margin = new System.Windows.Forms.Padding(4);
            this.txtHK.Name = "txtHK";
            this.txtHK.Size = new System.Drawing.Size(265, 22);
            this.txtHK.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "NAM:";
            // 
            // txtNAM
            // 
            this.txtNAM.Location = new System.Drawing.Point(160, 218);
            this.txtNAM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNAM.Name = "txtNAM";
            this.txtNAM.Size = new System.Drawing.Size(265, 22);
            this.txtNAM.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 271);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 37);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(300, 271);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMommonForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(467, 332);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNAM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMAGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMAHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMAMM);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMommonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Mở Môn Mới";
            this.Load += new System.EventHandler(this.AddMommonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMAMM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMAGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNAM;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}