using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountEmail : Form
    {
        public accountEmail()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void manageAccountEmail_Load(object sender, EventArgs e)
        {
            //Set the email text box to the variable.
            txtCurrentEmail.Text = loginMenu.EmailAddress;
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            //If the two new values are the same, and aren't blank execute.
            if ((txtNewEmail.Text == txtConfirmEmail.Text) && (txtNewEmail.Text != ""))
            {
                //Try parsing the text into the format of an email, if it fails inform the user the formatting is incorrect.
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtNewEmail.Text);
                    //Update user email address.
                    MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userEmailAddress = @email", conn);
                    command.Parameters.AddWithValue("@email", txtNewEmail.Text);
                    command.ExecuteNonQuery();
                    loginMenu.EmailAddress = txtNewEmail.Text;
                    Hide();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("You must enter an email address in the correct format.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your email address and try again.");
            }
        }
    }
}
