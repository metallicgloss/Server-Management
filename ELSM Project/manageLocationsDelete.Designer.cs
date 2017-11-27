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
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUsername.FlatAppearance.BorderSize = 0;
            this.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUsername.Location = new System.Drawing.Point(36, 84);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(206, 31);
            this.btnChangeUsername.TabIndex = 44;
            this.btnChangeUsername.Text = "Process Location Deletion";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 21);
            this.comboBox1.TabIndex = 46;
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
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 178);
            this.MinimumSize = new System.Drawing.Size(544, 178);
            this.Name = "manageLocationsDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}