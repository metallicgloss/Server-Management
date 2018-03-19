namespace ELSM_Project
{
    partial class setupEmailConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setupEmailConfiguration));
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.lblDatabasePassword = new System.Windows.Forms.Label();
            this.txtEmailUsername = new System.Windows.Forms.TextBox();
            this.lblEmailUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // logoImage
            // 
            this.logoImage.BackColor = System.Drawing.Color.Transparent;
            this.logoImage.BackgroundImage = global::ELSM_Project.Properties.Resources.imgLogo;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImage.Location = new System.Drawing.Point(287, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(118, 123);
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Raleway ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(130, 154);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(444, 29);
            this.lblWelcome.TabIndex = 44;
            this.lblWelcome.Text = "Welcome to the ELSM configuration!";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(60, 183);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(598, 30);
            this.lblDescription.TabIndex = 45;
            this.lblDescription.Text = "An open-source application for remote Linux server management, developed by Willi" +
    "am Phillips.\r\nCommisioned initially for Encrypted Laser Limited.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSMTPServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTPServer.Location = new System.Drawing.Point(245, 260);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(413, 20);
            this.txtSMTPServer.TabIndex = 47;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.BackColor = System.Drawing.Color.Transparent;
            this.lblHostname.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHostname.Location = new System.Drawing.Point(60, 260);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(100, 18);
            this.lblHostname.TabIndex = 46;
            this.lblHostname.Text = "SMTP Server:";
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSMTPPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSMTPPort.Location = new System.Drawing.Point(245, 286);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(413, 20);
            this.txtSMTPPort.TabIndex = 49;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabaseName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatabaseName.Location = new System.Drawing.Point(60, 286);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(83, 18);
            this.lblDatabaseName.TabIndex = 48;
            this.lblDatabaseName.Text = "SMTP Port:";
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.Location = new System.Drawing.Point(63, 375);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(595, 31);
            this.btnInstall.TabIndex = 54;
            this.btnInstall.Text = "Login";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailPassword.Location = new System.Drawing.Point(245, 338);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '•';
            this.txtEmailPassword.Size = new System.Drawing.Size(413, 20);
            this.txtEmailPassword.TabIndex = 53;
            // 
            // lblDatabasePassword
            // 
            this.lblDatabasePassword.AutoSize = true;
            this.lblDatabasePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabasePassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabasePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatabasePassword.Location = new System.Drawing.Point(60, 338);
            this.lblDatabasePassword.Name = "lblDatabasePassword";
            this.lblDatabasePassword.Size = new System.Drawing.Size(119, 18);
            this.lblDatabasePassword.TabIndex = 52;
            this.lblDatabasePassword.Text = "Email Password:";
            // 
            // txtEmailUsername
            // 
            this.txtEmailUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailUsername.Location = new System.Drawing.Point(245, 312);
            this.txtEmailUsername.Name = "txtEmailUsername";
            this.txtEmailUsername.Size = new System.Drawing.Size(413, 20);
            this.txtEmailUsername.TabIndex = 51;
            // 
            // lblEmailUsername
            // 
            this.lblEmailUsername.AutoSize = true;
            this.lblEmailUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmailUsername.Location = new System.Drawing.Point(60, 312);
            this.lblEmailUsername.Name = "lblEmailUsername";
            this.lblEmailUsername.Size = new System.Drawing.Size(125, 18);
            this.lblEmailUsername.TabIndex = 55;
            this.lblEmailUsername.Text = "Email Username:";
            // 
            // setupEmailConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 433);
            this.ControlBox = false;
            this.Controls.Add(this.lblEmailUsername);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.txtEmailPassword);
            this.Controls.Add(this.lblDatabasePassword);
            this.Controls.Add(this.txtEmailUsername);
            this.Controls.Add(this.txtSMTPPort);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtSMTPServer);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.logoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(544, 178);
            this.Name = "setupEmailConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Setup";
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtSMTPServer;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label lblDatabasePassword;
        private System.Windows.Forms.TextBox txtEmailUsername;
        private System.Windows.Forms.Label lblEmailUsername;
    }
}