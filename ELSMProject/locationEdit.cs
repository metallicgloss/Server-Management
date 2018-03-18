﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class locationEdit : Form
    {
        public locationEdit()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();  
        }

        private void manageLocationsEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            string sql = "SELECT * FROM serverLocations WHERE companyID = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader();      
            while (rdr.Read())     
            {
                cmboExisting.Items.Add(rdr.GetString("locationName"));
            }
            conn.Close();
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            if (txtLocationName.Text != "")
            {
                if (txtLongitude.Text != "")
                {
                    if (txtLatitude.Text != "")
                    {
                        MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
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
            MySqlDataReader rdr = cmd.ExecuteReader();      
            while (rdr.Read())     
            {
                cmboExisting.Items.Add(rdr.GetString("locationName"));
            }
            conn.Close();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("The latitude is blank. Please enter data.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The longitude entered is blank. Please enter data.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Your location name is blank.");
            }
        }

        private void LocationDetails(string name)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            string sql = "SELECT * FROM serverLocations WHERE locationName = @locationName"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@locationName", name); 
            MySqlDataReader rdr = cmd.ExecuteReader();      
            while (rdr.Read())     
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
