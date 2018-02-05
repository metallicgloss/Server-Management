using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class manageServersCreate : Form
    {
        public manageServersCreate()
        {
            InitializeComponent();
        }

        private void manageServersCreate_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand locationsCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE companyID = @companyID", connectionMySQL);
            locationsCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader locationsRDR = locationsCMD.ExecuteReader(); // Execute MySQL reader query 
            while (locationsRDR.Read()) // While rows in reader
            {
                cmboLocation.Items.Add(locationsRDR.GetString("locationName"));
            }
            locationsRDR.Close();
            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
            MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query 
            while (osRDR.Read()) // While rows in reader
            {
                cmboOS.Items.Add(osRDR.GetString("operatingSystemsName"));
            }
            osRDR.Close();
            MySqlCommand networkPortCMD = new MySqlCommand("SELECT * FROM serverPort", connectionMySQL);
            MySqlDataReader networkPortRDR = networkPortCMD.ExecuteReader(); // Execute MySQL reader query 
            while (networkPortRDR.Read()) // While rows in reader
            {
                cmboNetwork.Items.Add(networkPortRDR.GetString("portSpeed"));
            }
            networkPortRDR.Close();
            connectionMySQL.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand locationCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", connectionMySQL);
            locationCMD.Parameters.AddWithValue("@location", cmboLocation.Text);
            MySqlDataReader locationRDR = locationCMD.ExecuteReader(); // Execute MySQL reader query
            locationRDR.Read(); // Read data from the reader to become usable
            var location = Convert.ToString(locationRDR[0]);
            locationRDR.Close();

            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
            osCMD.Parameters.AddWithValue("@os", cmboOS.Text);
            MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query
            osRDR.Read(); // Read data from the reader to become usable
            var os = Convert.ToString(osRDR[0]);
            osRDR.Close();

            MySqlCommand networkCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", connectionMySQL);
            networkCMD.Parameters.AddWithValue("@port", cmboNetwork.Text);
            MySqlDataReader networkRDR = networkCMD.ExecuteReader(); // Execute MySQL reader query
            networkRDR.Read(); // Read data from the reader to become usable
            var network = Convert.ToString(networkRDR[0]);
            networkRDR.Close();

            MySqlCommand serverCMD = new MySqlCommand("INSERT INTO serverInformation (serverCompany, serverLocation, serverHostname, serverUsername, serverPassword, serverKey, serverOS, serverIP, serverProcessor, serverRAM, serverPort, serverTransfer) VALUES (@serverCompany, @serverLocation, @serverHostname, @serverUsername, @serverPassword, @serverKey, @serverOS, @serverIP, @serverProcessor, @serverRAM, @serverPort, @serverTransfer)", connectionMySQL); 
            serverCMD.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
            serverCMD.Parameters.AddWithValue("@serverLocation", location);
            serverCMD.Parameters.AddWithValue("@serverHostname", txtHostname.Text);
            serverCMD.Parameters.AddWithValue("@serverUsername", txtUsername.Text);
            serverCMD.Parameters.AddWithValue("@serverPassword", txtPassword.Text);
            serverCMD.Parameters.AddWithValue("@serverKey", txtKey.Text);
            serverCMD.Parameters.AddWithValue("@serverOS", os);
            serverCMD.Parameters.AddWithValue("@serverIP", txtIP.Text);
            serverCMD.Parameters.AddWithValue("@serverProcessor", txtProcessor.Text);
            serverCMD.Parameters.AddWithValue("@serverRAM", txtRAM.Text);
            serverCMD.Parameters.AddWithValue("@serverPort", network);
            serverCMD.Parameters.AddWithValue("@serverTransfer", txtTransfer.Text);
            serverCMD.ExecuteNonQuery();
            connectionMySQL.Close();
            txtHostname.Text = "";
            txtIP.Text = "";
            txtKey.Text = "";
            txtPassword.Text = "";
            txtProcessor.Text = "";
            txtRAM.Text = "";
            txtTransfer.Text = "";
            txtUsername.Text = "";
        }
    }
}
