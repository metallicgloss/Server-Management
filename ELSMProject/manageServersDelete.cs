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
    public partial class manageServersDelete : Form
    {
        public manageServersDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void manageServersDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); 
            conn.Open();
            string sql = "SELECT * FROM serverInformation WHERE serverCompany = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader(); 
            while (rdr.Read())
            {
                cmboHostname.Items.Add(rdr.GetString("serverHostname"));
            }
            conn.Close();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); 
            conn.Open();
            MySqlCommand serverCMD = new MySqlCommand("DELETE FROM serverInformation WHERE serverHostname = @Hostname", conn); 
            serverCMD.Parameters.AddWithValue("@Hostname", cmboHostname.Text);
            serverCMD.ExecuteNonQuery(); 
            cmboHostname.Items.Clear();
            string sql = "SELECT * FROM serverInformation WHERE serverCompany = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader(); 
            while (rdr.Read())
            {
                cmboHostname.Items.Add(rdr.GetString("serverHostname"));
            }
            conn.Close();
        }

    }
}