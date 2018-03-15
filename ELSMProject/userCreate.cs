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
            InitializeComponent();
        }

        public static string password, key;

        private void btnNewuser_Click(object sender, EventArgs e)
        {
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

        private void userCreate_Load(object sender, EventArgs e)
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();  
        }
    }
}
