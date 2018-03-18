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

        private void manageServersDelete_Load(object sender, EventArgs e)
        {
            //Connect to MySQL and set output to items in cmboHostname.
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
            //Connect to MySQL and delete from table row that matches selected value in cmboHostname.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand deleteServerCMD = new MySqlCommand("DELETE FROM serverInformation WHERE serverHostname = @Hostname", connectionMySQL);
            deleteServerCMD.Parameters.AddWithValue("@Hostname", cmboHostname.Text);
            deleteServerCMD.ExecuteNonQuery();
            //Clear cmboHostname
            cmboHostname.Items.Clear();
            //Connect to MySQL and set output to items in cmboHostname.
            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @companyID", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader();
            while (serverInformationRDR.Read())
            {
                cmboHostname.Items.Add(serverInformationRDR.GetString("serverHostname"));
            }
            connectionMySQL.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }
    }
}
