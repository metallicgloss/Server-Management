using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class mainDashboard : Form
    {
        public mainDashboard()
        {
            InitializeComponent();
        }

        private void DashboardFRM_Load(object sender, EventArgs e)
        {
            lblCurrentCompany.Text = "Company: " + loginMenu.CompanyName;
            lblCurrentIP.Text = "IP Address: " + loginMenu.IPAddress;
            lblCurrentIP.Text = "Position: " + loginMenu.Role;
            lblWelcomeBack.Text = "Welcome Back " + loginMenu.Forename + "!";
            pctProfilePhoto.ImageLocation = loginMenu.ProfileImage;
            pctProfilePhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            pctProfilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
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
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
        }
        
    }
}
