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
    public partial class manageLocationsCreate : Form
    {
        public manageLocationsCreate()
        {
            InitializeComponent();
        }

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            MySqlCommand locationCMD = new MySqlCommand("INSERT INTO serverLocations (locationName, companyID, locationLongitude, locationLatitude) VALUES (@locationName, @companyID, @locationLongitude, @locationLatitude)", conn); // Set MySQL query.
            locationCMD.Parameters.Add("@locationName", txtLocationName.Text);
            locationCMD.Parameters.Add("@locationLongitude", txtLongitude.Text);
            locationCMD.Parameters.Add("@companyID", loginMenu.CompanyID);
            locationCMD.Parameters.Add("@locationLatitude", txtLatitude.Text); // Replace text in string with variables.
            locationCMD.ExecuteNonQuery(); // Process query.
            conn.Close();
            txtLatitude.Text = "";
            txtLongitude.Text = "";
            txtLocationName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
