using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class userEdit : Form
    {
        public userEdit()
        {
            InitializeComponent();
        }

        public static string password, key;


        private void manageusersEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand userCMD = new MySqlCommand("SELECT * FROM userInformation", connectionMySQL);
            MySqlDataReader userRDR = userCMD.ExecuteReader(); // Execute MySQL reader query 
            while (userRDR.Read()) // While rows in reader
            {
                cmboUserID.Items.Add(userRDR.GetString("userHostname"));
            }
            userRDR.Close();
            connectionMySQL.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand userInformationCMD = new MySqlCommand("SELECT * FROM userInformation WHERE userCompany = @userCompany", connectionMySQL);
            userInformationCMD.Parameters.AddWithValue("@userCompany", loginMenu.CompanyID);
            MySqlDataReader userInformationRDR = userInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            userInformationRDR.Read(); // Read data from the reader to become usable

            txtUsername.Text = Convert.ToString(userInformationRDR[1]);
            userEdit.password = Convert.ToString(userInformationRDR[2]);
            txtForename.Text = Convert.ToString(userInformationRDR[3]);
            txtSurname.Text = Convert.ToString(userInformationRDR[4]);
            txtEmailAddress.Text = Convert.ToString(userInformationRDR[5]);
            txtProfileImage.Text = Convert.ToString(userInformationRDR[6]);
            userInformationRDR.Close();

            connectionMySQL.Close();
            txtUsername.Enabled = true;
            txtForename.Enabled = true;
            txtSurname.Enabled = true;
            txtPassword.Enabled = true;
            txtEmailAddress.Enabled = true;
            txtProfileImage.Enabled = true;
            txtPassword.Cursor = Cursors.Hand;
            txtForename.Cursor = Cursors.Hand;
            txtEmailAddress.Cursor = Cursors.Hand;
            txtProfileImage.Cursor = Cursors.Hand;
            txtSurname.Cursor = Cursors.Hand;
            txtUsername.Cursor = Cursors.Hand;
        }

        private void btnNewuser_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            if (txtPassword.Text == "")
            {
                var password = userEdit.password;
            }
            else
            {
                var password = txtPassword.Text;
                password = CodeShare.Cryptography.SHA.GenerateSHA512String(password);
            }



            MySqlCommand userInfoUpdateCMD = new MySqlCommand("UPDATE userInformation SET userForename = @userForename, userSurname = @userSurname, userLogin = @userLogin, userPassword = @userPassword, userEmailAddress = @userEmailAddress, userImage = @userImage WHERE userID = @userID", connectionMySQL);
            userInfoUpdateCMD.Parameters.AddWithValue("@userID", cmboUserID.Text);
            userInfoUpdateCMD.Parameters.AddWithValue("@userForename", txtForename.Text);
            userInfoUpdateCMD.Parameters.AddWithValue("@userSurname", txtSurname.Text);
            userInfoUpdateCMD.Parameters.AddWithValue("@userLogin", txtUsername.Text);
            userInfoUpdateCMD.Parameters.AddWithValue("@userPassword", password);
            userInfoUpdateCMD.Parameters.AddWithValue("@userEmailAddress", txtEmailAddress.Text);
            userInfoUpdateCMD.Parameters.AddWithValue("@userImage", txtProfileImage.Text);
            userInfoUpdateCMD.ExecuteNonQuery();

            connectionMySQL.Close();

            Hide(); //Hide form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }
    }
}
