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
    public partial class serverControlEdit : Form
    {
        public serverControlEdit()
        {
            InitializeComponent();
        }

        private static int loopnum, createloop, pointX = 235, pointY = 20, boxnum = 0, temploop;
        private static bool finished;
        private static string value, yes = "No";
        string[] operatingSystemsID = new string[100];
        string[] operatingSystems = new string[100];
        string[] commandOSID = new string[100]; 
        string[] commandText = new string[100];

        private void serverControlEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open(); // Open MySQL connection

            MySqlCommand serverCommandCMD = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", conn);
            serverCommandCMD.Parameters.AddWithValue("@company", loginMenu.CompanyID); // Replace string in query with variable
            MySqlDataReader serverCommandRDR = serverCommandCMD.ExecuteReader(); // Execute MySQL reader query 
            while (serverCommandRDR.Read()) // While rows in reader
            {
                cmboCommands.Items.Add(serverCommandRDR.GetString("commandName")); // Add item to dropdown box
            }
            serverCommandRDR.Close(); // Close reader

            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems ORDER BY operatingSystemsID ASC", conn);
            MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query 
            loopnum = 0; // Set variable to 0
            while (osRDR.Read()) // While rows in reader
            {
                operatingSystemsID[loopnum] = Convert.ToString(osRDR[0]); // Set variable to reader value
                operatingSystems[loopnum] = Convert.ToString(osRDR[1]); // Set variable to reader value
                loopnum += 1; // Add the value of 1 to the variable
            }
            osRDR.Close(); // Close reader
            finished = false; // Set value to false
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void valueChecked(object sender, EventArgs e)
        {
            if (finished == true)
            {
                string name = ((CheckBox)sender).Name; // Set variable to name of checkbox checked
                name = name.Replace("chkOS", string.Empty); // Get number contained within the name of the checkbox
                int OSNumber = Convert.ToInt16(name); // Convert number from string to int
                OSNumber -= 1; // Take 1 from number to counter dodgey code written originally
                string inputname = "txtInput" + OSNumber; // Combine number and string
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox; // Using combined string find textbox

                CheckBox chbxName = (CheckBox)sender; // Target sender checkbox
                if (chbxName.Checked == true)
                {
                    text.Enabled = true; // If its enabled turn on the textbox
                }
                else
                {
                    text.Enabled = false; // If it is disabled turn off the textbox
                    text.Text = "";// Clear the checkbox
                }
            } 
        }

        private void cmboCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open(); // Open MySQL Connection
            
            MySqlCommand serverCommandCMD = new MySqlCommand("SELECT * FROM serverCommands WHERE serverCompany = @company AND commandName = @Name", conn);
            serverCommandCMD.Parameters.AddWithValue("@company", loginMenu.CompanyID);  // Replace string in query with variable
            serverCommandCMD.Parameters.AddWithValue("@Name", cmboCommands.Text);  // Replace string in query with variable
            MySqlDataReader setCommandIDS = serverCommandCMD.ExecuteReader(); // Execute MySQL reader query 
            loopnum = 0; // Set variable to 0
            while (setCommandIDS.Read()) // While rows in reader
            {
                commandOSID[loopnum] = Convert.ToString(setCommandIDS[2]); // Set array value to reader value - the command ID number
                loopnum += 1; // Add the value of 1 to the variable
            }
            setCommandIDS.Close(); // Close reader

            MySqlDataReader setCommandText = serverCommandCMD.ExecuteReader(); // Execute MySQL reader query 
            loopnum = 0; // Set variable to 0
            while (setCommandText.Read()) // While rows in reader
            {
                commandText[loopnum] = Convert.ToString(setCommandText[4]); // Set array value to reader value - the command string
                loopnum += 1; // Add the value of 1 to the variable
            }
            setCommandText.Close(); // Close reader

            loopnum = 0; // Set variable to 0

            while (operatingSystemsID[loopnum] != null)
            {
                value = Convert.ToString(operatingSystems[loopnum]);
                temploop = 0; // Set variable to 0
                CheckBox dynamicCheckbox = new CheckBox(); // Create a checkbox
                dynamicCheckbox.Name = "chkOS" + Convert.ToString(loopnum); // Set checkbox name
                dynamicCheckbox.Text = value; // Set display text of checkbox to variable
                dynamicCheckbox.CheckedChanged += new System.EventHandler(valueChecked); // Add an event handler to checkbox
                dynamicCheckbox.AutoSize = true; // Set auto size to true
                dynamicCheckbox.Location = new Point(10, (loopnum + 1) * 20); // Set location of checkbox
                pnlConfiguration.Controls.Add(dynamicCheckbox); // Add checkbox to dscreen
                TextBox dynamicTextbox = new TextBox(); // Create textbox
                dynamicTextbox.Location = new Point(pointX, pointY); // Set position of textbox
                dynamicTextbox.Name = "txtInput" + (loopnum - 1); // Set name of textbox
                dynamicTextbox.Width = 800; // Set width of textbox
                pnlConfiguration.Controls.Add(dynamicTextbox); // Display textbox on screen
                pnlConfiguration.Show();
                while (commandOSID[temploop] != null)
                {
                    if (Convert.ToString(operatingSystemsID[loopnum]) == Convert.ToString(commandOSID[temploop]))
                    {
                        dynamicCheckbox.Checked = true;
                        dynamicTextbox.Enabled = true;
                        dynamicTextbox.Text = Convert.ToString(commandText[temploop]);
                        yes = "Yes";
                    }
                    temploop += 1; // Add the value of 1 to the variable
                }
                if (yes != "Yes")
                {
                    dynamicCheckbox.Checked = false;
                    dynamicTextbox.Enabled = false;
                }
                yes = "No"; // Reset the variable yes to no
                loopnum += 1; // Add the value of 1 to the variable
                pointY += 20; // Add the value of 20 to the variable
                boxnum += 1; // Add the value of 1 to the variable

            }
            this.Height += loopnum * 5;
            pnlConfiguration.Height += loopnum * 5;
            finished = true;
            btnEditCommand.Top += loopnum * 5;
            btnCancel.Top += loopnum * 5;

            connectionMySQL.Close();
        }

        private void btnNewCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            createloop = 0; // Set variable to 0
            MySqlCommand newDeleteCommand = new MySqlCommand("DELETE FROM `serverCommands` WHERE `commandName` = @commandName AND serverCompany = @serverCompany", conn); 
            newDeleteCommand.Parameters.AddWithValue("@commandName", cmboCommands.Text); // Replace string in query with variable
            newDeleteCommand.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID); // Replace string in query with variable
            newDeleteCommand.ExecuteNonQuery();// Run query 
            while (loopnum != createloop)
            {
                string chkname = "chkOS" + Convert.ToString(createloop);
                string inputname = "txtInput" + Convert.ToString(createloop - 1);
                var os = "";
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
                var checkBox = this.Controls.Find(chkname, true).FirstOrDefault() as CheckBox;
                    string checkBoxText = checkBox.Text;
                    MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", conn);
                    oscmd.Parameters.AddWithValue("@os", checkBoxText);
                    MySqlDataReader osrdr = oscmd.ExecuteReader(); // Execute MySQL reader query
                    osrdr.Read(); // Read data from the reader to become usable
                    os = Convert.ToString(osrdr[0]);
                    osrdr.Close();
                    if (text.Text != "")
                    {
                        MySqlCommand newCommand = new MySqlCommand("INSERT INTO `serverCommands` (`serverCompany`, `serverOS`, `commandName`, `serverCommand`) VALUES (@serverCompany, @serverOS, @commandName, @serverCommand)", conn); 
                        newCommand.Parameters.AddWithValue("@serverCommand", text.Text); // Replace string in query with variable
                        newCommand.Parameters.AddWithValue("@commandName", cmboCommands.Text); // Replace string in query with variable
                         newCommand.Parameters.AddWithValue("@serverOS", os); // Replace string in query with variable
                         newCommand.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID); // Replace string in query with variable
                         newCommand.ExecuteNonQuery(); // Run query
                    }
                createloop += 1; // Add the value of 1 to the variable
            }
            conn.Close();
            Hide(); //Hide form
        }
    }
}
