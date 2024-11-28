namespace MyFirstWinFormsApp
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
            cbxUsers = new ComboBox();
            btnOK = new Button();
            txtPreview = new TextBox();
            txtContent = new TextBox();
            lblPreview = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            showSomethingToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fileManagerToolStripMenuItem = new ToolStripMenuItem();
            btnNewForm = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxUsers
            // 
            cbxUsers.FormattingEnabled = true;
            cbxUsers.Location = new Point(548, 35);
            cbxUsers.Name = "cbxUsers";
            cbxUsers.Size = new Size(121, 23);
            cbxUsers.TabIndex = 0;
            cbxUsers.SelectedIndexChanged += cbxUsers_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.OrangeRed;
            btnOK.ForeColor = Color.Azure;
            btnOK.Location = new Point(47, 60);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            btnOK.KeyPress += btnOK_KeyPress;
            // 
            // txtPreview
            // 
            txtPreview.Location = new Point(127, 60);
            txtPreview.Name = "txtPreview";
            txtPreview.Size = new Size(145, 23);
            txtPreview.TabIndex = 2;
            txtPreview.TextChanged += txtPreview_TextChanged;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(47, 109);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(225, 188);
            txtContent.TabIndex = 3;
            txtContent.KeyPress += txtContent_KeyPress;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Location = new Point(305, 60);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(0, 15);
            lblPreview.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(400, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(346, 209);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showSomethingToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // showSomethingToolStripMenuItem
            // 
            showSomethingToolStripMenuItem.Name = "showSomethingToolStripMenuItem";
            showSomethingToolStripMenuItem.Size = new Size(163, 22);
            showSomethingToolStripMenuItem.Text = "Show something";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileManagerToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // fileManagerToolStripMenuItem
            // 
            fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            fileManagerToolStripMenuItem.Size = new Size(180, 22);
            fileManagerToolStripMenuItem.Text = "File manager";
            fileManagerToolStripMenuItem.Click += fileManagerToolStripMenuItem_Click;
            // 
            // btnNewForm
            // 
            btnNewForm.Location = new Point(53, 356);
            btnNewForm.Name = "btnNewForm";
            btnNewForm.Size = new Size(116, 23);
            btnNewForm.TabIndex = 7;
            btnNewForm.Text = "Nowe okno";
            btnNewForm.UseVisualStyleBackColor = true;
            btnNewForm.Click += btnNewForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 34);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNewForm);
            Controls.Add(dataGridView1);
            Controls.Add(lblPreview);
            Controls.Add(txtContent);
            Controls.Add(txtPreview);
            Controls.Add(btnOK);
            Controls.Add(cbxUsers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxUsers;
        private Button btnOK;
        private TextBox txtPreview;
        private TextBox txtContent;
        private Label lblPreview;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem showSomethingToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Button btnNewForm;
        private ToolStripMenuItem fileManagerToolStripMenuItem;
        private Label label1;
    }
}
