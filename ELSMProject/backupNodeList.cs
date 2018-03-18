using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class backupNodeList : Form
    {
        public backupNodeList()
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
            //On button event, hide current form and open serverManagement.
            Hide();
            serverManagement serverManagementForm = new serverManagement();
            serverManagementForm.ShowDialog();
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
            UpdateData();
        }

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            //On button event open backupNodeCreate.
            backupNodeCreate Create = new backupNodeCreate();
            Create.ShowDialog();
            UpdateData();
        }

        private void btnEditServer_Click(object sender, EventArgs e)
        {
            //On button event open backupNodeEdit.
            backupNodeEdit Edit = new backupNodeEdit();
            Edit.ShowDialog();
            UpdateData();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            //On button event open backupNodeDelete.
            backupNodeDelete delete = new backupNodeDelete();
            delete.ShowDialog();
            UpdateData();
        }

        public void UpdateData()
        {
            //Connect to MySQL and fill datagridview with data outputted from the SQL command.
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT backupNodeID, backupNodeHostname, backupNodeOS, backupNodeIP FROM serverInformation WHERE backupNodeCompany = " + loginMenu.CompanyID + "", conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dataGridView1.DataSource = bSource;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            conn.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //On button event open backupRunProcess.
            backupRunProcess backupRunProcessForm = new backupRunProcess();
            backupRunProcessForm.ShowDialog();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            //On button event open ticketNew.
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
