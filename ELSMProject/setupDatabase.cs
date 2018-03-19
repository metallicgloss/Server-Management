using System;
using System.Xml;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ELSM_Project
{
    public partial class setupDatabase : Form
    {
        public setupDatabase()
        {
            //On form load initialize component.
            InitializeComponent();
        }

        public static string ConnectionString;

        private void initialSetup_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("setup.xml");
            string Setup = doc.SelectSingleNode("Settings/Setup").InnerText;
            if (Setup != "No")
            {
                string IP = doc.SelectSingleNode("Settings/IP").InnerText;
                string DATABASE = doc.SelectSingleNode("Settings/Database").InnerText;
                string UID = doc.SelectSingleNode("Settings/Username").InnerText;
                string PASSWORD = doc.SelectSingleNode("Settings/Password").InnerText;
                ConnectionString = "SERVER=" + IP + ";DATABASE=" + DATABASE + ";UID=" + UID + ";PASSWORD=" + PASSWORD + ";";
                loginMenu login = new loginMenu();
                login.ShowDialog();
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
			//If all values entered aren't blank, execute.
            if ((txtHostname.Text != "") && (txtDatabaseName.Text != "") && (txtDatabaseUsername.Text != "") && (txtDatabasePassword.Text != ""))
            {
				//Set variables to input.
                string Hostname, Name, Username, Password, Connection;
                Hostname = txtHostname.Text;
                Name = txtDatabaseName.Text;
                Username = txtDatabaseUsername.Text;
                Password = txtDatabasePassword.Text;
                Connection = "SERVER=" + Hostname + ";DATABASE=" + Name + ";UID=" + Username + ";PASSWORD=" + Password + ";";
                MySqlConnection connectionMySQL = new MySqlConnection(Connection);
                connectionMySQL.Open();
				//If content exists in database, proceed setting database information. Else, execute SQL to create database.
                try
                {
                    MySqlCommand checkIfExists = new MySqlCommand("SELECT * FROM serverOperatingSystems", connectionMySQL);
                    MySqlDataReader rdr = checkIfExists.ExecuteReader();
                }
                catch (Exception)
                {
                    MySqlCommand installIfNotFound = new MySqlCommand("", connectionMySQL);
                    installIfNotFound.ExecuteNonQuery();
                }
                string xmlFile = "setup.xml";
				//Set lines of XML file.
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                xmlDoc.Load(xmlFile);
                xmlDoc.SelectSingleNode("Settings/Setup").InnerText = "Yes";
                xmlDoc.SelectSingleNode("Settings/IP").InnerText = Hostname;
                xmlDoc.SelectSingleNode("Settings/Database").InnerText = Name;
                xmlDoc.SelectSingleNode("Settings/Username").InnerText = Username;
                xmlDoc.SelectSingleNode("Settings/Password").InnerText = Password;
                xmlDoc.Save(xmlFile);
                ConnectionString = "SERVER=" + Hostname + ";DATABASE=" + Name + ";UID=" + Username + ";PASSWORD=" + Password + ";";
                Hide();
                setupEmailConfiguration email = new setupEmailConfiguration();
                email.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter data into the form.");
            }
        }
    }
}
