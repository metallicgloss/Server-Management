namespace ELSM_Project
{
    partial class setupDatabase
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
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtDatabaseUsername = new System.Windows.Forms.TextBox();
            this.lblDatabaseUsername = new System.Windows.Forms.Label();
            this.txtDatabasePassword = new System.Windows.Forms.TextBox();
            this.lblDatabasePassword = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
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
            // txtHostname
            // 
            this.txtHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHostname.Location = new System.Drawing.Point(245, 260);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(413, 20);
            this.txtHostname.TabIndex = 47;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.BackColor = System.Drawing.Color.Transparent;
            this.lblHostname.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHostname.Location = new System.Drawing.Point(60, 260);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(152, 18);
            this.lblHostname.TabIndex = 46;
            this.lblHostname.Text = "Database Hostname:";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabaseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabaseName.Location = new System.Drawing.Point(245, 286);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(413, 20);
            this.txtDatabaseName.TabIndex = 49;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabaseName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatabaseName.Location = new System.Drawing.Point(60, 286);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(123, 18);
            this.lblDatabaseName.TabIndex = 48;
            this.lblDatabaseName.Text = "Database Name:";
            // 
            // txtDatabaseUsername
            // 
            this.txtDatabaseUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabaseUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabaseUsername.Location = new System.Drawing.Point(245, 312);
            this.txtDatabaseUsername.Name = "txtDatabaseUsername";
            this.txtDatabaseUsername.Size = new System.Drawing.Size(413, 20);
            this.txtDatabaseUsername.TabIndex = 51;
            // 
            // lblDatabaseUsername
            // 
            this.lblDatabaseUsername.AutoSize = true;
            this.lblDatabaseUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabaseUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatabaseUsername.Location = new System.Drawing.Point(60, 312);
            this.lblDatabaseUsername.Name = "lblDatabaseUsername";
            this.lblDatabaseUsername.Size = new System.Drawing.Size(152, 18);
            this.lblDatabaseUsername.TabIndex = 50;
            this.lblDatabaseUsername.Text = "Database Username:";
            // 
            // txtDatabasePassword
            // 
            this.txtDatabasePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabasePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabasePassword.Location = new System.Drawing.Point(245, 338);
            this.txtDatabasePassword.Name = "txtDatabasePassword";
            this.txtDatabasePassword.PasswordChar = '•';
            this.txtDatabasePassword.Size = new System.Drawing.Size(413, 20);
            this.txtDatabasePassword.TabIndex = 53;
            // 
            // lblDatabasePassword
            // 
            this.lblDatabasePassword.AutoSize = true;
            this.lblDatabasePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblDatabasePassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabasePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatabasePassword.Location = new System.Drawing.Point(60, 338);
            this.lblDatabasePassword.Name = "lblDatabasePassword";
            this.lblDatabasePassword.Size = new System.Drawing.Size(146, 18);
            this.lblDatabasePassword.TabIndex = 52;
            this.lblDatabasePassword.Text = "Database Password:";
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.Location = new System.Drawing.Point(63, 410);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(595, 31);
            this.btnInstall.TabIndex = 54;
            this.btnInstall.Text = "Install/Connect";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // initialSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.txtDatabasePassword);
            this.Controls.Add(this.lblDatabasePassword);
            this.Controls.Add(this.txtDatabaseUsername);
            this.Controls.Add(this.lblDatabaseUsername);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.logoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(544, 178);
            this.Name = "initialSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Setup";
            this.Load += new System.EventHandler(this.initialSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtDatabaseUsername;
        private System.Windows.Forms.Label lblDatabaseUsername;
        private System.Windows.Forms.TextBox txtDatabasePassword;
        private System.Windows.Forms.Label lblDatabasePassword;
        private System.Windows.Forms.Button btnInstall;
    }
}