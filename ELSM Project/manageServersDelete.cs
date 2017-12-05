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
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string sql = "SELECT * FROM serverInformation WHERE companyID = @companyID"; // Create a string with the query command to run.
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@companyID", loginMenu.CompanyID); // Replace variable @userLogin with the variable collected earlier from the user.
            MySqlDataReader rdr = cmd.ExecuteReader(); // Process the query command and feedback data to reader.
            while (rdr.Read())
            {
                cmboHostname.Items.Add(rdr.GetString("serverHostname"));
            }
            conn.Close();
            Hide();
        }

        private void btnDeleteServer_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            MySqlCommand serverCMD = new MySqlCommand("DELETE FROM serverInformation WHERE serverHostname = @Hostname", conn); // Set MySQL query.
            serverCMD.Parameters.Add("@Hostname", cmboHostname.Text);
            serverCMD.ExecuteNonQuery(); // Process query.
            conn.Close();
        }
    }
}
