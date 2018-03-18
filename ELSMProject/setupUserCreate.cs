using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using Hashing.PasswordManagement;

namespace ELSM_Project
{
    public partial class setupUserCreate : Form
    {
        public setupUserCreate()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
			//If two values entered match, and txtPassword is not blank execute. Else output messagebox.
            if ((txtPassword.Text == txtConfirmPass.Text) && (txtPassword.Text =! ""))
            {
				//Connect to MySQL and insert row into userAccounts as admin.
                MySqlConnection connectionMySQL = new MySqlConnection(setupDatabase.ConnectionString);     
                connectionMySQL.Open();    
                MySqlCommand createAdmin = new MySqlCommand("INSERT INTO userAccounts (userLogin, userPassword, userForename, userSurname, userEmailAddress, userImage, userCompany, userRole) VALUES (@userLogin, @userPassword, @userForename, @userSurname, @userEmailAddress, @userImage, @userCompany, @userRole)", connectionMySQL);
                String EnteredPassword = SHA.GenerateSHA512String(loginMenu.userSalt + txtPassword.Text);   
                createAdmin.Parameters.AddWithValue("@userLogin", txtUsername.Text);
                createAdmin.Parameters.AddWithValue("@userPassword", EnteredPassword);
                createAdmin.Parameters.AddWithValue("@userForename", txtForename.Text);
                createAdmin.Parameters.AddWithValue("@userSurname", txtSurname.Text);
                createAdmin.Parameters.AddWithValue("@userEmailAddress", txtEmail.Text);
                createAdmin.Parameters.AddWithValue("@userImage", txtProfileImage.Text);
                createAdmin.Parameters.AddWithValue("@userCompany", "1");
                createAdmin.Parameters.AddWithValue("@userRole", "1");
                string fromEmail = txtEmail.Text;
				// Try emailing user with login details for SMTP server. Else display messagebox.
                try
                {
                    MailMessage mailMessage = new MailMessage(fromEmail, txtEmail.Text, "ELSM Management System Installed", "This is confirmation that your installation of your server management panel has been completed.");
                    SmtpClient smtpClient = new SmtpClient(setupEmailConfiguration.SMTPServer, Convert.ToInt16(setupEmailConfiguration.SMTPPort));
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromEmail, setupEmailConfiguration.EmailPass);
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
                }
                createAdmin.ExecuteNonQuery();
                connectionMySQL.Close();
                Hide();
                loginMenu login = new loginMenu();
                login.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Passwords did not match.");
            }

        }
    }
}