using System;
using System.Windows.Forms;

namespace ELSM_Project
{
    public partial class mainDashboard : Form
    {
        public mainDashboard()
        {
            //On form load initialize component.
            InitializeComponent();
        }
		
		private void btnHome_Click(object sender, EventArgs e)
        {
			//Display message box informing the user that they're already on the page that they attempted to navigate to.
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
			//On button event, hide current form and open userList.
            Hide();  
            userList userListForm = new userList();
            userListForm.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open serverManagement.
            Hide();  
            serverManagement manageServers = new serverManagement();
            manageServers.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
			//On button event, hide current form and open locationManagement.
            Hide();  
            locationManagement manageL = new locationManagement();
            manageL.ShowDialog();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open accountManagement.
            Hide();
            accountManagement Account = new accountManagement();
            Account.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //On button event, trigger a message box confirming logout. If the user input is Yes, close the form.
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
        }

		private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            //Create process to open the link www.metallicgloss.com in the default browser.
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");
        }

        private void DashboardFRM_Load(object sender, EventArgs e)
        {
			//On load, set text of 3 text boxes to display information relevant to the user.
            lblCurrentIP.Text = "IP Address: " + loginMenu.IPAddress;
            lblPosition.Text = "Position: " + loginMenu.Role;
            lblCurrentCompany.Text = "Company: " + loginMenu.CompanyName;
			//Initialize permissions by using boolean variables on the loginMenu form to disable buttons if the permission is not granted.
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
    }
}
