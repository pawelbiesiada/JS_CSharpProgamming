namespace MyFirstWinFormsApp
{
    partial class FileManagerFrm
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
            txtContent = new TextBox();
            btnLoad = new Button();
            txtFileName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(10, 59);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(778, 379);
            txtContent.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(631, 15);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 16);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(613, 23);
            txtFileName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(712, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FileManagerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtFileName);
            Controls.Add(btnLoad);
            Controls.Add(txtContent);
            Name = "FileManagerFrm";
            Text = "FileManagerFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContent;
        private Button btnLoad;
        private TextBox txtFileName;
        private Button btnSave;
    }
}