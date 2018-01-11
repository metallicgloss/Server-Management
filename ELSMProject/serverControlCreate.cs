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
                value = Convert.ToString(osRDR[1]);
                CheckBox dynamicCheckbox = new CheckBox();
                dynamicCheckbox.Name = "chkOS" + Convert.ToString(loopnum);
                dynamicCheckbox.Text = value;
                dynamicCheckbox.CheckedChanged += new System.EventHandler(valueChecked);
                dynamicCheckbox.AutoSize = true;
                dynamicCheckbox.Location = new Point(10, loopnum * 20);
                pnlConfiguration.Controls.Add(dynamicCheckbox);
                TextBox dynamicTextBox = new TextBox();
                dynamicTextBox.Location = new Point(pointX, pointY);
                dynamicTextBox.Name = "txtInput" + loopnum;
                dynamicTextBox.Width = 800;
                dynamicTextBox.Enabled = false;
                pnlConfiguration.Controls.Add(dynamicTextBox);
                pnlConfiguration.Show();
                loopnum += 1; // Add the value of 1 to the variable
            }

            osRDR.Close();
            this.Height += 40 +(loopnum * 5);
            pnlConfiguration.Height += 40 + (loopnum * 5);
            btnNewCommand.Top += loopnum * 6;
            btnCancel.Top += loopnum * 6;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide(); //Hide form
        }

        private void valueChecked(object sender, EventArgs e)
        {
            string name = ((CheckBox)sender).Name;
            name = name.Replace("chkOS", string.Empty);
            int OSNumber = Convert.ToInt16(name);
            OSNumber -= 1;
            string inputname = "txtInput" + OSNumber;
            var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;

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
                    osCMD.Parameters.AddWithValue("@os", checkBoxText);
                    MySqlDataReader osRDR = osCMD.ExecuteReader(); // Execute MySQL reader query
                    osRDR.Read(); // Read data from the reader to become usable
                    os = Convert.ToString(osRDR[0]);
                    osRDR.Close();
                    if (text.Text != "")
                    {
                        MySqlCommand newCommandCMD = new MySqlCommand("INSERT INTO `serverCommands` (`serverCompany`, `serverOS`, `commandName`, `serverCommand`) VALUES (@serverCompany, @serverOS, @commandName, @serverCommand)", connectionMySQL);
                    newCommandCMD.Parameters.AddWithValue("@serverCommand", text.Text);
                    newCommandCMD.Parameters.AddWithValue("@commandName", txtCommandName.Text);
                    newCommandCMD.Parameters.AddWithValue("@serverOS", os);
                    newCommandCMD.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
                    newCommandCMD.ExecuteNonQuery(); 
                    }
                createloop += 1; // Add the value of 1 to the variable
            }

            connectionMySQL.Close();
            Hide(); //Hide form
        }
    }
}
