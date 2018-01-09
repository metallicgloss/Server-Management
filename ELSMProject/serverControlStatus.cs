using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

namespace ELSM_Project
{
    public partial class serverControlStatus : Form
    {
        public serverControlStatus()
        {
            InitializeComponent();
        }

        private static int loopnum = 1, pointY = 20, pointX = 235;
        private static string value, pingOutcomeData;
        private static Label statusLabel = new Label();
        private static Label statusResult = new Label();
        private static Ping pingProcess = new Ping();
        private static PingReply pingResponse;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void serverControlStatus_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            string commandStatus = "SELECT * FROM serverInformation ORDER BY serverID";
            MySqlCommand statusExecute = new MySqlCommand(commandStatus, connectionMySQL);
            MySqlDataReader statusOutput = statusExecute.ExecuteReader();
            while (statusOutput.Read())
            {
                value = Convert.ToString(statusOutput[3]);
                statusLabel.Name = "lblServerHostname" + Convert.ToString(loopnum);
                statusLabel.Text = value;
                statusLabel.AutoSize = true;
                statusLabel.Location = new Point(10, loopnum * 20);
                pnlConfiguration.Controls.Add(statusLabel);
                statusResult.Location = new Point(pointX, pointY);
                statusResult.Name = "lblStatusOutcome" + loopnum;
                statusResult.Width = 800;
                statusResult.Height -= 5;
                statusResult.ForeColor = Color.Black;
                pingOutcomeData = Convert.ToString(statusOutput[8]);
                pingResponse = pingProcess.Send(pingOutcomeData);
                if (pingResponse.Status == IPStatus.Success)
                {
                    statusResult.Text = "Ping to " + pingOutcomeData.ToString() + " Successful! "
                       + " Response Time " + pingResponse.RoundtripTime.ToString() + "ms";
                }
                pnlConfiguration.Controls.Add(statusResult);
                pnlConfiguration.Height += 40;
                pointY += 20;
                loopnum += 1;
            }
            statusOutput.Close();
            connectionMySQL.Close();
            this.Height += 40+ (loopnum * 5);
            pnlConfiguration.Height += (loopnum * 5);
            btnCancel.Top += ((loopnum+5) * 6);
        }
    }
}
