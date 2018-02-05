using System;
using System.Windows.Forms;
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
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            MySqlCommand locationCMD = new MySqlCommand("INSERT INTO serverLocations (locationName, companyID, locationLongitude, locationLatitude) VALUES (@locationName, @companyID, @locationLongitude, @locationLatitude)", conn); 
            locationCMD.Parameters.AddWithValue("@locationName", txtLocationName.Text);
            locationCMD.Parameters.AddWithValue("@locationLongitude", txtLongitude.Text);
            locationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            locationCMD.Parameters.AddWithValue("@locationLatitude", txtLatitude.Text); 
            locationCMD.ExecuteNonQuery(); 
            conn.Close();
            txtLatitude.Text = "";
            txtLongitude.Text = "";
            txtLocationName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void manageLocationsCreate_Load(object sender, EventArgs e)
        {

        }
    }
}
