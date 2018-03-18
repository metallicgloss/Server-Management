using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class userList : Form
    {
        public userList()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            //Create process to open the link www.metallicgloss.com in the default browser.
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();  
            mainDashboard Dashboard = new mainDashboard();
            Dashboard.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide();  
            serverManagement serverManagementForm = new serverManagement();
            serverManagementForm.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
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

        private void manageServers_Load(object sender, EventArgs e)
        {
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
            if (loginMenu.permAdminAddUser == false)
            {
                btnCreateUser.Enabled = false;
            }
            if (loginMenu.permAdminDelUser == false)
            {
                btnDeleteUser.Enabled = false;
            }
            if (loginMenu.permAdminEditUserInfo == false)
            {
                btnEditUser.Enabled = false;
            }
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT userID, userLogin, userForename, userSurname, userEmailAddress FROM userAccounts WHERE userCompany = " + loginMenu.CompanyID + "", conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                userListDGV.DataSource = bSource;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            userCreate Create = new userCreate();
            Create.ShowDialog();
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT userID, userLogin, userForename, userSurname, userEmailAddress FROM userAccounts WHERE userCompany = " + loginMenu.CompanyID + "", conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                userListDGV.DataSource = bSource;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            userEdit Edit = new userEdit();
            Edit.ShowDialog();
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT userID, userLogin, userForename, userSurname, userEmailAddress FROM userAccounts WHERE userCompany = " + loginMenu.CompanyID + "", conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                userListDGV.DataSource = bSource;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            userDelete delete = new userDelete();
            delete.ShowDialog();
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand("SELECT userID, userLogin, userForename, userSurname, userEmailAddress FROM userAccounts WHERE userCompany = " + loginMenu.CompanyID + "", conn);
                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                userListDGV.DataSource = bSource;

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
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
