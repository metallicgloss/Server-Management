using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hashing.PasswordManagement;

namespace ELSM_Project
{
    public partial class userEdit : Form
    {
        public userEdit()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        public static string password;


        private void manageusersEdit_Load(object sender, EventArgs e)
        {
            //Initialize permissions by using boolean variables on the loginMenu form to disable buttons if the permission is not granted.
            if (loginMenu.permAdminForcePassReset == false)
            {
                txtPassword.Enabled = false;
            }
            if (loginMenu.permAdminChangePermissions == false)
            {
                cmboUserPerm.Enabled = false;
            }
			//Connect to MySQL, execute SQL and set output as items of cmboUserID.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand userCMD = new MySqlCommand("SELECT * FROM userAccounts", connectionMySQL);
            MySqlDataReader userRDR = userCMD.ExecuteReader();
            while (userRDR.Read())
            {
                cmboUserID.Items.Add(userRDR.GetString("userID"));
            }
            userRDR.Close();
			//Connect to MySQL, execute SQL and set output as items of cmboUserPerm.
            MySqlCommand permCMD = new MySqlCommand("SELECT * FROM userPermissions", connectionMySQL);
            MySqlDataReader permRDR = permCMD.ExecuteReader();
            while (permRDR.Read())
            {
                cmboUserPerm.Items.Add(permRDR.GetString("permRole"));
            }
            connectionMySQL.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
			//Connect to MySQL and execute SQL command.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand userAccountsCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userID = @userID", connectionMySQL);
            userAccountsCMD.Parameters.AddWithValue("@userID", cmboUserID.Text);
            MySqlDataReader userAccountsRDR = userAccountsCMD.ExecuteReader();
            userAccountsRDR.Read();
			//Set text boxes to display content from the output of userAccounts.
            txtUsername.Text = Convert.ToString(userAccountsRDR[1]);
            userEdit.password = Convert.ToString(userAccountsRDR[2]);
            txtForename.Text = Convert.ToString(userAccountsRDR[3]);
            txtSurname.Text = Convert.ToString(userAccountsRDR[4]);
            txtEmailAddress.Text = Convert.ToString(userAccountsRDR[5]);
            txtProfileImage.Text = Convert.ToString(userAccountsRDR[6]);
            cmboUserPerm.Text = Convert.ToString(userAccountsRDR[8]);
            userAccountsRDR.Close();
			//Execute SQL command to get the role name that matches the permission ID from last SQL query.
            MySqlCommand permCMD = new MySqlCommand("SELECT * FROM userPermissions WHERE permID = @permID", connectionMySQL);
            permCMD.Parameters.AddWithValue("@permID", cmboUserPerm.Text);
            MySqlDataReader permRDR = permCMD.ExecuteReader();
            permRDR.Read();
            cmboUserPerm.Text = Convert.ToString(permRDR[1]);
            permRDR.Close();
            connectionMySQL.Close();
        }

        private void btnNewuser_Click(object sender, EventArgs e)
        {
			//If text entered is blank, output message box informing user of no data entered.
            if (cmboUserID.Text != "")
            {
                if (txtForename.Text != "")
                {
                    if (txtSurname.Text != "")
                    {
                        if (txtUsername.Text != "")
                        {
                            if (txtEmailAddress.Text != "")
                            {
								//Attempt to parse txtEmailAddress into email format. If failed and errored, output message box informing user of incorrectly formatted email.
                                try
                                {
                                    var addr = new System.Net.Mail.MailAddress(txtEmailAddress.Text);
                                    if (txtProfileImage.Text != "")
                                    {
										//Connec to MySQL, if password is blank use data already entered, else use password entered after hash and salt.
                                        MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
                                        connectionMySQL.Open();
                                        if (txtPassword.Text == "")
                                        {
                                            userEdit.password = userEdit.password;
                                        }
                                        else
                                        {
                                            userEdit.password = SHA.GenerateSHA512String(loginMenu.userSalt + txtPassword.Text);
                                        }
										//Execute SQL to get the ID of the permission group selected.
                                        MySqlCommand permRoleCMD = new MySqlCommand("SELECT permID, permRole FROM userPermissions WHERE permRole = @permRole", connectionMySQL);
                                        permRoleCMD.Parameters.AddWithValue("@permRole", cmboUserPerm.Text);
                                        MySqlDataReader permRDR = permRoleCMD.ExecuteReader();
                                        permRDR.Read();
                                        string permID = Convert.ToString(permRDR.GetString("permID"));
                                        permRDR.Close();
										//Execute SQL to update user account details in table userAccounts.
                                        MySqlCommand userInfoUpdateCMD = new MySqlCommand("UPDATE userAccounts SET userForename = @userForename, userSurname = @userSurname, userLogin = @userLogin, userPassword = @userPassword, userEmailAddress = @userEmailAddress, userImage = @userImage WHERE userID = @userID", connectionMySQL);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userID", cmboUserID.Text);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userForename", txtForename.Text);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userSurname", txtSurname.Text);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userLogin", txtUsername.Text);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userPassword", password);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userEmailAddress", txtEmailAddress.Text);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userImage", txtProfileImage.Text);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userCompany", loginMenu.CompanyID);
                                        userInfoUpdateCMD.Parameters.AddWithValue("@userPerm", permID);
                                        userInfoUpdateCMD.ExecuteNonQuery();
                                        connectionMySQL.Close();
                                        Hide();
                                    }
                                    else
                                    {
                                        System.Windows.Forms.MessageBox.Show("Please enter a valid profile photo link.");
                                    }
                                }
                                catch
                                {
                                    System.Windows.Forms.MessageBox.Show("You must enter an email address in the correct format.");
                                }
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Please enter an email address.");
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please enter a username.");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Please enter a surname.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a forename.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select a user.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }
    }
}