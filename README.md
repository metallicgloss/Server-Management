# Linux Remote Server Management
A remote administration tool developed in C# to mass control and manage Linux servers over SSH.

**This program is _not_ intended for commercial use or public, but please feel free to mess around with the code and make what you'd like from it. The software has been released under Mozilla Public License 2.0.**

Originally developed as part of an A-Level computer science college qualification, this piece of software was created as a first attempt to create a working program within Visual Studio in the C# coding language. I stress again; this program is _not_ intended for public use as it likely has a lot of bugs and problems with it.

## Current Features
This program currently features:
* Automatic Setup
  * Remote MySQL Initiating
  * Automatic Admin Account Setup
  * SMTP Configuration (Needs Implementing)
* Personal Account Management
  * Change Username
  * Change Password
  * Change Email Address
  * Change Forename & Surname
* Account Management
  * View, Create, Edit & Delete Users
  * Configure Permission Level
* Location Management
  * View, Create, Edit & Delete Locations
  * Run Command
* Server Management
  * View, Create, Edit & Delete Servers
* Command Management
  * Create, Edit & Delete Commands
  * Per-OS Command Configuration
  * Ping All Servers / Check Server Status
  * Run Command
* Backup Centre
  * View, Create, Edit & Delete Backup Nodes
  * Execute Backup
* Ticket Management
  * Create Ticket
  * Reply-To Ticket
  * View Tickets
* Miscellaneous
  * Remote MySQL Data Storage
  * Multiple User Accounts
  * Hashed User Passwords (Method of salting needs improving)
  * Background Command & Backup Thread Processes