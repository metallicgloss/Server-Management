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
using Renci.SshNet;

namespace ELSM_Project
{
    public partial class serverControlRunCommand : Form
    {
        public serverControlRunCommand()
        {
            InitializeComponent();
        }

        public static int loopnum, createloop;
        public static bool finished;
        string[] operatingSystemsID = new string[100];
        string[] operatingSystems = new string[100];
        string[] commandOSID = new string[100];
        string[] commandText = new string[100];

        private void cmboCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnRunCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            createloop = 0;
            while (loopnum != createloop)
            {
                string chkname = "chkServer" + Convert.ToString(createloop);
                var os = "";
                var ip = "";
                var username = "";
                var password = "";
                var key = "";
                var checkBox = this.Controls.Find(chkname, true).FirstOrDefault() as CheckBox;
                string checkBoxText = checkBox.Text;
                if (checkBox.Checked == true)
                {
                    MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverInformation WHERE serverHostname = @hostname", conn);
                    oscmd.Parameters.AddWithValue("@hostname", checkBoxText);
                    MySqlDataReader osrdr = oscmd.ExecuteReader();
                    osrdr.Read();
                    ip = Convert.ToString(osrdr[8]);
                    username = Convert.ToString(osrdr[4]);
                    password = Convert.ToString(osrdr[5]);
                    key = Convert.ToString(osrdr[6]);
                    os = Convert.ToString(osrdr[7]);
                    osrdr.Close();
                    MySqlCommand oscommand = new MySqlCommand("SELECT * FROM serverCommands WHERE serverOS = @os AND commandName = @CommandName", conn);
                    oscommand.Parameters.AddWithValue("@os", os);
                    oscommand.Parameters.AddWithValue("@CommandName", cmboCommands.Text);
                    MySqlDataReader osreader = oscommand.ExecuteReader();
                    osreader.Read();
                    try
                    {
                        using (var client = new SshClient(ip, username, password))
                        {
                            client.Connect();
                            client.RunCommand(Convert.ToString(osreader[4]));
                            client.Disconnect();
                        }

                    }
                    catch (Exception exception)
                    {
                        System.Windows.Forms.MessageBox.Show("Error");
                    }
                    osreader.Close();
                }
                createloop += 1;
            }
            conn.Close();
            Hide();
        }

        private void serverControlRunCommand_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            MySqlCommand oscmd = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", conn);
            oscmd.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader serverrdr = oscmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (serverrdr.Read())
            {
                cmboCommands.Items.Add(serverrdr.GetString("commandName"));
            }
            serverrdr.Close();
            string os = "SELECT * FROM serverInformation WHERE serverCompany = @companyID ORDER BY serverID ASC"; // Create a string with the query command to run.
            MySqlCommand os2cmd = new MySqlCommand(os, conn);
            os2cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader osrdr = os2cmd.ExecuteReader(); // Process the query command and feedback data to reader.
            loopnum = 0;
            while (osrdr.Read())
            {
                operatingSystemsID[loopnum] = Convert.ToString(osrdr[3]);
                loopnum += 1;
            }
            osrdr.Close();
            MySqlCommand commandcmd = new MySqlCommand("SELECT * FROM serverInformation WHERE serverCompany = @company ORDER BY serverID", conn);
            commandcmd.Parameters.AddWithValue("@company", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader setcommandids = commandcmd.ExecuteReader(); // Process the query command and feedback data to reader.
            loopnum = 0;
            while (setcommandids.Read())
            {
                commandOSID[loopnum] = Convert.ToString(setcommandids[2]);
                loopnum += 1;
            }
            setcommandids.Close();
            MySqlDataReader commandrdr = commandcmd.ExecuteReader(); // Process the query command and feedback data to reader.
            int height;
            height = 206;
            loopnum = 0;
            int boxnum = 0;
            string value;
            while (operatingSystemsID[loopnum] != null)
            {
                value = Convert.ToString(operatingSystemsID[loopnum]);
                height += 20;
                CheckBox box;
                box = new CheckBox();
                box.Name = "chkServer" + Convert.ToString(loopnum);
                box.Text = value;
                box.AutoSize = true;
                box.Location = new Point(10, (loopnum + 1) * 20);
                pnlConfiguration.Controls.Add(box);
                loopnum += 1;
                boxnum += 1;

            }
            commandrdr.Close();
            finished = true;
            this.Height += (loopnum * 20) + 40;
            pnlConfiguration.Height += (loopnum * 20) + 40;
            loopnum += 1;
            btnRunCommand.Top += loopnum * 23;
            btnCancel.Top += loopnum * 23;
            loopnum -= 1;
        }
    }
}
