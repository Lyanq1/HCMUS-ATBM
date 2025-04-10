namespace TestDB
{
    partial class GrantRevokeForm
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
            this.cmbGrantee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbObject = new System.Windows.Forms.ComboBox();
            this.chkWithGrant = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGrantee
            // 
            this.cmbGrantee.FormattingEnabled = true;
            this.cmbGrantee.Location = new System.Drawing.Point(107, 15);
            this.cmbGrantee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGrantee.Name = "cmbGrantee";
            this.cmbGrantee.Size = new System.Drawing.Size(265, 24);
            this.cmbGrantee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đối tượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quyền:";
            // 
            // cmbPrivilege
            // 
            this.cmbPrivilege.FormattingEnabled = true;
            this.cmbPrivilege.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "EXECUTE"});
            this.cmbPrivilege.Location = new System.Drawing.Point(107, 48);
            this.cmbPrivilege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(265, 24);
            this.cmbPrivilege.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đối tượng:";
            // 
            // cmbObject
            // 
            this.cmbObject.FormattingEnabled = true;
            this.cmbObject.Location = new System.Drawing.Point(107, 81);
            this.cmbObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbObject.Name = "cmbObject";
            this.cmbObject.Size = new System.Drawing.Size(265, 24);
            this.cmbObject.TabIndex = 4;
            // 
            // chkWithGrant
            // 
            this.chkWithGrant.AutoSize = true;
            this.chkWithGrant.Location = new System.Drawing.Point(107, 114);
            this.chkWithGrant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWithGrant.Name = "chkWithGrant";
            this.chkWithGrant.Size = new System.Drawing.Size(169, 20);
            this.chkWithGrant.TabIndex = 6;
            this.chkWithGrant.Text = "WITH GRANT OPTION";
            this.chkWithGrant.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(273, 143);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(100, 28);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Thực hiện";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // GrantRevokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 186);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.chkWithGrant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPrivilege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGrantee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GrantRevokeForm";
            this.Text = "Cấp/Thu hồi quyền";
            this.Load += new System.EventHandler(this.GrantRevokeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGrantee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbObject;
        private System.Windows.Forms.CheckBox chkWithGrant;
        private System.Windows.Forms.Button btnExecute;
    }
}