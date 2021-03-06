﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class controlCommandEdit : Form
    {
        public controlCommandEdit()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        private static int loopnum, createloop, pointX = 235, pointY = 20, boxnum = 0, temploop;
        private static bool finished, firstrun;
        private static string value, yes = "No";
        string[] operatingSystemsID = new string[100];
        string[] operatingSystems = new string[100];
        string[] commandOSID = new string[100];
        string[] commandText = new string[100];

        private void serverControlEdit_Load(object sender, EventArgs e)
        {
            firstrun = true;
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
			//Run SQL to get the name of commands that are unique and set the output as items of cmboCommands.
            MySqlCommand serverCommandCMD = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", conn);
            serverCommandCMD.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader serverCommandRDR = serverCommandCMD.ExecuteReader();
            while (serverCommandRDR.Read())
            {
                cmboCommands.Items.Add(serverCommandRDR.GetString("commandName"));
            }
            serverCommandRDR.Close();
			//Run SQL to list the name and Id of the operating system in array.
            MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems ORDER BY operatingSystemsID ASC", conn);
            MySqlDataReader osRDR = osCMD.ExecuteReader();
            loopnum = 0;
            while (osRDR.Read())
            {
                operatingSystemsID[loopnum] = Convert.ToString(osRDR[0]);
                operatingSystems[loopnum] = Convert.ToString(osRDR[1]);
                loopnum += 1;
            }
            osRDR.Close();
            finished = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void valueChecked(object sender, EventArgs e)
        {
            if (finished == true)
            {
				//Get the name of the checkbox, split it to get the ID.
                string name = ((CheckBox)sender).Name;
                name = name.Replace("chkOS", string.Empty);
                int OSNumber = Convert.ToInt16(name);
                OSNumber -= 1;
				//Get the name of the textbox, split it to get the ID.
                string inputname = "txtInput" + OSNumber;
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
				//Target the checkbox, if it is checked, enable the textbox. If it is not checked, disable and clear the checkbox.
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
        }

        private void cmboCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
			//Execute SQL to get the OS ID for different operating systems where it matches the commandname.
            MySqlCommand serverCommandCMD = new MySqlCommand("SELECT * FROM serverCommands WHERE serverCompany = @company AND commandName = @Name", connectionMySQL);
            serverCommandCMD.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            serverCommandCMD.Parameters.AddWithValue("@Name", cmboCommands.Text);
            MySqlDataReader setCommandIDS = serverCommandCMD.ExecuteReader();
            loopnum = 0;
            while (setCommandIDS.Read())
            {
                commandOSID[loopnum] = Convert.ToString(setCommandIDS[2]);
                loopnum += 1;
            }
            setCommandIDS.Close();
			//Execute SQL to get the command content for different operating systems where it matches the commandname.
            MySqlDataReader setCommandText = serverCommandCMD.ExecuteReader();
            loopnum = 0;
            while (setCommandText.Read())
            {
                commandText[loopnum] = Convert.ToString(setCommandText[4]);
                loopnum += 1;
            }
            setCommandText.Close();
            loopnum = 0;
            pointX = 235;
            pointY = 20;
            pnlConfiguration.Controls.Clear();
            while (operatingSystemsID[loopnum] != null)
            {
				//Create a dynamic checkbox, set different properties such as the location, event handler and size. Named with the ID of the loop.
                value = Convert.ToString(operatingSystems[loopnum]);
                temploop = 0;
                CheckBox dynamicCheckbox = new CheckBox();
                dynamicCheckbox.Name = "chkOS" + Convert.ToString(loopnum);
                dynamicCheckbox.Text = value;
                dynamicCheckbox.CheckedChanged += new System.EventHandler(valueChecked);
                dynamicCheckbox.AutoSize = true;
                dynamicCheckbox.Location = new Point(10, (loopnum + 1) * 20);
                pnlConfiguration.Controls.Add(dynamicCheckbox);
				//Create a dynamic textbox, set different properties such as the location and width. Named with the ID of the loop.
                TextBox dynamicTextbox = new TextBox();
                dynamicTextbox.Location = new Point(pointX, pointY);
                dynamicTextbox.Name = "txtInput" + (loopnum - 1);
                dynamicTextbox.Width = 800;
                pnlConfiguration.Controls.Add(dynamicTextbox);
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
                    temploop += 1;
                }
                if (yes != "Yes")
                {
                    dynamicCheckbox.Checked = false;
                    dynamicTextbox.Enabled = false;
                }
                yes = "No";
                loopnum += 1;
                pointY += 20;
                boxnum += 1;

            }
			//If not the first time loading the page, set the window height accordingly.
            if (firstrun != false)
            {
                this.Height += loopnum * 5;
                pnlConfiguration.Height += loopnum * 5;
                finished = true;
                btnEditCommand.Top += loopnum * 5;
                btnCancel.Top += loopnum * 5;
            }
            firstrun = false;

            connectionMySQL.Close();
        }

        private void btnNewCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            createloop = 0;
			//Delete all entries for the command with different OS configurations.
            MySqlCommand newDeleteCommand = new MySqlCommand("DELETE FROM `serverCommands` WHERE `commandName` = @commandName AND serverCompany = @serverCompany", conn);
            newDeleteCommand.Parameters.AddWithValue("@commandName", cmboCommands.Text);
            newDeleteCommand.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
            newDeleteCommand.ExecuteNonQuery();
            while (loopnum != createloop)
            {
				//For each operating system selected, combine string to be able to target the textbox and the checkbox.
                string chkname = "chkOS" + Convert.ToString(createloop);
                string inputname = "txtInput" + Convert.ToString(createloop - 1);
                var os = "";
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
                var checkBox = this.Controls.Find(chkname, true).FirstOrDefault() as CheckBox;
                string checkBoxText = checkBox.Text;
				//Get the ID of the operating system that is selected in the checkbox selected.
                MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", conn);
                oscmd.Parameters.AddWithValue("@os", checkBoxText);
                MySqlDataReader osrdr = oscmd.ExecuteReader();
                osrdr.Read();
                os = Convert.ToString(osrdr[0]);
                osrdr.Close();
				//If the command text isn't equal to blank, insert into the table.
                if (text.Text != "")
                {
                    MySqlCommand newCommand = new MySqlCommand("INSERT INTO `serverCommands` (`serverCompany`, `serverOS`, `commandName`, `serverCommand`) VALUES (@serverCompany, @serverOS, @commandName, @serverCommand)", conn);
                    newCommand.Parameters.AddWithValue("@serverCommand", text.Text);
                    newCommand.Parameters.AddWithValue("@commandName", cmboCommands.Text);
                    newCommand.Parameters.AddWithValue("@serverOS", os);
                    newCommand.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
                    newCommand.ExecuteNonQuery();
                }
                createloop += 1;
            }
            conn.Close();
            Hide();
        }
    }
}
