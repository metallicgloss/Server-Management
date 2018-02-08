namespace ELSM_Project
{
    partial class accountEmail
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
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblConfirmUsername = new System.Windows.Forms.Label();
            this.txtCurrentEmail = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmEmail = new System.Windows.Forms.TextBox();
            this.btnChangeEmail = new System.Windows.Forms.Button();
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
            this.lblCurrentUsername.Size = new System.Drawing.Size(105, 18);
            this.lblCurrentUsername.TabIndex = 26;
            this.lblCurrentUsername.Text = "Current Email:";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewUsername.Location = new System.Drawing.Point(33, 73);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(86, 18);
            this.lblNewUsername.TabIndex = 27;
            this.lblNewUsername.Text = "New Email:";
            // 
            // lblConfirmUsername
            // 
            this.lblConfirmUsername.AutoSize = true;
            this.lblConfirmUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmUsername.Location = new System.Drawing.Point(33, 110);
            this.lblConfirmUsername.Name = "lblConfirmUsername";
            this.lblConfirmUsername.Size = new System.Drawing.Size(108, 18);
            this.lblConfirmUsername.TabIndex = 28;
            this.lblConfirmUsername.Text = "Confirm Email:";
            // 
            // txtCurrentEmail
            // 
            this.txtCurrentEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentEmail.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCurrentEmail.Location = new System.Drawing.Point(178, 33);
            this.txtCurrentEmail.Name = "txtCurrentEmail";
            this.txtCurrentEmail.ReadOnly = true;
            this.txtCurrentEmail.Size = new System.Drawing.Size(310, 20);
            this.txtCurrentEmail.TabIndex = 29;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewEmail.Location = new System.Drawing.Point(178, 71);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(310, 20);
            this.txtNewEmail.TabIndex = 30;
            // 
            // txtConfirmEmail
            // 
            this.txtConfirmEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmEmail.Location = new System.Drawing.Point(178, 109);
            this.txtConfirmEmail.Name = "txtConfirmEmail";
            this.txtConfirmEmail.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmEmail.TabIndex = 31;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmail.FlatAppearance.BorderSize = 0;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeEmail.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Location = new System.Drawing.Point(36, 145);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(206, 31);
            this.btnChangeEmail.TabIndex = 32;
            this.btnChangeEmail.Text = "Process Email Change";
            this.btnChangeEmail.UseVisualStyleBackColor = false;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
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
            // accountEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 203);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.txtConfirmEmail);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.txtCurrentEmail);
            this.Controls.Add(this.lblConfirmUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 242);
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "accountEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Account Email";
            this.Load += new System.EventHandler(this.manageAccountEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblConfirmUsername;
        private System.Windows.Forms.TextBox txtCurrentEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtConfirmEmail;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Button btnCancel;
    }
}