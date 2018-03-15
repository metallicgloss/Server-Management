using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class serverEdit : Form
    {
        public serverEdit()
        {
            InitializeComponent();
        }

        public static string password, key;


        private void manageServersEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();
            MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation", connectionMySQL);
            MySqlDataReader serverRDR = serverCMD.ExecuteReader();      
            while (serverRDR.Read())     
            {
                cmboHostNames.Items.Add(serverRDR.GetString("serverHostname"));
            }
            serverRDR.Close();
            connectionMySQL.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();

            MySqlCommand serverInformationCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @Hostname", connectionMySQL);
            serverInformationCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text); 
            MySqlDataReader serverInformationRDR = serverInformationCMD.ExecuteReader();      
            serverInformationRDR.Read();         
            txtUsername.Text = Convert.ToString(serverInformationRDR[4]);
            txtIP.Text = Convert.ToString(serverInformationRDR[7]);
            txtProcessor.Text = Convert.ToString(serverInformationRDR[8]);
            txtRAM.Text = Convert.ToString(serverInformationRDR[9]);
            txtTransfer.Text = Convert.ToString(serverInformationRDR[11]);
            serverEdit.password = Convert.ToString(serverInformationRDR[5]);
            var serverLocation = Convert.ToString(serverInformationRDR[2]);
            var serverOS = Convert.ToString(serverInformationRDR[6]);
            var serverPort = Convert.ToString(serverInformationRDR[10]);
            txtPassword.Text = "";
            serverInformationRDR.Close();

            MySqlCommand serverLocationCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE companyID = @companyID", connectionMySQL);
            serverLocationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader serverLocationRDR = serverLocationCMD.ExecuteReader();      
            while (serverLocationRDR.Read())     
            {
                cmboLocation.Items.Add(serverLocationRDR.GetString("locationName"));
            }
            serverLocationRDR.Close();

            MySqlCommand serverOSCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
            MySqlDataReader serverOSRDR = serverOSCMD.ExecuteReader();      
            while (serverOSRDR.Read())     
            {
                cmboOS.Items.Add(serverOSRDR.GetString("operatingSystemsName"));
            }
            serverOSRDR.Close();

            MySqlCommand serverNetworkPortCMD = new MySqlCommand("SELECT * FROM serverPort", connectionMySQL);
            MySqlDataReader serverNetworkPortRDR = serverNetworkPortCMD.ExecuteReader();      
            while (serverNetworkPortRDR.Read())     
            {
                cmboNetwork.Items.Add(serverNetworkPortRDR.GetString("portSpeed"));
            }
            serverNetworkPortRDR.Close();
            
            MySqlCommand serverLocationDisplayCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationID = @locationID", connectionMySQL);
            serverLocationDisplayCMD.Parameters.AddWithValue("@locationID", serverLocation); 
            MySqlDataReader serverLocationDisplayRDR = serverLocationDisplayCMD.ExecuteReader();      
            serverLocationDisplayRDR.Read();         
            cmboLocation.Text = Convert.ToString(serverLocationDisplayRDR.GetString("locationName"));
            serverLocationDisplayRDR.Close();
            
            MySqlCommand serverOSDisplayCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsID = @operatingSystemsID", connectionMySQL);
            serverOSDisplayCMD.Parameters.AddWithValue("@operatingSystemsID", serverOS); 
            MySqlDataReader serverOSDisplayRDR = serverOSDisplayCMD.ExecuteReader();      
            serverOSDisplayRDR.Read();         
            cmboOS.Text = Convert.ToString(serverOSDisplayRDR[1]);
            serverOSDisplayRDR.Close();
            
            MySqlCommand serverNetworkPortDisplayCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portID = @portID", connectionMySQL);
            serverNetworkPortDisplayCMD.Parameters.AddWithValue("@portID", serverPort); 
            MySqlDataReader serverNetworkPortDisplayRDR = serverNetworkPortDisplayCMD.ExecuteReader();      
            serverNetworkPortDisplayRDR.Read();         
            cmboNetwork.Text = Convert.ToString(serverNetworkPortDisplayRDR[1]);
            serverNetworkPortDisplayRDR.Close();

            connectionMySQL.Close();
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            if (cmboHostNames.Text != "")
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

            MySqlCommand locationsdCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", connectionMySQL);
            locationsdCMD.Parameters.AddWithValue("@location", cmboLocation.Text);
            MySqlDataReader locationRDR = locationsdCMD.ExecuteReader();     
            locationRDR.Read();         
            var location = Convert.ToString(locationRDR[0]);
            locationRDR.Close();

            MySqlCommand operatingSystemsCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
            operatingSystemsCMD.Parameters.AddWithValue("@os", cmboOS.Text);
            MySqlDataReader osRDR = operatingSystemsCMD.ExecuteReader();     
            osRDR.Read();         
            var os = Convert.ToString(osRDR[0]);
            osRDR.Close();

            MySqlCommand networkCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", connectionMySQL);
            networkCMD.Parameters.AddWithValue("@port", cmboNetwork.Text);
            MySqlDataReader networkRDR = networkCMD.ExecuteReader();     
            networkRDR.Read();         
            var network = Convert.ToString(networkRDR[0]);
            networkRDR.Close();

            if (txtPassword.Text == "")
            {
                var password = serverEdit.password;
            }
            else
            {
                var password = txtPassword.Text;
            }

            MySqlCommand serverInfoUpdateCMD = new MySqlCommand("UPDATE serverInformation SET serverLocation = @serverLocation, serverHostname = @serverHostname, serverUsername = @serverUsername, serverPassword = @serverPassword, serverOS = @serverOS, serverIP = @serverIP, serverProcessor = @serverProcessor, serverRAM = @serverRAM, serverPort = @serverPort, serverTransfer = @serverTransfer WHERE serverHostname = @Hostname", connectionMySQL);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverLocation", location);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverHostname", cmboHostNames.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@Hostname", cmboHostNames.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverUsername", txtUsername.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverPassword", password);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverOS", os);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverIP", txtIP.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverProcessor", txtProcessor.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverRAM", txtRAM.Text);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverPort", network);
            serverInfoUpdateCMD.Parameters.AddWithValue("@serverTransfer", txtTransfer.Text);
            serverInfoUpdateCMD.ExecuteNonQuery();

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
                System.Windows.Forms.MessageBox.Show("Your hostname is blank.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();  
        }
    }
}
