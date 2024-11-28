using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicCSharpConsoleNET.Exercises;

namespace MyFirstWinFormsApp
{
    public partial class UserDetailsFrm : Form
    {
        private User _user;

        public UserDetailsFrm(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void UserDetailsFrm_Load(object sender, EventArgs e)
        {
            Text = _user.Name;
            txtName.Text = _user.Name;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _user.Name = txtName.Text;
            this.Close();
        }
    }
}
