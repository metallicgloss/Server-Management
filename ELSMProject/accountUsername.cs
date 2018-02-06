using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountUsername : Form
    {
        public accountUsername()
        {
            InitializeComponent();
        }

        private void manageAccountUsername_Load(object sender, EventArgs e)
        {
            txtCurrentUsername.Text = loginMenu.Username;
        }

        private void manageAccountUsername_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide(); //Hide form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == txtConfirmNewUsername.Text)
            {
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userLogin = @newUsername", conn);
                command.Parameters.AddWithValue("@newUsername", txtNewUsername.Text);
                command.ExecuteNonQuery();
                loginMenu.Username = txtNewUsername.Text;
                Hide(); //Hide form
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your username and try again.");
            }
        }
    }
}
