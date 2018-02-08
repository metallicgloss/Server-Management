﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace ELSM_Project
{
    public partial class setupUserCreate : Form
    {
        public setupUserCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                    MySqlConnection connectionMySQL = new MySqlConnection(setupDatabase.ConnectionString); // Open MySQL connection 
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
                string fromEmail = txtEmail.Text;
                MailMessage mailMessage = new MailMessage(fromEmail, txtEmail.Text, "ELSM Management System Installed", "Body");
                SmtpClient smtpClient = new SmtpClient(setupEmailConfiguration.SMTPServer, Convert.ToInt16(setupEmailConfiguration.SMTPPort));
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, setupEmailConfiguration.EmailPass);
                try
                {
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


            } else {
                System.Windows.Forms.MessageBox.Show("Passwords did not match.");
            }
            
        }

        private void createUser_Load(object sender, EventArgs e)
        {

        }
    }
}