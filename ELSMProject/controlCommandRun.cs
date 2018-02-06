using System;
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
            InitializeComponent();
        }

        //  Declare Variables For Use  //
        private static int loopNum, activeLoop = 0;
        private static string os, ip, username, password, key, chkBoxName, checkBoxText, commandData, value;
        private string[] operatingSystemsID = new string[100], operatingSystems = new string[100], commandOSID = new string[100], commandText = new string[100];

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection runCommandConnection = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL Connection 
            runCommandConnection.Open(); // Open MySQL Connection 
            while (loopNum != activeLoop) // While lookNum is not equal to activeLoop
            {
                chkBoxName = "chkServer" + Convert.ToString(activeLoop); // Set variable to a combination of string and number
                var checkBox = this.Controls.Find(chkBoxName, true).FirstOrDefault() as CheckBox; // Convert variable to be able to target CheckBox element.
                checkBoxText = checkBox.Text; // Set variable to value
                if (checkBox.Checked == true) // If box is checked, execute code
                {
                    MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @hostname", runCommandConnection);
                    serverCMD.Parameters.AddWithValue("@hostname", checkBoxText); // Replace string in query with variable
                    MySqlDataReader serverInformationRDR = serverCMD.ExecuteReader(); // Execute MySQL reader query
                    serverInformationRDR.Read(); // Read data from the reader to become usable
                    ip = Convert.ToString(serverInformationRDR[8]); // Set variable to data from reader
                    username = Convert.ToString(serverInformationRDR[4]); // Set variable to data from reader
                    password = Convert.ToString(serverInformationRDR[5]); // Set variable to data from reader
                    key = Convert.ToString(serverInformationRDR[6]); // Set variable to data from reader
                    os = Convert.ToString(serverInformationRDR[7]); // Set variable to data from reader
                    serverInformationRDR.Close(); // Close Reader
                    MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverCommands WHERE serverOS = @os AND commandName = @CommandName", runCommandConnection);
                    osCMD.Parameters.AddWithValue("@os", os); // Replace string in query with variable
                    osCMD.Parameters.AddWithValue("@CommandName", cmboCommands.Text); // Replace string in query with variable
                    MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query
                    osRDR.Read(); // Read data from the reader to become usable
                    commandData = Convert.ToString(osRDR[4]); // Set variable to data from reader
                    new Thread(() => // Create new thread to run in background
                    {
                        Thread.CurrentThread.IsBackground = true; // Run in background
                        try // Try to connect to node using connection details and to run a command stored in a variable
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
                            System.Windows.Forms.MessageBox.Show("Error"); // If error print out error
                        }
                    }).Start();
                    osRDR.Close(); // Close reader
                }
                activeLoop += 1; // Add the value of 1 to the variable
            }
            runCommandConnection.Close(); // Close MySQL connection
            Hide(); //Hide form
        }

        private void serverControlRunCommand_Load(object sender, EventArgs e)
        {
            MySqlConnection commandLoadConnection = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL Connection 
            commandLoadConnection.Open(); // Open MySQL Connection 

            MySqlCommand commandName = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", commandLoadConnection);
            commandName.Parameters.AddWithValue("@company", loginMenu.CompanyID); // Replace string in query with variable
            MySqlDataReader commandNameRDR = commandName.ExecuteReader(); // Execute MySQL reader query 
            while (commandNameRDR.Read()) // While rows in reader
            {
                cmboCommands.Items.Add(commandNameRDR.GetString("commandName"));
            }
            commandNameRDR.Close(); // Close reader
            
            MySqlCommand osIDCommand = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @companyID ORDER BY serverID ASC", commandLoadConnection);
            osIDCommand.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); // Replace string in query with variable
            MySqlDataReader operatingSystemRDR = osIDCommand.ExecuteReader(); // Execute MySQL reader query 
            loopNum = 0; // Set variable to 0
            while (operatingSystemRDR.Read()) // While rows in reader
            {
                operatingSystemsID[loopNum] = Convert.ToString(operatingSystemRDR[3]); // Set array value to data from reader
                loopNum += 1; // Add the value of 1 to the variable
            }
            operatingSystemRDR.Close(); // Close reader

            MySqlCommand cmdIDCommand = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @company ORDER BY serverID", commandLoadConnection);
            cmdIDCommand.Parameters.AddWithValue("@company", loginMenu.CompanyID);  // Replace string in query with variable
            MySqlDataReader commandIDRDR = cmdIDCommand.ExecuteReader(); // Execute MySQL reader query 
            loopNum = 0; // Set variable to 0
            while (commandIDRDR.Read()) // While rows in reader
            {
                commandOSID[loopNum] = Convert.ToString(commandIDRDR[2]); // Set array value to data from reader
                loopNum += 1; // Add the value of 1 to the variable
            }
            commandIDRDR.Close(); // Close reader

            while (operatingSystemsID[loopNum] != null) // While values in array
            {
                value = Convert.ToString(operatingSystemsID[loopNum]); // Set variable to array value
                CheckBox box = new CheckBox(); // Create checkbox
                box.Name = "chkServer" + Convert.ToString(loopNum); // Set checkbox name
                box.Text = value; // Set display text to variable
                box.AutoSize = true; // Enable autosoze
                box.Location = new Point(10, (loopNum + 1) * 20); // Set location of checkbox
                pnlConfiguration.Controls.Add(box); // Add checkbox to screen
                loopNum += 1; // Add the value of 1 to the variable
            }
            this.Height += (loopNum * 20) + 40; // Set window height
            pnlConfiguration.Height += (loopNum * 20) + 40; // Set panel height
            loopNum += 1; // Add the value of 1 to the variable
            btnRunCommand.Top += loopNum * 23; // Set button position
            btnCancel.Top += loopNum * 23; // Set button position
        }
    }
}
