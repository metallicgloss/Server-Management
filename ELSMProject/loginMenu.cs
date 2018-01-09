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

        public static string IPAddress, Forename, Surname, CompanyID, CompanyName, EmailAddress, ProfileImage, Role, UserID, Username, Password, externalIP;
        public static Boolean permChangePassword, permChangeUsername, permChangeEmail, permViewServers, permEditServers, permDeleteServers, permViewLocations, permEditLocations, permDeleteLocations, permCreateTicket, permAdminTicket, permCloseTicket, permViewServerPass, permEditServerPass, permAddAction, permEditAction, permDeleteAction, permRunUpdate, permRunReboot, permAddServerNote, permRunCustomAction, permAdminViewUsers, permAdminEditUserInfo, permAdminForcePassReset, permAdminAddUser, permAdminDelUser, permAdminChangePermissions, permControlServers;
        public static string ConnectionString = "SERVER=185.44.78.200;DATABASE=metallic_elsm_test;UID=metallic_testing;PASSWORD=zyRHxVhgdv8zTH2E53;"; 
        


        public loginMenu()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userLogin = txtUsername.Text; 
            var userPassword = txtPassword.Text; 
            var checkpointReached = false; 

            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string sql = "SELECT * FROM userAccounts WHERE userLogin = @userLogin"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userLogin", userLogin); 
            MySqlDataReader rdr = cmd.ExecuteReader(); 
            rdr.Read();
            
            try
            {
                var Valid = Convert.ToString(rdr[0]); 
                checkpointReached = true; 
            }
            catch (Exception) 
            {
                System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                txtUsername.Text = "";
                txtPassword.Text = "";
                rdr.Close();
                conn.Close();
            }
            if (checkpointReached == true) 
            {
                var databasePassword = Convert.ToString(rdr[2]); 
                loginMenu.UserID = Convert.ToString(rdr[0]);
                loginMenu.Username = Convert.ToString(rdr[1]);
                loginMenu.Password = Convert.ToString(rdr[2]);
                loginMenu.Forename = Convert.ToString(rdr[3]);
                loginMenu.Surname = Convert.ToString(rdr[4]);
                loginMenu.EmailAddress = Convert.ToString(rdr[5]);
                loginMenu.ProfileImage = Convert.ToString(rdr[6]);
                loginMenu.CompanyID = Convert.ToString(rdr[7]);
                loginMenu.Role = Convert.ToString(rdr[8]);
                conn.Close();
                String EnteredPassword = CodeShare.Cryptography.SHA.GenerateSHA512String(txtPassword.Text);

                rdr.Close();
                if (EnteredPassword != databasePassword) 
                {
                    System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    conn.Open();
                    MySqlCommand failedCMD = new MySqlCommand("INSERT INTO failedLoginAttempts (attemptUsername, attemptIP, attemptTimeStamp) VALUES (@attemptUsername, @attemptIP, @attemptTimeStamp)", conn); 
                    failedCMD.Parameters.AddWithValue("@attemptUsername", txtUsername.Text);
                    failedCMD.Parameters.AddWithValue("@attemptIP", loginMenu.IPAddress);
                    failedCMD.Parameters.AddWithValue("@attemptTimeStamp", DateTime.Now); 
                    failedCMD.ExecuteNonQuery(); 
                }
                else
                {
                    conn.Open();
                    MySqlCommand accountCMD = new MySqlCommand("UPDATE `userAccounts` SET userIPAddress = @attemptIP, userLastLogin = @attemptTimeStamp", conn); 
                    accountCMD.Parameters.AddWithValue("@attemptIP", ELSM_Project.loginMenu.IPAddress);
                    accountCMD.Parameters.AddWithValue("@attemptTimeStamp", DateTime.Now); 
                    accountCMD.ExecuteNonQuery(); 

                    MySqlCommand permissionCommand = new MySqlCommand("SELECT * FROM userPermissions WHERE permID = @permid", conn);
                    permissionCommand.Parameters.AddWithValue("@permid", Role);
                    MySqlDataReader permissionRDR = permissionCommand.ExecuteReader();
                    permissionRDR.Read();
                    permChangePassword = Convert.ToBoolean(permissionRDR[4]);
                    permChangeUsername = Convert.ToBoolean(permissionRDR[5]);
                    permChangeEmail = Convert.ToBoolean(permissionRDR[6]);
                    permViewServers = Convert.ToBoolean(permissionRDR[7]);
                    permEditServers = Convert.ToBoolean(permissionRDR[8]);
                    permDeleteServers = Convert.ToBoolean(permissionRDR[9]);
                    permViewLocations = Convert.ToBoolean(permissionRDR[10]);
                    permEditLocations = Convert.ToBoolean(permissionRDR[11]);
                    permDeleteLocations = Convert.ToBoolean(permissionRDR[12]);
                    permCreateTicket = Convert.ToBoolean(permissionRDR[13]);
                    permAdminTicket = Convert.ToBoolean(permissionRDR[14]);
                    permCloseTicket = Convert.ToBoolean(permissionRDR[15]);
                    permViewServerPass = Convert.ToBoolean(permissionRDR[16]);
                    permEditServerPass = Convert.ToBoolean(permissionRDR[17]);
                    permAddAction = Convert.ToBoolean(permissionRDR[18]);
                    permEditAction = Convert.ToBoolean(permissionRDR[19]);
                    permDeleteAction = Convert.ToBoolean(permissionRDR[20]);
                    permRunUpdate = Convert.ToBoolean(permissionRDR[21]);
                    permRunReboot = Convert.ToBoolean(permissionRDR[22]);
                    permAddServerNote = Convert.ToBoolean(permissionRDR[23]);
                    permRunCustomAction = Convert.ToBoolean(permissionRDR[24]);
                    permAdminViewUsers = Convert.ToBoolean(permissionRDR[25]);
                    permAdminEditUserInfo = Convert.ToBoolean(permissionRDR[26]);
                    permAdminForcePassReset = Convert.ToBoolean(permissionRDR[27]);
                    permAdminAddUser = Convert.ToBoolean(permissionRDR[28]);
                    permAdminDelUser = Convert.ToBoolean(permissionRDR[29]);
                    permAdminChangePermissions = Convert.ToBoolean(permissionRDR[30]);
                    permControlServers = Convert.ToBoolean(permissionRDR[31]);
                    permissionRDR.Close();

                    MySqlCommand companyCMD = new MySqlCommand("SELECT * FROM userCompanies WHERE companyID = @companyID", conn);
                    companyCMD.Parameters.AddWithValue("@companyID", CompanyID);
                    MySqlDataReader companyRDR = companyCMD.ExecuteReader();
                    companyRDR.Read();
                    CompanyName = Convert.ToString(companyRDR[2]);
                    conn.Close();
                    companyRDR.Close();

                    Hide(); //Hide form

                    mainDashboard loginMenu = new mainDashboard();
                    loginMenu.ShowDialog();

                    txtUsername.Text = "";
                    txtPassword.Text = "";

                    Show();
                }
            }
            conn.Close();
        }

        private void loginFRM_Load(object sender, EventArgs e)
        {
            externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches((new WebClient()).DownloadString("https://www.metallicgloss.com/functions/ip.php"))[0].ToString(); 
            loginMenu.IPAddress = externalIP;
        }        
    }
    public class Functions
    {
        public static string ShowSomeInfo(string text, int number)
        {
            return text + ": " + number.ToString();
        }
    }
}
