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
using System.Security.Cryptography;
using CodeShare.Cryptography;


namespace ELSM_Project
{

    public partial class manageAccountPassword : Form
    {
        public manageAccountPassword()
        {
            InitializeComponent();
        }

        private void manageAccountPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String Currentpassword = SHA.GenerateSHA512String(txtCurrentPassword.Text);
            String NewPassword = SHA.GenerateSHA512String(txtNewPassword.Text);
            if (Currentpassword == loginMenu.Password)
            {
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userPassword = @pass", conn);
                command.Parameters.Add("@pass", NewPassword);
                command.ExecuteNonQuery();
                Hide();
                manageAccount Account = new manageAccount();
                Account.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your email address and try again.");
            }
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
