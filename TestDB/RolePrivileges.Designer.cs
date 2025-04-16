namespace TestDB
{
    partial class RolePrivileges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userRole = new System.Windows.Forms.TextBox();
            this.grantedRole = new System.Windows.Forms.TextBox();
            this.withAdminOption = new System.Windows.Forms.CheckBox();
            this.grantBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User/Role need to be granted";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Granted role";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.grantBtn);
            this.panel1.Controls.Add(this.withAdminOption);
            this.panel1.Controls.Add(this.grantedRole);
            this.panel1.Controls.Add(this.userRole);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userRole
            // 
            this.userRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userRole.Location = new System.Drawing.Point(285, 40);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(135, 26);
            this.userRole.TabIndex = 2;
            // 
            // grantedRole
            // 
            this.grantedRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grantedRole.Location = new System.Drawing.Point(285, 80);
            this.grantedRole.Name = "grantedRole";
            this.grantedRole.Size = new System.Drawing.Size(135, 26);
            this.grantedRole.TabIndex = 3;
            // 
            // withAdminOption
            // 
            this.withAdminOption.AutoSize = true;
            this.withAdminOption.Location = new System.Drawing.Point(457, 47);
            this.withAdminOption.Name = "withAdminOption";
            this.withAdminOption.Size = new System.Drawing.Size(111, 17);
            this.withAdminOption.TabIndex = 4;
            this.withAdminOption.Text = "With admin option";
            this.withAdminOption.UseVisualStyleBackColor = true;
            // 
            // grantBtn
            // 
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grantBtn.Location = new System.Drawing.Point(457, 71);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(111, 35);
            this.grantBtn.TabIndex = 5;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = true;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 272);
            this.dataGridView1.TabIndex = 6;
            // 
            // RolePrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RolePrivileges";
            this.Text = "RolePrivileges";
            this.Load += new System.EventHandler(this.RolePrivileges_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.CheckBox withAdminOption;
        private System.Windows.Forms.TextBox grantedRole;
        private System.Windows.Forms.TextBox userRole;
    }
}