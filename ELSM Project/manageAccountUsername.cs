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

namespace ELSM_Project
{
    public partial class manageAccountUsername : Form
    {
        public manageAccountUsername()
        {
            InitializeComponent();
        }

        private void manageAccountUsername_Load(object sender, EventArgs e)
        {
            txtCurrentUsername.Text = loginMenu.Username;
        }

        private void manageAccountUsername_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if (txtNewUsername.Text == txtConfirmNewUsername.Text)
            {
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userLogin = @newUsername", conn);
                command.Parameters.Add("@newUsername", txtNewUsername.Text);
                command.ExecuteNonQuery();
                Hide();
                manageAccount Account = new manageAccount();
                Account.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your username and try again.");
            }
        }
    }
}
