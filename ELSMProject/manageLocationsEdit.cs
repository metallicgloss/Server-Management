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
    public partial class manageLocationsEdit : Form
    {
        public manageLocationsEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void manageLocationsEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string sql = "SELECT * FROM serverLocations WHERE companyID = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader(); // Execute MySQL reader query 
            while (rdr.Read()) // While rows in reader
            {
                cmboExisting.Items.Add(rdr.GetString("locationName"));
            }
            conn.Close();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            MySqlCommand locationCMD = new MySqlCommand("UPDATE serverLocations SET locationName = @locationName, locationLongitude = @locationLongitude, locationLatitude = @locationLatitude WHERE locationName = @oldLocationName", conn); 
            locationCMD.Parameters.AddWithValue("@locationName", txtLocationName.Text);
            locationCMD.Parameters.AddWithValue("@locationLongitude", txtLongitude.Text);
            locationCMD.Parameters.AddWithValue("@oldLocationName", cmboExisting.Text);
            locationCMD.Parameters.AddWithValue("@locationLatitude", txtLatitude.Text); 
            locationCMD.ExecuteNonQuery(); 
            txtLatitude.Text = "";
            txtLongitude.Text = "";
            txtLocationName.Text = "";
            string sql = "SELECT * FROM serverLocations WHERE companyID = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader(); // Execute MySQL reader query 
            while (rdr.Read()) // While rows in reader
            {
                cmboExisting.Items.Add(rdr.GetString("locationName"));
            }
            conn.Close();
        }

        private void LocationDetails(string name)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string sql = "SELECT * FROM serverLocations WHERE locationName = @locationName"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@locationName", name); 
            MySqlDataReader rdr = cmd.ExecuteReader(); // Execute MySQL reader query 
            while (rdr.Read()) // While rows in reader
            {
                if (!rdr.HasRows)
                    return;
                txtLocationName.Text = rdr.GetString("locationName").ToString();
                txtLongitude.Text = rdr.GetString("locationLongitude").ToString();
                txtLatitude.Text = rdr.GetString("locationLatitude").ToString();
            }
        }

        private void cmboExisting_SelectedIndexChanged(object sender, EventArgs e)
        {
            var locationName = Convert.ToString(cmboExisting.Text);
            LocationDetails(locationName);
        }
    }
    
}
