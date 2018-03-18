using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class serverDelete : Form
    {
        public serverDelete()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();  
        }

        private void manageServersDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();
            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader();      
            while (serverInformationRDR.Read())     
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("serverHostname"));
            }
            connectionMySQL.Close();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();
            MySqlCommand deleteServerCMD = new MySqlCommand("DELETE FROM serverInformation WHERE serverHostname = @Hostname", connectionMySQL);
            deleteServerCMD.Parameters.AddWithValue("@Hostname", cmboHostname.Text);
            deleteServerCMD.ExecuteNonQuery(); 
            cmboHostname.Items.Clear();
            
            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader();      
            while (serverInformationRDR.Read())     
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("serverHostname"));
            }
            connectionMySQL.Close();
        }

    }
}
