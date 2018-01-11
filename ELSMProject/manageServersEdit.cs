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
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string server = "SELECT * FROM serverInformation"; 
            MySqlCommand servercmd = new MySqlCommand(server, conn);
            MySqlDataReader serverrdr = servercmd.ExecuteReader(); // Execute MySQL reader query 
            while (serverrdr.Read()) // While rows in reader
            {
                cmboHostNames.Items.Add(serverrdr.GetString("serverHostname"));
            }
            serverrdr.Close();
            conn.Close();
        }

        private void cmboHostNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string server = "SELECT * FROM serverInformation WHERE serverHostname = @Hostname"; 
            MySqlCommand servercmd = new MySqlCommand(server, conn);
            servercmd.Parameters.AddWithValue("@Hostname", cmboHostNames.Text); 
            MySqlDataReader serverrdr = servercmd.ExecuteReader(); // Execute MySQL reader query 
            serverrdr.Read(); // Read data from the reader to become usable
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
            string locations = "SELECT * FROM serverLocations WHERE companyID = @companyID"; 
            MySqlCommand locationscmd = new MySqlCommand(locations, conn);
            locationscmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader locationrdr = locationscmd.ExecuteReader(); // Execute MySQL reader query 
            while (locationrdr.Read()) // While rows in reader
            {
                cmboLocation.Items.Add(locationrdr.GetString("locationName"));
            }
            locationrdr.Close();
            string os = "SELECT * FROM serverOperatingSystems"; 
            MySqlCommand oscmd = new MySqlCommand(os, conn);
            MySqlDataReader osrdr = oscmd.ExecuteReader(); // Execute MySQL reader query 
            while (osrdr.Read()) // While rows in reader
            {
                cmboOS.Items.Add(osrdr.GetString("operatingSystemsName"));
            }
            osrdr.Close();
            string port = "SELECT * FROM serverPort"; 
            MySqlCommand portcmd = new MySqlCommand(port, conn);
            MySqlDataReader portrdr = portcmd.ExecuteReader(); // Execute MySQL reader query 
            while (portrdr.Read()) // While rows in reader
            {
                cmboNetwork.Items.Add(portrdr.GetString("portSpeed"));
            }
            portrdr.Close();

            string serverLocations = "SELECT * FROM serverLocations WHERE locationID = @locationID"; 
            MySqlCommand serverLocationcmd = new MySqlCommand(serverLocations, conn);
            serverLocationcmd.Parameters.AddWithValue("@locationID", serverLocation); 
            MySqlDataReader serverlocationrdr = serverLocationcmd.ExecuteReader(); // Execute MySQL reader query 
            serverlocationrdr.Read(); // Read data from the reader to become usable
            cmboLocation.Text = Convert.ToString(serverlocationrdr.GetString("locationName"));
            serverlocationrdr.Close();

            string serveros = "SELECT * FROM serverOperatingSystems WHERE operatingSystemsID = @operatingSystemsID"; 
            MySqlCommand serveroscmd = new MySqlCommand(serveros, conn);
            serveroscmd.Parameters.AddWithValue("@operatingSystemsID", serverOS); 
            MySqlDataReader serverosrdr = serveroscmd.ExecuteReader(); // Execute MySQL reader query 
            serverosrdr.Read(); // Read data from the reader to become usable
            cmboOS.Text = Convert.ToString(serverosrdr[1]);
            serverosrdr.Close();


            string serverport = "SELECT * FROM serverPort WHERE portID = @portID"; 
            MySqlCommand serverportcmd = new MySqlCommand(serverport, conn);
            serverportcmd.Parameters.AddWithValue("@portID", serverPort); 
            MySqlDataReader serverportrdr = serverportcmd.ExecuteReader(); // Execute MySQL reader query 
            serverportrdr.Read(); // Read data from the reader to become usable
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
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();

            MySqlCommand locationcmd = new MySqlCommand("SELECT * FROM serverLocations WHERE locationName = @location", conn);
            locationcmd.Parameters.AddWithValue("@location", cmboLocation.Text);
            MySqlDataReader locationrdr = locationcmd.ExecuteReader(); // Execute MySQL reader query
            locationrdr.Read(); // Read data from the reader to become usable
            var location = Convert.ToString(locationrdr[0]);
            locationrdr.Close();
            MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", conn);
            oscmd.Parameters.AddWithValue("@os", cmboOS.Text);
            MySqlDataReader osrdr = oscmd.ExecuteReader(); // Execute MySQL reader query
            osrdr.Read(); // Read data from the reader to become usable
            var os = Convert.ToString(osrdr[0]);
            osrdr.Close();
            MySqlCommand networkcmd = new MySqlCommand("SELECT * FROM serverPort WHERE portSpeed = @port", conn);
            networkcmd.Parameters.AddWithValue("@port", cmboNetwork.Text);
            MySqlDataReader networkrdr = networkcmd.ExecuteReader(); // Execute MySQL reader query
            networkrdr.Read(); // Read data from the reader to become usable
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

            MySqlCommand server = new MySqlCommand("UPDATE serverInformation SET serverLocation = @serverLocation, serverHostname = @serverHostname, serverUsername = @serverUsername, serverPassword = @serverPassword, serverKey = @serverKey, serverOS = @serverOS, serverIP = @serverIP, serverProcessor = @serverProcessor, serverRAM = @serverRAM, serverPort = @serverPort, serverTransfer = @serverTransfer WHERE serverHostname = @Hostname", conn); 
            server.Parameters.AddWithValue("@serverLocation", location);
            server.Parameters.AddWithValue("@serverHostname", cmboHostNames.Text);
            server.Parameters.AddWithValue("@Hostname", cmboHostNames.Text);
            server.Parameters.AddWithValue("@serverUsername", txtUsername.Text);
            server.Parameters.AddWithValue("@serverPassword", password);
            server.Parameters.AddWithValue("@serverKey", key);
            server.Parameters.AddWithValue("@serverOS", os);
            server.Parameters.AddWithValue("@serverIP", txtIP.Text);
            server.Parameters.AddWithValue("@serverProcessor", txtProcessor.Text);
            server.Parameters.AddWithValue("@serverRAM", txtRAM.Text);
            server.Parameters.AddWithValue("@serverPort", network);
            server.Parameters.AddWithValue("@serverTransfer", txtTransfer.Text);
            server.ExecuteNonQuery(); 
            Hide(); //Hide form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }
    }
}
