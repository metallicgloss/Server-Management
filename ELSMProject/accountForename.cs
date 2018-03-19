using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountForename : Form
    {
        public accountForename()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void accountForename_Load(object sender, EventArgs e)
        {
            //Set the forename text box to the variable.
            txtCurrentForename.Text = loginMenu.Forename;
        }

        private void btnChangeForename_Click(object sender, EventArgs e)
        {
            //If the two new values are the same, and aren't blank execute.
            if ((txtNewForename.Text == txtConfirmForename.Text) && (txtNewForename.Text != ""))
            {
                //Update user forename.
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userForename = @Forename", conn);
                command.Parameters.AddWithValue("@Forename", txtNewForename.Text);
                command.ExecuteNonQuery();
                loginMenu.Forename = txtNewForename.Text;
                Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match and not blank. Please check your forename field and try again.");
            }
        }
    }
}
