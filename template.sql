SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE TABLE `backupNodeInformation` (
  `backupNodeID` int(11) NOT NULL,
  `backupNodeCompany` int(11) NOT NULL,
  `backupNodeLocation` int(11) NOT NULL,
  `backupNodeHostname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodeUsername` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodePassword` varchar(8192) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodeOS` int(11) NOT NULL,
  `backupNodeIP` varchar(17) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodeProcessor` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodeRAM` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodePort` int(10) NOT NULL,
  `backupNodeTransfer` varchar(4) COLLATE utf8_unicode_ci NOT NULL,
  `backupNodeBackupPath` varchar(128) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `failedLoginAttempts` (
  `attemptID` int(11) NOT NULL,
  `attemptUsername` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `attemptIP` varchar(123) COLLATE utf8_unicode_ci NOT NULL,
  `attemptTimeStamp` datetime NOT NULL,
  `attemptTries` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `serverCommands` (
  `serverCommandID` int(11) NOT NULL,
  `serverCompany` int(11) NOT NULL,
  `serverOS` int(11) NOT NULL,
  `commandName` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `serverCommand` varchar(8192) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `serverInformation` (
  `serverID` int(11) NOT NULL,
  `serverCompany` int(11) NOT NULL,
  `serverLocation` int(11) NOT NULL,
  `serverHostname` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `serverUsername` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `serverPassword` varchar(8192) COLLATE utf8_unicode_ci NOT NULL,
  `serverOS` int(11) NOT NULL,
  `serverIP` varchar(17) COLLATE utf8_unicode_ci NOT NULL,
  `serverProcessor` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `serverRAM` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `serverPort` int(10) NOT NULL,
  `serverTransfer` varchar(4) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `serverLocations` (
  `locationID` int(11) NOT NULL,
  `companyID` int(11) NOT NULL,
  `locationName` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `locationLongitude` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `locationLatitude` varchar(20) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `serverOperatingSystems` (
  `operatingSystemsID` int(11) NOT NULL,
  `operatingSystemsName` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

INSERT INTO `serverOperatingSystems` (`operatingSystemsID`, `operatingSystemsName`) VALUES
(1, 'CentOS 5.10'),
(2, 'CentOS 5.11'),
(3, 'CentOS 5.5'),
(4, 'CentOS 5.8'),
(5, 'CentOS 5.9'),
(6, 'CentOS 6.2'),
(7, 'CentOS 6.3'),
(8, 'CentOS 6.4'),
(9, 'CentOS 6.5'),
(10, 'CentOS 6.6'),
(11, 'CentOS 6.9'),
(12, 'CentOS 7.0'),
(13, 'CentOS 7.1'),
(14, 'CentOS 7.3'),
(15, 'Debian 5.0'),
(16, 'Debian 6.0'),
(17, 'Debian 7.0'),
(18, 'Debian 7.1'),
(19, 'Debian 7.2'),
(20, 'Debian 7.3'),
(21, 'Debian 7.4'),
(22, 'Debian 7.6'),
(23, 'Debian 7.8'),
(24, 'Debian 8.0'),
(25, 'Debian 8.7'),
(26, 'Fedora 13'),
(27, 'Fedora 15'),
(28, 'Fedora 16'),
(29, 'Fedora 17'),
(30, 'Fedora 18'),
(31, 'Fedora 19'),
(32, 'Fedora 20'),
(33, 'Fedora 21'),
(34, 'Scientific 6.3'),
(35, 'Scientific 6.4'),
(36, 'Scientific 6.6'),
(37, 'Scientific 7.0'),
(38, 'Scientific 7.1'),
(39, 'Suse 11.3'),
(40, 'Suse 12.2'),
(41, 'Suse 12.3'),
(42, 'Suse 13.1'),
(43, 'Ubuntu 10.04'),
(44, 'Ubuntu 10.10'),
(45, 'Ubuntu 11.04'),
(46, 'Ubuntu 11.10'),
(47, 'Ubuntu 12.04'),
(48, 'Ubuntu 12.10'),
(49, 'Ubuntu 13.04'),
(50, 'Ubuntu 13.10'),
(51, 'Ubuntu 14.04'),
(52, 'Ubuntu 15.04'),
(53, 'Ubuntu 16.04');

CREATE TABLE `serverPort` (
  `portID` int(11) NOT NULL,
  `portSpeed` varchar(20) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

INSERT INTO `serverPort` (`portID`, `portSpeed`) VALUES
(6, '100Gbps'),
(2, '100Mbps'),
(5, '10Gbps'),
(1, '10Mbps'),
(3, '1Gbps'),
(4, '3Gbps');

CREATE TABLE `systemReplies` (
  `replyID` int(11) NOT NULL,
  `ticketID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `replyContent` varchar(8192) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `systemTickets` (
  `ticketID` int(11) NOT NULL,
  `userCompanyID` int(11) NOT NULL,
  `ticketUpdated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ticketCustomer` int(11) NOT NULL,
  `ticketRegarding` varchar(1024) COLLATE utf8_unicode_ci NOT NULL,
  `ticketSubject` varchar(200) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `userAccounts` (
  `userID` int(11) NOT NULL,
  `userLogin` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `userPassword` varchar(8192) COLLATE utf8_unicode_ci NOT NULL,
  `userForename` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `userSurname` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `userEmailAddress` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `userImage` varchar(256) COLLATE utf8_unicode_ci NOT NULL,
  `userCompany` int(5) NOT NULL,
  `userRole` int(10) NOT NULL,
  `userIPAddress` varchar(13) COLLATE utf8_unicode_ci DEFAULT NULL,
  `userLastLogin` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `userCompanies` (
  `companyID` int(11) NOT NULL,
  `ownerID` int(11) NOT NULL,
  `companyName` varchar(256) COLLATE utf8_unicode_ci NOT NULL,
  `companyDateCreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

CREATE TABLE `userPermissions` (
  `permID` int(11) NOT NULL,
  `permRole` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `permDateModified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `permChangePassword` tinyint(1) NOT NULL,
  `permChangeUsername` tinyint(1) NOT NULL,
  `permChangeEmail` tinyint(1) NOT NULL,
  `permViewServers` tinyint(1) NOT NULL,
  `permEditServers` tinyint(4) NOT NULL,
  `permDeleteServers` tinyint(1) NOT NULL,
  `permViewLocations` tinyint(1) NOT NULL,
  `permEditLocations` tinyint(1) NOT NULL,
  `permDeleteLocations` tinyint(1) NOT NULL,
  `permCreateTicket` tinyint(1) NOT NULL,
  `permAdminTicketView` tinyint(1) NOT NULL,
  `permCloseTicket` tinyint(1) NOT NULL,
  `permAddAction` tinyint(1) NOT NULL,
  `permEditAction` tinyint(1) NOT NULL,
  `permDeleteAction` tinyint(1) NOT NULL,
  `permRunCustomAction` tinyint(1) NOT NULL,
  `permAdminViewUsers` tinyint(1) NOT NULL,
  `permAdminEditUserInfo` tinyint(1) NOT NULL,
  `permAdminForcePassReset` tinyint(1) NOT NULL,
  `permAdminAddUser` tinyint(1) NOT NULL,
  `permAdminDelUser` tinyint(1) NOT NULL,
  `permAdminChangePermissions` tinyint(1) NOT NULL,
  `permControlServers` tinyint(1) NOT NULL,
  `permManageBackupSystem` tinyint(1) NOT NULL,
  `permCreateLocation` tinyint(1) NOT NULL,
  `permCreateServer` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

INSERT INTO `userPermissions` (`permID`, `permRole`, `permDateModified`, `permChangePassword`, `permChangeUsername`, `permChangeEmail`, `permViewServers`, `permEditServers`, `permDeleteServers`, `permViewLocations`, `permEditLocations`, `permDeleteLocations`, `permCreateTicket`, `permAdminTicketView`, `permCloseTicket`, `permAddAction`, `permEditAction`, `permDeleteAction`, `permRunCustomAction`, `permAdminViewUsers`, `permAdminEditUserInfo`, `permAdminForcePassReset`, `permAdminAddUser`, `permAdminDelUser`, `permAdminChangePermissions`, `permControlServers`, `permManageBackupSystem`, `permCreateLocation`, `permCreateServer`) VALUES
(1, 'Admin', '2018-03-15 10:35:03', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
(2, 'System Administrator', '2018-03-15 10:36:09', 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0),
(3, 'Datacentre Manager', '2018-03-15 10:36:55', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1),
(4, 'Account Manager', '2018-03-15 10:37:42', 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0);

ALTER TABLE `backupNodeInformation`
  ADD PRIMARY KEY (`backupNodeID`),
  ADD KEY `backupNodeCompany` (`backupNodeCompany`),
  ADD KEY `backupNodeLocation` (`backupNodeLocation`),
  ADD KEY `backupNodeOS` (`backupNodeOS`),
  ADD KEY `backupNodePort` (`backupNodePort`);

ALTER TABLE `failedLoginAttempts`
  ADD PRIMARY KEY (`attemptID`);

ALTER TABLE `serverCommands`
  ADD PRIMARY KEY (`serverCommandID`),
  ADD KEY `serverCompany` (`serverCompany`),
  ADD KEY `serverOS` (`serverOS`);

ALTER TABLE `serverInformation`
  ADD PRIMARY KEY (`serverID`),
  ADD KEY `serverLocation` (`serverLocation`),
  ADD KEY `serverOS` (`serverOS`),
  ADD KEY `serverCompanyOwner` (`serverCompany`),
  ADD KEY `serverPort` (`serverPort`);

ALTER TABLE `serverLocations`
  ADD PRIMARY KEY (`locationID`),
  ADD KEY `companyID` (`companyID`),
  ADD KEY `locationName` (`locationName`);

ALTER TABLE `serverOperatingSystems`
  ADD PRIMARY KEY (`operatingSystemsID`),
  ADD KEY `operatingSystemsName` (`operatingSystemsName`);

ALTER TABLE `serverPort`
  ADD PRIMARY KEY (`portID`),
  ADD KEY `portSpeed` (`portSpeed`);

ALTER TABLE `systemReplies`
  ADD PRIMARY KEY (`replyID`),
  ADD KEY `ticketID` (`ticketID`),
  ADD KEY `userID` (`userID`);

ALTER TABLE `systemTickets`
  ADD PRIMARY KEY (`ticketID`),
  ADD KEY `userCompanyID` (`userCompanyID`),
  ADD KEY `ticketCustomer` (`ticketCustomer`);

ALTER TABLE `userAccounts`
  ADD PRIMARY KEY (`userID`),
  ADD KEY `userRole` (`userRole`);

ALTER TABLE `userCompanies`
  ADD PRIMARY KEY (`companyID`);

ALTER TABLE `userPermissions`
  ADD PRIMARY KEY (`permID`);

ALTER TABLE `backupNodeInformation`
  MODIFY `backupNodeID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `failedLoginAttempts`
  MODIFY `attemptID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `serverCommands`
  MODIFY `serverCommandID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `serverInformation`
  MODIFY `serverID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `serverLocations`
  MODIFY `locationID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `serverOperatingSystems`
  MODIFY `operatingSystemsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

ALTER TABLE `serverPort`
  MODIFY `portID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

ALTER TABLE `systemReplies`
  MODIFY `replyID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `systemTickets`
  MODIFY `ticketID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `userAccounts`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `userCompanies`
  MODIFY `companyID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `userPermissions`
  MODIFY `permID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

ALTER TABLE `backupNodeInformation`
  ADD CONSTRAINT `backupNodeInformation_ibfk_1` FOREIGN KEY (`backupNodeCompany`) REFERENCES `userCompanies` (`companyID`),
  ADD CONSTRAINT `backupNodeInformation_ibfk_2` FOREIGN KEY (`backupNodeLocation`) REFERENCES `serverLocations` (`locationID`),
  ADD CONSTRAINT `backupNodeInformation_ibfk_3` FOREIGN KEY (`backupNodeOS`) REFERENCES `serverOperatingSystems` (`operatingSystemsID`),
  ADD CONSTRAINT `backupNodeInformation_ibfk_4` FOREIGN KEY (`backupNodePort`) REFERENCES `serverPort` (`portID`);

ALTER TABLE `serverCommands`
  ADD CONSTRAINT `serverCommands_ibfk_1` FOREIGN KEY (`serverCompany`) REFERENCES `userCompanies` (`companyID`),
  ADD CONSTRAINT `serverCommands_ibfk_2` FOREIGN KEY (`serverOS`) REFERENCES `serverOperatingSystems` (`operatingSystemsID`);

ALTER TABLE `serverInformation`
  ADD CONSTRAINT `serverInformation_ibfk_1` FOREIGN KEY (`serverCompany`) REFERENCES `userCompanies` (`companyID`),
  ADD CONSTRAINT `serverInformation_ibfk_2` FOREIGN KEY (`serverLocation`) REFERENCES `serverLocations` (`locationID`),
  ADD CONSTRAINT `serverInformation_ibfk_3` FOREIGN KEY (`serverOS`) REFERENCES `serverOperatingSystems` (`operatingSystemsID`),
  ADD CONSTRAINT `serverInformation_ibfk_4` FOREIGN KEY (`serverPort`) REFERENCES `serverPort` (`portID`);

ALTER TABLE `serverLocations`
  ADD CONSTRAINT `serverLocations_ibfk_1` FOREIGN KEY (`companyID`) REFERENCES `userCompanies` (`companyID`);

ALTER TABLE `systemReplies`
  ADD CONSTRAINT `systemReplies_ibfk_1` FOREIGN KEY (`ticketID`) REFERENCES `systemTickets` (`ticketID`),
  ADD CONSTRAINT `systemReplies_ibfk_2` FOREIGN KEY (`userID`) REFERENCES `userAccounts` (`userID`);

ALTER TABLE `systemTickets`
  ADD CONSTRAINT `systemTickets_ibfk_1` FOREIGN KEY (`ticketCustomer`) REFERENCES `userAccounts` (`userID`),
  ADD CONSTRAINT `systemTickets_ibfk_2` FOREIGN KEY (`userCompanyID`) REFERENCES `userCompanies` (`companyID`);

ALTER TABLE `userAccounts`
  ADD CONSTRAINT `userAccounts_ibfk_2` FOREIGN KEY (`userRole`) REFERENCES `userPermissions` (`permID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
