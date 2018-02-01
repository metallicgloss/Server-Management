using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ELSM_Project
{
    public partial class initialSetup : Form
    {
        public initialSetup()
        {
            InitializeComponent();
        }


        private void initialSetup_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("setup.xml");
            string opt1 = doc.SelectSingleNode("Settings/Setup").InnerText;
            System.Windows.Forms.MessageBox.Show(Convert.ToString(opt1));
        }
    }
}
