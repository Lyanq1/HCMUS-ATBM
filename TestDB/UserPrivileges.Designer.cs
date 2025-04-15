namespace TestDB
{
    partial class UserPrivileges
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grant = new System.Windows.Forms.Button();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.column = new System.Windows.Forms.CheckedListBox();
            this.withGrantOption = new System.Windows.Forms.CheckBox();
            this.table = new System.Windows.Forms.ComboBox();
            this.Privi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Grant);
            this.panel1.Controls.Add(this.iconButton8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.column);
            this.panel1.Controls.Add(this.withGrantOption);
            this.panel1.Controls.Add(this.table);
            this.panel1.Controls.Add(this.Privi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 456);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 199);
            this.dataGridView1.TabIndex = 23;
            // 
            // Grant
            // 
            this.Grant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Grant.Location = new System.Drawing.Point(295, 184);
            this.Grant.Margin = new System.Windows.Forms.Padding(2);
            this.Grant.Name = "Grant";
            this.Grant.Size = new System.Drawing.Size(108, 35);
            this.Grant.TabIndex = 22;
            this.Grant.Text = "GRANT";
            this.Grant.UseVisualStyleBackColor = true;
            this.Grant.Click += new System.EventHandler(this.Grant_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.Font = new System.Drawing.Font("Verdana", 10F);
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(704, 421);
            this.iconButton8.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(48, 24);
            this.iconButton8.TabIndex = 21;
            this.iconButton8.Text = "Exit";
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(481, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Attributes";
            // 
            // column
            // 
            this.column.FormattingEnabled = true;
            this.column.Location = new System.Drawing.Point(485, 71);
            this.column.Margin = new System.Windows.Forms.Padding(2);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(205, 154);
            this.column.TabIndex = 11;
            this.column.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // withGrantOption
            // 
            this.withGrantOption.AutoSize = true;
            this.withGrantOption.Location = new System.Drawing.Point(295, 154);
            this.withGrantOption.Margin = new System.Windows.Forms.Padding(2);
            this.withGrantOption.Name = "withGrantOption";
            this.withGrantOption.Size = new System.Drawing.Size(109, 17);
            this.withGrantOption.TabIndex = 10;
            this.withGrantOption.Text = "With Grant option";
            this.withGrantOption.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.FormattingEnabled = true;
            this.table.Items.AddRange(new object[] {
            "QLDH_NHANVIEN",
            "QLDH_SINHVIEN",
            "QLDH_DONVI",
            "QLDH_HOCPHAN",
            "QLDH_MOMON",
            "QLDH_DANGKY"});
            this.table.Location = new System.Drawing.Point(156, 198);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(121, 21);
            this.table.TabIndex = 9;
            this.table.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Privi
            // 
            this.Privi.FormattingEnabled = true;
            this.Privi.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE",
            "EXECUTE"});
            this.Privi.Location = new System.Drawing.Point(156, 136);
            this.Privi.Name = "Privi";
            this.Privi.Size = new System.Drawing.Size(121, 21);
            this.Privi.TabIndex = 8;
            this.Privi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priviledges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(37, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Table";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grant user priviledges";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Username.Location = new System.Drawing.Point(156, 71);
            this.Username.Margin = new System.Windows.Forms.Padding(2);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(123, 26);
            this.Username.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(395, 245);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(295, 199);
            this.dataGridView2.TabIndex = 24;
            // 
            // UserPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 456);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserPrivileges";
            this.Text = "UserPriveledge";
            this.Load += new System.EventHandler(this.UserPrivileges_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox table;
        private System.Windows.Forms.ComboBox Privi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox column;
        private System.Windows.Forms.CheckBox withGrantOption;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Button Grant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}