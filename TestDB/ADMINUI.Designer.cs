namespace TestDB
{
    partial class ADMINUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.revokePrivilTab = new FontAwesome.Sharp.IconButton();
            this.tabPrivilView = new FontAwesome.Sharp.IconButton();
            this.objPriviTab = new FontAwesome.Sharp.IconButton();
            this.rolePriviTab = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.userTab = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.editNames = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.iconButton7);
            this.panel1.Controls.Add(this.revokePrivilTab);
            this.panel1.Controls.Add(this.tabPrivilView);
            this.panel1.Controls.Add(this.objPriviTab);
            this.panel1.Controls.Add(this.rolePriviTab);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.userTab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 762);
            this.panel1.TabIndex = 4;
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton7.AutoSize = true;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.iconButton7.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 40;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 648);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton7.Size = new System.Drawing.Size(250, 71);
            this.iconButton7.TabIndex = 6;
            this.iconButton7.Text = "Logout";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // revokePrivilTab
            // 
            this.revokePrivilTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.revokePrivilTab.FlatAppearance.BorderSize = 0;
            this.revokePrivilTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revokePrivilTab.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokePrivilTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.revokePrivilTab.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.revokePrivilTab.IconColor = System.Drawing.Color.Gainsboro;
            this.revokePrivilTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.revokePrivilTab.IconSize = 40;
            this.revokePrivilTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revokePrivilTab.Location = new System.Drawing.Point(0, 509);
            this.revokePrivilTab.Name = "revokePrivilTab";
            this.revokePrivilTab.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.revokePrivilTab.Size = new System.Drawing.Size(250, 71);
            this.revokePrivilTab.TabIndex = 5;
            this.revokePrivilTab.Text = "Revoke Privileges";
            this.revokePrivilTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revokePrivilTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.revokePrivilTab.UseVisualStyleBackColor = true;
            this.revokePrivilTab.Click += new System.EventHandler(this.revokePrivilTab_Click);
            // 
            // tabPrivilView
            // 
            this.tabPrivilView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPrivilView.FlatAppearance.BorderSize = 0;
            this.tabPrivilView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabPrivilView.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrivilView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.tabPrivilView.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.tabPrivilView.IconColor = System.Drawing.Color.Gainsboro;
            this.tabPrivilView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tabPrivilView.IconSize = 40;
            this.tabPrivilView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabPrivilView.Location = new System.Drawing.Point(0, 438);
            this.tabPrivilView.Name = "tabPrivilView";
            this.tabPrivilView.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tabPrivilView.Size = new System.Drawing.Size(250, 71);
            this.tabPrivilView.TabIndex = 4;
            this.tabPrivilView.Text = "Privilege viewer";
            this.tabPrivilView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabPrivilView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tabPrivilView.UseVisualStyleBackColor = true;
            this.tabPrivilView.Click += new System.EventHandler(this.tabPrivilView_Click);
            // 
            // objPriviTab
            // 
            this.objPriviTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.objPriviTab.FlatAppearance.BorderSize = 0;
            this.objPriviTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.objPriviTab.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objPriviTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.objPriviTab.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.objPriviTab.IconColor = System.Drawing.Color.Gainsboro;
            this.objPriviTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.objPriviTab.IconSize = 40;
            this.objPriviTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.objPriviTab.Location = new System.Drawing.Point(0, 367);
            this.objPriviTab.Name = "objPriviTab";
            this.objPriviTab.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.objPriviTab.Size = new System.Drawing.Size(250, 71);
            this.objPriviTab.TabIndex = 3;
            this.objPriviTab.Text = "Object\'s Privileges";
            this.objPriviTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.objPriviTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.objPriviTab.UseVisualStyleBackColor = true;
            this.objPriviTab.Click += new System.EventHandler(this.objPriviTab_Click);
            // 
            // rolePriviTab
            // 
            this.rolePriviTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.rolePriviTab.FlatAppearance.BorderSize = 0;
            this.rolePriviTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rolePriviTab.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolePriviTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.rolePriviTab.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.rolePriviTab.IconColor = System.Drawing.Color.Gainsboro;
            this.rolePriviTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rolePriviTab.IconSize = 40;
            this.rolePriviTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rolePriviTab.Location = new System.Drawing.Point(0, 296);
            this.rolePriviTab.Name = "rolePriviTab";
            this.rolePriviTab.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.rolePriviTab.Size = new System.Drawing.Size(250, 71);
            this.rolePriviTab.TabIndex = 2;
            this.rolePriviTab.Text = "Role\'s Privileges";
            this.rolePriviTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rolePriviTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rolePriviTab.UseVisualStyleBackColor = true;
            this.rolePriviTab.Click += new System.EventHandler(this.rolePriviTab_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 225);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(250, 71);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "User\'s Privileges";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // userTab
            // 
            this.userTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.userTab.FlatAppearance.BorderSize = 0;
            this.userTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userTab.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.userTab.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.userTab.IconColor = System.Drawing.Color.Gainsboro;
            this.userTab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userTab.IconSize = 40;
            this.userTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userTab.Location = new System.Drawing.Point(0, 154);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.userTab.Size = new System.Drawing.Size(250, 71);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "Users && Roles";
            this.userTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userTab.UseVisualStyleBackColor = true;
            this.userTab.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(250, 154);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dataGridViewRoles);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.deleteUser);
            this.panel5.Controls.Add(this.CreateUserBtn);
            this.panel5.Controls.Add(this.editNames);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dataGridViewUsers);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.iconButton8);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(258, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1168, 762);
            this.panel5.TabIndex = 20;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(878, 665);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 43);
            this.button5.TabIndex = 33;
            this.button5.Text = "Delete roles";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(878, 565);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 43);
            this.button6.TabIndex = 32;
            this.button6.Text = "Create new ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "";
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(52, 398);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 24);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Search for roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(45, 352);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Roles";
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoles.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRoles.EnableHeadersVisualStyles = false;
            this.dataGridViewRoles.GridColor = System.Drawing.Color.White;
            this.dataGridViewRoles.Location = new System.Drawing.Point(51, 452);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.RowHeadersWidth = 62;
            this.dataGridViewRoles.Size = new System.Drawing.Size(788, 257);
            this.dataGridViewRoles.TabIndex = 28;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button8.Location = new System.Drawing.Point(255, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 42);
            this.button8.TabIndex = 27;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(878, 302);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(110, 43);
            this.deleteUser.TabIndex = 26;
            this.deleteUser.Text = "Delete users";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.button4_Click);
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Location = new System.Drawing.Point(878, 202);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(110, 43);
            this.CreateUserBtn.TabIndex = 25;
            this.CreateUserBtn.Text = "Create new ";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // editNames
            // 
            this.editNames.Location = new System.Drawing.Point(878, 112);
            this.editNames.Name = "editNames";
            this.editNames.Size = new System.Drawing.Size(110, 43);
            this.editNames.TabIndex = 24;
            this.editNames.Text = "Edit";
            this.editNames.UseVisualStyleBackColor = true;
            this.editNames.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(51, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 24);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Search for users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUsers.ColumnHeadersHeight = 18;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.White;
            this.dataGridViewUsers.Location = new System.Drawing.Point(51, 112);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.Size = new System.Drawing.Size(798, 235);
            this.dataGridViewUsers.TabIndex = 21;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(255, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(44, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 242);
            this.panel3.TabIndex = 34;
            // 
            // iconButton8
            // 
            this.iconButton8.Font = new System.Drawing.Font("Verdana", 10F);
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(1072, 703);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(72, 37);
            this.iconButton8.TabIndex = 36;
            this.iconButton8.Text = "Exit";
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(92)))), ((int)(((byte)(232)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(44, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(796, 267);
            this.panel4.TabIndex = 35;
            // 
            // ADMINUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1426, 762);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "ADMINUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private FontAwesome.Sharp.IconButton userTab;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton revokePrivilTab;
        private FontAwesome.Sharp.IconButton tabPrivilView;
        private FontAwesome.Sharp.IconButton objPriviTab;
        private FontAwesome.Sharp.IconButton rolePriviTab;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.Button editNames;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Panel panel4;
    }
}

