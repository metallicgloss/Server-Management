using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class backupNodeEdit : Form
    {
        public backupNodeEdit()
        {
            InitializeComponent();
        }

        public static string password, key;


        private void managebackupNodesEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand backupNodeCMD = new MySqlCommand("SELECT * FROM backupNodeInformation", connectionMySQL);
            MySqlDataReader backupNodeRDR = backupNodeCMD.ExecuteReader(); // Execute MySQL reader query 
            while (backupNodeRDR.Read()) // While rows in reader
            {
                cmboHostNames.Items.Add(backupNodeRDR.GetString("backupNodeHostname"));
            }
            backupNodeRDR.Close();
            connectionMySQL.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand backupNodeInformationCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeHostname = @Hostname", connectionMySQL);
            backupNodeInformationCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text);
            MySqlDataReader backupNodeInformationRDR = backupNodeInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            backupNodeInformationRDR.Read(); // Read data from the reader to become usable
            txtUsername.Text = Convert.ToString(backupNodeInformationRDR[4]);
            txtIP.Text = Convert.ToString(backupNodeInformationRDR[7]);
            txtProcessor.Text = Convert.ToString(backupNodeInformationRDR[8]);
            txtRAM.Text = Convert.ToString(backupNodeInformationRDR[9]);
            txtTransfer.Text = Convert.ToString(backupNodeInformationRDR[11]);
            backupNodeEdit.password = Convert.ToString(backupNodeInformationRDR[5]);
            var backupNodeLocation = Convert.ToString(backupNodeInformationRDR[2]);
            var backupNodeOS = Convert.ToString(backupNodeInformationRDR[6]);
            var backupNodePort = Convert.ToString(backupNodeInformationRDR[10]);
            txtBackupPath.Text = Convert.ToString(backupNodeInformationRDR[12]);
            txtPassword.Text = "";
            backupNodeInformationRDR.Close();

            MySqlCommand backupNodeLocationCMD = new MySqlCommand("SELECT * FROM backupNodeLocations WHERE companyID = @companyID", connectionMySQL);
            backupNodeLocationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader backupNodeLocationRDR = backupNodeLocationCMD.ExecuteReader(); // Execute MySQL reader query 
            while (backupNodeLocationRDR.Read()) // While rows in reader
            {
                cmboLocation.Items.Add(backupNodeLocationRDR.GetString("locationName"));
            }
            backupNodeLocationRDR.Close();

            MySqlCommand backupNodeOSCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
            MySqlDataReader backupNodeOSRDR = backupNodeOSCMD.ExecuteReader(); // Execute MySQL reader query 
            while (backupNodeOSRDR.Read()) // While rows in reader
            {
                cmboOS.Items.Add(backupNodeOSRDR.GetString("operatingSystemsName"));
            }
            backupNodeOSRDR.Close();

            MySqlCommand backupNodeNetworkPortCMD = new MySqlCommand("SELECT * FROM backupNodePort", connectionMySQL);
            MySqlDataReader backupNodeNetworkPortRDR = backupNodeNetworkPortCMD.ExecuteReader(); // Execute MySQL reader query 
            while (backupNodeNetworkPortRDR.Read()) // While rows in reader
            {
                cmboNetwork.Items.Add(backupNodeNetworkPortRDR.GetString("portSpeed"));
            }
            backupNodeNetworkPortRDR.Close();

            MySqlCommand backupNodeLocationDisplayCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationID = @locationID", connectionMySQL);
            backupNodeLocationDisplayCMD.Parameters.AddWithValue("@locationID", backupNodeLocation);
            MySqlDataReader backupNodeLocationDisplayRDR = backupNodeLocationDisplayCMD.ExecuteReader(); // Execute MySQL reader query 
            backupNodeLocationDisplayRDR.Read(); // Read data from the reader to become usable
            cmboLocation.Text = Convert.ToString(backupNodeLocationDisplayRDR.GetString("locationName"));
            backupNodeLocationDisplayRDR.Close();

            MySqlCommand backupNodeOSDisplayCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsID = @operatingSystemsID", connectionMySQL);
            backupNodeOSDisplayCMD.Parameters.AddWithValue("@operatingSystemsID", backupNodeOS);
            MySqlDataReader backupNodeOSDisplayRDR = backupNodeOSDisplayCMD.ExecuteReader(); // Execute MySQL reader query 
            backupNodeOSDisplayRDR.Read(); // Read data from the reader to become usable
            cmboOS.Text = Convert.ToString(backupNodeOSDisplayRDR[1]);
            backupNodeOSDisplayRDR.Close();

            MySqlCommand backupNodeNetworkPortDisplayCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portID = @portID", connectionMySQL);
            backupNodeNetworkPortDisplayCMD.Parameters.AddWithValue("@portID", backupNodePort);
            MySqlDataReader backupNodeNetworkPortDisplayRDR = backupNodeNetworkPortDisplayCMD.ExecuteReader(); // Execute MySQL reader query 
            backupNodeNetworkPortDisplayRDR.Read(); // Read data from the reader to become usable
            cmboNetwork.Text = Convert.ToString(backupNodeNetworkPortDisplayRDR[1]);
            backupNodeNetworkPortDisplayRDR.Close();

            connectionMySQL.Close();

            cmboLocation.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
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
            cmboOS.Cursor = Cursors.Hand;
            txtIP.Cursor = Cursors.Hand;
            txtProcessor.Cursor = Cursors.Hand;
            txtRAM.Cursor = Cursors.Hand;
            cmboNetwork.Cursor = Cursors.Hand;
            txtTransfer.Cursor = Cursors.Hand;
        }

        private void btnNewbackupNode_Click(object sender, EventArgs e)
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
                var password = backupNodeEdit.password;
            }
            else
            {
                var password = txtPassword.Text;
            }

            MySqlCommand backupNodeInfoUpdateCMD = new MySqlCommand("UPDATE backupNodeInformation SET backupNodeLocation = @backupNodeLocation, backupNodeHostname = @backupNodeHostname, backupNodeUsername = @backupNodeUsername, backupNodePassword = @backupNodePassword, backupNodeOS = @backupNodeOS, backupNodeIP = @backupNodeIP, backupNodeProcessor = @backupNodeProcessor, backupNodeRAM = @backupNodeRAM, backupNodePort = @backupNodePort, backupNodeTransfer = @backupNodeTransfer, backupNodeBackupPath = @backupNodePath WHERE backupNodeHostname = @Hostname", connectionMySQL);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeLocation", location);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeHostname", cmboHostNames.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeUsername", txtUsername.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodePassword", password);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeOS", os);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeIP", txtIP.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeProcessor", txtProcessor.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeRAM", txtRAM.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodePort", network);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodeTransfer", txtTransfer.Text);
            backupNodeInfoUpdateCMD.Parameters.AddWithValue("@backupNodePath", txtBackupPath.Text);
            backupNodeInfoUpdateCMD.ExecuteNonQuery();

            connectionMySQL.Close();

            Hide(); //Hide form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }
    }
}
