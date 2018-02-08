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
            InitializeComponent();
        }


        //  Declare Variables For Use  //
        private static int loopnum = 1, pointY = 20, pointX = 235;
        private static string value, pingOutcomeData;
        private static PingReply pingResponse;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form //Hide form
        }

        private void serverControlStatus_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
            connectionMySQL.Open(); // Open MySQL connection
            MySqlCommand statusExecute = new MySqlCommand("SELECT * FROM serverInformation ORDER BY serverID", connectionMySQL); // Construct MySQL query into command
            MySqlDataReader statusOutput = statusExecute.ExecuteReader(); // Execute MySQL reader query // Process MySQL query, save output in reader
            while (statusOutput.Read()) // While rows available in reader
            {
                value = Convert.ToString(statusOutput[3]); // Set value to 4th collumn in database
                Label statusLabel = new Label(); // Create dynamic label
                statusLabel.Name = "lblServerHostname" + Convert.ToString(loopnum); // Set name of dynamically created label
                statusLabel.Text = value; // Set Text Equal to 
                statusLabel.AutoSize = true; // Allow Label AutoSize
                statusLabel.Location = new Point(10, loopnum * 20); // Set location of label
                pnlConfiguration.Controls.Add(statusLabel); // Display label on form
                Label statusResult = new Label(); // Create dynamic label
                statusResult.Location = new Point(pointX, pointY); // Set location of label
                statusResult.Name = "lblStatusOutcome" + loopnum; // Set name of dynamically created label
                statusResult.Width = 800; // Set width of label
                statusResult.Height -= 5; // Set height of label
                statusResult.ForeColor = Color.Black; // Set text color to black
                pingOutcomeData = Convert.ToString(statusOutput[7]); // Set pingOutcomeData variable from database equal to the IP address
                Ping pingProcess = new Ping(); // Construct a ping variable
                pingResponse = pingProcess.Send(pingOutcomeData); // Ping variable containing server IP from database row
                if (pingResponse.Status == IPStatus.Success) // If ping request shows online
                {
                    statusResult.Text = "Ping to " + pingOutcomeData.ToString() + " Successful! "
                       + " Response Time " + pingResponse.RoundtripTime.ToString() + "ms"; // Set label to display information
                }
                else
                {
                    statusResult.Text = "Server Offline"; // Set label to display information
                }
                pnlConfiguration.Controls.Add(statusResult); // Display new label
                pnlConfiguration.Height += 40; // Increase height of panel by 40
                pointY += 20; // Increase position by 20
                loopnum += 1; // Add the value of 1 to the variable
            }
            statusOutput.Close(); // Close database reader
            connectionMySQL.Close(); // Close mysql connection
            this.Height += 40 + (loopnum * 5); // Increase window height
            pnlConfiguration.Height += (loopnum * 5); // Increase panel height
            btnCancel.Top += ((loopnum+5) * 6); // Reposition the cancel button
        }
    }
}
