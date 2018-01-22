using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class newTicket : Form
    {
        public newTicket()
        {
            InitializeComponent();
        }

        private void newTicket_Load(object sender, EventArgs e)
        {
            txtName.Text = loginMenu.Forename + " " + loginMenu.Surname;
            txtEmail.Text = loginMenu.EmailAddress;
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand serverCMD = new MySqlCommand("SELECT * FROM serverInformation", connectionMySQL);
            MySqlDataReader serverRDR = serverCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverRDR.Read()) // While rows in reader
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
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand newTicket = new MySqlCommand("INSERT INTO systemTickets (ticketCustomer, ticketRegarding) VALUES (@ticketCustomer, @ticketRegarding)", connectionMySQL);
            newTicket.Parameters.AddWithValue("@ticketCustomer", loginMenu.UserID);
            newTicket.Parameters.AddWithValue("@ticketRegarding", cmboRegarding.Text);
            newTicket.ExecuteNonQuery();

            if (newTicket.LastInsertedId != null) newTicket.Parameters.Add(
            new MySqlParameter("newId", newTicket.LastInsertedId));

            var ticketID = Convert.ToInt32(newTicket.Parameters["@newId"].Value);

            MySqlCommand newTicketReply = new MySqlCommand("INSERT INTO systemTickets (ticketID, userID, replyContent) VALUES (@ticketID, @userID, @replyContent)", connectionMySQL);
            newTicket.Parameters.AddWithValue("@ticketID", ticketID);
            newTicket.Parameters.AddWithValue("@userID", loginMenu.UserID);
            newTicket.Parameters.AddWithValue("@replyContent", txtContent.Text);
            newTicket.ExecuteNonQuery();
            Hide();
        }
    }
}
