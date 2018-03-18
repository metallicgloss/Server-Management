using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class controlManagement : Form
    {
        public controlManagement()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void serverControl_Load(object sender, EventArgs e)
        {
            //Connect to MySQL and fill datagridview with data outputted from the SQL command.
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
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            //Initialize permissions by using boolean variables on the loginMenu form to disable buttons if the permission is not granted.
            if (loginMenu.permAddAction == false)
            {
                btnCreateCommand.Enabled = false;
            }
            if (loginMenu.permEditAction == false)
            {
                btnEditCommand.Enabled = false;
            }
            if (loginMenu.permDeleteAction == false)
            {
                btnDeleteCommand.Enabled = false;
            }
            if (loginMenu.permRunCustomAction == false)
            {
                btnRunCommand.Enabled = false;
            }
        }

        private void btnCreateCommand_Click(object sender, EventArgs e)
        {
            //On button event open controlCommandCreate.
            controlCommandCreate Create = new controlCommandCreate();
            Create.ShowDialog();
        }

        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            //On button event open controlCommandEdit.
            controlCommandEdit Edit = new controlCommandEdit();
            Edit.ShowDialog();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            //On button event open controlCommandDelete.
            controlCommandDelete Delete = new controlCommandDelete();
            Delete.ShowDialog();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            //On button event open controlCommandRun.
            controlCommandRun Run = new controlCommandRun();
            Run.ShowDialog();
        }

        private void btnServerStatus_Click(object sender, EventArgs e)
        {
            //On button event open controlServerStatus.
            controlServerStatus Status = new controlServerStatus();
            Status.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //On button event open serverManagement.
            Hide();
            serverManagement serverManagementFRM = new serverManagement();
            serverManagementFRM.ShowDialog();
        }
    }
}
