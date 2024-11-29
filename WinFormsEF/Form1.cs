using Microsoft.EntityFrameworkCore;
using WinFormsEF.Models;

namespace WinFormsEF
{
    public partial class Form1 : Form
    {
        EftestDbContext _dbContext;

        public Form1()
        {
            InitializeComponent();


        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await _dbContext.SaveChangesAsync();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _dbContext = new EftestDbContext();

                //await _dbContext.Users.LoadAsync();

                //lbxUsers.DataSource = _dbContext.Users.Local.ToBindingList();
                //lbxUsers.DisplayMember = "Name";

                //  => Groups
                await _dbContext.Groups.LoadAsync();
                groupBindingSource.DataSource = _dbContext.Groups.Local.ToBindingList();

                cbxGroups.DataSource = _dbContext.Groups.Local.ToBindingList();
                cbxGroups.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            //"John : Admin, PowerUser"

            var users = _dbContext.Users
                //.Where(u => u.UserGroups.Any(ug => ug.Group.Id == ((Group)cbxGroups.SelectedItem).Id))
                .Where(u => u.UserGroups.Any(ug => ug.Group.Equals(cbxGroups.SelectedItem)))
                .Select(u => $"{u.Name} : {string.Join(",", u.UserGroups.Select(ug => ug.Group.Name))}")
                .ToArray();

            lbxUsers.DataSource = users;
        }
    }
}
