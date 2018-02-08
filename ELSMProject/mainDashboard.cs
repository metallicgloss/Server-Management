using System;
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
            lblCurrentIP.Text = "IP Address: " + loginMenu.IPAddress;
            lblPosition.Text = "Position: " + loginMenu.Role;
            if ((loginMenu.permControlServers == false) && (loginMenu.permViewLocations == false) && (loginMenu.permViewServers == false))
            {
                btnHome.Top += 129;
                btnManageLocations.Visible = false;
                btnManageServers.Visible = false;
                btnManageUsers.Visible = false;
            }
            else if ((loginMenu.permControlServers == false) && (loginMenu.permViewLocations == false))
            {
                btnHome.Top += 129;
                btnManageServers.Top += 86;
                btnManageUsers.Visible = false;
                btnManageLocations.Visible = false;
            }
            else if ((loginMenu.permControlServers == false) && (loginMenu.permViewServers == false))
            {
                btnHome.Top += 86;
                btnManageUsers.Visible = false;
                btnManageServers.Visible = false;
            }
            else if ((loginMenu.permViewServers == false) && (loginMenu.permViewLocations == false))
            {
                btnHome.Top += 86;
                btnManageUsers.Top += 86;
                btnManageLocations.Visible = false;
                btnManageServers.Visible = false;
            }
            else if (loginMenu.permControlServers == false)
            {
                btnHome.Top += 43;
                btnManageUsers.Visible = false;
            }
            else if (loginMenu.permViewServers == false)
            {
                btnHome.Top += 43;
                btnManageUsers.Top += 43;
                btnManageServers.Visible = false;
            }
            else if (loginMenu.permViewLocations == false)
            {
                btnHome.Top += 43;
                btnManageUsers.Top += 43;
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

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            userList userListForm = new userList();
            userListForm.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            serverManagement manageServers = new serverManagement();
            manageServers.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            locationManagement manageL = new locationManagement();
            manageL.ShowDialog();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            accountManagement manageAccount = new accountManagement();
            manageAccount.ShowDialog();
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
            ticketNew ticket = new ticketNew();
            ticket.ShowDialog();
        }

        private void btnTicketReply_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
            ticketNew ticket = new ticketNew();
            ticket.ShowDialog();
        }
    }
}
