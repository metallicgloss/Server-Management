namespace ELSM_Project
{
    partial class serverControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverControl));
            this.lblMetallicGloss = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnManageServers = new System.Windows.Forms.Button();
            this.btnManageLocations = new System.Windows.Forms.Button();
            this.btnServerControl = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.ELHSLogo = new System.Windows.Forms.PictureBox();
            this.menuBackground = new System.Windows.Forms.PictureBox();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.btnCreateCommand = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblServerControl = new System.Windows.Forms.Label();
            this.btnServerStatus = new System.Windows.Forms.Button();
            this.btnRunCommand = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ELHSLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMetallicGloss
            // 
            this.lblMetallicGloss.AutoSize = true;
            this.lblMetallicGloss.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMetallicGloss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMetallicGloss.Font = new System.Drawing.Font("Raleway Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetallicGloss.Location = new System.Drawing.Point(51, 561);
            this.lblMetallicGloss.Name = "lblMetallicGloss";
            this.lblMetallicGloss.Size = new System.Drawing.Size(208, 26);
            this.lblMetallicGloss.TabIndex = 16;
            this.lblMetallicGloss.Text = "Originally developed by William Phillips.\r\nMetallicGloss.com";
            this.lblMetallicGloss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMetallicGloss.Click += new System.EventHandler(this.lblMetallicGloss_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Font = new System.Drawing.Font("Raleway SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(36, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 50);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Encrypted Laser\r\nServer Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 504);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(293, 43);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(0, 462);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(293, 43);
            this.btnManageAccount.TabIndex = 5;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnManageServers
            // 
            this.btnManageServers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageServers.FlatAppearance.BorderSize = 0;
            this.btnManageServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageServers.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageServers.Location = new System.Drawing.Point(0, 378);
            this.btnManageServers.Name = "btnManageServers";
            this.btnManageServers.Size = new System.Drawing.Size(293, 43);
            this.btnManageServers.TabIndex = 3;
            this.btnManageServers.Text = "Manage Servers";
            this.btnManageServers.UseVisualStyleBackColor = true;
            this.btnManageServers.Click += new System.EventHandler(this.btnManageServers_Click);
            // 
            // btnManageLocations
            // 
            this.btnManageLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageLocations.FlatAppearance.BorderSize = 0;
            this.btnManageLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLocations.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLocations.Location = new System.Drawing.Point(0, 420);
            this.btnManageLocations.Name = "btnManageLocations";
            this.btnManageLocations.Size = new System.Drawing.Size(293, 43);
            this.btnManageLocations.TabIndex = 4;
            this.btnManageLocations.Text = "Manage Locations";
            this.btnManageLocations.UseVisualStyleBackColor = true;
            this.btnManageLocations.Click += new System.EventHandler(this.btnManageLocations_Click);
            // 
            // btnServerControl
            // 
            this.btnServerControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServerControl.FlatAppearance.BorderSize = 0;
            this.btnServerControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerControl.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerControl.Location = new System.Drawing.Point(0, 336);
            this.btnServerControl.Name = "btnServerControl";
            this.btnServerControl.Size = new System.Drawing.Size(293, 43);
            this.btnServerControl.TabIndex = 2;
            this.btnServerControl.Text = "Server Control";
            this.btnServerControl.UseVisualStyleBackColor = true;
            this.btnServerControl.Click += new System.EventHandler(this.btnServerControl_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 294);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(293, 43);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ELHSLogo
            // 
            this.ELHSLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ELHSLogo.BackgroundImage = global::ELSM_Project.Properties.Resources.imgLogoPurple;
            this.ELHSLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ELHSLogo.Location = new System.Drawing.Point(75, 66);
            this.ELHSLogo.Name = "ELHSLogo";
            this.ELHSLogo.Size = new System.Drawing.Size(129, 115);
            this.ELHSLogo.TabIndex = 47;
            this.ELHSLogo.TabStop = false;
            // 
            // menuBackground
            // 
            this.menuBackground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBackground.Location = new System.Drawing.Point(0, -1);
            this.menuBackground.Name = "menuBackground";
            this.menuBackground.Size = new System.Drawing.Size(293, 609);
            this.menuBackground.TabIndex = 48;
            this.menuBackground.TabStop = false;
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCommand.FlatAppearance.BorderSize = 0;
            this.btnDeleteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(845, 453);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(240, 46);
            this.btnDeleteCommand.TabIndex = 57;
            this.btnDeleteCommand.Text = "Delete Command";
            this.btnDeleteCommand.UseVisualStyleBackColor = true;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCommand.FlatAppearance.BorderSize = 0;
            this.btnEditCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCommand.Location = new System.Drawing.Point(603, 453);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(240, 46);
            this.btnEditCommand.TabIndex = 56;
            this.btnEditCommand.Text = "Edit Command";
            this.btnEditCommand.UseVisualStyleBackColor = true;
            this.btnEditCommand.Click += new System.EventHandler(this.btnEditCommand_Click);
            // 
            // btnCreateCommand
            // 
            this.btnCreateCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCommand.FlatAppearance.BorderSize = 0;
            this.btnCreateCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCommand.Location = new System.Drawing.Point(361, 453);
            this.btnCreateCommand.Name = "btnCreateCommand";
            this.btnCreateCommand.Size = new System.Drawing.Size(240, 46);
            this.btnCreateCommand.TabIndex = 55;
            this.btnCreateCommand.Text = "Create Command";
            this.btnCreateCommand.UseVisualStyleBackColor = true;
            this.btnCreateCommand.Click += new System.EventHandler(this.btnCreateCommand_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(361, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(723, 1);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // lblServerControl
            // 
            this.lblServerControl.AutoSize = true;
            this.lblServerControl.BackColor = System.Drawing.Color.Transparent;
            this.lblServerControl.Font = new System.Drawing.Font("Raleway ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServerControl.Location = new System.Drawing.Point(624, 66);
            this.lblServerControl.Name = "lblServerControl";
            this.lblServerControl.Size = new System.Drawing.Size(185, 29);
            this.lblServerControl.TabIndex = 53;
            this.lblServerControl.Text = "Server Control";
            // 
            // btnServerStatus
            // 
            this.btnServerStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServerStatus.FlatAppearance.BorderSize = 0;
            this.btnServerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerStatus.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStatus.Location = new System.Drawing.Point(725, 501);
            this.btnServerStatus.Name = "btnServerStatus";
            this.btnServerStatus.Size = new System.Drawing.Size(359, 46);
            this.btnServerStatus.TabIndex = 52;
            this.btnServerStatus.Text = "Server Status";
            this.btnServerStatus.UseVisualStyleBackColor = true;
            this.btnServerStatus.Click += new System.EventHandler(this.btnServerStatus_Click);
            // 
            // btnRunCommand
            // 
            this.btnRunCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunCommand.FlatAppearance.BorderSize = 0;
            this.btnRunCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCommand.Location = new System.Drawing.Point(361, 501);
            this.btnRunCommand.Name = "btnRunCommand";
            this.btnRunCommand.Size = new System.Drawing.Size(361, 46);
            this.btnRunCommand.TabIndex = 51;
            this.btnRunCommand.Text = "Run Command";
            this.btnRunCommand.UseVisualStyleBackColor = true;
            this.btnRunCommand.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(361, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(723, 258);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.VirtualMode = true;
            // 
            // serverControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 601);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteCommand);
            this.Controls.Add(this.btnEditCommand);
            this.Controls.Add(this.btnCreateCommand);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblServerControl);
            this.Controls.Add(this.btnServerStatus);
            this.Controls.Add(this.btnRunCommand);
            this.Controls.Add(this.lblMetallicGloss);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnManageServers);
            this.Controls.Add(this.btnManageLocations);
            this.Controls.Add(this.btnServerControl);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ELHSLogo);
            this.Controls.Add(this.menuBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1146, 640);
            this.MinimumSize = new System.Drawing.Size(1146, 640);
            this.Name = "serverControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Control";
            this.Load += new System.EventHandler(this.serverControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ELHSLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetallicGloss;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button btnManageServers;
        private System.Windows.Forms.Button btnManageLocations;
        private System.Windows.Forms.Button btnServerControl;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox ELHSLogo;
        private System.Windows.Forms.PictureBox menuBackground;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.Button btnCreateCommand;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblServerControl;
        private System.Windows.Forms.Button btnServerStatus;
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}