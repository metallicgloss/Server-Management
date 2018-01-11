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

        public static string IPAddress, Forename, Surname, CompanyID, CompanyName, EmailAddress, ProfileImage, Role, UserID, Username, Password, externalIP, userLogin, userPassword;
        public static Boolean permChangePassword, permChangeUsername, permChangeEmail, permViewServers, permEditServers, permDeleteServers, permViewLocations, permEditLocations, permDeleteLocations, permCreateTicket, permAdminTicket, permCloseTicket, permViewServerPass, permEditServerPass, permAddAction, permEditAction, permDeleteAction, permRunUpdate, permRunReboot, permAddServerNote, permRunCustomAction, permAdminViewUsers, permAdminEditUserInfo, permAdminForcePassReset, permAdminAddUser, permAdminDelUser, permAdminChangePermissions, permControlServers, checkpointReached;
        public static string ConnectionString = "SERVER=185.44.78.200;DATABASE=metallic_elsm_test;UID=metallic_testing;PASSWORD=zyRHxVhgdv8zTH2E53;"; 
        


        public loginMenu()
        {
            InitializeComponent();
        }


        private void loginFRM_Load(object sender, EventArgs e)
        {
            externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches((new WebClient()).DownloadString("https://www.metallicgloss.com/functions/ip.php"))[0].ToString();
            loginMenu.IPAddress = externalIP;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            userLogin = txtUsername.Text; 
            userPassword = txtPassword.Text; 
            checkpointReached = false; 

            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open(); // Open MySQL connection
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM userAccounts WHERE userLogin = @userLogin", connectionMySQL);
            cmd.Parameters.AddWithValue("@userLogin", userLogin); 
            MySqlDataReader rdr = cmd.ExecuteReader(); // Execute MySQL reader query 
            rdr.Read(); // Read data from the reader to become usable
            
            try
            {
                var Valid = Convert.ToString(rdr[0]); // Set variable equal to item in reader
                var databasePassword = Convert.ToString(rdr[2]); // Set variable equal to item in reader
                loginMenu.UserID = Convert.ToString(rdr[0]); // Set variable equal to item in reader
                loginMenu.Username = Convert.ToString(rdr[1]); // Set variable equal to item in reader
                loginMenu.Password = Convert.ToString(rdr[2]); // Set variable equal to item in reader
                loginMenu.Forename = Convert.ToString(rdr[3]); // Set variable equal to item in reader
                loginMenu.Surname = Convert.ToString(rdr[4]); // Set variable equal to item in reader
                loginMenu.EmailAddress = Convert.ToString(rdr[5]); // Set variable equal to item in reader
                loginMenu.ProfileImage = Convert.ToString(rdr[6]); // Set variable equal to item in reader
                loginMenu.CompanyID = Convert.ToString(rdr[7]); // Set variable equal to item in reader
                loginMenu.Role = Convert.ToString(rdr[8]); // Set variable equal to item in reader
                String EnteredPassword = CodeShare.Cryptography.SHA.GenerateSHA512String(txtPassword.Text); // Decrypt Password
                rdr.Close(); // Close reader
                if (EnteredPassword != databasePassword)
                {
                    System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                    MySqlCommand failedCMD = new MySqlCommand("INSERT INTO failedLoginAttempts (attemptUsername, attemptIP, attemptTimeStamp) VALUES (@attemptUsername, @attemptIP, @attemptTimeStamp)", conn);
                    failedCMD.Parameters.AddWithValue("@attemptUsername", txtUsername.Text); // Replace string in query with variable
                    failedCMD.Parameters.AddWithValue("@attemptIP", loginMenu.IPAddress); // Replace string in query with variable
                    failedCMD.Parameters.AddWithValue("@attemptTimeStamp", DateTime.Now); // Replace string in query with variable
                    failedCMD.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand accountCMD = new MySqlCommand("UPDATE `userAccounts` SET userIPAddress = @attemptIP, userLastLogin = @attemptTimeStamp", connectionMySQL);
                    accountCMD.Parameters.AddWithValue("@attemptIP", ELSM_Project.loginMenu.IPAddress); // Replace string in query with variable
                    accountCMD.Parameters.AddWithValue("@attemptTimeStamp", DateTime.Now); // Replace string in query with variable
                    accountCMD.ExecuteNonQuery();

                    MySqlCommand permissionCommand = new MySqlCommand("SELECT * FROM userPermissions WHERE permID = @permid", connectionMySQL);
                    permissionCommand.Parameters.AddWithValue("@permid", Role); // Replace string in query with variable
                    MySqlDataReader permissionRDR = permissionCommand.ExecuteReader(); // Execute MySQL reader query
                    permissionRDR.Read(); // Read data from the reader to become usable
                    permChangePassword = Convert.ToBoolean(permissionRDR[4]); // Set variable equal to item in reader
                    permChangeUsername = Convert.ToBoolean(permissionRDR[5]); // Set variable equal to item in reader
                    permChangeEmail = Convert.ToBoolean(permissionRDR[6]); // Set variable equal to item in reader
                    permViewServers = Convert.ToBoolean(permissionRDR[7]); // Set variable equal to item in reader
                    permEditServers = Convert.ToBoolean(permissionRDR[8]); // Set variable equal to item in reader
                    permDeleteServers = Convert.ToBoolean(permissionRDR[9]); // Set variable equal to item in readerv
                    permViewLocations = Convert.ToBoolean(permissionRDR[10]); // Set variable equal to item in reader
                    permEditLocations = Convert.ToBoolean(permissionRDR[11]); // Set variable equal to item in reader
                    permDeleteLocations = Convert.ToBoolean(permissionRDR[12]); // Set variable equal to item in reader
                    permCreateTicket = Convert.ToBoolean(permissionRDR[13]); // Set variable equal to item in reader
                    permAdminTicket = Convert.ToBoolean(permissionRDR[14]); // Set variable equal to item in reader
                    permCloseTicket = Convert.ToBoolean(permissionRDR[15]); // Set variable equal to item in reader
                    permViewServerPass = Convert.ToBoolean(permissionRDR[16]); // Set variable equal to item in reader
                    permEditServerPass = Convert.ToBoolean(permissionRDR[17]); // Set variable equal to item in reader
                    permAddAction = Convert.ToBoolean(permissionRDR[18]); // Set variable equal to item in reader
                    permEditAction = Convert.ToBoolean(permissionRDR[19]); // Set variable equal to item in reader
                    permDeleteAction = Convert.ToBoolean(permissionRDR[20]); // Set variable equal to item in reader
                    permRunUpdate = Convert.ToBoolean(permissionRDR[21]); // Set variable equal to item in reader
                    permRunReboot = Convert.ToBoolean(permissionRDR[22]); // Set variable equal to item in reader
                    permAddServerNote = Convert.ToBoolean(permissionRDR[23]); // Set variable equal to item in reader
                    permRunCustomAction = Convert.ToBoolean(permissionRDR[24]); // Set variable equal to item in reader
                    permAdminViewUsers = Convert.ToBoolean(permissionRDR[25]); // Set variable equal to item in reader
                    permAdminEditUserInfo = Convert.ToBoolean(permissionRDR[26]); // Set variable equal to item in reader
                    permAdminForcePassReset = Convert.ToBoolean(permissionRDR[27]); // Set variable equal to item in reader
                    permAdminAddUser = Convert.ToBoolean(permissionRDR[28]); // Set variable equal to item in reader
                    permAdminDelUser = Convert.ToBoolean(permissionRDR[29]); // Set variable equal to item in reader
                    permAdminChangePermissions = Convert.ToBoolean(permissionRDR[30]); // Set variable equal to item in reader
                    permControlServers = Convert.ToBoolean(permissionRDR[31]); // Set variable equal to item in reader
                    permissionRDR.Close(); // Close reader

                    MySqlCommand companyCMD = new MySqlCommand("SELECT * FROM userCompanies WHERE companyID = @companyID", connectionMySQL);
                    companyCMD.Parameters.AddWithValue("@companyID", CompanyID); // Replace string in query with variable
                    MySqlDataReader companyRDR = companyCMD.ExecuteReader(); // Execute MySQL reader query
                    companyRDR.Read(); // Read data from the reader to become usable
                    CompanyName = Convert.ToString(companyRDR[2]); // Set variable equal to item in reader
                    companyRDR.Close(); // Close reader

                    Hide(); //Hide form

                    mainDashboard mainDashboardDisplay = new mainDashboard();
                    mainDashboardDisplay.ShowDialog();
                    Show();
                }
            }
            catch (Exception) 
            {
                System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                rdr.Close();
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
            connectionMySQL.Close();
        }
     
    }
}
