using System;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class manageAccount : Form
    {
        public manageAccount()
        {
            InitializeComponent();
        }

        private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            mainDashboard Dashboard = new mainDashboard();
            Dashboard.ShowDialog();
        }

        private void btnServerControl_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            serverControl Servers = new serverControl();
            Servers.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            manageServers manageS = new manageServers();
            manageS.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            manageLocations manageL = new manageLocations();
            manageL.ShowDialog();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
        }

        private void manageAccount_Load(object sender, EventArgs e)
        {
            largeProfileImage.ImageLocation = loginMenu.ProfileImage;
            largeProfileImage.SizeMode = PictureBoxSizeMode.CenterImage;
            largeProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;

            lblUserID.Text = "User ID: " + loginMenu.UserID;
            lblUsername.Text = "Username: " + loginMenu.Username;
            lblForename.Text = "Forename: " + loginMenu.Forename;
            lblSurname.Text = "Surname: " + loginMenu.Surname;
            lblEmailAddress.Text = "Email Address: " + loginMenu.EmailAddress;
            lblProfileURL.Text = "URL: " + loginMenu.ProfileImage;
            lblCompany.Text = "Company: " + loginMenu.CompanyName;
            lblCompanyPosition.Text = "Position: " + loginMenu.Role;
            if ((loginMenu.permControlServers == false) && (loginMenu.permViewLocations == false) && (loginMenu.permViewServers == false))
            {
                btnHome.Top += 129;
                btnManageLocations.Visible = false;
                btnManageServers.Visible = false;
                btnServerControl.Visible = false;
            }
            else if ((loginMenu.permControlServers == false) && (loginMenu.permViewLocations == false))
            {
                btnHome.Top += 129;
                btnManageServers.Top += 86;
                btnServerControl.Visible = false;
                btnManageLocations.Visible = false;
            }
            else if ((loginMenu.permControlServers == false) && (loginMenu.permViewServers == false))
            {
                btnHome.Top += 86;
                btnServerControl.Visible = false;
                btnManageServers.Visible = false;
            }
            else if ((loginMenu.permViewServers == false) && (loginMenu.permViewLocations == false))
            {
                btnHome.Top += 86;
                btnServerControl.Top += 86;
                btnManageLocations.Visible = false;
                btnManageServers.Visible = false;
            }
            else if (loginMenu.permControlServers == false)
            {
                btnHome.Top += 43;
                btnServerControl.Visible = false;
            }
            else if (loginMenu.permViewServers == false)
            {
                btnHome.Top += 43;
                btnServerControl.Top += 43;
                btnManageServers.Visible = false;
            }
            else if (loginMenu.permViewLocations == false)
            {
                btnHome.Top += 43;
                btnServerControl.Top += 43;
                btnManageServers.Top += 43;
                btnManageLocations.Visible = false;
            }

            if (loginMenu.permChangeEmail == false)
            {
                btnChangeEmailAddress.Enabled = false;
            }
            if (loginMenu.permChangeUsername == false)
            {
                btnChangeUsername.Enabled = false;
            }
            if (loginMenu.permChangePassword == false)
            {
                btnChangePassword.Enabled = false;
            }
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            manageAccountUsername username = new manageAccountUsername();
            username.ShowDialog();
            lblUsername.Text = "Username: " + loginMenu.Username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            manageAccountPassword password = new manageAccountPassword();
            password.ShowDialog();
        }

        private void btnChangeEmailAddress_Click(object sender, EventArgs e)
        {
            manageAccountEmail Email = new manageAccountEmail();
            Email.ShowDialog();
            lblEmailAddress.Text = "Email Address: " + loginMenu.EmailAddress;
        }
    }
}
