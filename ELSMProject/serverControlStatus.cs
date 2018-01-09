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
using System.Net.NetworkInformation;

namespace ELSM_Project
{
    public partial class serverControlStatus : Form
    {
        public serverControlStatus()
        {
            InitializeComponent();
        }


        public static int loopnum, createloop;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void serverControlStatus_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(loginMenu.ConnectionString);
            conn.Open();
            string os = "SELECT * FROM serverInformation ORDER BY serverID";
            MySqlCommand oscmd = new MySqlCommand(os, conn);
            MySqlDataReader osrdr = oscmd.ExecuteReader();
            int height;
            height = 206;
            loopnum = 1;

            int boxnum = 0;
            string value;

            int pointY = 20;
            int pointX = 235;
            pnlConfiguration.Height += 40;
            this.Height += 40;
            while (osrdr.Read())
            {
                value = Convert.ToString(osrdr[3]);
                Label name;
                name = new Label();
                name.Name = "lblServer" + Convert.ToString(loopnum);
                name.Text = value;
                name.AutoSize = true;
                name.Location = new Point(10, loopnum * 20);
                pnlConfiguration.Controls.Add(name);
                Label a = new Label();
                a.Location = new Point(pointX, pointY);
                a.Name = "lblInput" + loopnum;
                a.Width = 800;
                a.Height -= 5;
                a.ForeColor = Color.Black;
                Ping p = new Ping();
                PingReply r;
                string s;
                s = Convert.ToString(osrdr[8]);
                r = p.Send(s);
                if (r.Status == IPStatus.Success)
                {
                    a.Text = "Ping to " + s.ToString() + " Successful! "
                       + " Response Time " + r.RoundtripTime.ToString() + "ms";
                }
                pnlConfiguration.Controls.Add(a);
                pnlConfiguration.Show();
                pointY += 20;
                boxnum += 1;
                loopnum += 1;
            }
            osrdr.Close();
            this.Height += loopnum * 5;
            pnlConfiguration.Height += (loopnum * 5);
            btnCancel.Top += ((loopnum+5) * 6);
        }
    }
}
