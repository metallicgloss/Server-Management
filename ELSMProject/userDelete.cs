﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class userDelete : Form
    {
        public userDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void manageUsersDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand UserInformationCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userCompany = @companyID", connectionMySQL);
            UserInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader UserInformationRDR = UserInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            while (UserInformationRDR.Read()) // While rows in reader
            {
                cmboUserID.Items.Add(UserInformationRDR.GetString("userID"));
            }
            connectionMySQL.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            MySqlCommand deleteUserCMD = new MySqlCommand("DELETE FROM userAccounts WHERE userID = @userID", connectionMySQL);
            deleteUserCMD.Parameters.AddWithValue("@userID", cmboUserID.Text);
            deleteUserCMD.ExecuteNonQuery();
            cmboUserID.Items.Clear();

            MySqlCommand UserInformationCMD = new MySqlCommand("SELECT * FROM userAccounts WHERE userCompany = @companyID", connectionMySQL);
            UserInformationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader UserInformationRDR = UserInformationCMD.ExecuteReader(); // Execute MySQL reader query 
            while (UserInformationRDR.Read()) // While rows in reader
            {
                cmboUserID.Items.Add(UserInformationRDR.GetString("userID"));
            }
            connectionMySQL.Close();
        }

        private void cmboHostname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
