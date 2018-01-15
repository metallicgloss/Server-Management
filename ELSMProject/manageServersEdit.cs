using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class manageServersEdit : Form
    {
        public manageServersEdit()
        {
            InitializeComponent();
        }

        public static string password, key;


        private void manageServersEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation", connectionMySQL);
            MySqlDataReader serverRDR = serverCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverRDR.Read()) // While rows in reader
            {
                cmboHostNames.Items.Add(serverRDR.GetString("serverHostname"));
            }
            serverRDR.Close();
            connectionMySQL.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @Hostname", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text); 
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            serverInformationRDR.Read(); // Read data from the reader to become usable
            txtUsername.Text = Convert.ToString(serverInformationRDR[4]);
            txtIP.Text = Convert.ToString(serverInformationRDR[8]);
            txtProcessor.Text = Convert.ToString(serverInformationRDR[9]);
            txtRAM.Text = Convert.ToString(serverInformationRDR[10]);
            txtTransfer.Text = Convert.ToString(serverInformationRDR[12]);
            manageServersEdit.password = Convert.ToString(serverInformationRDR[5]);
            manageServersEdit.key = Convert.ToString(serverInformationRDR[6]);
            var serverLocation = Convert.ToString(serverInformationRDR[2]);
            var serverOS = Convert.ToString(serverInformationRDR[7]);
            var serverPort = Convert.ToString(serverInformationRDR[11]);
            txtPassword.Text = "";
            txtKey.Text = "";
            serverInformationRDR.Close();

            MySqlCommand serverLocationCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE companyID = @companyID", connectionMySQL);
            serverLocationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader serverLocationRDR = serverLocationCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverLocationRDR.Read()) // While rows in reader
            {
                cmboLocation.Items.Add(serverLocationRDR.GetString("locationName"));
            }
            serverLocationRDR.Close();

            MySqlCommand serverOSCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
            MySqlDataReader serverOSRDR = serverOSCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverOSRDR.Read()) // While rows in reader
            {
                cmboOS.Items.Add(serverOSRDR.GetString("operatingSystemsName"));
            }
            serverOSRDR.Close();

            MySqlCommand serverNetworkPortCMD = new MySqlCommand("SELECT * FROM serverPort", connectionMySQL);
            MySqlDataReader serverNetworkPortRDR = serverNetworkPortCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverNetworkPortRDR.Read()) // While rows in reader
            {
                cmboNetwork.Items.Add(serverNetworkPortRDR.GetString("portSpeed"));
            }
            serverNetworkPortRDR.Close();
            
            MySqlCommand serverLocationDisplayCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationID = @locationID", connectionMySQL);
            serverLocationDisplayCMD.Parameters.AddWithValue("@locationID", serverLocation); 
            MySqlDataReader serverLocationDisplayRDR = serverLocationDisplayCMD.ExecuteReader(); // Execute MySQL reader query 
            serverLocationDisplayRDR.Read(); // Read data from the reader to become usable
            cmboLocation.Text = Convert.ToString(serverLocationDisplayRDR.GetString("locationName"));
            serverLocationDisplayRDR.Close();
            
            MySqlCommand serverOSDisplayCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsID = @operatingSystemsID", connectionMySQL);
            serverOSDisplayCMD.Parameters.AddWithValue("@operatingSystemsID", serverOS); 
            MySqlDataReader serverOSDisplayRDR = serverOSDisplayCMD.ExecuteReader(); // Execute MySQL reader query 
            serverOSDisplayRDR.Read(); // Read data from the reader to become usable
            cmboOS.Text = Convert.ToString(serverOSDisplayRDR[1]);
            serverOSDisplayRDR.Close();
            
            MySqlCommand serverNetworkPortDisplayCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portID = @portID", connectionMySQL);
            serverNetworkPortDisplayCMD.Parameters.AddWithValue("@portID", serverPort); 
            MySqlDataReader serverNetworkPortDisplayRDR = serverNetworkPortDisplayCMD.ExecuteReader(); // Execute MySQL reader query 
            serverNetworkPortDisplayRDR.Read(); // Read data from the reader to become usable
            cmboNetwork.Text = Convert.ToString(serverNetworkPortDisplayRDR[1]);
            serverNetworkPortDisplayRDR.Close();

            connectionMySQL.Close();

            cmboLocation.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtKey.Enabled = true;
            cmboOS.Enabled = true;
            txtIP.Enabled = true;
            txtProcessor.Enabled = true;
            txtRAM.Enabled = true;
            cmboNetwork.Enabled = true;
            txtTransfer.Enabled = true;
            cmboLocation.Cursor = Cursors.Hand;
            cmboLocation.Cursor = Cursors.Hand;
            txtUsername.Cursor = Cursors.Hand;
            txtPassword.Cursor = Cursors.Hand;
            txtKey.Cursor = Cursors.Hand;
            cmboOS.Cursor = Cursors.Hand;
            txtIP.Cursor = Cursors.Hand;
            txtProcessor.Cursor = Cursors.Hand;
            txtRAM.Cursor = Cursors.Hand;
            cmboNetwork.Cursor = Cursors.Hand;
            txtTransfer.Cursor = Cursors.Hand;
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand locationsdCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", connectionMySQL);
            locationsdCMD.Parameters.AddWithValue("@location", cmboLocation.Text);
            MySqlDataReader locationRDR = locationsdCMD.ExecuteReader(); // Execute MySQL reader query
            locationRDR.Read(); // Read data from the reader to become usable
            var location = Convert.ToString(locationRDR[0]);
            locationRDR.Close();

            MySqlCommand operatingSystemsCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
            operatingSystemsCMD.Parameters.AddWithValue("@os", cmboOS.Text);
            MySqlDataReader osRDR = operatingSystemsCMD.ExecuteReader(); // Execute MySQL reader query
            osRDR.Read(); // Read data from the reader to become usable
            var os = Convert.ToString(osRDR[0]);
            osRDR.Close();

            MySqlCommand networkCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", connectionMySQL);
            networkCMD.Parameters.AddWithValue("@port", cmboNetwork.Text);
            MySqlDataReader networkRDR = networkCMD.ExecuteReader(); // Execute MySQL reader query
            networkRDR.Read(); // Read data from the reader to become usable
            var network = Convert.ToString(networkRDR[0]);
            networkRDR.Close();

            if (txtPassword.Text == "")
            {
                var password = manageServersEdit.password;
            }
            else
            {
                var password = txtPassword.Text;
            }

            if (txtKey.Text == "")
            {
                var key = manageServersEdit.key;
            }
            else
            {
                var key = txtKey.Text;
            }

            MySqlCommand serverInfoUpdateCMD = new MySqlCommand("UPDATE serverInformation SET serverLocation = @serverLocation, serverHostname = @serverHostname, serverUsername = @serverUsername, serverPassword = @serverPassword, serverKey = @serverKey, serverOS = @serverOS, serverIP = @serverIP, serverProcessor = @serverProcessor, serverRAM = @serverRAM, serverPort = @serverPort, serverTransfer = @serverTransfer WHERE serverHostname = @Hostname", connectionMySQL);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverLocation", location);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverHostname", cmboHostNames.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverUsername", txtUsername.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverPassword", password);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverKey", key);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverOS", os);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverIP", txtIP.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverProcessor", txtProcessor.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverRAM", txtRAM.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverPort", network);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverTransfer", txtTransfer.Text);
            serverInfoUpdateCMD.ExecuteNonQuery();

            connectionMySQL.Close();

            Hide(); //Hide form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }
    }
}
