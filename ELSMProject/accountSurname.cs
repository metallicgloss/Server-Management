using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountSurname : Form
    {
        public accountSurname()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void accountSurname_Load(object sender, EventArgs e)
        {
            //Set the surname text box to the variable.
            txtCurrentSurname.Text = loginMenu.Surname;
        }

        private void btnChangeSurname_Click(object sender, EventArgs e)
        {
            //If the two new values are the same, and aren't blank execute.
            if ((txtNewSurname.Text == txtConfirmSurname.Text) && (txtNewSurname.Text != ""))
            {
                //Update user surname.
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userSurname = @Surname", conn);
                command.Parameters.AddWithValue("@Surname", txtNewSurname.Text);
                command.ExecuteNonQuery();
                loginMenu.Surname = txtNewSurname.Text;
                Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match or is blank. Please check your Surname and try again.");
            }

        }
    }
}
