using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstWinFormsApp
{
    public partial class FileManagerFrm : Form
    {
        public FileManagerFrm()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = txtFileName.Text;

            if (File.Exists(filePath) && filePath.EndsWith(".txt"))
            {
                try
                {
                    await Task.Delay(5000);
                    string fileContent = await File.ReadAllTextAsync(filePath);
                    txtContent.Text = fileContent;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                var result = MessageBox.Show("Plik nie istnieje", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var task = File.WriteAllTextAsync(txtFileName.Text, txtContent.Text);
            
            try
            {
                //File.WriteAllText(txtFileName.Text, txtContent.Text);
                //File.WriteAllTextAsync(txtFileName.Text, txtContent.Text).Wait();
                await task;
                ///
            }
            catch 
            {
                MessageBox.Show("Mamy problem przy zapisu plika!");
            }
        }
    }
}
