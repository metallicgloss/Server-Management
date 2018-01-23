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
    public partial class serverControlCreate : Form
    {
        public serverControlCreate()
        {
            InitializeComponent();
        }

        private static int loopnum = 1, createloop = 0, pointX = 235, pointY = 20;
        private static string value;

        private void serverControlCreate_Load(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();

            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems ORDER BY operatingSystemsID", connectionMySQL);
            MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query
            
            while (osRDR.Read()) // While rows in reader
            {
                value = Convert.ToString(osRDR[1]); // Set variable to reader value
                CheckBox dynamicCheckbox = new CheckBox(); // Create checbkx
                dynamicCheckbox.Name = "chkOS" + Convert.ToString(loopnum); // Set checkbox name
                dynamicCheckbox.Text = value; // Set display value text to variable value
                dynamicCheckbox.CheckedChanged += new System.EventHandler(valueChecked); // Add event hander event to checkbox
                dynamicCheckbox.AutoSize = true; // Enable autosize
                dynamicCheckbox.Location = new Point(10, loopnum * 20); // Set checbox location
                pnlConfiguration.Controls.Add(dynamicCheckbox); // Display checkbox on window
                TextBox dynamicTextBox = new TextBox(); // Create textbox
                dynamicTextBox.Location = new Point(pointX, pointY); // Set textbox location
                dynamicTextBox.Name = "txtInput" + loopnum; // Set textbox name
                dynamicTextBox.Width = 800; // Set textbox width
                dynamicTextBox.Enabled = false; // Set enabled to false
                pnlConfiguration.Controls.Add(dynamicTextBox); // Display textbox on window
                pnlConfiguration.Show();
                loopnum += 1; // Add the value of 1 to the variable
            }
            
                this.Height += 40 + (loopnum * 5);
                pnlConfiguration.Height += 40 + (loopnum * 5);
                btnNewCommand.Top += loopnum * 6;
                btnCancel.Top += loopnum * 6;
            osRDR.Close(); // Close reader
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void valueChecked(object sender, EventArgs e)
        {
            string name = ((CheckBox)sender).Name; // Set string to name of checkbox name
            name = name.Replace("chkOS", string.Empty); // Get number in checkbox name
            int OSNumber = Convert.ToInt16(name); // Convert number from string to int
            OSNumber -= 1; // Take one from number to combat dodgey code originally
            string inputname = "txtInput" + OSNumber; // Make string for input box
            var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox; // Find textbox using string

            CheckBox chbxName = (CheckBox)sender;
            if (chbxName.Checked == true)
            {
                text.Enabled = true;
            }
            else
            {
                text.Enabled = false;
                text.Text = "";
            }
        }

        private void btnNewCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            connectionMySQL.Open();
            while (loopnum != createloop)
            {
                string chkname = "chkOS" + Convert.ToString(createloop);
                string inputname = "txtInput" + Convert.ToString(createloop - 1);
                var os = "";
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
                var checkBox = this.Controls.Find(chkname, true).FirstOrDefault() as CheckBox;
                    string checkBoxText = checkBox.Text;
                    MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
                    osCMD.Parameters.AddWithValue("@os", checkBoxText); // Replace string in query with variable
                    MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query
                    osRDR.Read(); // Read data from the reader to become usable
                    os = Convert.ToString(osRDR[0]);
                    osRDR.Close();
                    if (text.Text != "")
                    {
                        MySqlCommand newCommandCMD = new MySqlCommand("INSERT INTO `serverCommands` (`serverCompany`, `serverOS`, `commandName`, `serverCommand`) VALUES (@serverCompany, @serverOS, @commandName, @serverCommand)", connectionMySQL);
                    newCommandCMD.Parameters.AddWithValue("@serverCommand", text.Text); // Replace string in query with variable
                    newCommandCMD.Parameters.AddWithValue("@commandName", txtCommandName.Text); // Replace string in query with variable
                    newCommandCMD.Parameters.AddWithValue("@serverOS", os); // Replace string in query with variable
                    newCommandCMD.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID); // Replace string in query with variable
                    newCommandCMD.ExecuteNonQuery();  //Execute query
                    }
                createloop += 1; // Add the value of 1 to the variable
            }

            connectionMySQL.Close();
            Hide(); //Hide form
        }
    }
}
