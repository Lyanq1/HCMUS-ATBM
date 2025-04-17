namespace TestDB
{
    partial class RevokePrivileges
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
            this.revokeButton = new System.Windows.Forms.Button();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.updateCheck = new System.Windows.Forms.CheckBox();
            this.insertCheck = new System.Windows.Forms.CheckBox();
            this.selectCheck = new System.Windows.Forms.CheckBox();
            this.preLabel = new System.Windows.Forms.Label();
            this.reTable = new System.Windows.Forms.Label();
            this.userroleBox = new System.Windows.Forms.TextBox();
            this.tableview = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TVcomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // revokeButton
            // 
            this.revokeButton.BackColor = System.Drawing.SystemColors.Control;
            this.revokeButton.Location = new System.Drawing.Point(256, 195);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(135, 63);
            this.revokeButton.TabIndex = 32;
            this.revokeButton.Text = "REVOKE";
            this.revokeButton.UseVisualStyleBackColor = false;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_Click);
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Location = new System.Drawing.Point(586, 163);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(82, 24);
            this.deleteCheck.TabIndex = 31;
            this.deleteCheck.Text = "Delete";
            this.deleteCheck.UseVisualStyleBackColor = true;
            // 
            // updateCheck
            // 
            this.updateCheck.AutoSize = true;
            this.updateCheck.Location = new System.Drawing.Point(471, 162);
            this.updateCheck.Name = "updateCheck";
            this.updateCheck.Size = new System.Drawing.Size(88, 24);
            this.updateCheck.TabIndex = 30;
            this.updateCheck.Text = "Update";
            this.updateCheck.UseVisualStyleBackColor = true;
            // 
            // insertCheck
            // 
            this.insertCheck.AutoSize = true;
            this.insertCheck.Location = new System.Drawing.Point(362, 163);
            this.insertCheck.Name = "insertCheck";
            this.insertCheck.Size = new System.Drawing.Size(76, 24);
            this.insertCheck.TabIndex = 29;
            this.insertCheck.Text = "Insert";
            this.insertCheck.UseVisualStyleBackColor = true;
            // 
            // selectCheck
            // 
            this.selectCheck.AutoSize = true;
            this.selectCheck.Location = new System.Drawing.Point(256, 162);
            this.selectCheck.Name = "selectCheck";
            this.selectCheck.Size = new System.Drawing.Size(80, 24);
            this.selectCheck.TabIndex = 28;
            this.selectCheck.Text = "Select";
            this.selectCheck.UseVisualStyleBackColor = true;
            // 
            // preLabel
            // 
            this.preLabel.AutoSize = true;
            this.preLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preLabel.Location = new System.Drawing.Point(56, 160);
            this.preLabel.Name = "preLabel";
            this.preLabel.Size = new System.Drawing.Size(98, 22);
            this.preLabel.TabIndex = 27;
            this.preLabel.Text = "Privileges";
            // 
            // reTable
            // 
            this.reTable.AutoSize = true;
            this.reTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reTable.Location = new System.Drawing.Point(54, 43);
            this.reTable.Name = "reTable";
            this.reTable.Size = new System.Drawing.Size(99, 22);
            this.reTable.TabIndex = 26;
            this.reTable.Text = "User/Role";
            this.reTable.Click += new System.EventHandler(this.reTable_Click);
            // 
            // userroleBox
            // 
            this.userroleBox.Location = new System.Drawing.Point(256, 42);
            this.userroleBox.Name = "userroleBox";
            this.userroleBox.Size = new System.Drawing.Size(384, 26);
            this.userroleBox.TabIndex = 25;
            // 
            // tableview
            // 
            this.tableview.AutoSize = true;
            this.tableview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableview.Location = new System.Drawing.Point(54, 103);
            this.tableview.Name = "tableview";
            this.tableview.Size = new System.Drawing.Size(110, 22);
            this.tableview.TabIndex = 24;
            this.tableview.Text = "Table/View";
            this.tableview.UseWaitCursor = true;
            // 
            // TVcomboBox
            // 
            this.TVcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TVcomboBox.FormattingEnabled = true;
            this.TVcomboBox.Items.AddRange(new object[] {
            "QLDH_NHANVIEN",
            "QLDH_SINHVIEN",
            "QLDH_DONVI",
            "QLDH_HOCPHAN",
            "QLDH_MOMON",
            "QLDH_DANGKY"});
            this.TVcomboBox.Location = new System.Drawing.Point(256, 102);
            this.TVcomboBox.Name = "TVcomboBox";
            this.TVcomboBox.Size = new System.Drawing.Size(384, 28);
            this.TVcomboBox.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(574, 382);
            this.dataGridView1.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(628, 266);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(524, 382);
            this.dataGridView2.TabIndex = 35;
            // 
            // RevokePrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.deleteCheck);
            this.Controls.Add(this.updateCheck);
            this.Controls.Add(this.insertCheck);
            this.Controls.Add(this.selectCheck);
            this.Controls.Add(this.preLabel);
            this.Controls.Add(this.reTable);
            this.Controls.Add(this.userroleBox);
            this.Controls.Add(this.tableview);
            this.Controls.Add(this.TVcomboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RevokePrivileges";
            this.Text = "RevokePrivileges";
            this.Load += new System.EventHandler(this.RevokePrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.CheckBox updateCheck;
        private System.Windows.Forms.CheckBox insertCheck;
        private System.Windows.Forms.CheckBox selectCheck;
        private System.Windows.Forms.Label preLabel;
        private System.Windows.Forms.Label reTable;
        private System.Windows.Forms.TextBox userroleBox;
        private System.Windows.Forms.Label tableview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox TVcomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}