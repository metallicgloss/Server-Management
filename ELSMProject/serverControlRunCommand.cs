using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace ELSM_Project
{
    public partial class serverControlRunCommand : Form
    {
        public serverControlRunCommand()
        {
            InitializeComponent();
        }
        
        private static int loopNum, activeLoop = 0;
        private static bool finished;
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
            while (loopNum != activeLoop)
            {
                chkBoxName = "chkServer" + Convert.ToString(activeLoop);
                var checkBox = this.Controls.Find(chkBoxName, true).FirstOrDefault() as CheckBox;
                checkBoxText = checkBox.Text;
                if (checkBox.Checked == true)
                {
                    MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @hostname", runCommandConnection);
                    serverCMD.Parameters.AddWithValue("@hostname", checkBoxText);
                    MySqlDataReader serverInformationRDR = serverCMD.ExecuteReader();
                    serverInformationRDR.Read();
                    ip = Convert.ToString(serverInformationRDR[8]);
                    username = Convert.ToString(serverInformationRDR[4]);
                    password = Convert.ToString(serverInformationRDR[5]);
                    key = Convert.ToString(serverInformationRDR[6]);
                    os = Convert.ToString(serverInformationRDR[7]);
                    serverInformationRDR.Close();
                    MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverCommands WHERE serverOS = @os AND commandName = @CommandName", runCommandConnection);
                    osCMD.Parameters.AddWithValue("@os", os);
                    osCMD.Parameters.AddWithValue("@CommandName", cmboCommands.Text);
                    MySqlDataReader osRDR = osCMD.ExecuteReader();
                    osRDR.Read();
                    commandData = Convert.ToString(osRDR[4]);
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
                    osRDR.Close();
                }
                activeLoop += 1; // Add the value of 1 to the variable
            }
            runCommandConnection.Close();
            Hide(); //Hide form
        }

        private void serverControlRunCommand_Load(object sender, EventArgs e)
        {
            MySqlConnection commandLoadConnection = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL Connection 
            commandLoadConnection.Open(); // Open MySQL Connection 

            MySqlCommand commandName = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", commandLoadConnection);
            commandName.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader commandNameRDR = commandName.ExecuteReader(); 
            while (commandNameRDR.Read())
            {
                cmboCommands.Items.Add(commandNameRDR.GetString("commandName"));
            }
            commandNameRDR.Close();
            
            MySqlCommand os2cmd = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @companyID ORDER BY serverID ASC", commandLoadConnection);
            os2cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader serverInformationRDR = os2cmd.ExecuteReader(); 
            loopNum = 0;
            while (serverInformationRDR.Read())
            {
                operatingSystemsID[loopNum] = Convert.ToString(serverInformationRDR[3]);
                loopNum += 1; // Add the value of 1 to the variable
            }
            serverInformationRDR.Close();

            MySqlCommand commandcmd = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @company ORDER BY serverID", commandLoadConnection);
            commandcmd.Parameters.AddWithValue("@company", loginMenu.CompanyID); 
            MySqlDataReader setcommandids = commandcmd.ExecuteReader(); 
            loopNum = 0;
            while (setcommandids.Read())
            {
                commandOSID[loopNum] = Convert.ToString(setcommandids[2]);
                loopNum += 1; // Add the value of 1 to the variable
            }
            setcommandids.Close();

            MySqlDataReader commandrdr = commandcmd.ExecuteReader();
            loopNum = 0;
            while (operatingSystemsID[loopNum] != null)
            {
                value = Convert.ToString(operatingSystemsID[loopNum]);
                CheckBox box;
                box = new CheckBox();
                box.Name = "chkServer" + Convert.ToString(loopNum);
                box.Text = value;
                box.AutoSize = true;
                box.Location = new Point(10, (loopNum + 1) * 20);
                pnlConfiguration.Controls.Add(box);
                loopNum += 1; // Add the value of 1 to the variable
            }
            commandrdr.Close();

            finished = true;
            this.Height += (loopNum * 20) + 40;
            pnlConfiguration.Height += (loopNum * 20) + 40;
            loopNum += 1; // Add the value of 1 to the variable
            btnRunCommand.Top += loopNum * 23;
            btnCancel.Top += loopNum * 23;
            loopNum -= 1;
        }
    }
}
