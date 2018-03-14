namespace ELSM_Project
{
    partial class userEdit
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
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.txtProfileImage = new System.Windows.Forms.TextBox();
            this.cmboUserID = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(36, 302);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(206, 31);
            this.btnUpdateUser.TabIndex = 44;
            this.btnUpdateUser.Text = "Process User Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnNewuser_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserID.Location = new System.Drawing.Point(33, 38);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(58, 18);
            this.lblUserID.TabIndex = 40;
            this.lblUserID.Text = "UserID:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocation.Location = new System.Drawing.Point(33, 73);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(83, 18);
            this.lblLocation.TabIndex = 39;
            this.lblLocation.Text = "Username:";
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtForename.Location = new System.Drawing.Point(178, 142);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(310, 20);
            this.txtForename.TabIndex = 50;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Location = new System.Drawing.Point(178, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(310, 20);
            this.txtPassword.TabIndex = 49;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(33, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 18);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Forename:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(33, 105);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 18);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "Password:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.Location = new System.Drawing.Point(178, 215);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(310, 20);
            this.txtEmailAddress.TabIndex = 56;
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessor.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProcessor.Location = new System.Drawing.Point(33, 254);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(137, 18);
            this.lblProcessor.TabIndex = 54;
            this.lblProcessor.Text = "Profile Image URL:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.BackColor = System.Drawing.Color.Transparent;
            this.lblIP.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIP.Location = new System.Drawing.Point(33, 217);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(109, 18);
            this.lblIP.TabIndex = 53;
            this.lblIP.Text = "Email Address:";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.BackColor = System.Drawing.Color.Transparent;
            this.lblOS.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOS.Location = new System.Drawing.Point(33, 180);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(74, 18);
            this.lblOS.TabIndex = 52;
            this.lblOS.Text = "Surname:";
            // 
            // txtProfileImage
            // 
            this.txtProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfileImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfileImage.Location = new System.Drawing.Point(178, 252);
            this.txtProfileImage.Name = "txtProfileImage";
            this.txtProfileImage.Size = new System.Drawing.Size(310, 20);
            this.txtProfileImage.TabIndex = 68;
            // 
            // cmboUserID
            // 
            this.cmboUserID.FormattingEnabled = true;
            this.cmboUserID.Location = new System.Drawing.Point(178, 35);
            this.cmboUserID.Name = "cmboUserID";
            this.cmboUserID.Size = new System.Drawing.Size(310, 21);
            this.cmboUserID.TabIndex = 71;
            this.cmboUserID.SelectedIndexChanged += new System.EventHandler(this.cmboHostNames_SelectedIndexChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Location = new System.Drawing.Point(178, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(310, 20);
            this.txtUsername.TabIndex = 72;
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Location = new System.Drawing.Point(178, 180);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(310, 20);
            this.txtSurname.TabIndex = 73;
            // 
            // userEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 359);
            this.ControlBox = false;
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmboUserID);
            this.Controls.Add(this.txtProfileImage);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(558, 542);
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "userEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.manageusersEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox txtProfileImage;
        private System.Windows.Forms.ComboBox cmboUserID;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSurname;
    }
}