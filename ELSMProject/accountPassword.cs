using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace ELSM_Project
{

    public partial class accountPassword : Form
    {
        public accountPassword()
        {
            InitializeComponent();
        }
        
        private void manageAccountPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide(); //Hide form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String Currentpassword = loginMenu.EncryptString(txtCurrentPassword.Text, loginMenu.key, loginMenu.iv);
            String NewPassword = loginMenu.EncryptString(txtNewPassword.Text, loginMenu.key, loginMenu.iv);
            String NewPasswordConfirm = loginMenu.EncryptString(txtConfirmPassword.Text, loginMenu.key, loginMenu.iv);
            if (Currentpassword == loginMenu.Password)
            {
                if (NewPassword == NewPasswordConfirm)
                {
                    MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userPassword = @pass", conn);
                    command.Parameters.AddWithValue("@pass", NewPassword);
                    command.ExecuteNonQuery();
                    loginMenu.Password = txtNewPassword.Text;
                    Hide(); //Hide form
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The new password you have entered was not done so correctly. Please make sure you've type it correctly.");
                }
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your email address and try again.");
            }
        }

        private void manageAccountPassword_Load(object sender, EventArgs e)
        {

        }
    }
}