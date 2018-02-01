using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class createCompany : Form
    {
        public createCompany()
        {
            InitializeComponent();
        }
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(initialSetup.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open(); // Open MySQL connection
            MySqlCommand createCompany = new MySqlCommand("INSERT INTO userCompanies (companyName, OwnerID) VALUES (@companyName, '1')", connectionMySQL);
            createCompany.Parameters.AddWithValue("@companyName", txtName.Text);
            createCompany.ExecuteNonQuery();
            connectionMySQL.Close();

            Hide();
            createUser user = new createUser();
            user.ShowDialog();
        }
    }
}
