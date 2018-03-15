using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class controlCommandDelete : Form
    {
        public controlCommandDelete()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();  
        }

        private void serverControlDelete_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();
            MySqlCommand commandNameCMD = new MySqlCommand("SELECT DISTINCT commandName FROM serverCommands WHERE serverCompany = @companyID", connectionMySQL);
            commandNameCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader commandNameRDR = commandNameCMD.ExecuteReader();      
            while (commandNameRDR.Read())     
            {
                cmboName.Items.Add(commandNameRDR.GetString("commandName"));
            }
            connectionMySQL.Close();
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);     
            connectionMySQL.Open();
            MySqlCommand deleteCommandCMD = new MySqlCommand("DELETE FROM serverCommands WHERE commandName = @Name, serverCompany = @Company", connectionMySQL);
            deleteCommandCMD.Parameters.AddWithValue("@Name", cmboName.Text);
            deleteCommandCMD.Parameters.AddWithValue("@Company", loginMenu.CompanyID);
            deleteCommandCMD.ExecuteNonQuery();
            cmboName.Items.Clear();

            MySqlCommand commandNameCMD = new MySqlCommand("SELECT * FROM serverCommands WHERE serverCompany = @companyID", connectionMySQL);
            commandNameCMD.Parameters.AddWithValue("@companyID", loginMenu.CompanyID); 
            MySqlDataReader commandNameRDR = commandNameCMD.ExecuteReader();      
            while (commandNameRDR.Read())     
            {
                cmboName.Items.Add(commandNameRDR.GetString("commandName"));
            }
            connectionMySQL.Close();
            

        }
    }
}
