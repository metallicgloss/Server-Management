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
    public partial class mainDashboard : Form
    {

        public static Boolean IsOwner;
        public static string CompanyName;

        public mainDashboard()
        {
            InitializeComponent();
        }

        private void DashboardFRM_Load(object sender, EventArgs e)
        {
            lblCurrentIP.Text = "IP Address: " + loginMenu.IPAddress;
            lblPosition.Text = "Position: " + loginMenu.Role;
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            string sql = "SELECT * FROM userCompanies WHERE companyID = @companyID";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@companyID", loginMenu.CompanyID);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            CompanyName = Convert.ToString(rdr[2]);
            lblCurrentCompany.Text = "Company: " + CompanyName;
            if (loginMenu.UserID == Convert.ToString(rdr[1]))
            {
                IsOwner = true;
            }
            rdr.Read();
            conn.Close();
        }

        private void lblMetallicGloss_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.metallicgloss.com");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here!", "Notce", MessageBoxButtons.OK);
        }

        private void btnServerControl_Click(object sender, EventArgs e)
        {
            Hide();
            serverControl Servers = new serverControl();
            Servers.ShowDialog();
        }

        private void btnManageServers_Click(object sender, EventArgs e)
        {
            Hide();
            manageServers manageS = new manageServers();
            manageS.ShowDialog();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            Hide();
            manageLocations manageL = new manageLocations();
            manageL.ShowDialog();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            Hide();
            manageAccount Account = new manageAccount();
            Account.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                this.Close();
            }
        }
        
    }
}
