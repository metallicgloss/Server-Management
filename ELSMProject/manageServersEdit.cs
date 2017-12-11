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
    public partial class manageServersEdit : Form
    {
        public manageServersEdit()
        {
            InitializeComponent();
        }

        public static string password, key;


        private void manageServersEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string server = "SELECT * FROM serverInformation"; // Create a string with the query command to run.
            MySqlCommand servercmd = new MySqlCommand(server, conn);
            MySqlDataReader serverrdr = servercmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (serverrdr.Read())
            {
                cmboHostNames.Items.Add(serverrdr.GetString("serverHostname"));
            }
            serverrdr.Close();
            conn.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string server = "SELECT * FROM serverInformation WHERE serverHostname = @Hostname"; // Create a string with the query command to run.
            MySqlCommand servercmd = new MySqlCommand(server, conn);
            servercmd.Parameters.Add("@Hostname", cmboHostNames.Text); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader serverrdr = servercmd.ExecuteReader(); // Process the query command and feedback data to reader.
            serverrdr.Read();
            txtUsername.Text = Convert.ToString(serverrdr[4]);
            txtPassword.Text = "";
            txtKey.Text = "";
            txtIP.Text = Convert.ToString(serverrdr[8]);
            txtProcessor.Text = Convert.ToString(serverrdr[9]);
            txtRAM.Text = Convert.ToString(serverrdr[10]);
            txtTransfer.Text = Convert.ToString(serverrdr[12]);
            manageServersEdit.password = Convert.ToString(serverrdr[5]);
            manageServersEdit.key = Convert.ToString(serverrdr[6]);
            var serverLocation = Convert.ToString(serverrdr[2]);
            var serverOS = Convert.ToString(serverrdr[7]);
            var serverPort = Convert.ToString(serverrdr[11]);
            serverrdr.Close();
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

            string serverLocations = "SELECT * FROM serverLocations WHERE locationID = @locationID"; // Create a string with the query command to run.
            MySqlCommand serverLocationcmd = new MySqlCommand(serverLocations, conn);
            serverLocationcmd.Parameters.Add("@locationID", serverLocation); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader serverlocationrdr = serverLocationcmd.ExecuteReader(); // Process the query command and feedback data to reader.
            serverlocationrdr.Read();
            cmboLocation.Text = Convert.ToString(serverlocationrdr.GetString("locationName"));
            serverlocationrdr.Close();

            string serveros = "SELECT * FROM serverOperatingSystems WHERE operatingSystemsID = @operatingSystemsID"; // Create a string with the query command to run.
            MySqlCommand serveroscmd = new MySqlCommand(serveros, conn);
            serveroscmd.Parameters.Add("@operatingSystemsID", serverOS); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader serverosrdr = serveroscmd.ExecuteReader(); // Process the query command and feedback data to reader.
            serverosrdr.Read();
            cmboOS.Text = Convert.ToString(serverosrdr[1]);
            serverosrdr.Close();


            string serverport = "SELECT * FROM serverPort WHERE portID = @portID"; // Create a string with the query command to run.
            MySqlCommand serverportcmd = new MySqlCommand(serverport, conn);
            serverportcmd.Parameters.Add("@portID", serverPort); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader serverportrdr = serverportcmd.ExecuteReader(); // Process the query command and feedback data to reader.
            serverportrdr.Read();
            cmboNetwork.Text = Convert.ToString(serverportrdr[1]);
            serverportrdr.Close();

            cmboLocation.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtKey.Enabled = true;
            cmboOS.Enabled = true;
            txtIP.Enabled = true;
            txtProcessor.Enabled = true;
            txtRAM.Enabled = true;
            cmboNetwork.Enabled = true;
            txtTransfer.Enabled = true;
            cmboLocation.Cursor = Cursors.Hand;
            cmboLocation.Cursor = Cursors.Hand;
            txtUsername.Cursor = Cursors.Hand;
            txtPassword.Cursor = Cursors.Hand;
            txtKey.Cursor = Cursors.Hand;
            cmboOS.Cursor = Cursors.Hand;
            txtIP.Cursor = Cursors.Hand;
            txtProcessor.Cursor = Cursors.Hand;
            txtRAM.Cursor = Cursors.Hand;
            cmboNetwork.Cursor = Cursors.Hand;
            txtTransfer.Cursor = Cursors.Hand;
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();

            MySqlCommand locationcmd = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", conn);
            locationcmd.Parameters.Add("@location", cmboLocation.Text);
            MySqlDataReader locationrdr = locationcmd.ExecuteReader();
            locationrdr.Read();
            var location = Convert.ToString(locationrdr[0]);
            locationrdr.Close();
            MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", conn);
            oscmd.Parameters.Add("@os", cmboOS.Text);
            MySqlDataReader osrdr = oscmd.ExecuteReader();
            osrdr.Read();
            var os = Convert.ToString(osrdr[0]);
            osrdr.Close();
            MySqlCommand networkcmd = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", conn);
            networkcmd.Parameters.Add("@port", cmboNetwork.Text);
            MySqlDataReader networkrdr = networkcmd.ExecuteReader();
            networkrdr.Read();
            var network = Convert.ToString(networkrdr[0]);
            networkrdr.Close();

            if (txtPassword.Text == "")
            {
                var password = manageServersEdit.password;
            }
            else
            {
                var password = txtPassword.Text;
            }

            if (txtKey.Text == "")
            {
                var key = manageServersEdit.key;
            }
            else
            {
                var key = txtKey.Text;
            }

            MySqlCommand server = new MySqlCommand("UPDATE serverInformation SET serverLocation = @serverLocation, serverHostname = @serverHostname, serverUsername = @serverUsername, serverPassword = @serverPassword, serverKey = @serverKey, serverOS = @serverOS, serverIP = @serverIP, serverProcessor = @serverProcessor, serverRAM = @serverRAM, serverPort = @serverPort, serverTransfer = @serverTransfer WHERE serverHostname = @Hostname", conn); // Set MySQL query.
            server.Parameters.Add("@serverLocation", location);
            server.Parameters.Add("@serverHostname", cmboHostNames.Text);
            server.Parameters.Add("@Hostname", cmboHostNames.Text);
            server.Parameters.Add("@serverUsername", txtUsername.Text);
            server.Parameters.Add("@serverPassword", password);
            server.Parameters.Add("@serverKey", key);
            server.Parameters.Add("@serverOS", os);
            server.Parameters.Add("@serverIP", txtIP.Text);
            server.Parameters.Add("@serverProcessor", txtProcessor.Text);
            server.Parameters.Add("@serverRAM", txtRAM.Text);
            server.Parameters.Add("@serverPort", network);
            server.Parameters.Add("@serverTransfer", txtTransfer.Text);
            server.ExecuteNonQuery(); // Process query.
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
