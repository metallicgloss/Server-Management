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
    public partial class manageLocationsDelete : Form
    {
        public manageLocationsDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            MySqlCommand locationCMD = new MySqlCommand("DELETE FROM serverLocations WHERE locationName = @locationName", conn); // Set MySQL query.
            locationCMD.Parameters.Add("@locationName", cmboExisting.Text);
            locationCMD.ExecuteNonQuery(); // Process query.
            conn.Close();

            // Something to update in the future, hidden ID variable as will delete multiple rows if the name is the same.
        }

        private void manageLocationsDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string sql = "SELECT * FROM serverLocations WHERE companyID = @companyID"; // Create a string with the query command to run.
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@companyID", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader rdr = cmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (rdr.Read())
            {
                cmboExisting.Items.Add(rdr.GetString("locationName"));
            }
            conn.Close();
            Hide();
        }
    }
}
