namespace ELSM_Project
{
    partial class manageLocationsDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageLocationsDelete));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.cmboExisting = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLocation.FlatAppearance.BorderSize = 0;
            this.btnDeleteLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLocation.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocation.Location = new System.Drawing.Point(36, 84);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(206, 31);
            this.btnDeleteLocation.TabIndex = 44;
            this.btnDeleteLocation.Text = "Process Location Deletion";
            this.btnDeleteLocation.UseVisualStyleBackColor = false;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentUsername.Location = new System.Drawing.Point(33, 34);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(71, 18);
            this.lblCurrentUsername.TabIndex = 38;
            this.lblCurrentUsername.Text = "Location:";
            // 
            // cmboExisting
            // 
            this.cmboExisting.FormattingEnabled = true;
            this.cmboExisting.Location = new System.Drawing.Point(178, 33);
            this.cmboExisting.Name = "cmboExisting";
            this.cmboExisting.Size = new System.Drawing.Size(310, 21);
            this.cmboExisting.TabIndex = 46;
            // 
            // manageLocationsDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteLocation);
            this.Controls.Add(this.lblCurrentUsername);
            this.Controls.Add(this.cmboExisting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 178);
            this.MinimumSize = new System.Drawing.Size(544, 178);
            this.Name = "manageLocationsDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Location";
            this.Load += new System.EventHandler(this.manageLocationsDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.ComboBox cmboExisting;
    }
}