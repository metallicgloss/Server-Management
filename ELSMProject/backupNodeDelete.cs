using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class backupNodeDelete : Form
    {
        public backupNodeDelete()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void backupNodeDelete_Load(object sender, EventArgs e)
        {
			//Connect to MySQL and set output as items of cmboHostname.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader();
            while (serverInformationRDR.Read())
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("backupNodeHostname"));
            }
            connectionMySQL.Close();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
			//Delete row from backupNodeInformation where hostname matches selected.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand deleteServerCMD = new MySqlCommand("DELETE FROM backupNodeInformation WHERE backupNodeHostname = @Hostname", connectionMySQL);
            deleteServerCMD.Parameters.AddWithValue("@Hostname", cmboHostname.Text);
            deleteServerCMD.ExecuteNonQuery();
            cmboHostname.Items.Clear();
			//Update information. Connect to MySQL and set output as items of cmboHostname.
            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader();
            while (serverInformationRDR.Read())
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("backupNodeHostname"));
            }
            connectionMySQL.Close();
        }

    }
}
