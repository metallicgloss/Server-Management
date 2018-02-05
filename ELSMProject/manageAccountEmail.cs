using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class manageAccountEmail : Form
    {
        public manageAccountEmail()
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
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userEmailAddress = @email", conn);
                command.Parameters.AddWithValue("@email", txtNewEmail.Text);
                command.ExecuteNonQuery();
                loginMenu.EmailAddress = txtNewEmail.Text;
                Hide(); //Hide form
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your email address and try again.");
            }
            
        }
    }
}
