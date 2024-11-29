namespace WinFormsEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbxUsers = new ListBox();
            dgvGroups = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBindingSource = new BindingSource(components);
            btnSave = new Button();
            groupBindingSource1 = new BindingSource(components);
            cbxGroups = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lbxUsers
            // 
            lbxUsers.FormattingEnabled = true;
            lbxUsers.Location = new Point(544, 33);
            lbxUsers.Name = "lbxUsers";
            lbxUsers.Size = new Size(244, 184);
            lbxUsers.TabIndex = 0;
            // 
            // dgvGroups
            // 
            dgvGroups.AutoGenerateColumns = false;
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dgvGroups.DataSource = groupBindingSource;
            dgvGroups.Location = new Point(52, 33);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.Size = new Size(278, 203);
            dgvGroups.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // groupBindingSource
            // 
            groupBindingSource.DataSource = typeof(Models.Group);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(142, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBindingSource1
            // 
            groupBindingSource1.DataSource = typeof(Models.Group);
            // 
            // cbxGroups
            // 
            cbxGroups.FormattingEnabled = true;
            cbxGroups.Location = new Point(407, 33);
            cbxGroups.Name = "cbxGroups";
            cbxGroups.Size = new Size(121, 23);
            cbxGroups.TabIndex = 3;
            cbxGroups.SelectedIndexChanged += cbxGroups_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxGroups);
            Controls.Add(btnSave);
            Controls.Add(dgvGroups);
            Controls.Add(lbxUsers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private ListBox lbxUsers;
        private DataGridView dgvGroups;
        private Button btnSave;
        private BindingSource groupBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource groupBindingSource1;
        private ComboBox cbxGroups;
    }
}
