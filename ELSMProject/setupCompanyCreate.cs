using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class setupCompanyCreate : Form
    {
        public setupCompanyCreate()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //If entered text isn't blank, insert new row into the database table userCompanies. Else, output messagebox.
            if (txtName.Text != "")
            {
                MySqlConnection connectionMySQL = new MySqlConnection(setupDatabase.ConnectionString);
                connectionMySQL.Open();
                MySqlCommand createCompany = new MySqlCommand("INSERT INTO userCompanies (companyName, ownerID) VALUES (@companyName, '1')", connectionMySQL);
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
