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
    public partial class serverControlDelete : Form
    {
        public serverControlDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void serverControlDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string sql = "SELECT DISTINCT commandName FROM serverCommands WHERE serverCompany = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader(); 
            while (rdr.Read())
            {
                cmboName.Items.Add(rdr.GetString("commandName"));
            }
            conn.Close();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            MySqlCommand serverCMD = new MySqlCommand("DELETE FROM serverCommands WHERE commandName = @Name, serverCompany = @Company", conn); 
            serverCMD.Parameters.AddWithValue("@Name", cmboName.Text);
            serverCMD.Parameters.AddWithValue("@Company", loginMenu.CompanyID); 
            serverCMD.ExecuteNonQuery(); 
            cmboName.Items.Clear();
            string sql = "SELECT * FROM serverCommands WHERE serverCompany = @companyID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader rdr = cmd.ExecuteReader(); 
            while (rdr.Read())
            {
                cmboName.Items.Add(rdr.GetString("commandName"));
            }
            conn.Close();
            

        }
    }
}
