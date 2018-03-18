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
            //On form load initialize component.
            InitializeComponent();
        }

        private static int loopnum, pointX = 235, pointY = 20;


        private void serverControlEdit_Load(object sender, EventArgs e)
        {
            string[] userIDList = new string[100];
            string[] replyContent = new string[100];
            string forename = "", surname = "";

            loopnum = 0;
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();

            MySqlCommand systemRepliesCMD = new MySqlCommand("SELECT * FROM systemReplies WHERE ticketID = @ticketID", connectionMySQL);
            systemRepliesCMD.Parameters.AddWithValue("@ticketID", ticketView.ticketID);
            MySqlDataReader repliesReader = systemRepliesCMD.ExecuteReader();

            while (repliesReader.Read())
            {
                userIDList[loopnum] = Convert.ToString(repliesReader[2]);
                replyContent[loopnum] = Convert.ToString(repliesReader[3]);
                loopnum = loopnum + 1;
            }
            repliesReader.Close();

            int totalloop = loopnum;
            loopnum = 0;

            pnlConfiguration.Height += 40;
            this.Height += 40;
            while (loopnum != totalloop)
            {
                MySqlCommand userDetailsCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userID = @userID", connectionMySQL);
                userDetailsCMD.Parameters.AddWithValue("@userID", userIDList[loopnum]);
                MySqlDataReader userDetailReader = userDetailsCMD.ExecuteReader();
                userDetailReader.Read();
                forename = Convert.ToString(userDetailReader[3]);
                surname = Convert.ToString(userDetailReader[4]);
                userDetailReader.Close();
                Label box = new Label();
                box.Name = "chkOS" + Convert.ToString(loopnum);
                box.Text = forename + " " + surname;
                box.AutoSize = true;
                box.Location = new Point(10, loopnum * 20);
                box.ForeColor = Color.White;
                pnlConfiguration.Controls.Add(box);
                loopnum += 1;
            }
            int pointX = 235;
            int pointY = 0;
            int loopnum2 = 0;
            for (int i = 0; i < loopnum; i++)
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
                loopnum2 += 1;
            }
            this.Height += loopnum2 * 5;
            pnlConfiguration.Height += (loopnum2 * 5);
            connectionMySQL.Close();
        }


        private void btnNewCommand_Click(object sender, EventArgs e)
        {
			//Insert new reply into the database.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand newTicketReply = new MySqlCommand("INSERT INTO systemReplies (ticketID, userID, replyContent) VALUES (@ticketID, @userID, @replyContent)", connectionMySQL);
            newTicketReply.Parameters.AddWithValue("@ticketID", ticketView.ticketID);
            newTicketReply.Parameters.AddWithValue("@userID", loginMenu.UserID);
            newTicketReply.Parameters.AddWithValue("@replyContent", txtReply.Text);
            newTicketReply.ExecuteNonQuery();

            //Hide the form.
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }
    }
}
