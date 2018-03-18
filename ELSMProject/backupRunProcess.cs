using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace ELSM_Project
{
    public partial class backupRunProcess : Form
    {
        public backupRunProcess()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private static int loopNum, activeLoop = 0;
        private static bool proceed;
        private static string os, ip, username, password, chkBoxName, checkBoxText, commandData, value, location, backupIP, backupUsername, backupPassword, backupPath;
        private string[] operatingSystemsID = new string[100], operatingSystems = new string[100], commandOSID = new string[100], commandText = new string[100];

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection runCommandConnection = new MySqlConnection(loginMenu.ConnectionString);
            runCommandConnection.Open();
            while (loopNum != activeLoop)
            {
				//Create string to combine the ID and the name to be able to target the checkbox.
                chkBoxName = "chkServer" + Convert.ToString(activeLoop);
                var checkBox = this.Controls.Find(chkBoxName, true).FirstOrDefault() as CheckBox;
                checkBoxText = checkBox.Text;
				//If Checkbox is ticked, execute code.
                if (checkBox.Checked == true)
                {
					//Run SQL to get data about servers stored in the table serverInformation and save output as variables to be used.
                    MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @hostname", runCommandConnection);
                    serverCMD.Parameters.AddWithValue("@hostname", checkBoxText);
                    MySqlDataReader serverInformationRDR = serverCMD.ExecuteReader();
                    serverInformationRDR.Read();
                    ip = Convert.ToString(serverInformationRDR[7]);
                    username = Convert.ToString(serverInformationRDR[4]);
                    password = Convert.ToString(serverInformationRDR[5]);
                    os = Convert.ToString(serverInformationRDR[6]);
                    location = Convert.ToString(serverInformationRDR[2]);
                    serverInformationRDR.Close();
					//Try to get the login details to a backup node in the same location as the server selected. Else, try to find a backup node available. If nothing available, output error.
                    try
                    {
                        MySqlCommand osCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeCompany = @backupNodeCompany AND backupNodeLocation = @backupNodeLocation", runCommandConnection);
                        osCMD.Parameters.AddWithValue("@backupNodeCompany", loginMenu.CompanyID);
                        osCMD.Parameters.AddWithValue("@backupNodeLocation", location);
                        MySqlDataReader osRDR = osCMD.ExecuteReader();
                        osRDR.Read();
                        backupIP = Convert.ToString(osRDR[7]);
                        backupUsername = Convert.ToString(osRDR[4]);
                        backupPassword = Convert.ToString(osRDR[5]);
                        backupPath = Convert.ToString(osRDR[12]);
                        proceed = true;
                    }
                    catch
                    {
                        try
                        {
                            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM backupNodeInformation WHERE backupNodeCompany = @backupNodeCompany", runCommandConnection);
                            osCMD.Parameters.AddWithValue("@backupNodeCompany", loginMenu.CompanyID);
                            MySqlDataReader osRDR = osCMD.ExecuteReader();
                            osRDR.Read();
                            backupIP = Convert.ToString(osRDR[7]);
                            backupUsername = Convert.ToString(osRDR[4]);
                            backupPassword = Convert.ToString(osRDR[5]);
                            backupPath = Convert.ToString(osRDR[12]);
                            proceed = true;
                        }
                        catch
                        {
                            System.Windows.Forms.MessageBox.Show("Please configure a backup node.");
                        }
                    }
					//If a backup node has been found, create a background thread to execute an rsync command to backup a node to a the backup server.
                    if (proceed == true)
                    {
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            try
                            {
                                string SSHCommand = "sshpass -p '" + backupPassword + "' rsync -az / " + backupUsername + "@" + backupIP + ":" + backupPath + "/" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
                                using (var client = new SshClient(ip, username, password))
                                {
                                    client.Connect();
                                    client.RunCommand(Convert.ToString(SSHCommand));
                                    client.Disconnect();
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
                            }
                        }).Start();
                    }
                }
                activeLoop += 1;
            }
            runCommandConnection.Close();
            Hide();
        }

        private void serverControlRunCommand_Load(object sender, EventArgs e)
        {
            MySqlConnection commandLoadConnection = new MySqlConnection(loginMenu.ConnectionString);
            commandLoadConnection.Open();
			//Execute SQL command to get the IDs of the operating systems used.
            MySqlCommand osIDCommand = new MySqlCommand("SELECT * FROM serverInformation", commandLoadConnection);
            osIDCommand.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader operatingSystemRDR = osIDCommand.ExecuteReader();
            loopNum = 0;
            while (operatingSystemRDR.Read())
            {
                operatingSystemsID[loopNum] = Convert.ToString(operatingSystemRDR[3]);
                loopNum += 1;
            }
            operatingSystemRDR.Close();
            loopNum = 0;
			//Create a checkbox for each server.
            while (operatingSystemsID[loopNum] != null)
            {
                value = Convert.ToString(operatingSystemsID[loopNum]);
                CheckBox box = new CheckBox();
                box.Name = "chkServer" + Convert.ToString(loopNum);
                box.Text = value;
                box.AutoSize = true;
                box.Location = new Point(10, (loopNum + 1) * 20);
                pnlConfiguration.Controls.Add(box);
                loopNum += 1;
            }
            this.Height += (loopNum * 20) + 40;
            pnlConfiguration.Height += (loopNum * 20) + 40;
            btnRunBackup.Top += loopNum * 23;
            btnCancel.Top += loopNum * 23;
        }
    }
}
