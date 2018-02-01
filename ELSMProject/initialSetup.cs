using System;
using System.Xml;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ELSM_Project
{
    public partial class initialSetup : Form
    {
        public initialSetup()
        {
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
                string UID = doc.SelectSingleNode("Settings/UserName").InnerText;
                string PASSWORD = doc.SelectSingleNode("Settings/Password").InnerText;
                ConnectionString = "SERVER" + IP + ";DATABASE" + DATABASE + ";UID=" + UID + ";PASSWORD=" + PASSWORD + ";";
                loginMenu login = new loginMenu();
                login.ShowDialog();
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            string Hostname, Name, Username, Password, Connection;
            Hostname = txtHostname.Text;
            Name = txtDatabaseName.Text;
            Username = txtDatabaseUsername.Text;
            Password = txtDatabasePassword.Text;
            Connection = "SERVER" + Hostname + ";DATABASE" + Name + ";UID=" + Username + ";PASSWORD=" + Password + ";";
            MySqlConnection connectionMySQL = new MySqlConnection(Connection); // Open MySQL connection 
            connectionMySQL.Open(); // Open MySQL connection
            MySqlCommand installIfNotFound = new MySqlCommand("SET SQL_MODE = 'NO_AUTO_VALUE_ON_ZERO'; SET AUTOCOMMIT = 0; START TRANSACTION; SET time_zone = '+00:00'; /*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */; /*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */; /*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */; /*!40101 SET NAMES utf8mb4 */; CREATE TABLE IF NOT EXISTS `failedLoginAttempts`( `attemptID` int(11) NOT NULL AUTO_INCREMENT, `attemptUsername` varchar(128) COLLATE utf8_unicode_ci NOT NULL, `attemptIP` varchar(123) COLLATE utf8_unicode_ci NOT NULL, `attemptTimeStamp` datetime NOT NULL, PRIMARY KEY (`attemptID`)) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `serverCommands` ( `serverCommandID` int(11) NOT NULL AUTO_INCREMENT, `serverCompany` int(11) NOT NULL, `serverOS` int(11) NOT NULL, `commandName` varchar(128) COLLATE utf8_unicode_ci NOT NULL, `serverCommand` varchar(8192) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`serverCommandID`), KEY `serverCompany` (`serverCompany`), KEY `serverOS` (`serverOS`) ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `serverInformation` ( `serverID` int(11) NOT NULL AUTO_INCREMENT, `serverCompany` int(11) NOT NULL, `serverLocation` int(11) NOT NULL, `serverHostname` varchar(50) COLLATE utf8_unicode_ci NOT NULL, `serverUsername` varchar(30) COLLATE utf8_unicode_ci NOT NULL, `serverPassword` varchar(8192) COLLATE utf8_unicode_ci NOT NULL, `serverKey` text COLLATE utf8_unicode_ci NOT NULL, `serverOS` int(11) NOT NULL, `serverIP` varchar(17) COLLATE utf8_unicode_ci NOT NULL, `serverProcessor` varchar(40) COLLATE utf8_unicode_ci NOT NULL, `serverRAM` varchar(10) COLLATE utf8_unicode_ci NOT NULL, `serverPort` int(10) NOT NULL, `serverTransfer` varchar(4) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`serverID`), KEY `serverLocation` (`serverLocation`), KEY `serverOS` (`serverOS`), KEY `serverCompanyOwner` (`serverCompany`), KEY `serverPort` (`serverPort`) ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `serverLocations` ( `locationID` int(11) NOT NULL AUTO_INCREMENT, `companyID` int(11) NOT NULL, `locationName` varchar(50) COLLATE utf8_unicode_ci NOT NULL, `locationLongitude` varchar(20) COLLATE utf8_unicode_ci NOT NULL, `locationLatitude` varchar(20) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`locationID`), KEY `companyID` (`companyID`), KEY `locationName` (`locationName`) ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `serverOperatingSystems` ( `operatingSystemsID` int(11) NOT NULL AUTO_INCREMENT, `operatingSystemsName` varchar(50) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`operatingSystemsID`), KEY `operatingSystemsName` (`operatingSystemsName`) ) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; INSERT INTO `serverOperatingSystems` (`operatingSystemsID`, `operatingSystemsName`) VALUES (1, 'CentOS 5.10'), (2, 'CentOS 5.11'), (3, 'CentOS 5.5'), (4, 'CentOS 5.8'), (5, 'CentOS 5.9'), (6, 'CentOS 6.2'), (7, 'CentOS 6.3'), (8, 'CentOS 6.4'), (9, 'CentOS 6.5'), (10, 'CentOS 6.6'), (11, 'CentOS 6.9'), (12, 'CentOS 7.0'), (13, 'CentOS 7.1'), (14, 'CentOS 7.3'), (15, 'Debian 5.0'), (16, 'Debian 6.0'), (17, 'Debian 7.0'), (18, 'Debian 7.1'), (19, 'Debian 7.2'), (20, 'Debian 7.3'), (21, 'Debian 7.4'), (22, 'Debian 7.6'), (23, 'Debian 7.8'), (24, 'Debian 8.0'), (25, 'Debian 8.7'), (26, 'Fedora 13'), (27, 'Fedora 15'), (28, 'Fedora 16'), (29, 'Fedora 17'), (30, 'Fedora 18'), (31, 'Fedora 19'), (32, 'Fedora 20'), (33, 'Fedora 21'), (34, 'Scientific 6.3'), (35, 'Scientific 6.4'), (36, 'Scientific 6.6'), (37, 'Scientific 7.0'), (38, 'Scientific 7.1'), (39, 'Suse 11.3'), (40, 'Suse 12.2'), (41, 'Suse 12.3'), (42, 'Suse 13.1'), (43, 'Ubuntu 10.04'), (44, 'Ubuntu 10.10'), (45, 'Ubuntu 11.04'), (46, 'Ubuntu 11.10'), (47, 'Ubuntu 12.04'), (48, 'Ubuntu 12.10'), (49, 'Ubuntu 13.04'), (50, 'Ubuntu 13.10'), (51, 'Ubuntu 14.04'), (52, 'Ubuntu 15.04'), (53, 'Ubuntu 16.04'); CREATE TABLE IF NOT EXISTS `serverPort` ( `portID` int(11) NOT NULL AUTO_INCREMENT, `portSpeed` varchar(20) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`portID`), KEY `portSpeed` (`portSpeed`) ) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; INSERT INTO `serverPort` (`portID`, `portSpeed`) VALUES (6, '100Gbps'), (2, '100Mbps'), (5, '10Gbps'), (1, '10Mbps'), (3, '1Gbps'), (4, '3Gbps'); CREATE TABLE IF NOT EXISTS `systemReplies` ( `replyID` int(11) NOT NULL AUTO_INCREMENT, `ticketID` int(11) NOT NULL, `userID` int(11) NOT NULL, `replyContent` varchar(8192) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`replyID`) ) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `systemTickets` ( `ticketID` int(11) NOT NULL AUTO_INCREMENT, `ticketUpdated` datetime NOT NULL, `ticketCustomer` int(11) NOT NULL, `ticketRegarding` varchar(1024) COLLATE utf8_unicode_ci NOT NULL, PRIMARY KEY (`ticketID`) ) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `userAccounts` ( `userID` int(11) NOT NULL AUTO_INCREMENT, `userLogin` varchar(128) COLLATE utf8_unicode_ci NOT NULL, `userPassword` varchar(8192) COLLATE utf8_unicode_ci NOT NULL, `userForename` varchar(64) COLLATE utf8_unicode_ci NOT NULL, `userSurname` varchar(64) COLLATE utf8_unicode_ci NOT NULL, `userEmailAddress` varchar(128) COLLATE utf8_unicode_ci NOT NULL, `userImage` varchar(256) COLLATE utf8_unicode_ci NOT NULL, `userCompany` int(5) NOT NULL, `userRole` int(10) NOT NULL, `userIPAddress` varchar(13) COLLATE utf8_unicode_ci NOT NULL, `userLastLogin` datetime NOT NULL, PRIMARY KEY (`userID`), KEY `userCompany` (`userCompany`), KEY `userRole` (`userRole`) ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `userCompanies` ( `companyID` int(11) NOT NULL AUTO_INCREMENT, `ownerID` varchar(10) COLLATE utf8_unicode_ci NOT NULL, `companyName` varchar(256) COLLATE utf8_unicode_ci NOT NULL, `companyDateCreated` date NOT NULL, PRIMARY KEY (`companyID`) ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; CREATE TABLE IF NOT EXISTS `userPermissions` ( `permID` int(11) NOT NULL AUTO_INCREMENT, `companyID` int(11) NOT NULL, `permRole` varchar(30) COLLATE utf8_unicode_ci NOT NULL, `permDateModified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, `permChangePassword` tinyint(1) NOT NULL, `permChangeUsername` tinyint(1) NOT NULL, `permChangeEmail` tinyint(1) NOT NULL, `permViewServers` tinyint(1) NOT NULL, `permEditServers` tinyint(4) NOT NULL, `permDeleteServers` tinyint(1) NOT NULL, `permViewLocations` tinyint(1) NOT NULL, `permEditLocations` tinyint(1) NOT NULL, `permDeleteLocations` tinyint(1) NOT NULL, `permCreateTicket` tinyint(1) NOT NULL, `permAdminTicket` tinyint(1) NOT NULL, `permCloseTicket` tinyint(1) NOT NULL, `permViewServerPass` tinyint(1) NOT NULL, `permEditServerPass` tinyint(1) NOT NULL, `permAddAction` tinyint(1) NOT NULL, `permEditAction` tinyint(1) NOT NULL, `permDeleteAction` tinyint(1) NOT NULL, `permRunUpdate` tinyint(1) NOT NULL, `permRunReboot` tinyint(1) NOT NULL, `permAddServerNote` tinyint(1) NOT NULL, `permRunCustomAction` tinyint(1) NOT NULL, `permAdminViewUsers` tinyint(1) NOT NULL, `permAdminEditUserInfo` tinyint(1) NOT NULL, `permAdminForcePassReset` tinyint(1) NOT NULL, `permAdminAddUser` tinyint(1) NOT NULL, `permAdminDelUser` tinyint(1) NOT NULL, `permAdminChangePermissions` tinyint(1) NOT NULL, `permControlServers` int(1) NOT NULL, PRIMARY KEY (`permID`), KEY `companyID` (`companyID`) ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci; ALTER TABLE `serverCommands` ADD CONSTRAINT `serverCommands_ibfk_1` FOREIGN KEY (`serverCompany`) REFERENCES `userCompanies` (`companyID`), ADD CONSTRAINT `serverCommands_ibfk_2` FOREIGN KEY (`serverOS`) REFERENCES `serverOperatingSystems` (`operatingSystemsID`); ALTER TABLE `serverInformation` ADD CONSTRAINT `serverInformation_ibfk_1` FOREIGN KEY (`serverCompany`) REFERENCES `userCompanies` (`companyID`), ADD CONSTRAINT `serverInformation_ibfk_2` FOREIGN KEY (`serverLocation`) REFERENCES `serverLocations` (`locationID`), ADD CONSTRAINT `serverInformation_ibfk_3` FOREIGN KEY (`serverOS`) REFERENCES `serverOperatingSystems` (`operatingSystemsID`), ADD CONSTRAINT `serverInformation_ibfk_4` FOREIGN KEY (`serverPort`) REFERENCES `serverPort` (`portID`); ALTER TABLE `serverLocations` ADD CONSTRAINT `serverLocations_ibfk_1` FOREIGN KEY (`companyID`) REFERENCES `userCompanies` (`companyID`); ALTER TABLE `userAccounts` ADD CONSTRAINT `userAccounts_ibfk_1` FOREIGN KEY (`userCompany`) REFERENCES `userCompanies` (`companyID`), ADD CONSTRAINT `userAccounts_ibfk_2` FOREIGN KEY (`userRole`) REFERENCES `userPermissions` (`permID`); ALTER TABLE `userPermissions` ADD CONSTRAINT `userPermissions_ibfk_1` FOREIGN KEY (`companyID`) REFERENCES `userCompanies` (`companyID`); COMMIT; /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */; /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */; /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;", connectionMySQL);
            installIfNotFound.ExecuteNonQuery();
            connectionMySQL.Close();

            string xmlFile = "test.xml";
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load(xmlFile);
            xmlDoc.SelectSingleNode("Settings/Setup").InnerText = "Yes";
            xmlDoc.SelectSingleNode("Settings/IP").InnerText = Hostname;
            xmlDoc.SelectSingleNode("Settings/Database").InnerText = Name;
            xmlDoc.SelectSingleNode("Settings/Username").InnerText = Username;
            xmlDoc.SelectSingleNode("Settings/Password").InnerText = Password;
            xmlDoc.Save(xmlFile);

            createCompany company = new createCompany();
            company.ShowDialog();
        }
    }
}
