using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class setupCompanyCreate : Form
    {
        public setupCompanyCreate()
        {
            InitializeComponent();
        }
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                MySqlConnection connectionMySQL = new MySqlConnection(setupDatabase.ConnectionString); // Open MySQL connection 
                connectionMySQL.Open(); // Open MySQL connection
                MySqlCommand createCompany = new MySqlCommand("INSERT INTO userCompanies (companyName, OwnerID) VALUES (@companyName, '1')", connectionMySQL);
                createCompany.Parameters.AddWithValue("@companyName", txtName.Text);
                createCompany.ExecuteNonQuery();
                connectionMySQL.Close();

                Hide();
                setupUserCreate user = new setupUserCreate();
                user.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter data into the form.");
            }
        }
    }
}
