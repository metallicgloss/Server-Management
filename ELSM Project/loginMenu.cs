using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text.RegularExpressions;

namespace ELSM_Project
{
    public partial class loginMenu : Form
    {

        public static string IPAddress, Forename, Surname, CompanyID, EmailAddress, ProfileImage, Role, UserID, Username;
        public static string ConnectionString = "SERVER=185.44.78.200;DATABASE=metallic_elsm_test;UID=metallic_testing;PASSWORD=zyRHxVhgdv8zTH2E53;"; // Temp login credentials to remotely hosted MySQL database.
        // Want cheap, reliable and powerful MySQL and web hosting? Check out https://www.elhostingservices.com - Shameless plug. Login information and this comment to be removed at a later date.


        public loginMenu()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userLogin = txtUsername.Text; // Set userLogin variable to the user input.
            var userPassword = txtPassword.Text; // Set userPassword variable to the user input.
            var checkpointReached = false; // Setup variable for use later on in the login stage to catch a MySQL error.

            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string sql = "SELECT * FROM userAccounts WHERE userLogin = @userLogin"; // Create a string with the query command to run.
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@userLogin", userLogin); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader rdr = cmd.ExecuteReader(); // Process the query command and feedback data to reader.
            rdr.Read();
            
            try
            {
                var Valid = Convert.ToString(rdr[0]); // Attempting to create a random variable and set it to value from the database.
                checkpointReached = true; // If the re was no error set the flag to true.
            }
            catch (Exception) // If variable was unable to be set to a value from the database and threw an error, process catch section.
            {
                System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                txtUsername.Text = "";
                txtPassword.Text = "";
                rdr.Close();
                conn.Close();
            }
            if (checkpointReached == true) // If the Valid variable earlier could be set and the flag was changed to true, run code.
            {
                var databasePassword = Convert.ToString(rdr[2]); // Set databasePassword equal to the value in the database for the user.
                loginMenu.UserID = Convert.ToString(rdr[0]);
                loginMenu.Username = Convert.ToString(rdr[1]);
                loginMenu.Forename = Convert.ToString(rdr[3]);
                loginMenu.Surname = Convert.ToString(rdr[4]);
                loginMenu.EmailAddress = Convert.ToString(rdr[5]);
                loginMenu.ProfileImage = Convert.ToString(rdr[6]);
                loginMenu.CompanyID = Convert.ToString(rdr[7]);
                loginMenu.Role = Convert.ToString(rdr[8]);
                conn.Close();
                if (userPassword != databasePassword) // If databasevalue doesn't match what the user entered, run code. Else run another block of code.
                {
                    System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO failedLoginAttempts (attemptUsername, attemptIP, attemptTimeStamp) VALUES (@attemptUsername, @attemptIP, @attemptTimeStamp)", conn); // Set MySQL query.
                    command.Parameters.Add("@attemptUsername", txtUsername.Text);
                    command.Parameters.Add("@attemptIP", loginMenu.IPAddress);
                    command.Parameters.Add("@attemptTimeStamp", DateTime.Now); // Replace text in string with variables.
                    command.ExecuteNonQuery(); // Process query.
                }
                else
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userIPAddress = @attemptIP, userLastLogin = @attemptTimeStamp", conn); // Set MySQL query.
                    command.Parameters.Add("@attemptIP", ELSM_Project.loginMenu.IPAddress);
                    command.Parameters.Add("@attemptTimeStamp", DateTime.Now); // Replace text in string with variables.
                    command.ExecuteNonQuery(); // Process query.
                    Hide();
                    mainDashboard loginMenu = new mainDashboard();
                    loginMenu.ShowDialog();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    Show();
                }
            }
            rdr.Close();
            conn.Close();
        }

        private void loginFRM_Load(object sender, EventArgs e)
        {
            string externalIP; // Define variable to be used.
            externalIP = (new WebClient()).DownloadString("http://checkip.dyndns.org/"); // Get download from URL about computer information.
            externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString(); // Truncate and convert kickback string 
            loginMenu.IPAddress = externalIP;
        }

        
    }
}
