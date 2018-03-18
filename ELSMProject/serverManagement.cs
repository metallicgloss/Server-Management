using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class serverManagement : Form
    {
        public serverManagement()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open mainDashboard.
            Hide();
            mainDashboard Dashboard = new mainDashboard();
            Dashboard.ShowDialog();
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
            //Display message box informing the user that they're already on the page that they attempted to navigate to.
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
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

        private void manageServers_Load(object sender, EventArgs e)
        {
            //Initialize permissions by using boolean variables on the loginMenu form to disable buttons if the permission is not granted.
            if (loginMenu.permControlServers == false)
            {
                btnControlServers.Enabled = false;
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
            if (loginMenu.permCreateTicket == false)
            {
                btnCreateTicket.Enabled = false;
            }
            if (loginMenu.permCreateServer == false)
            {
                btnCreateServer.Enabled = false;
            }
            if (loginMenu.permCreateTicket == false)
            {
                btnCreateTicket.Enabled = false;
            }
            if (loginMenu.permEditServers == false)
            {
                btnEditServer.Enabled = false;
            }
            if (loginMenu.permDeleteServers == false)
            {
                btnDeleteServer.Enabled = false;
            }
            if (loginMenu.permManageBackupSystem == false)
            {
                btnBackupCentre.Enabled = false;
            }
            UpdateData();
        }

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            //On button event, open serverCreate form.
            serverCreate Create = new serverCreate();
            Create.ShowDialog();
            UpdateData();
        }

        private void btnEditServer_Click(object sender, EventArgs e)
        {
            //On button event, open serverEdit form.
            serverEdit Edit = new serverEdit();
            Edit.ShowDialog();
            UpdateData();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            //On button event, open serverDelete form.
            serverDelete Delete = new serverDelete();
            Delete.ShowDialog();
            UpdateData();
        }

        public void UpdateData()
        {
            //When serverDelete form is closed, connect to MySQL, run SQL command and output result to datagridview.
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT serverID, serverHostname, serverOS, serverIP FROM serverInformation WHERE serverCompany = " + loginMenu.CompanyID + "", conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dataGridView1.DataSource = bSource;

            }
            //If MySQL error, display messagebox with error.
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            conn.Close();
        }

        private void btnControlServers_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open controlManagement.
            Hide();
            controlManagement controlServerFRM = new controlManagement();
            controlServerFRM.ShowDialog();
        }

        private void btnBackupCentre_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open backupNodeList.
            Hide();
            backupNodeList backupNodeListForm = new backupNodeList();
            backupNodeListForm.ShowDialog();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open ticketNew.
            ticketNew ticket = new ticketNew();
            ticket.ShowDialog();
        }

        private void btnTicketReply_Click(object sender, EventArgs e)
        {
            //On button event, hide current form and open ticketView.
            Hide();
            ticketView ticket = new ticketView();
            ticket.ShowDialog();
        }
    }
}
