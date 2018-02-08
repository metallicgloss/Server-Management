using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class serverControl : Form
    {
        public serverControl()
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
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
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
            Hide(); //Hide form
            accountManagement Account = new accountManagement();
            Account.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
        }

        private void serverControl_Load(object sender, EventArgs e)
        {
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

            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
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
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void btnCreateCommand_Click(object sender, EventArgs e)
        {
            serverControlCreate Create = new serverControlCreate();
            Create.ShowDialog();
        }

        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            controlCommandEdit Edit = new controlCommandEdit();
            Edit.ShowDialog();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            serverControlDelete Delete = new serverControlDelete();
            Delete.ShowDialog();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            controlCommandRun Run = new controlCommandRun();
            Run.ShowDialog();
        }

        private void btnServerStatus_Click(object sender, EventArgs e)
        {
            serverControlStatus Status = new serverControlStatus();
            Status.ShowDialog();
        }
    }
}
