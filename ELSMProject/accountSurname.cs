using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class accountSurname : Form
    {
        public accountSurname()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void accountSurname_Load(object sender, EventArgs e)
        {
            txtCurrentSurname.Text = loginMenu.Surname;
        }

        private void btnChangeSurname_Click(object sender, EventArgs e)
        {
            if ((txtNewSurname.Text == txtConfirmSurname.Text) && (txtNewSurname.Text != ""))
            {
                MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection
                conn.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `userAccounts` SET userSurname = @Surname", conn);
                command.Parameters.AddWithValue("@Surname", txtNewSurname.Text);
                command.ExecuteNonQuery();
                loginMenu.Surname = txtNewSurname.Text;
                Hide(); //Hide form
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The data you have entered doesn't match or is blank. Please check your Surname and try again.");
            }

        }
    }
}
