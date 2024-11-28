using System.Data;
using System.Data.Common;
using BasicCSharpConsoleNET.Exercises;
using Microsoft.Data.SqlClient;

namespace MyFirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtContent.Text += txtPreview.Text + Environment.NewLine;
        }

        private void txtContent_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnOK_Click(sender, e);
            }
        }

        private void txtPreview_TextChanged(object sender, EventArgs e)
        {
            lblPreview.Text = txtPreview.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFTestDb;Integrated Security=True;";
            var users = new List<User>();
            try
            {
                using (var conn = new SqlConnection(conStr))
                {
                    await conn.OpenAsync();

                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "Select * from Users";


                    var reader  = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        users.Add(new User
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            IsActive = reader.GetBoolean("IsActive")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            cbxUsers.DataSource = users;
            cbxUsers.DisplayMember = "Name";

            //dataGridView1.ro
            dataGridView1.DataSource = users;
        }

        private UserDetailsFrm _frm;

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            if (_frm == null)
            {
                _frm = new UserDetailsFrm((cbxUsers.SelectedItem != null) ?
                    (User)cbxUsers.SelectedItem :
                    new User());
            }

            if (_frm.Visible)
            {
                _frm.Hide();
            }
            else
            {
                _frm.ShowDialog();


                var users = cbxUsers.DataSource;
                cbxUsers.DataSource = null;
                cbxUsers.DataSource = users;
                cbxUsers.DisplayMember = "Name";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            DataSet dataSet = new DataSet();


            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FileManagerFrm();
            frm.ShowDialog();
        }

        private int _counter = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = $"({e.X},{e.Y}) count {_counter++}";
            
            //Thread.Sleep(500);

        }
    }
}
