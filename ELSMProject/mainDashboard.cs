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
            lblCurrentCompany.Text = "Company: " + loginMenu.CompanyName;
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
            if (loginMenu.permCreateTicket == false)
            {
                btnCreateTicket.Enabled = false;
            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            ticketNew ticket = new ticketNew();
            ticket.ShowDialog();
        }

        private void btnTicketReply_Click(object sender, EventArgs e)
        {
            Hide();  
            ticketView ticket = new ticketView();
            ticket.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Hide();  
            userList userListForm = new userList();
            userListForm.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide();  
            serverManagement manageServers = new serverManagement();
            manageServers.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            Hide();  
            locationManagement manageL = new locationManagement();
            manageL.ShowDialog();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            Hide();  
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

        

        
        private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");
        }
    }
}
