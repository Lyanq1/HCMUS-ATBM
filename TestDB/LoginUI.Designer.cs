namespace TestDB
{
    partial class LoginUI
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
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Role = new System.Windows.Forms.ComboBox();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Username.Location = new System.Drawing.Point(251, 94);
            this.Username.Margin = new System.Windows.Forms.Padding(2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 26);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(110, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(110, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password.Location = new System.Drawing.Point(253, 138);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(123, 26);
            this.Password.TabIndex = 2;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(113, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "HỆ THỐNG QUẢN LÝ ĐẠI HỌC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(114, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(173, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Role
            // 
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "ADMIN",
            "Nhân Viên"});
            this.Role.Location = new System.Drawing.Point(253, 180);
            this.Role.Margin = new System.Windows.Forms.Padding(2);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(121, 28);
            this.Role.TabIndex = 8;
            // 
            // iconButton8
            // 
            this.iconButton8.Font = new System.Drawing.Font("Verdana", 10F);
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(477, 261);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(48, 24);
            this.iconButton8.TabIndex = 20;
            this.iconButton8.Text = "Exit";
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 304);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Role;
        private FontAwesome.Sharp.IconButton iconButton8;
    }
}