﻿namespace ELSM_Project
{
    partial class serverEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateServer = new System.Windows.Forms.Button();
            this.lblHostname = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.cmboLocation = new System.Windows.Forms.ComboBox();
            this.cmboOS = new System.Windows.Forms.ComboBox();
            this.cmboNetwork = new System.Windows.Forms.ComboBox();
            this.txtProcessor = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtTransfer = new System.Windows.Forms.TextBox();
            this.cmboHostNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateServer
            // 
            this.btnUpdateServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateServer.FlatAppearance.BorderSize = 0;
            this.btnUpdateServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateServer.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateServer.Location = new System.Drawing.Point(36, 405);
            this.btnUpdateServer.Name = "btnUpdateServer";
            this.btnUpdateServer.Size = new System.Drawing.Size(206, 31);
            this.btnUpdateServer.TabIndex = 44;
            this.btnUpdateServer.Text = "Process Server Update";
            this.btnUpdateServer.UseVisualStyleBackColor = false;
            this.btnUpdateServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.BackColor = System.Drawing.Color.Transparent;
            this.lblHostname.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHostname.Location = new System.Drawing.Point(33, 38);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(83, 18);
            this.lblHostname.TabIndex = 40;
            this.lblHostname.Text = "Hostname:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocation.Location = new System.Drawing.Point(33, 73);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(71, 18);
            this.lblLocation.TabIndex = 39;
            this.lblLocation.Text = "Location:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(178, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(310, 20);
            this.txtPassword.TabIndex = 50;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.No;
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(178, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(310, 20);
            this.txtUsername.TabIndex = 49;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(33, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 18);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(33, 105);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 18);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "Username:";
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Cursor = System.Windows.Forms.Cursors.No;
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(178, 211);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(310, 20);
            this.txtIP.TabIndex = 56;
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessor.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProcessor.Location = new System.Drawing.Point(33, 250);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(125, 18);
            this.lblProcessor.TabIndex = 54;
            this.lblProcessor.Text = "Server Processor";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIP.Location = new System.Drawing.Point(33, 213);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(133, 18);
            this.lblIP.TabIndex = 53;
            this.lblIP.Text = "Server IP Address:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.Color.Transparent;
            this.lblOS.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOS.Location = new System.Drawing.Point(33, 174);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(135, 18);
            this.lblOS.TabIndex = 52;
            this.lblOS.Text = "Operating System:";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.BackColor = System.Drawing.Color.Transparent;
            this.lblTransfer.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTransfer.Location = new System.Drawing.Point(33, 362);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(66, 18);
            this.lblTransfer.TabIndex = 61;
            this.lblTransfer.Text = "Transfer:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPort.Location = new System.Drawing.Point(33, 323);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(103, 18);
            this.lblPort.TabIndex = 60;
            this.lblPort.Text = "Network Port:";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Transparent;
            this.lblRAM.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRAM.Location = new System.Drawing.Point(33, 287);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(44, 18);
            this.lblRAM.TabIndex = 58;
            this.lblRAM.Text = "RAM:";
            // 
            // cmboLocation
            // 
            this.cmboLocation.Cursor = System.Windows.Forms.Cursors.No;
            this.cmboLocation.Enabled = false;
            this.cmboLocation.FormattingEnabled = true;
            this.cmboLocation.Location = new System.Drawing.Point(178, 70);
            this.cmboLocation.Name = "cmboLocation";
            this.cmboLocation.Size = new System.Drawing.Size(310, 21);
            this.cmboLocation.TabIndex = 62;
            // 
            // cmboOS
            // 
            this.cmboOS.Cursor = System.Windows.Forms.Cursors.No;
            this.cmboOS.Enabled = false;
            this.cmboOS.FormattingEnabled = true;
            this.cmboOS.Location = new System.Drawing.Point(178, 173);
            this.cmboOS.Name = "cmboOS";
            this.cmboOS.Size = new System.Drawing.Size(310, 21);
            this.cmboOS.TabIndex = 63;
            // 
            // cmboNetwork
            // 
            this.cmboNetwork.Cursor = System.Windows.Forms.Cursors.No;
            this.cmboNetwork.Enabled = false;
            this.cmboNetwork.FormattingEnabled = true;
            this.cmboNetwork.Location = new System.Drawing.Point(178, 322);
            this.cmboNetwork.Name = "cmboNetwork";
            this.cmboNetwork.Size = new System.Drawing.Size(310, 21);
            this.cmboNetwork.TabIndex = 66;
            // 
            // txtProcessor
            // 
            this.txtProcessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessor.Cursor = System.Windows.Forms.Cursors.No;
            this.txtProcessor.Enabled = false;
            this.txtProcessor.Location = new System.Drawing.Point(178, 248);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.Size = new System.Drawing.Size(310, 20);
            this.txtProcessor.TabIndex = 68;
            // 
            // txtRAM
            // 
            this.txtRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRAM.Cursor = System.Windows.Forms.Cursors.No;
            this.txtRAM.Enabled = false;
            this.txtRAM.Location = new System.Drawing.Point(178, 285);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(310, 20);
            this.txtRAM.TabIndex = 69;
            // 
            // txtTransfer
            // 
            this.txtTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransfer.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTransfer.Enabled = false;
            this.txtTransfer.Location = new System.Drawing.Point(178, 360);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(310, 20);
            this.txtTransfer.TabIndex = 70;
            // 
            // cmboHostNames
            // 
            this.cmboHostNames.FormattingEnabled = true;
            this.cmboHostNames.Location = new System.Drawing.Point(178, 35);
            this.cmboHostNames.Name = "cmboHostNames";
            this.cmboHostNames.Size = new System.Drawing.Size(310, 21);
            this.cmboHostNames.TabIndex = 71;
            this.cmboHostNames.SelectedIndexChanged += new System.EventHandler(this.cmboHostNames_SelectedIndexChanged);
            // 
            // serverEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 455);
            this.ControlBox = false;
            this.Controls.Add(this.cmboHostNames);
            this.Controls.Add(this.txtTransfer);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtProcessor);
            this.Controls.Add(this.cmboNetwork);
            this.Controls.Add(this.cmboOS);
            this.Controls.Add(this.cmboLocation);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateServer);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(558, 542);
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "serverEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Server";
            this.Load += new System.EventHandler(this.manageServersEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateServer;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.ComboBox cmboLocation;
        private System.Windows.Forms.ComboBox cmboOS;
        private System.Windows.Forms.ComboBox cmboNetwork;
        private System.Windows.Forms.TextBox txtProcessor;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtTransfer;
        private System.Windows.Forms.ComboBox cmboHostNames;
    }
}