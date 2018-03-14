﻿using System;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class accountManagement : Form
    {
        public accountManagement()
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

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            userList userListForm = new userList();
            userListForm.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            serverManagement manageS = new serverManagement();
            manageS.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            locationManagement manageL = new locationManagement();
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
            if (loginMenu.permControlServers == false)
            {
                btnManageUsers.Enabled = false;
            }
            if (loginMenu.permViewLocations == false)
            {
                btnManageLocations.Enabled = false;
            }
            if (loginMenu.permAdminViewUsers == false)
            {
                btnManageUsers.Enabled = false;
            }
            if (loginMenu.permViewServers == false)
            {
                btnManageServers.Enabled = false;
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
            accountUsername username = new accountUsername();
            username.ShowDialog();
            lblUsername.Text = "Username: " + loginMenu.Username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            accountPassword password = new accountPassword();
            password.ShowDialog();
        }

        private void btnChangeEmailAddress_Click(object sender, EventArgs e)
        {
            accountEmail Email = new accountEmail();
            Email.ShowDialog();
            lblEmailAddress.Text = "Email Address: " + loginMenu.EmailAddress;
        }

        private void btnForename_Click(object sender, EventArgs e)
        {
            accountForename forename = new accountForename();
            forename.ShowDialog();
        }

        private void btnSurname_Click(object sender, EventArgs e)
        {
            accountSurname surname = new accountSurname();
            surname.ShowDialog();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            ticketNew ticket = new ticketNew();
            ticket.ShowDialog();
        }
    }
}
