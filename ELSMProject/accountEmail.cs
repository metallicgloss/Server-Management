using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountEmail : Form
    {
        public accountEmail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void manageAccountEmail_Load(object sender, EventArgs e)
        {
            txtCurrentEmail.Text = loginMenu.EmailAddress;
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (txtNewEmail.Text == txtConfirmEmail.Text)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtNewEmail.Text);
                    MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userEmailAddress = @email", conn);
                    command.Parameters.AddWithValue("@email", txtNewEmail.Text);
                    command.ExecuteNonQuery();
                    loginMenu.EmailAddress = txtNewEmail.Text;
                    Hide(); //Hide form
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
