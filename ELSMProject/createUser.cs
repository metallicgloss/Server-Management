using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace ELSM_Project
{
    public partial class createUser : Form
    {
        public createUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                    MySqlConnection connectionMySQL = new MySqlConnection(initialSetup.ConnectionString); // Open MySQL connection 
                    connectionMySQL.Open(); // Open MySQL connection
                    MySqlCommand createAdmin = new MySqlCommand("INSERT INTO userAccounts (userLogin, userPassword, userForename, userSurname, userEmailAddress, userImage, userCompany, userRole) VALUES (@userLogin, @userPassword, @userForename, @userSurname, @userEmailAddress, @userImage, @userCompany, @userRole)", connectionMySQL);

                    String EnteredPassword = CodeShare.Cryptography.SHA.GenerateSHA512String(txtPassword.Text); // Decrypt Password
                    createAdmin.Parameters.AddWithValue("@userLogin", txtUsername.Text);
                    createAdmin.Parameters.AddWithValue("@userPassword", EnteredPassword);
                    createAdmin.Parameters.AddWithValue("@userForename", txtForename.Text);
                    createAdmin.Parameters.AddWithValue("@userSurname", txtSurname.Text);
                    createAdmin.Parameters.AddWithValue("@userEmailAddress", txtEmail.Text);
                    createAdmin.Parameters.AddWithValue("@userImage", txtProfileImage.Text);
                    createAdmin.Parameters.AddWithValue("@userCompany", "1");
                    createAdmin.Parameters.AddWithValue("@userRole", "1");
                    Boolean EmailSent = false;
                        MailMessage mail = new MailMessage(txtEmail.Text, txtEmail.Text);
                        SmtpClient client = new SmtpClient();
                        client.Port = 25;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Host = "smtp.gmail.com";
                        mail.Subject = "this is a test email.";
                        mail.Body = "this is my test email body";
                        client.Send(mail);
                        EmailSent = true;

                    if (EmailSent = true) {
                        createAdmin.ExecuteNonQuery();
                        connectionMySQL.Close();
                        Hide();
                        loginMenu login = new loginMenu();
                        login.ShowDialog();
                    }


            } else {
                System.Windows.Forms.MessageBox.Show("Passwords did not match.");
            }
            
        }
    }
}
