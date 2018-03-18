using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class userDelete : Form
    {
        public userDelete()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void manageUsersDelete_Load(object sender, EventArgs e)
        {
			//Connect to MySQL and set output as items of cmboUserID.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand UserInformationCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userCompany = @companyID", connectionMySQL);
            UserInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader UserInformationRDR = UserInformationCMD.ExecuteReader();
            while (UserInformationRDR.Read())
            {
                cmboUserID.Items.Add(UserInformationRDR.GetString("userID"));
            }
            connectionMySQL.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
			//Delete row from userAccounts where userID matches selected.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand deleteUserCMD = new MySqlCommand("DELETE FROM userAccounts WHERE userID = @userID", connectionMySQL);
            deleteUserCMD.Parameters.AddWithValue("@userID", cmboUserID.Text);
            deleteUserCMD.ExecuteNonQuery();
            cmboUserID.Items.Clear();
			//Update information. Connect to MySQL and set output as items of cmboUserID.
            MySqlCommand UserInformationCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userCompany = @companyID", connectionMySQL);
            UserInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader UserInformationRDR = UserInformationCMD.ExecuteReader();
            while (UserInformationRDR.Read())
            {
                cmboUserID.Items.Add(UserInformationRDR.GetString("userID"));
            }
            connectionMySQL.Close();
        }
    }
}
