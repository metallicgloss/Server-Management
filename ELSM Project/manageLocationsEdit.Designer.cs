namespace ELSM_Project
{
    partial class manageLocationsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageLocationsEdit));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblNewLongitude = new System.Windows.Forms.Label();
            this.lblNewLocation = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmboExisting = new System.Windows.Forms.ComboBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditLocation.FlatAppearance.BorderSize = 0;
            this.btnEditLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLocation.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocation.Location = new System.Drawing.Point(36, 186);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(206, 31);
            this.btnEditLocation.TabIndex = 44;
            this.btnEditLocation.Text = "Process Location Edit";
            this.btnEditLocation.UseVisualStyleBackColor = false;
            // 
            // txtLongitude
            // 
            this.txtLongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitude.Location = new System.Drawing.Point(178, 109);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(310, 20);
            this.txtLongitude.TabIndex = 43;
            // 
            // txtLocationName
            // 
            this.txtLocationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocationName.Location = new System.Drawing.Point(178, 71);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(310, 20);
            this.txtLocationName.TabIndex = 42;
            // 
            // lblNewLongitude
            // 
            this.lblNewLongitude.AutoSize = true;
            this.lblNewLongitude.BackColor = System.Drawing.Color.Transparent;
            this.lblNewLongitude.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLongitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewLongitude.Location = new System.Drawing.Point(33, 110);
            this.lblNewLongitude.Name = "lblNewLongitude";
            this.lblNewLongitude.Size = new System.Drawing.Size(82, 18);
            this.lblNewLongitude.TabIndex = 40;
            this.lblNewLongitude.Text = "Longitude:";
            // 
            // lblNewLocation
            // 
            this.lblNewLocation.AutoSize = true;
            this.lblNewLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblNewLocation.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewLocation.Location = new System.Drawing.Point(33, 73);
            this.lblNewLocation.Name = "lblNewLocation";
            this.lblNewLocation.Size = new System.Drawing.Size(118, 18);
            this.lblNewLocation.TabIndex = 39;
            this.lblNewLocation.Text = "Location Name:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocation.Location = new System.Drawing.Point(33, 34);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(128, 18);
            this.lblLocation.TabIndex = 38;
            this.lblLocation.Text = "Existing Location:";
            // 
            // cmboExisting
            // 
            this.cmboExisting.FormattingEnabled = true;
            this.cmboExisting.Location = new System.Drawing.Point(178, 33);
            this.cmboExisting.Name = "cmboExisting";
            this.cmboExisting.Size = new System.Drawing.Size(310, 21);
            this.cmboExisting.TabIndex = 47;
            // 
            // txtLatitude
            // 
            this.txtLatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatitude.Location = new System.Drawing.Point(178, 147);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(310, 20);
            this.txtLatitude.TabIndex = 49;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.BackColor = System.Drawing.Color.Transparent;
            this.lblLatitude.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLatitude.Location = new System.Drawing.Point(33, 148);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(68, 18);
            this.lblLatitude.TabIndex = 48;
            this.lblLatitude.Text = "Latitude:";
            // 
            // manageLocationsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 241);
            this.ControlBox = false;
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditLocation);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.lblNewLongitude);
            this.Controls.Add(this.lblNewLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cmboExisting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 280);
            this.MinimumSize = new System.Drawing.Size(544, 280);
            this.Name = "manageLocationsEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label lblNewLongitude;
        private System.Windows.Forms.Label lblNewLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmboExisting;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
    }
}