using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class backupNodeDelete : Form
    {
        public backupNodeDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void backupNodeDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE serverCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverInformationRDR.Read()) // While rows in reader
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("serverHostname"));
            }
            connectionMySQL.Close();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand deleteServerCMD = new MySqlCommand("DELETE FROM backupNodeInformation WHERE backupNodeHostname = @Hostname", connectionMySQL);
            deleteServerCMD.Parameters.AddWithValue("@Hostname", cmboHostname.Text);
            deleteServerCMD.ExecuteNonQuery();
            cmboHostname.Items.Clear();

            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverInformationRDR.Read()) // While rows in reader
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("backupNodeHostname"));
            }
            connectionMySQL.Close();
        }

    }
}
