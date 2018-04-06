namespace ELSM_Project
{
    partial class accountForename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountForename));
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblConfirmUsername = new System.Windows.Forms.Label();
            this.txtCurrentForename = new System.Windows.Forms.TextBox();
            this.txtNewForename = new System.Windows.Forms.TextBox();
            this.txtConfirmForename = new System.Windows.Forms.TextBox();
            this.btnChangeForename = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentUsername.Location = new System.Drawing.Point(33, 34);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(138, 18);
            this.lblCurrentUsername.TabIndex = 26;
            this.lblCurrentUsername.Text = "Current Forename:";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewUsername.Location = new System.Drawing.Point(33, 73);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(119, 18);
            this.lblNewUsername.TabIndex = 27;
            this.lblNewUsername.Text = "New Forename:";
            // 
            // lblConfirmUsername
            // 
            this.lblConfirmUsername.AutoSize = true;
            this.lblConfirmUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmUsername.Location = new System.Drawing.Point(33, 110);
            this.lblConfirmUsername.Name = "lblConfirmUsername";
            this.lblConfirmUsername.Size = new System.Drawing.Size(141, 18);
            this.lblConfirmUsername.TabIndex = 28;
            this.lblConfirmUsername.Text = "Confirm Forename:";
            // 
            // txtCurrentForename
            // 
            this.txtCurrentForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentForename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentForename.Location = new System.Drawing.Point(178, 33);
            this.txtCurrentForename.Name = "txtCurrentForename";
            this.txtCurrentForename.ReadOnly = true;
            this.txtCurrentForename.Size = new System.Drawing.Size(310, 20);
            this.txtCurrentForename.TabIndex = 29;
            // 
            // txtNewForename
            // 
            this.txtNewForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewForename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewForename.Location = new System.Drawing.Point(178, 71);
            this.txtNewForename.Name = "txtNewForename";
            this.txtNewForename.Size = new System.Drawing.Size(310, 20);
            this.txtNewForename.TabIndex = 30;
            // 
            // txtConfirmForename
            // 
            this.txtConfirmForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmForename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmForename.Location = new System.Drawing.Point(178, 109);
            this.txtConfirmForename.Name = "txtConfirmForename";
            this.txtConfirmForename.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmForename.TabIndex = 31;
            // 
            // btnChangeForename
            // 
            this.btnChangeForename.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeForename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeForename.FlatAppearance.BorderSize = 0;
            this.btnChangeForename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeForename.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeForename.Location = new System.Drawing.Point(36, 145);
            this.btnChangeForename.Name = "btnChangeForename";
            this.btnChangeForename.Size = new System.Drawing.Size(206, 31);
            this.btnChangeForename.TabIndex = 32;
            this.btnChangeForename.Text = "Process Forename Change";
            this.btnChangeForename.UseVisualStyleBackColor = false;
            this.btnChangeForename.Click += new System.EventHandler(this.btnChangeForename_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // accountForename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 203);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeForename);
            this.Controls.Add(this.txtConfirmForename);
            this.Controls.Add(this.txtNewForename);
            this.Controls.Add(this.txtCurrentForename);
            this.Controls.Add(this.lblConfirmUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 242);
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "accountForename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Account Forename";
            this.Load += new System.EventHandler(this.accountForename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblConfirmUsername;
        private System.Windows.Forms.TextBox txtCurrentForename;
        private System.Windows.Forms.TextBox txtNewForename;
        private System.Windows.Forms.TextBox txtConfirmForename;
        private System.Windows.Forms.Button btnChangeForename;
        private System.Windows.Forms.Button btnCancel;
    }
}