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
            Hide();
        }

        private void serverControlDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string sql = "SELECT DISTINCT commandName FROM serverCommands WHERE serverCompany = @companyID"; // Create a string with the query command to run.
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader rdr = cmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (rdr.Read())
            {
                cmboName.Items.Add(rdr.GetString("commandName"));
            }
            conn.Close();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            MySqlCommand serverCMD = new MySqlCommand("DELETE FROM serverCommands WHERE commandName = @Name, serverCompany = @Company", conn); // Set MySQL query.
            serverCMD.Parameters.AddWithValue("@Name", cmboName.Text);
            serverCMD.Parameters.AddWithValue("@Company", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            serverCMD.ExecuteNonQuery(); // Process query.
            cmboName.Items.Clear();
            string sql = "SELECT * FROM serverCommands WHERE serverCompany = @companyID"; // Create a string with the query command to run.
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader rdr = cmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (rdr.Read())
            {
                cmboName.Items.Add(rdr.GetString("commandName"));
            }
            conn.Close();
            

        }
    }
}
