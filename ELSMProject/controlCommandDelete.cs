using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class controlCommandDelete : Form
    {
        public controlCommandDelete()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void serverControlDelete_Load(object sender, EventArgs e)
        {
			//Connect to MySQL and set output as items of cmboName.
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
			//Delete row from serverCommands where the command name matches selected.
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            MySqlCommand deleteCommandCMD = new MySqlCommand("DELETE FROM serverCommands WHERE commandName = @Name, serverCompany = @Company", connectionMySQL);
            deleteCommandCMD.Parameters.AddWithValue("@Name", cmboName.Text);
            deleteCommandCMD.Parameters.AddWithValue("@Company", loginMenu.CompanyID);
            deleteCommandCMD.ExecuteNonQuery();
            cmboName.Items.Clear();
			//Update information. Connect to MySQL and set output as items of cmboName.
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
