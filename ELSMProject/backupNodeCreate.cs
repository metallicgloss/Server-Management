using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class backupNodeCreate : Form
    {
        public backupNodeCreate()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void manageServersCreate_Load(object sender, EventArgs e)
        {
			//Connect to MySQL and execute an SQL command. Set output as items of cmboLocation.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand locationsCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE companyID = @companyID", connectionMySQL);
            locationsCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader locationsRDR = locationsCMD.ExecuteReader();
            while (locationsRDR.Read())
            {
                cmboLocation.Items.Add(locationsRDR.GetString("locationName"));
            }
            locationsRDR.Close();
			//Connect to MySQL and execute an SQL command. Set output as items of cmboOS.
            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
            MySqlDataReader osRDR = osCMD.ExecuteReader();
            while (osRDR.Read())
            {
                cmboOS.Items.Add(osRDR.GetString("operatingSystemsName"));
            }
            osRDR.Close();
			//Connect to MySQL and execute an SQL command. Set output as items of cmboNetwork.
            MySqlCommand networkPortCMD = new MySqlCommand("SELECT * FROM serverPort", connectionMySQL);
            MySqlDataReader networkPortRDR = networkPortCMD.ExecuteReader();
            while (networkPortRDR.Read())
            {
                cmboNetwork.Items.Add(networkPortRDR.GetString("portSpeed"));
            }
            networkPortRDR.Close();
            connectionMySQL.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
			//If field on form is blank, generate a message box informing the user of the blank field.
            if (txtHostname.Text != "")
            {
                if (txtBackupPath.Text != "")
                {
                    if (txtIP.Text != "")
                    {
                        if (txtPassword.Text != "")
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
														//Connect to MySQL, execute SQL and set output field to variable.
                                                        MySqlCommand locationCMD = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", connectionMySQL);
                                                        locationCMD.Parameters.AddWithValue("@location", cmboLocation.Text);
                                                        MySqlDataReader locationRDR = locationCMD.ExecuteReader();
                                                        locationRDR.Read();
                                                        var location = Convert.ToString(locationRDR[0]);
                                                        locationRDR.Close();
														//Connect to MySQL, execute SQL and set output field to variable.
                                                        MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
                                                        osCMD.Parameters.AddWithValue("@os", cmboOS.Text);
                                                        MySqlDataReader osRDR = osCMD.ExecuteReader();
                                                        osRDR.Read();
                                                        var os = Convert.ToString(osRDR[0]);
                                                        osRDR.Close();
														//Connect to MySQL, execute SQL and set output field to variable.
                                                        MySqlCommand networkCMD = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", connectionMySQL);
                                                        networkCMD.Parameters.AddWithValue("@port", cmboNetwork.Text);
                                                        MySqlDataReader networkRDR = networkCMD.ExecuteReader();
                                                        networkRDR.Read();
                                                        var network = Convert.ToString(networkRDR[0]);
                                                        networkRDR.Close();
														//Connect to MySQL, execute SQL and insert row into backupNodeInformation with values inserted from the form to create a new backup node.
                                                        MySqlCommand serverCMD = new MySqlCommand("INSERT INTO backupNodeInformation (backupNodeCompany, backupNodeLocation, backupNodeHostname, backupNodeUsername, backupNodePassword, backupNodeOS, backupNodeIP, backupNodeProcessor, backupNodeRAM, backupNodePort, backupNodeTransfer, backupNodeBackupPath) VALUES (@serverCompany, @serverLocation, @serverHostname, @serverUsername, @serverPassword, @serverOS, @serverIP, @serverProcessor, @serverRAM, @serverPort, @serverTransfer, @backupPath)", connectionMySQL);
                                                        serverCMD.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
                                                        serverCMD.Parameters.AddWithValue("@serverLocation", location);
                                                        serverCMD.Parameters.AddWithValue("@serverHostname", txtHostname.Text);
                                                        serverCMD.Parameters.AddWithValue("@serverUsername", txtUsername.Text);
                                                        serverCMD.Parameters.AddWithValue("@serverPassword", txtPassword.Text);
                                                        serverCMD.Parameters.AddWithValue("@serverOS", os);
                                                        serverCMD.Parameters.AddWithValue("@serverIP", txtIP.Text);
                                                        serverCMD.Parameters.AddWithValue("@serverProcessor", txtProcessor.Text);
                                                        serverCMD.Parameters.AddWithValue("@serverRAM", txtRAM.Text);
                                                        serverCMD.Parameters.AddWithValue("@serverPort", network);
                                                        serverCMD.Parameters.AddWithValue("@serverTransfer", txtTransfer.Text);
                                                        serverCMD.Parameters.AddWithValue("@backupPath", txtBackupPath.Text);
                                                        serverCMD.ExecuteNonQuery();
                                                        connectionMySQL.Close();
                                                        System.Windows.Forms.MessageBox.Show("Created Successfully.");
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
                            System.Windows.Forms.MessageBox.Show("The password entered is blank. Please enter data.");
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
    }
}