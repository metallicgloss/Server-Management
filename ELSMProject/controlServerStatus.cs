using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

namespace ELSM_Project
{
    public partial class controlServerStatus : Form
    {
        public controlServerStatus()
        {
            //On form load initialize component.
            InitializeComponent();
        }


        //Declare variables.
        private static int loopnum = 1, pointY = 20, pointX = 235;
        private static string value, pingOutcomeData;
        private static PingReply pingResponse;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void serverControlStatus_Load(object sender, EventArgs e)
        {
            //Connect to MySQL, for each row found, dynamically create to lables. One with the name of the server, the other with the result. During the process, the program pings the server.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand statusExecute = new MySqlCommand("SELECT * FROM serverInformation ORDER BY serverID", connectionMySQL);
            MySqlDataReader statusOutput = statusExecute.ExecuteReader();
            while (statusOutput.Read())
            {
                value = Convert.ToString(statusOutput[3]);
                Label statusLabel = new Label();
                statusLabel.Name = "lblServerHostname" + Convert.ToString(loopnum);
                statusLabel.Text = value;
                statusLabel.AutoSize = true;
                statusLabel.Location = new Point(10, loopnum * 20);
                pnlConfiguration.Controls.Add(statusLabel);
                Label statusResult = new Label();
                statusResult.Location = new Point(pointX, pointY);
                statusResult.Name = "lblStatusOutcome" + loopnum;
                statusResult.Width = 800;
                statusResult.Height -= 5;
                statusResult.ForeColor = Color.Black;
                pingOutcomeData = Convert.ToString(statusOutput[7]);
                Ping pingProcess = new Ping();
                pingResponse = pingProcess.Send(pingOutcomeData);
                if (pingResponse.Status == IPStatus.Success)
                {
                    statusResult.Text = "Ping to " + pingOutcomeData.ToString() + " Successful! "
                       + " Response Time " + pingResponse.RoundtripTime.ToString() + "ms";
                }
                else
                {
                    statusResult.Text = "Server Offline";
                }
                pnlConfiguration.Controls.Add(statusResult);
                pnlConfiguration.Height += 40;
                pointY += 20;
                loopnum += 1;
            }
            statusOutput.Close();
            connectionMySQL.Close();
            this.Height += 40 + (loopnum * 5);
            pnlConfiguration.Height += (loopnum * 5);
            btnCancel.Top += ((loopnum + 5) * 6);
        }
    }
}
