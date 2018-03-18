using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class locationDelete : Form
    {
        public locationDelete()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            //Delete row from table serverLocations where the locationName matches the one that has been set.
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            MySqlCommand locationCMD = new MySqlCommand("DELETE FROM serverLocations WHERE locationName = @locationName", conn);
            locationCMD.Parameters.AddWithValue("@locationName", cmboExisting.Text);
            locationCMD.ExecuteNonQuery();
            conn.Close();
        }

        private void manageLocationsDelete_Load(object sender, EventArgs e)
        {
            //Connect to MYSQL and set output as items in cmboExisting.
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM serverLocations WHERE companyID = @companyID", conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmboExisting.Items.Add(rdr.GetString("locationName"));
            }
            conn.Close();
            Hide();
        }
    }
}
