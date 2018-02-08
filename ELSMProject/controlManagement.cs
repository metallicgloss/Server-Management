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
            InitializeComponent();
        }       
        
        private void serverControl_Load(object sender, EventArgs e)
        {
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
            controlCommandCreate Create = new controlCommandCreate();
            Create.ShowDialog();
        }

        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            controlCommandEdit Edit = new controlCommandEdit();
            Edit.ShowDialog();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            controlCommandDelete Delete = new controlCommandDelete();
            Delete.ShowDialog();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            controlCommandRun Run = new controlCommandRun();
            Run.ShowDialog();
        }

        private void btnServerStatus_Click(object sender, EventArgs e)
        {
            controlServerStatus Status = new controlServerStatus();
            Status.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            serverManagement serverManagementFRM = new serverManagement();
            serverManagementFRM.ShowDialog();
        }
    }
}
