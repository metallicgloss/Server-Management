using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Hashing.PasswordManagement;

namespace ELSM_Project
{
    public partial class userCreate : Form
    {
        public userCreate()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        public static string password;

        private void userCreate_Load(object sender, EventArgs e)
        {
            //Connect to MySQL, run SQL command and output result of the field 'permRole' to cmboUserPerm.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand permCMD = new MySqlCommand("SELECT * FROM userPermissions", connectionMySQL);
            MySqlDataReader permRDR = permCMD.ExecuteReader();
            while (permRDR.Read())
            {
                cmboUserPerm.Items.Add(permRDR.GetString("permRole"));
            }
            connectionMySQL.Close();
        }

        private void btnNewuser_Click(object sender, EventArgs e)
        {
            //If a field required is blank, output error message informing the user that they need to enter data.
            if (txtForename.Text != "")
            {
                if (txtSurname.Text != "")
                {
                    if (txtUsername.Text != "")
                    {
                        if (txtEmailAddress.Text != "")
                        {
                            //Attempt to parse the address data into the format of an email address. If it fails & errors, output error message informing the user that they need to enter data.
                            try
                            {
                                var addr = new System.Net.Mail.MailAddress(txtEmailAddress.Text);
                                if (txtProfileImage.Text != "")
                                {
                                    //Connect to MySQL. Proceed with running an SQL command to get the ID of the role selected in the combo box, hash and salt the password entered and then inserting a field into the userAccounts table.
                                    MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
                                    connectionMySQL.Open();
                                    userCreate.password = SHA.GenerateSHA512String(loginMenu.userSalt + txtPassword.Text);
                                    MySqlCommand permRoleCMD = new MySqlCommand("SELECT permID, permRole FROM userPermissions WHERE permRole = @permRole", connectionMySQL);
                                    permRoleCMD.Parameters.AddWithValue("@permRole", cmboUserPerm.Text);
                                    MySqlDataReader permRDR = permRoleCMD.ExecuteReader();
                                    permRDR.Read();
                                    string permID = Convert.ToString(permRDR.GetString("permID"));
                                    permRDR.Close();
                                    MySqlCommand userInfoUpdateCMD = new MySqlCommand("INSERT INTO userAccounts (userForename, userSurname, userLogin, userPassword, userEmailAddress, userImage, userCompany, userRole) VALUES (@userForename, @userSurname, @userLogin, @userPassword, @userEmailAddress, @userImage, @userCompany, @userPerm)", connectionMySQL);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }
    }
}