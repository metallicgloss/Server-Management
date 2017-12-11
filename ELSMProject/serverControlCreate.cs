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

        private void serverControlCreate_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString); // Turn connection string into MySQL Connection form.
            conn.Open();
            string os = "SELECT * FROM serverOperatingSystems"; // Create a string with the query command to run.
            MySqlCommand oscmd = new MySqlCommand(os, conn);
            MySqlDataReader osrdr = oscmd.ExecuteReader(); // Process the query command and feedback data to reader.
            int loopnum, height, width, button1x, button1y, button2x, button2y;
            width = 1182;
            height = 206;
            button1x = 36;
            button1y = 111;
            button2x = 579;
            button2y = 111;
            loopnum = 1;
            
            int boxnum = 0;
            string value;
            pnlConfiguration.Height += 40;
            this.Height += 40;
            while (osrdr.Read())
            {
                value = Convert.ToString(osrdr[1]);
                height += 20;
                this.Height += 20;
                pnlConfiguration.Height += 20;
                CheckBox box;
                box = new CheckBox();
                box.Tag = loopnum;
                box.Text = value;
                box.CheckedChanged += new System.EventHandler(valueChecked);
                box.AutoSize = true;
                box.Location = new Point(10, loopnum * 23);
                pnlConfiguration.Controls.Add(box);
                loopnum += 1;
            }
            int pointX = 235;
            int pointY = 20;
            int loopnum2 = 0;
            for (int i = 0; i < loopnum; i++)
            {
                TextBox a = new TextBox();
                a.Location = new Point(pointX, pointY);
                a.Tag = "Value" + loopnum2;
                a.Width = 849;
                a.Enabled = false;
                pnlConfiguration.Controls.Add(a);
                pnlConfiguration.Show();
                pointY += 20;
                boxnum += 1;
                loopnum2 += 1;
            }
            osrdr.Close();
            btnNewCommand.Top += loopnum2 * 23;
            btnCancel.Top += loopnum2 * 23;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void valueChecked(object sender, EventArgs e)
        {
            string name = this.Name;
            string inputname = "Value" + name;
            var text = this.Controls.Find(inputname, true).FirstOrDefault() as TextBox;
            text.Enabled = true;
        }

        
    }
}
