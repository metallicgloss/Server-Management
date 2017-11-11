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
    public partial class manageAccountEmail : Form
    {
        public manageAccountEmail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void manageAccountEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void manageAccountEmail_Load(object sender, EventArgs e)
        {
            txtCurrentEmail.Text = loginMenu.EmailAddress;
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            if (txtNewEmail.Text == txtConfirmEmail.Text)
            {
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userEmailAddress = @email", conn);
                command.Parameters.Add("@attemptIP", txtNewEmail.Text);
                command.ExecuteNonQuery();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match. Please check your email address and try again.");
            }
            
        }
    }
}
