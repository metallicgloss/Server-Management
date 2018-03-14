namespace ELSM_Project
{
    partial class backupNodeCreate
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
            this.btnNewServer = new System.Windows.Forms.Button();
            this.txtHostname = new System.Windows.Forms.TextBox();
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
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewServer
            // 
            this.btnNewServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewServer.FlatAppearance.BorderSize = 0;
            this.btnNewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewServer.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewServer.Location = new System.Drawing.Point(36, 453);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(206, 31);
            this.btnNewServer.TabIndex = 44;
            this.btnNewServer.Text = "Process New Backup Server";
            this.btnNewServer.UseVisualStyleBackColor = false;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // txtHostname
            // 
            this.txtHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHostname.Location = new System.Drawing.Point(178, 34);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(310, 20);
            this.txtHostname.TabIndex = 43;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.BackColor = System.Drawing.Color.Transparent;
            this.lblHostname.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHostname.Location = new System.Drawing.Point(33, 35);
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
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Location = new System.Drawing.Point(178, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(310, 20);
            this.txtPassword.TabIndex = 50;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Location = new System.Drawing.Point(178, 110);
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
            this.lblPassword.Location = new System.Drawing.Point(33, 150);
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
            this.lblUsername.Location = new System.Drawing.Point(33, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 18);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "Username:";
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.Location = new System.Drawing.Point(178, 224);
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
            this.lblProcessor.Location = new System.Drawing.Point(33, 263);
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
            this.lblIP.Location = new System.Drawing.Point(33, 226);
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
            this.lblOS.Location = new System.Drawing.Point(33, 187);
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
            this.lblTransfer.Location = new System.Drawing.Point(33, 375);
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
            this.lblPort.Location = new System.Drawing.Point(33, 336);
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
            this.lblRAM.Location = new System.Drawing.Point(33, 300);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(44, 18);
            this.lblRAM.TabIndex = 58;
            this.lblRAM.Text = "RAM:";
            // 
            // cmboLocation
            // 
            this.cmboLocation.FormattingEnabled = true;
            this.cmboLocation.Location = new System.Drawing.Point(178, 70);
            this.cmboLocation.Name = "cmboLocation";
            this.cmboLocation.Size = new System.Drawing.Size(310, 21);
            this.cmboLocation.TabIndex = 62;
            // 
            // cmboOS
            // 
            this.cmboOS.FormattingEnabled = true;
            this.cmboOS.Location = new System.Drawing.Point(178, 186);
            this.cmboOS.Name = "cmboOS";
            this.cmboOS.Size = new System.Drawing.Size(310, 21);
            this.cmboOS.TabIndex = 63;
            // 
            // cmboNetwork
            // 
            this.cmboNetwork.FormattingEnabled = true;
            this.cmboNetwork.Location = new System.Drawing.Point(178, 335);
            this.cmboNetwork.Name = "cmboNetwork";
            this.cmboNetwork.Size = new System.Drawing.Size(310, 21);
            this.cmboNetwork.TabIndex = 66;
            // 
            // txtProcessor
            // 
            this.txtProcessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcessor.Location = new System.Drawing.Point(178, 261);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.Size = new System.Drawing.Size(310, 20);
            this.txtProcessor.TabIndex = 68;
            // 
            // txtRAM
            // 
            this.txtRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRAM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRAM.Location = new System.Drawing.Point(178, 298);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(310, 20);
            this.txtRAM.TabIndex = 69;
            // 
            // txtTransfer
            // 
            this.txtTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransfer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransfer.Location = new System.Drawing.Point(178, 373);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(310, 20);
            this.txtTransfer.TabIndex = 70;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupPath.Location = new System.Drawing.Point(178, 409);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(310, 20);
            this.txtBackupPath.TabIndex = 72;
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.BackColor = System.Drawing.Color.Transparent;
            this.lblBackupPath.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBackupPath.Location = new System.Drawing.Point(33, 411);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(98, 18);
            this.lblBackupPath.TabIndex = 71;
            this.lblBackupPath.Text = "Backup Path:";
            // 
            // backupNodeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 496);
            this.ControlBox = false;
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.lblBackupPath);
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
            this.Controls.Add(this.btnNewServer);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "backupNodeCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Backup Node";
            this.Load += new System.EventHandler(this.manageServersCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.TextBox txtHostname;
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
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label lblBackupPath;
    }
}