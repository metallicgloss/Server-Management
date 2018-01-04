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

        public static int loopnum, createloop;
        public static bool finished;
        string[] operatingSystemsID = new string[100];
        string[] operatingSystems = new string[100];
        string[] commandOSID = new string[100]; 
        string[] commandText = new string[100];

        private void serverControlEdit_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); 
            conn.Open();
            MySqlCommand oscmd = new MySqlCommand("SELECT DISTINCT * FROM serverCommands WHERE serverCompany = @company GROUP BY commandName", conn);
            oscmd.Parameters.AddWithValue("@company", loginMenu.CompanyID);
            MySqlDataReader serverrdr = oscmd.ExecuteReader(); 
            while (serverrdr.Read())
            {
                cmboCommands.Items.Add(serverrdr.GetString("commandName"));
            }
            serverrdr.Close();
            string os = "SELECT * FROM serverOperatingSystems ORDER BY operatingSystemsID ASC"; 
            MySqlCommand os2cmd = new MySqlCommand(os, conn);
            MySqlDataReader osrdr = os2cmd.ExecuteReader(); 
            loopnum = 0;
            while (osrdr.Read())
            {
                operatingSystemsID[loopnum] = Convert.ToString(osrdr[0]);
                operatingSystems[loopnum] = Convert.ToString(osrdr[1]);
                loopnum += 1;
            }
            osrdr.Close();
                finished = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void valueChecked(object sender, EventArgs e)
        {
            if (finished == true)
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
        }

        private void cmboCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); 
            conn.Open();
            
            MySqlCommand commandcmd = new MySqlCommand("SELECT * FROM serverCommands WHERE serverCompany = @company AND commandName = @Name", conn);
            commandcmd.Parameters.AddWithValue("@company", loginMenu.CompanyID); 
            commandcmd.Parameters.AddWithValue("@Name", cmboCommands.Text); 
            MySqlDataReader setcommandids = commandcmd.ExecuteReader(); 
            loopnum = 0;
            while (setcommandids.Read())
            {
                commandOSID[loopnum] = Convert.ToString(setcommandids[2]);
                loopnum += 1;
            }
            setcommandids.Close();
            MySqlDataReader setcommandtext = commandcmd.ExecuteReader(); 
            loopnum = 0;
            while (setcommandtext.Read())
            {
                commandText[loopnum] = Convert.ToString(setcommandtext[4]);
                loopnum += 1;
            }
            setcommandtext.Close();
            MySqlDataReader commandrdr = commandcmd.ExecuteReader();
            int height;
            height = 206;
            loopnum = 0;
            int pointX = 235;
            int pointY = 20;
            int boxnum = 0;
            string value;
            pnlConfiguration.Height += 40;
            this.Height += 40;
            int temploop;
            string yes = "No";
            while (operatingSystemsID[loopnum] != null)
            {
                value = Convert.ToString(operatingSystems[loopnum]);
                temploop = 0;
                height += 20;
                this.Height += 20;
                pnlConfiguration.Height += 20;
                CheckBox box;
                box = new CheckBox();
                box.Name = "chkOS" + Convert.ToString(loopnum);
                box.Text = value;
                box.CheckedChanged += new System.EventHandler(valueChecked);
                box.AutoSize = true;
                box.Location = new Point(10, (loopnum + 1) * 20);
                pnlConfiguration.Controls.Add(box);
                TextBox a = new TextBox();
                a.Location = new Point(pointX, pointY);
                a.Name = "txtInput" + (loopnum - 1);
                a.Width = 849;
                temploop = 0;
                pnlConfiguration.Controls.Add(a);
                pnlConfiguration.Show();
                commandrdr.Read();
                while (commandOSID[temploop] != null)
                {
                    if (Convert.ToString(operatingSystemsID[loopnum]) == Convert.ToString(commandOSID[temploop]))
                    {
                        box.Checked = true;
                        a.Enabled = true;
                        a.Text = Convert.ToString(commandText[temploop]);
                        yes = "Yes";
                    }
                    temploop += 1;
                }
                if (yes != "Yes")
                {
                    box.Checked = false;
                    a.Enabled = false;
                }
                yes = "No";
                loopnum += 1;
                pointY += 20;
                boxnum += 1;

            }
            commandrdr.Close();
            finished = true;
            btnEditCommand.Top += loopnum * 23;
            btnCancel.Top += loopnum * 23;
        }

        private void btnNewCommand_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); 
            conn.Open();
            createloop = 0;
            MySqlCommand newDeleteCommand = new MySqlCommand("DELETE FROM `serverCommands` WHERE `commandName` = @commandName AND serverCompany = @serverCompany", conn); 
            newDeleteCommand.Parameters.AddWithValue("@commandName", cmboCommands.Text);
            newDeleteCommand.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
            newDeleteCommand.ExecuteNonQuery(); 
            while (loopnum != createloop)
            {
                string chkname = "chkOS" + Convert.ToString(createloop);
                string inputname = "txtInput" + Convert.ToString(createloop - 1);
                var os = "";
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
                var checkBox = this.Controls.Find(chkname, true).FirstOrDefault() as CheckBox;
                
                try
                {
                    string checkBoxText = checkBox.Text;
                    MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", conn);
                    oscmd.Parameters.AddWithValue("@os", checkBoxText);
                    MySqlDataReader osrdr = oscmd.ExecuteReader();
                    osrdr.Read();
                    os = Convert.ToString(osrdr[0]);
                    osrdr.Close();
                }
                catch (Exception)
                {

                }

                try
                {
                    if (text.Text != "")
                    {
                        MySqlCommand newCommand = new MySqlCommand("INSERT INTO `serverCommands` (`serverCompany`, `serverOS`, `commandName`, `serverCommand`) VALUES (@serverCompany, @serverOS, @commandName, @serverCommand)", conn); 
                        newCommand.Parameters.AddWithValue("@serverCommand", text.Text);
                        newCommand.Parameters.AddWithValue("@commandName", cmboCommands.Text);
                        newCommand.Parameters.AddWithValue("@serverOS", os);
                        newCommand.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
                        newCommand.ExecuteNonQuery(); 
                    }

                }
                catch (Exception)
                {

                }
                createloop += 1;
            }

            conn.Close();
            Hide();
        }
    }
}
