using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class userCreate : Form
    {
        public userCreate()
        {
            InitializeComponent();
        }

        public static string password, key;

        private void btnNewuser_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
           userCreate.password = loginMenu.EncryptString(txtPassword.Text, loginMenu.key, loginMenu.iv);



            MySqlCommand userInfoUpdateCMD = new MySqlCommand("INSERT INTO userAccounts (userForename, userSurname, userLogin, userPassword, userEmailAddress, userImage) VALUES (@userForename, @userSurname, @userLogin, @userPassword, @userEmailAddress, @userImage)", connectionMySQL);
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
