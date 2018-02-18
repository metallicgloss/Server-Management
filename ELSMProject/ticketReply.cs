using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class ticketReply : Form
    {
        public ticketReply()
        {
            InitializeComponent();
        }

        private static int loopnum, createloop, pointX = 235, pointY = 20, boxnum = 0, temploop;
        private static bool finished, firstrun = true;
        private static string value, yes = "No";
        string[] userIDList = new string[100];
        string[] replyContent = new string[100];

        private void serverControlEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open(); // Open MySQL Connection

            MySqlCommand systemRepliesCMD = new MySqlCommand("SELECT * FROM systemReplies WHERE ticketID = @ticketID", connectionMySQL);
            systemRepliesCMD.Parameters.AddWithValue("@ticketID", ticketView.ticketID);  // Replace string in query with variable
            MySqlDataReader repliesReader = systemRepliesCMD.ExecuteReader(); // Execute MySQL reader query 

            while (repliesReader.Read()) // While rows in reader
            {
                userIDList[loopnum] = Convert.ToString(repliesReader[2]); // Set array value to reader value - the command ID number
                replyContent[loopnum] = Convert.ToString(repliesReader[3]); // Set array value to reader value - the command ID number
                loopnum = loopnum + 1;
            }
            repliesReader.Close(); // Close reader

            int totalloop = loopnum;
            loopnum = 0;
            
            pnlConfiguration.Height += 40;
            this.Height += 40;
            while (loopnum != totalloop) // While rows in reader
            {
                MySqlCommand userDetailsCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userID = @userID", connectionMySQL);
                userDetailsCMD.Parameters.AddWithValue("@userID", userIDList[loopnum]);  // Replace string in query with variable
                MySqlDataReader userDetailReader = userDetailsCMD.ExecuteReader(); // Execute MySQL reader query 
                userDetailReader.Read();
                string forename = Convert.ToString(userDetailReader[3]);
                string surname = Convert.ToString(userDetailReader[4]);
                userDetailReader.Close();
                Label box = new Label();
                box.Name = "chkOS" + Convert.ToString(loopnum);
                box.Text = forename + " " + surname;
                box.AutoSize = true;
                box.Location = new Point(10, loopnum * 20);
                box.ForeColor = Color.White;
                pnlConfiguration.Controls.Add(box);
                loopnum += 1; // Add the value of 1 to the variable
            }
            int pointX = 235;
            int pointY = 0;
            int loopnum2 = 0; // Set variable to 0
            for (int i = 0; i < loopnum; i++)  // Set variable to 0
            {
                Label a = new Label();
                a.Location = new Point(pointX, pointY);
                a.Name = "txtInput" + loopnum2;
                a.Text = replyContent[loopnum2];
                a.AutoSize = true;
                a.ForeColor = Color.White;
                pnlConfiguration.Controls.Add(a);
                pnlConfiguration.Show();
                pointY += 20;
                loopnum2 += 1; // Add the value of 1 to the variable
            }
            this.Height += loopnum2 * 5;
            pnlConfiguration.Height += (loopnum2 * 5);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }
       

        private void btnNewCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand newTicketReply = new MySqlCommand("INSERT INTO systemReplies (ticketID, userID, replyContent) VALUES (@ticketID, @userID, @replyContent)", connectionMySQL);
            newTicketReply.Parameters.AddWithValue("@ticketID", ticketView.ticketID);
            newTicketReply.Parameters.AddWithValue("@userID", loginMenu.UserID);
            newTicketReply.Parameters.AddWithValue("@replyContent", txtReply.Text);
            newTicketReply.ExecuteNonQuery();


            Hide();
        }
    }
}
