﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace ELSM_Project
{
    public partial class controlCommandRun : Form
    {
        public controlCommandRun()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private static int loopNum, activeLoop = 0;
        private static string os, ip, username, password, chkBoxName, checkBoxText, commandData, value;
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
				//Compile a string with the loopnum and then target the checbox.
                chkBoxName = "chkServer" + Convert.ToString(activeLoop);
                var checkBox = this.Controls.Find(chkBoxName, true).FirstOrDefault() as CheckBox;
                checkBoxText = checkBox.Text;
				//If checked execute.
                if (checkBox.Checked == true)
                {
					//Run SQL to get the hostname of the server that the hostname matches.
                    MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @hostname", runCommandConnection);
                    serverCMD.Parameters.AddWithValue("@hostname", checkBoxText);
                    MySqlDataReader serverInformationRDR = serverCMD.ExecuteReader();
                    serverInformationRDR.Read();
					//Store output from SQL as variables.
                    ip = Convert.ToString(serverInformationRDR[7]);
                    username = Convert.ToString(serverInformationRDR[4]);
                    password = Convert.ToString(serverInformationRDR[5]);
                    os = Convert.ToString(serverInformationRDR[6]);
                    serverInformationRDR.Close();
					//SQL Select the command where the commandname matches that selected and the OS matches - to ensure that the OS has been configured.
                    MySqlCommand serverCommandCMD = new MySqlCommand("SELECT * FROM serverCommands WHERE serverOS = @os AND commandName = @CommandName", runCommandConnection);
                    serverCommandCMD.Parameters.AddWithValue("@os", os);
                    serverCommandCMD.Parameters.AddWithValue("@CommandName", cmboCommands.Text);
                    MySqlDataReader serverCommandRDR = serverCommandCMD.ExecuteReader();
                    serverCommandRDR.Read();
                    commandData = Convert.ToString(serverCommandRDR[4]);
					//Create new thread to run in the background. Attempt to SSH into the node with the hostname selected in the loop, execute the command that matches the OS then disconnect.
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        try
                        {
                            using (var client = new SshClient(ip, username, password))
                            {
                                client.Connect();
                                client.RunCommand(Convert.ToString(commandData));
                                client.Disconnect();
                            }
                        }
                        catch (Exception)
                        {
                            System.Windows.Forms.MessageBox.Show("Error");
                        }
                    }).Start();
                    serverCommandRDR.Close();
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
			//Connect to MySQL, execute SQL and set output as items of cmboCommands.
            MySqlCommand commandName = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", commandLoadConnection);
            commandName.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader commandNameRDR = commandName.ExecuteReader();
            while (commandNameRDR.Read())
            {
                cmboCommands.Items.Add(commandNameRDR.GetString("commandName"));
            }
            commandNameRDR.Close();
			//Run SQL statement to get the names of the operating systems used
            MySqlCommand osIDCommand = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @companyID ORDER BY serverID ASC", commandLoadConnection);
            osIDCommand.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader operatingSystemRDR = osIDCommand.ExecuteReader();
            loopNum = 0;
            while (operatingSystemRDR.Read())
            {
                operatingSystemsID[loopNum] = Convert.ToString(operatingSystemRDR[3]);
                loopNum += 1;
            }
            operatingSystemRDR.Close();
			//Run SQL statement to get the IDs of the operating systems used.
            MySqlCommand cmdIDCommand = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @company ORDER BY serverID", commandLoadConnection);
            cmdIDCommand.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader commandIDRDR = cmdIDCommand.ExecuteReader();
            loopNum = 0;
            while (commandIDRDR.Read())
            {
                commandOSID[loopNum] = Convert.ToString(commandIDRDR[2]);
                loopNum += 1;
            }
            commandIDRDR.Close();
            //While values, dynamically create checkboxes for servers.
            loopNum = 0;
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
            loopNum += 1;
            btnRunCommand.Top += loopNum * 23;
            btnCancel.Top += loopNum * 23;
        }
    }
}
