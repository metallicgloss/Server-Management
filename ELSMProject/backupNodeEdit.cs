using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class backupNodeEdit : Form
    {
        public backupNodeEdit()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        public static string password, key;

        private void managebackupNodesEdit_Load(object sender, EventArgs e)
        {
			//Connect to MySQL, execute SQL and set output as items ofcmboHostNamescmboUserID.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand backupNodeCMD = new MySqlCommand("SELECT * FROM backupNodeInformation", connectionMySQL);
            MySqlDataReader backupNodeRDR = backupNodeCMD.ExecuteReader();
            while (backupNodeRDR.Read())
            {
                cmboHostNames.Items.Add(backupNodeRDR.GetString("backupNodeHostname"));
            }
            backupNodeRDR.Close();
            connectionMySQL.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
			//Execute SQL and set output as different variables that correspond to the value for use later in the program.
            MySqlCommand backupNodeInformationCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeHostname = @Hostname", connectionMySQL);
            backupNodeInformationCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text);
            MySqlDataReader backupNodeInformationRDR = backupNodeInformationCMD.ExecuteReader();
            backupNodeInformationRDR.Read();
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
			//Execute SQL and set output as items of cmboLocation.
            MySqlCommand backupNodeLocationCMD = new MySqlCommand("SELECT * FROM backupNodeLocations WHERE companyID = @companyID", connectionMySQL);
            backupNodeLocationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader backupNodeLocationRDR = backupNodeLocationCMD.ExecuteReader();
            while (backupNodeLocationRDR.Read())
            {
                cmboLocation.Items.Add(backupNodeLocationRDR.GetString("locationName"));
            }
            backupNodeLocationRDR.Close();
			//Execute SQL and set output as items of cmboOS.
            MySqlCommand backupNodeOSCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
            MySqlDataReader backupNodeOSRDR = backupNodeOSCMD.ExecuteReader();
            while (backupNodeOSRDR.Read())
            {
                cmboOS.Items.Add(backupNodeOSRDR.GetString("operatingSystemsName"));
            }
            backupNodeOSRDR.Close();
			//Execute SQL and set output as items of cmboNetwork.
            MySqlCommand backupNodeNetworkPortCMD = new MySqlCommand("SELECT * FROM backupNodePort", connectionMySQL);
            MySqlDataReader backupNodeNetworkPortRDR = backupNodeNetworkPortCMD.ExecuteReader();
            while (backupNodeNetworkPortRDR.Read())
            {
                cmboNetwork.Items.Add(backupNodeNetworkPortRDR.GetString("portSpeed"));
            }
            backupNodeNetworkPortRDR.Close();
			//Execute SQL and set output as active text of cmboLocation.
            MySqlCommand backupNodeLocationDisplayCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationID = @locationID", connectionMySQL);
            backupNodeLocationDisplayCMD.Parameters.AddWithValue("@locationID", backupNodeLocation);
            MySqlDataReader backupNodeLocationDisplayRDR = backupNodeLocationDisplayCMD.ExecuteReader();
            backupNodeLocationDisplayRDR.Read();
            cmboLocation.Text = Convert.ToString(backupNodeLocationDisplayRDR.GetString("locationName"));
            backupNodeLocationDisplayRDR.Close();
			//Execute SQL and set output as active text of cmboOS.
            MySqlCommand backupNodeOSDisplayCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsID = @operatingSystemsID", connectionMySQL);
            backupNodeOSDisplayCMD.Parameters.AddWithValue("@operatingSystemsID", backupNodeOS);
            MySqlDataReader backupNodeOSDisplayRDR = backupNodeOSDisplayCMD.ExecuteReader();
            backupNodeOSDisplayRDR.Read();
            cmboOS.Text = Convert.ToString(backupNodeOSDisplayRDR[1]);
            backupNodeOSDisplayRDR.Close();
			//Execute SQL and set output as active text of cmboNetwork.
            MySqlCommand backupNodeNetworkPortDisplayCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portID = @portID", connectionMySQL);
            backupNodeNetworkPortDisplayCMD.Parameters.AddWithValue("@portID", backupNodePort);
            MySqlDataReader backupNodeNetworkPortDisplayRDR = backupNodeNetworkPortDisplayCMD.ExecuteReader();
            backupNodeNetworkPortDisplayRDR.Read();
            cmboNetwork.Text = Convert.ToString(backupNodeNetworkPortDisplayRDR[1]);
            backupNodeNetworkPortDisplayRDR.Close();

            connectionMySQL.Close();
        }

        private void btnNewbackupNode_Click(object sender, EventArgs e)
        {
			//If fields entered is blank, output message box to user informing them of no data.
            if (cmboHostNames.Text != "")
            {
                if (txtBackupPath.Text != "")
                {
                    if (txtIP.Text != "")
                    {
                        if (txtProcessor.Text != "")
                        {
                            if (txtRAM.Text != "")
                            {
                                if (txtTransfer.Text != "")
                                {
                                    if (txtUsername.Text != "")
                                    {
                                        if (cmboLocation.Text != "")
                                        {
                                            if (cmboNetwork.Text != "")
                                            {
                                                if (cmboOS.Text != "")
                                                {
                                                    MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
                                                    connectionMySQL.Open();
													//Execute SQL and set output as variable "location".
                                                    MySqlCommand locationsdCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", connectionMySQL);
                                                    locationsdCMD.Parameters.AddWithValue("@location", cmboLocation.Text);
                                                    MySqlDataReader locationRDR = locationsdCMD.ExecuteReader();
                                                    locationRDR.Read();
                                                    var location = Convert.ToString(locationRDR[0]);
                                                    locationRDR.Close();
													//Execute SQL and set output as variable "os".
                                                    MySqlCommand operatingSystemsCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
                                                    operatingSystemsCMD.Parameters.AddWithValue("@os", cmboOS.Text);
                                                    MySqlDataReader osRDR = operatingSystemsCMD.ExecuteReader();
                                                    osRDR.Read();
                                                    var os = Convert.ToString(osRDR[0]);
                                                    osRDR.Close();
													//Execute SQL and set output as variable "network".
                                                    MySqlCommand networkCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", connectionMySQL);
                                                    networkCMD.Parameters.AddWithValue("@port", cmboNetwork.Text);
                                                    MySqlDataReader networkRDR = networkCMD.ExecuteReader();
                                                    networkRDR.Read();
                                                    var network = Convert.ToString(networkRDR[0]);
                                                    networkRDR.Close();
													//If password is blank, use password already set one. Otherwise, use the password entered.
                                                    if (txtPassword.Text != "")
                                                    {
                                                        var password = txtPassword.Text;
                                                    }
													//Execute SQl to update information about a backup node in table backupNodeInformation.
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
                                                    Hide();
                                                }
                                                else
                                                {
                                                    System.Windows.Forms.MessageBox.Show("You haven't selected sn operating system. Please do so.");
                                                }
                                            }
                                            else
                                            {
                                                System.Windows.Forms.MessageBox.Show("You haven't selected a network port. Please do so.");
                                            }
                                        }
                                        else
                                        {
                                            System.Windows.Forms.MessageBox.Show("You haven't selected a location. Please do so.");
                                        }
                                    }
                                    else
                                    {
                                        System.Windows.Forms.MessageBox.Show("The user entered is blank. Please enter data.");
                                    }
                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show("The transfer amount entered is blank. Please enter data.");
                                }
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("The RAM amount entered is blank. Please enter data.");
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("The processor entered is blank. Please enter data.");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The IP entered is blank. Please enter data.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The backup path entered is blank. Please enter data.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Your hostname is blank.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }
    }
}