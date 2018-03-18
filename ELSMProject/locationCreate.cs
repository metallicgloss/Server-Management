using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class locationCreate : Form
    {
        public locationCreate()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            //If input is blank, output messagebox error informing the user that the field is blank.
            if (txtLocationName.Text != "")
            {
                if (txtLongitude.Text != "")
                {
                    if (txtLatitude.Text != "")
                    {
                        //Insert row into the database with the new location information.
                        MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
                        conn.Open();
                        MySqlCommand locationCMD = new MySqlCommand("INSERT INTO serverLocations (locationName, companyID, locationLongitude, locationLatitude) VALUES (@locationName, @companyID, @locationLongitude, @locationLatitude)", conn);
                        locationCMD.Parameters.AddWithValue("@locationName", txtLocationName.Text);
                        locationCMD.Parameters.AddWithValue("@locationLongitude", txtLongitude.Text);
                        locationCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
                        locationCMD.Parameters.AddWithValue("@locationLatitude", txtLatitude.Text);
                        locationCMD.ExecuteNonQuery();
                        conn.Close();
                        System.Windows.Forms.MessageBox.Show("Location Created.");
                        Hide();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }
    }
}