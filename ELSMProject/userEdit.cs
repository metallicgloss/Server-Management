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

        public static string password, key;


        private void manageusersEdit_Load(object sender, EventArgs e)
        {
            if (loginMenu.permAdminForcePassReset == false)
            {
                txtPassword.Enabled = false;
            }
            if (loginMenu.permAdminChangePermissions == false)
            {
                cmboUserPerm.Enabled = false;
            }
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand userCMD = new MySqlCommand("SELECT * FROM userAccounts", connectionMySQL);
            MySqlDataReader userRDR = userCMD.ExecuteReader();
            while (userRDR.Read())
            {
                cmboUserID.Items.Add(userRDR.GetString("userID"));
            }
            userRDR.Close();
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
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand userAccountsCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userID = @userID", connectionMySQL);
            userAccountsCMD.Parameters.AddWithValue("@userID", cmboUserID.Text);
            MySqlDataReader userAccountsRDR = userAccountsCMD.ExecuteReader();
            userAccountsRDR.Read();
            txtUsername.Text = Convert.ToString(userAccountsRDR[1]);
            userEdit.password = Convert.ToString(userAccountsRDR[2]);
            txtForename.Text = Convert.ToString(userAccountsRDR[3]);
            txtSurname.Text = Convert.ToString(userAccountsRDR[4]);
            txtEmailAddress.Text = Convert.ToString(userAccountsRDR[5]);
            txtProfileImage.Text = Convert.ToString(userAccountsRDR[6]);
            cmboUserPerm.Text = Convert.ToString(userAccountsRDR[8]);
            userAccountsRDR.Close();
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
                                try
                                {
                                    var addr = new System.Net.Mail.MailAddress(txtEmailAddress.Text);
                                    if (txtProfileImage.Text != "")
                                    {
                                        MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
                                        connectionMySQL.Open();
                                        string tmppassword;
                                        if (txtPassword.Text == "")
                                        {
                                            tmppassword = userEdit.password;
                                        }
                                        else
                                        {
                                            tmppassword = txtPassword.Text;
                                            userEdit.password = SHA.GenerateSHA512String(loginMenu.userSalt + tmppassword);
                                        }
                                        MySqlCommand permRoleCMD = new MySqlCommand("SELECT permID, permRole FROM userPermissions WHERE permRole = @permRole", connectionMySQL);
                                        permRoleCMD.Parameters.AddWithValue("@permRole", cmboUserPerm.Text);
                                        MySqlDataReader permRDR = permRoleCMD.ExecuteReader();
                                        permRDR.Read();
                                        string permID = Convert.ToString(permRDR.GetString("permID"));
                                        permRDR.Close();
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