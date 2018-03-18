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
                chkBoxName = "chkServer" + Convert.ToString(activeLoop);
                var checkBox = this.Controls.Find(chkBoxName, true).FirstOrDefault() as CheckBox;
                checkBoxText = checkBox.Text;
                if (checkBox.Checked == true)
                {
                    MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @hostname", runCommandConnection);
                    serverCMD.Parameters.AddWithValue("@hostname", checkBoxText);
                    MySqlDataReader serverInformationRDR = serverCMD.ExecuteReader();
                    serverInformationRDR.Read();
                    ip = Convert.ToString(serverInformationRDR[7]);
                    username = Convert.ToString(serverInformationRDR[4]);
                    password = Convert.ToString(serverInformationRDR[5]);
                    os = Convert.ToString(serverInformationRDR[6]);
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
                activeLoop += 1;
            }
            runCommandConnection.Close();
            Hide();
        }

        private void serverControlRunCommand_Load(object sender, EventArgs e)
        {
            MySqlConnection commandLoadConnection = new MySqlConnection(loginMenu.ConnectionString);
            commandLoadConnection.Open();

            MySqlCommand commandName = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", commandLoadConnection);
            commandName.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader commandNameRDR = commandName.ExecuteReader();
            while (commandNameRDR.Read())
            {
                cmboCommands.Items.Add(commandNameRDR.GetString("commandName"));
            }
            commandNameRDR.Close();

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
