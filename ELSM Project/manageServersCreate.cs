﻿using System;
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
            MySqlCommand serverCMD = new MySqlCommand("INSERT INTO serverInformation (serverCompany, serverLocation, serverHostname, serverUsername, serverPassword, serverKey, serverOS, serverIP, serverProcessor, serverRAM, serverPort, serverTransfer) VALUES (@serverCompany, @serverLocation, @serverHostname, @serverUsername, @serverPassword, @serverKey, @serverOS, @serverIP, @serverProcessor, @serverRAM, @serverPort, @serverTransfer)", conn); // Set MySQL query.
            serverCMD.Parameters.Add("@serverCompany", loginMenu.CompanyID);
            serverCMD.Parameters.Add("@serverLocation", location);
            serverCMD.Parameters.Add("@serverHostname", txtHostname.Text);
            serverCMD.Parameters.Add("@serverUsername", txtUsername.Text);
            serverCMD.Parameters.Add("@serverPassword", txtPassword.Text);
            serverCMD.Parameters.Add("@serverKey", txtKey.Text);
            serverCMD.Parameters.Add("@serverOS", os);
            serverCMD.Parameters.Add("@serverIP", txtIP.Text);
            serverCMD.Parameters.Add("@serverProcessor", txtProcessor.Text);
            serverCMD.Parameters.Add("@serverRAM", txtRAM.Text);
            serverCMD.Parameters.Add("@serverPort", network);
            serverCMD.Parameters.Add("@serverTransfer", txtTransfer.Text);
            serverCMD.ExecuteNonQuery(); // Process query.
            conn.Close();
            txtHostname.Text = "";
            txtIP.Text = "";
            txtKey.Text = "";
            txtPassword.Text = "";
            txtProcessor.Text = "";
            txtRAM.Text = "";
            txtServerName.Text = "";
            txtTransfer.Text = "";
            txtUsername.Text = "";
        }
    }
}