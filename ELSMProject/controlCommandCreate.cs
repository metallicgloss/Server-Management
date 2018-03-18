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
            //On form load initialize component.
            InitializeComponent();
        }

        private static int loopnum = 1, createloop = 0, pointX = 235, pointY = 20;
        private static string value;

        private void serverControlCreate_Load(object sender, EventArgs e)
        {
			//Connect to MySQL and get all rows in serverOperatingSystems.
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            MySqlCommand oscmd = new MySqlCommand("SELECT * FROM serverOperatingSystems ORDER BY operatingSystemsID", conn);
            MySqlDataReader osrdr = oscmd.ExecuteReader();
            int height;
            height = 206;
            loopnum = 0;
            int boxnum = 0;
            pnlConfiguration.Height += 40;
            this.Height += 40;
			//For each row in reader, execute code.
            while (osrdr.Read())
            {
				// Create a dynamic checkbox, set the name of the checkbox equal to the loopnum. Set the text to the output of the read, create an event handler for it & set sizing and locations. Add it to the screen.
                CheckBox box = new CheckBox();
                box.Name = "chkOS" + Convert.ToString(loopnum);
                box.Text = Convert.ToString(osrdr[1]);
                box.CheckedChanged += new System.EventHandler(valueChecked);
                box.AutoSize = true;
                box.Location = new Point(10, loopnum * 20);
                pnlConfiguration.Controls.Add(box);
				//Add 1 to loop.
                loopnum += 1;
            }
            int pointX = 235;
            int pointY = 0;
            int loopnum2 = 0;
			//For each line that read has processed, execute code.
            for (int i = 0; i < loopnum; i++)
            {
				//Create dynamic textbox, set the location, width and set it to enabled. Set the name of the text box to the loopnum.
                TextBox a = new TextBox();
                a.Location = new Point(pointX, pointY);
                a.Name = "txtInput" + loopnum2;
                a.Width = 800;
                a.Enabled = false;
                pnlConfiguration.Controls.Add(a);
                pnlConfiguration.Show();
                pointY += 20;
                boxnum += 1;
                loopnum2 += 1;
            }
            osrdr.Close();
			//Set form heights.
            this.Height += loopnum2 * 5;
            pnlConfiguration.Height += (loopnum2 * 5);
            btnNewCommand.Top += loopnum2 * 6;
            btnCancel.Top += loopnum2 * 6;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //On button event, hide the form.
            Hide();
        }

        private void valueChecked(object sender, EventArgs e)
        {
			//When a checkbox is checked or unchcked, split apart the name to get the ID, compile the ID to be able to target the textbox and then enable the textbox if checked, clear and disable if unchecked.
            string name = ((CheckBox)sender).Name;
            name = name.Replace("chkOS", string.Empty);
            int OSNumber = Convert.ToInt16(name);
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
            MySqlConnection connectionMySQL = new MySqlConnection(loginMenu.ConnectionString);
            connectionMySQL.Open();
            while (loopnum != createloop)
            {
				//Compile a string to be able to then target the textbox and checkbox to see if it is checked and has text. Then connect to MySQL.
                string chkname = "chkOS" + Convert.ToString(createloop);
                string inputname = "txtInput" + Convert.ToString(createloop);
                var os = "";
                var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
                var checkBox = this.Controls.Find(chkname, true).FirstOrDefault() as CheckBox;
                string checkBoxText = checkBox.Text;
                MySqlCommand osCMD = new MySqlCommand("SELECT * FROM serverOperatingSystems WHERE operatingSystemsName = @os", connectionMySQL);
                osCMD.Parameters.AddWithValue("@os", checkBoxText);
                MySqlDataReader osRDR = osCMD.ExecuteReader();
                osRDR.Read();
                os = Convert.ToString(osRDR[0]);
                osRDR.Close();
				//If the textbox isn't blank, insert new command.
                if (text.Text != "")
                {
                    MySqlCommand newCommandCMD = new MySqlCommand("INSERT INTO `serverCommands` (`serverCompany`, `serverOS`, `commandName`, `serverCommand`) VALUES (@serverCompany, @serverOS, @commandName, @serverCommand)", connectionMySQL);
                    newCommandCMD.Parameters.AddWithValue("@serverCommand", text.Text);
                    newCommandCMD.Parameters.AddWithValue("@commandName", txtCommandName.Text);
                    newCommandCMD.Parameters.AddWithValue("@serverOS", os);
                    newCommandCMD.Parameters.AddWithValue("@serverCompany", loginMenu.CompanyID);
                    newCommandCMD.ExecuteNonQuery();
                }
                createloop += 1;
            }
            connectionMySQL.Close();
            Hide();
        }
    }
}
