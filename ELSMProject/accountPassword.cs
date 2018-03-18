using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hashing.PasswordManagement;


namespace ELSM_Project
{

    public partial class accountPassword : Form
    {
        public accountPassword()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //Hash and salt the two new passwords.
            String NewPassword = SHA.GenerateSHA512String(loginMenu.userSalt + txtNewPassword.Text);
            String NewPasswordConfirm = SHA.GenerateSHA512String(loginMenu.userSalt + txtConfirmPassword.Text);
            //If the two new values are the same, and aren't blank execute.
            if ((NewPassword == NewPasswordConfirm) && (txtNewPassword.Text != ""))
            {
                //Update user password.
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userPassword = @pass", conn);
                command.Parameters.AddWithValue("@pass", NewPassword);
                command.ExecuteNonQuery();
                loginMenu.Password = txtNewPassword.Text;
                Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your email address and try again.");
            }
        }
    }
}