using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ELSM_Project
{
    public partial class controlCommandCreate : Form
    {
        public controlCommandCreate()
        {
            InitializeComponent();
        }

        private static int loopnum = 1, createloop = 0, pointX = 235, pointY = 20;
        private static string value;

        private void serverControlCreate_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Open MySQL connection 
            conn.Open();
            string os = "SELECT * FROM serverOperatingSystems ORDER BY operatingSystemsID";
            MySqlCommand oscmd = new MySqlCommand(os, conn);
            MySqlDataReader osrdr = oscmd.ExecuteReader(); // Execute MySQL reader query
            int height;
            height = 206;
            loopnum = 0;

            int boxnum = 0; // Set variable to 0
            string value;
            pnlConfiguration.Height += 40;
            this.Height += 40;
            while (osrdr.Read()) // While rows in reader
            {
                value = Convert.ToString(osrdr[1]);
                CheckBox box;
                box = new CheckBox();
                box.Name = "chkOS" + Convert.ToString(loopnum);
                box.Text = value;
                box.CheckedChanged += new System.EventHandler(valueChecked);
                box.AutoSize = true;
                box.Location = new Point(10, loopnum * 20);
                pnlConfiguration.Controls.Add(box);
                loopnum += 1; // Add the value of 1 to the variable
            }
            int pointX = 235;
            int pointY = 0;
            int loopnum2 = 0; // Set variable to 0
            for (int i = 0; i < loopnum; i++)  // Set variable to 0
            {
                TextBox a = new TextBox();
                a.Location = new Point(pointX, pointY);
                a.Name = "txtInput" + loopnum2;
                a.Width = 800;
                a.Enabled = false;
                pnlConfiguration.Controls.Add(a);
                pnlConfiguration.Show();
                pointY += 20;
                boxnum += 1; // Add the value of 1 to the variable
                loopnum2 += 1; // Add the value of 1 to the variable
            }
            osrdr.Close();
            this.Height += loopnum2 * 5;
            pnlConfiguration.Height += (loopnum2 * 5);
            btnNewCommand.Top += loopnum2 * 6;
            btnCancel.Top += loopnum2 * 6;

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
                string inputname = "txtInput" + Convert.ToString(createloop);
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
