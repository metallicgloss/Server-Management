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
    public partial class mainDashboard : Form
    {

        public mainDashboard()
        {
            InitializeComponent();
        }

        private void DashboardFRM_Load(object sender, EventArgs e)
        {
            lblCurrentIP.Text = "IP Address: " + loginMenu.IPAddress;
            lblPosition.Text = "Position: " + loginMenu.Role;
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
        }

        private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");//www.metallicgloss.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
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
            Hide(); //Hide form
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

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            newTicket ticket = new newTicket();
            ticket.ShowDialog();
        }
    }
}
