using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
            Hide();
            mainDashboard Dashboard = new mainDashboard();
            Dashboard.ShowDialog();
        }

        private void btnServerControl_Click(object sender, EventArgs e)
        {
            Hide();
            serverControl Servers = new serverControl();
            Servers.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide();
            manageServers manageS = new manageServers();
            manageS.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            Hide();
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
            lblCurrentIP.Text = "IP Address: " + loginMenu.IPAddress;
            lblPosition.Text = "Position: " + loginMenu.Role;
            lblWelcomeBack.Text = "Welcome Back " + loginMenu.Forename + "!";
            pctProfilePhoto.ImageLocation = loginMenu.ProfileImage;
            pctProfilePhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            pctProfilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            largeProfileImage.ImageLocation = loginMenu.ProfileImage;
            largeProfileImage.SizeMode = PictureBoxSizeMode.CenterImage;
            largeProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;

            lblUserID.Text = "User ID: " + loginMenu.UserID;
            lblUsername.Text = "Username: " + loginMenu.Username;
            lblForename.Text = "Forename: " + loginMenu.Forename;
            lblSurname.Text = "Surname: " + loginMenu.Surname;
            lblEmailAddress.Text = "Email Address: " + loginMenu.EmailAddress;
            lblProfileURL.Text = "URL: " + loginMenu.ProfileImage;
            lblCompany.Text = "Company: " + mainDashboard.CompanyName;
            lblCompanyPosition.Text = "Position: " + loginMenu.Role;
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
