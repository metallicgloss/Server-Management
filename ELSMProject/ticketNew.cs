using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class ticketNew : Form
    {
        public ticketNew()
        {
            InitializeComponent();
        }

        private void newTicket_Load(object sender, EventArgs e)
        {
            txtName.Text = loginMenu.Forename + " " + loginMenu.Surname;
            txtEmail.Text = loginMenu.EmailAddress;
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
            Hide();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();

            MySqlCommand newTicket = new MySqlCommand("INSERT INTO systemTickets (ticketCustomer, ticketRegarding, userCompanyID, ticketSubject) VALUES (@ticketCustomer, @ticketRegarding, @userCompanyID, @ticketSubject);", connectionMySQL);
            newTicket.Parameters.AddWithValue("@ticketCustomer", loginMenu.UserID);
            newTicket.Parameters.AddWithValue("@ticketRegarding", cmboRegarding.Text);
            newTicket.Parameters.AddWithValue("@ticketSubject", txtSubject.Text);
            newTicket.Parameters.AddWithValue("@userCompanyID", loginMenu.CompanyID);
            newTicket.ExecuteNonQuery();
            var ticketID = newTicket.LastInsertedId;


            MySqlCommand newTicketReply = new MySqlCommand("INSERT INTO systemReplies (ticketID, userID, replyContent) VALUES (@ticketID, @userID, @replyContent)", connectionMySQL);
            newTicketReply.Parameters.AddWithValue("@ticketID", ticketID);
            newTicketReply.Parameters.AddWithValue("@userID", loginMenu.UserID);
            newTicketReply.Parameters.AddWithValue("@replyContent", txtContent.Text);
            newTicketReply.ExecuteNonQuery();
            Hide();
        }
    }
}