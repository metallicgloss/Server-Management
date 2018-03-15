using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class locationDelete : Form
    {
        public locationDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();  
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);     
            conn.Open();
            MySqlCommand locationCMD = new MySqlCommand("DELETE FROM serverLocations WHERE locationName = @locationName", conn); 
            locationCMD.Parameters.AddWithValue("@locationName", cmboExisting.Text);
            locationCMD.ExecuteNonQuery(); 
            conn.Close();

            
        }

        private void manageLocationsDelete_Load(object sender, EventArgs e)
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
            Hide();  
        }
    }
}
