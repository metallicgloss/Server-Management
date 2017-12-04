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
    public partial class manageServersCreate : Form
    {
        public manageServersCreate()
        {
            InitializeComponent();
        }

        private void manageServersCreate_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string locations = "SELECT * FROM serverLocations WHERE companyID = @companyID"; // Create a string with the query command to run.
            MySqlCommand locationscmd = new MySqlCommand(locations, conn);
            locationscmd.Parameters.Add("@companyID", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader locationrdr = locationscmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (locationrdr.Read())
            {
                cmboLocation.Items.Add(locationrdr.GetString("locationName"));
            }
            locationrdr.Close();
            string os = "SELECT * FROM serverOperatingSystems"; // Create a string with the query command to run.
            MySqlCommand oscmd = new MySqlCommand(os, conn);
            MySqlDataReader osrdr = oscmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (osrdr.Read())
            {
                cmboOS.Items.Add(osrdr.GetString("operatingSystemsName"));
            }
            osrdr.Close();
            string port = "SELECT * FROM serverPort"; // Create a string with the query command to run.
            MySqlCommand portcmd = new MySqlCommand(port, conn);
            MySqlDataReader portrdr = portcmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (portrdr.Read())
            {
                cmboNetwork.Items.Add(portrdr.GetString("portSpeed"));
            }
            portrdr.Close();
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
