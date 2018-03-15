using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountForename : Form
    {
        public accountForename()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void accountForename_Load(object sender, EventArgs e)
        {
            txtCurrentForename.Text = loginMenu.Forename;
        }

        private void btnChangeForename_Click(object sender, EventArgs e)
        {
            if ((txtNewForename.Text == txtConfirmForename.Text) && (txtNewForename.Text != ""))
            {
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userForename = @Forename", conn);
                command.Parameters.AddWithValue("@Forename", txtNewForename.Text);
                command.ExecuteNonQuery();
                loginMenu.Forename = txtNewForename.Text;
                Hide(); //Hide form
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match and not blank. Please check your forename field and try again.");
            }

        }
    }
}
