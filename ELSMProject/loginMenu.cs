using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using CodeShare.Cryptography;

namespace ELSM_Project
{
    public partial class loginMenu : Form
    {

        public static string IPAddress, Forename, Surname, CompanyID, CompanyName, EmailAddress, ProfileImage, Role, UserID, Username, Password, externalIP, userLogin, userPassword;
        public static Boolean permChangePassword, permChangeUsername, permChangeEmail, permViewServers, permEditServers, permDeleteServers, permViewLocations, permEditLocations, permDeleteLocations, permCreateTicket, permAdminTicket, permCloseTicket, permViewServerPass, permEditServerPass, permAddAction, permEditAction, permDeleteAction, permRunUpdate, permRunReboot, permAddServerNote, permRunCustomAction, permAdminViewUsers, permAdminEditUserInfo, permAdminForcePassReset, permAdminAddUser, permAdminDelUser, permAdminChangePermissions, permControlServers, checkpointReached, permManageBackupSystem;
        public static string ConnectionString;
        public static SHA256 mySHA256 = SHA256Managed.Create();
        public static string userSalt = "pFMQk3VmLdES6rw9bzJFyrh2422cyZCpWT9nzNxBAZEKWgc7vnbhFLxPsp4hcYX2FWRQtRVQm6quQ2EtvkgRs9kZjB4pTPvmMGMgZqFFggxUG5TzXGtMHKP7F9svCXnjkTpxyudQVLgKr77UnUwEauLpu9ybmaDyuZpjW95dT5ReE5qU4s68jC8sbtZNda2s8rZ2RdA3Lcyfkmqh5EMjFZsZXD9kFRFvhkwGFD2Y6NJwNy3RxBMkW6b8qjnhe7uNNQUv7rL6eMWUWDytZBgwP4DbX9XxDpuJHPFtxzvTLh6rrrFzmKcBy8hCspcPnGDwkShr8A48yKWtMHpdCv85BJajFJtyEXWjkGfpLeWNT3dLBT6RRadvxRv5u25tvdB8LE56y2468xLhpCDSmxWFNfACnHmkZY2MSKeChJDwNjss27yY8vqLmmmWGf2L6wgUuXngPTLRnAU6jnajF3ZgqsP9G6JutgHmnYxJDJ6rNg5Zwc7hNzFZwnZ6w2eDYTgvzQVW2vWBhnwCbhTz2KRX5uj63buW7HEun8KWzfYdCQQWazLHGL5KxE4aggQWKnD8Dr5Z23rptegS7n3YN5gwkxKnt5VwxWgtUBLcsGdjP3bdZF94ZHZV7yvkvj8n6PPuqHzyWxp6FD2bt6ZkEeAaUhsHwLKqHpntYdPwRN84NvscqzrWtDV3n39KudrJtc5y42gfNR44XCT4Jp2PW3rPcDg7NY2tjBtt4ANe4zRq8v83sa99s6sxmWgSaT4MnrqTgMGs2CuvJYn9RWh5gBzTdeG4nnEuNhpnfBjLPQCu6B3hB2qM3hNvVKzBsu56E2YyNPtSKvrXMXdNafsPDkpSUYjY2qjvfYfa2SYY34j3rVGdCHWBsH5sq2tVFJHEzjqWwy8UVchGpUauJeMrh7F4E9M9dR6ak5JvLaCcYcLPBq3fWn3NETrHWSY58T4WpNzMc2BuMC4hDQeuQfZjSXuHfyZk6mTU69Z2dpd7emB2TRZ8LYV3Bg6zczdUpWXsJ96A";
        public static byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes("rh6Pe7nMdT1ZdoSCbJVEB7xjl4yKKRNtpy4xeePlf60pZrauG8ZQkCFfikN7NJ5yvWhS5zHDK4PbwNeXT1bj67fvI6Ad7rOtCeEA")); // Change the string of text when compiling for a different encryption key. Built directly into the program so the end user configuring the software is not likely to ever see it.
        public static byte[] iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };


        public loginMenu()
        {
            InitializeComponent();
        }


        private void loginFRM_Load(object sender, EventArgs e)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches((new WebClient()).DownloadString("http://www.metallicgloss.com/functions/ip.php"))[0].ToString();
            loginMenu.IPAddress = externalIP;

            XmlDocument doc = new XmlDocument();
            doc.Load("setup.xml");
            string Setup = doc.SelectSingleNode("Settings/Setup").InnerText;
            if (Setup == "No")
            {
                Hide();
                setupDatabase setupDatabaseFRM = new setupDatabase();
                setupDatabaseFRM.ShowDialog();
            }

            string IP = doc.SelectSingleNode("Settings/IP").InnerText;
            string DATABASE = doc.SelectSingleNode("Settings/Database").InnerText;
            string UID = doc.SelectSingleNode("Settings/Username").InnerText;
            string PASSWORD = doc.SelectSingleNode("Settings/Password").InnerText;
            ConnectionString = "SERVER=" + IP + ";DATABASE=" + DATABASE + ";UID=" + UID + ";PASSWORD=" + PASSWORD + ";";

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            userLogin = txtUsername.Text; 
            userPassword = txtPassword.Text; 
            checkpointReached = false;
            if ((userLogin != "") || (userPassword != "")) {
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

                    String EnteredPassword = SHA.GenerateSHA512String(loginMenu.userSalt + txtPassword.Text); // Encrypt Password

                    rdr.Close(); // Close reader
                    if (EnteredPassword != databasePassword)
                    {
                        System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                        MySqlCommand failedCMD = new MySqlCommand("INSERT INTO failedLoginAttempts (attemptUsername, attemptIP, attemptTimeStamp) VALUES (@attemptUsername, @attemptIP, @attemptTimeStamp)", connectionMySQL);
                        failedCMD.Parameters.AddWithValue("@attemptUsername", txtUsername.Text); // Replace string in query with variable
                        failedCMD.Parameters.AddWithValue("@attemptIP", loginMenu.IPAddress); // Replace string in query with variable
                        failedCMD.Parameters.AddWithValue("@attemptTimeStamp", DateTime.Now); // Replace string in query with variable
                        failedCMD.ExecuteNonQuery();
                    }
                    else
                    {
                        MySqlCommand accountCMD = new MySqlCommand("UPDATE `userAccounts` SET userIPAddress = @attemptIP, userLastLogin = @attemptTimeStamp", connectionMySQL);
                        accountCMD.Parameters.AddWithValue("@attemptIP", loginMenu.IPAddress); // Replace string in query with variable
                        accountCMD.Parameters.AddWithValue("@attemptTimeStamp", DateTime.Now); // Replace string in query with variable
                        accountCMD.ExecuteNonQuery();

                        MySqlCommand permissionCommand = new MySqlCommand("SELECT * FROM userPermissions WHERE permID = @permid", connectionMySQL);
                        permissionCommand.Parameters.AddWithValue("@permid", Role); // Replace string in query with variable
                        MySqlDataReader permissionRDR = permissionCommand.ExecuteReader(); // Execute MySQL reader query
                        permissionRDR.Read(); // Read data from the reader to become usable
                        loginMenu.Role = Convert.ToString(permissionRDR[1]); // Set variable equal to item in reader
                        permChangePassword = Convert.ToBoolean(permissionRDR[3]); // Set variable equal to item in reader
                        permChangeUsername = Convert.ToBoolean(permissionRDR[4]); // Set variable equal to item in reader
                        permChangeEmail = Convert.ToBoolean(permissionRDR[5]); // Set variable equal to item in reader
                        permViewServers = Convert.ToBoolean(permissionRDR[6]); // Set variable equal to item in reader
                        permEditServers = Convert.ToBoolean(permissionRDR[7]); // Set variable equal to item in reader
                        permDeleteServers = Convert.ToBoolean(permissionRDR[8]); // Set variable equal to item in readerv
                        permViewLocations = Convert.ToBoolean(permissionRDR[9]); // Set variable equal to item in reader
                        permEditLocations = Convert.ToBoolean(permissionRDR[10]); // Set variable equal to item in reader
                        permDeleteLocations = Convert.ToBoolean(permissionRDR[11]); // Set variable equal to item in reader
                        permCreateTicket = Convert.ToBoolean(permissionRDR[12]); // Set variable equal to item in reader
                        permAdminTicket = Convert.ToBoolean(permissionRDR[13]); // Set variable equal to item in reader
                        permCloseTicket = Convert.ToBoolean(permissionRDR[14]); // Set variable equal to item in reader
                        permAddAction = Convert.ToBoolean(permissionRDR[15]); // Set variable equal to item in reader
                        permEditAction = Convert.ToBoolean(permissionRDR[16]); // Set variable equal to item in reader
                        permDeleteAction = Convert.ToBoolean(permissionRDR[17]); // Set variable equal to item in reader
                        permRunCustomAction = Convert.ToBoolean(permissionRDR[18]); // Set variable equal to item in reader
                        permAdminViewUsers = Convert.ToBoolean(permissionRDR[19]); // Set variable equal to item in reader
                        permAdminEditUserInfo = Convert.ToBoolean(permissionRDR[20]); // Set variable equal to item in reader
                        permAdminForcePassReset = Convert.ToBoolean(permissionRDR[21]); // Set variable equal to item in reader
                        permAdminAddUser = Convert.ToBoolean(permissionRDR[22]); // Set variable equal to item in reader
                        permAdminDelUser = Convert.ToBoolean(permissionRDR[23]); // Set variable equal to item in reader
                        permAdminChangePermissions = Convert.ToBoolean(permissionRDR[24]); // Set variable equal to item in reader
                        permControlServers = Convert.ToBoolean(permissionRDR[25]); // Set variable equal to item in reader
                        permManageBackupSystem = Convert.ToBoolean(permissionRDR[26]); // Set variable equal to item in reader
                        permissionRDR.Close(); // Close reader

                        MySqlCommand companyCMD = new MySqlCommand("SELECT * FROM userCompanies WHERE companyID = @companyID", connectionMySQL);
                        companyCMD.Parameters.AddWithValue("@companyID", CompanyID); // Replace string in query with variable
                        MySqlDataReader companyRDR = companyCMD.ExecuteReader(); // Execute MySQL reader query
                        companyRDR.Read(); // Read data from the reader to become usable
                        CompanyName = Convert.ToString(companyRDR[2]); // Set variable equal to item in reader
                        companyRDR.Close(); // Close reader



                        Hide(); //Hide form
                        try
                        {
                            mainDashboard mainDashboardDisplay = new mainDashboard();
                            mainDashboardDisplay.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
                        }
                        Show();
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Login Denied. The username or password you have entered do not match any account we have on record.");
                    rdr.Close();
                }
                txtUsername.Text = "";
                txtPassword.Text = "";
                connectionMySQL.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The username or password cannot be blank.");

            }
            
        }

        //Encrypt password so that it can be decrypted again.
        public static string EncryptString(string plainText, byte[] key, byte[] iv)
        {
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;
            encryptor.Key = key;
            encryptor.IV = iv;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
            return cipherText;
        }

        //Decript string function for SSH login.
        public static string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            Aes encryptor = Aes.Create();
            encryptor.Mode = CipherMode.CBC;
            encryptor.Key = key;
            encryptor.IV = iv;
            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);
            string plainText = String.Empty;
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] plainBytes = memoryStream.ToArray();
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                memoryStream.Close();
                cryptoStream.Close();
            }
            return plainText;
        }

    }
}
namespace CodeShare.Cryptography
{
    public static class SHA
    {

        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

    }
}
