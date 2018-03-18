using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountUsername : Form
    {
        public accountUsername()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void manageAccountUsername_Load(object sender, EventArgs e)
        {
            //Set the username text box to the variable.
            txtCurrentUsername.Text = loginMenu.Username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            //If the two new values are the same, and aren't blank execute.
            if ((txtNewUsername.Text == txtConfirmNewUsername.Text) && (txtNewUsername.Text != ""))
            {
                //Update user username.
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userLogin = @newUsername", conn);
                command.Parameters.AddWithValue("@newUsername", txtNewUsername.Text);
                command.ExecuteNonQuery();
                loginMenu.Username = txtNewUsername.Text;
                Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match or is blank. Please check your username and try again.");
            }
        }
    }
}
