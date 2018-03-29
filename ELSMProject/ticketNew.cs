using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class ticketNew : Form
    {
        public ticketNew()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void newTicket_Load(object sender, EventArgs e)
        {
			//Set textboxes to customised text.
            txtName.Text = loginMenu.Forename + " " + loginMenu.Surname;
            txtEmail.Text = loginMenu.EmailAddress;
			//Connect to MySQL, set output from sql and set as items of cmboRegarding.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation", connectionMySQL);
            MySqlDataReader serverRDR = serverCMD.ExecuteReader();
            while (serverRDR.Read())
            {
                cmboRegarding.Items.Add(serverRDR.GetString("serverHostname"));
            }
            serverRDR.Close();
            connectionMySQL.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            //Convert datetime to format for MySQL.
            string dateValue = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //Insert row into systemTickets using values.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand newTicket = new MySqlCommand("INSERT INTO systemTickets (ticketCustomer, ticketRegarding, 	ticketUpdated, userCompanyID, ticketSubject) VALUES (@ticketCustomer, @ticketRegarding, @ticketUpdated, @userCompanyID, @ticketSubject);", connectionMySQL);
            newTicket.Parameters.AddWithValue("@ticketCustomer", loginMenu.UserID);
            newTicket.Parameters.AddWithValue("@ticketRegarding", cmboRegarding.Text);
            newTicket.Parameters.AddWithValue("@ticketUpdated", dateValue);
            newTicket.Parameters.AddWithValue("@ticketSubject", txtSubject.Text);
            newTicket.Parameters.AddWithValue("@userCompanyID", loginMenu.CompanyID);
            newTicket.ExecuteNonQuery();
			//Get the LastInsertId of the last insert.
            var ticketID = newTicket.LastInsertedId;
			//Insert row into systemReplies using values.
            MySqlCommand newTicketReply = new MySqlCommand("INSERT INTO systemReplies (ticketID, userID, replyContent) VALUES (@ticketID, @userID, @replyContent)", connectionMySQL);
            newTicketReply.Parameters.AddWithValue("@ticketID", ticketID);
            newTicketReply.Parameters.AddWithValue("@userID", loginMenu.UserID);
            newTicketReply.Parameters.AddWithValue("@replyContent", txtContent.Text);
            newTicketReply.ExecuteNonQuery();
            Hide();
        }
    }
}