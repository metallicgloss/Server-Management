namespace ELSM_Project
{
    partial class manageAccountUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageAccountUsername));
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblConfirmUsername = new System.Windows.Forms.Label();
            this.txtCurrentUsername = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtConfirmNewUsername = new System.Windows.Forms.TextBox();
            this.btnChangeUsername = new System.Windows.Forms.Button();
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
            this.lblCurrentUsername.Size = new System.Drawing.Size(139, 18);
            this.lblCurrentUsername.TabIndex = 26;
            this.lblCurrentUsername.Text = "Current Username:";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewUsername.Location = new System.Drawing.Point(33, 73);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(120, 18);
            this.lblNewUsername.TabIndex = 27;
            this.lblNewUsername.Text = "New Username:";
            // 
            // lblConfirmUsername
            // 
            this.lblConfirmUsername.AutoSize = true;
            this.lblConfirmUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmUsername.Location = new System.Drawing.Point(33, 110);
            this.lblConfirmUsername.Name = "lblConfirmUsername";
            this.lblConfirmUsername.Size = new System.Drawing.Size(142, 18);
            this.lblConfirmUsername.TabIndex = 28;
            this.lblConfirmUsername.Text = "Confirm Username:";
            // 
            // txtCurrentUsername
            // 
            this.txtCurrentUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentUsername.Location = new System.Drawing.Point(178, 33);
            this.txtCurrentUsername.Name = "txtCurrentUsername";
            this.txtCurrentUsername.ReadOnly = true;
            this.txtCurrentUsername.Size = new System.Drawing.Size(310, 20);
            this.txtCurrentUsername.TabIndex = 29;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUsername.Location = new System.Drawing.Point(178, 71);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(310, 20);
            this.txtNewUsername.TabIndex = 30;
            // 
            // txtConfirmNewUsername
            // 
            this.txtConfirmNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmNewUsername.Location = new System.Drawing.Point(178, 109);
            this.txtConfirmNewUsername.Name = "txtConfirmNewUsername";
            this.txtConfirmNewUsername.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmNewUsername.TabIndex = 31;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeUsername.FlatAppearance.BorderSize = 0;
            this.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUsername.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeUsername.Location = new System.Drawing.Point(36, 145);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(206, 31);
            this.btnChangeUsername.TabIndex = 32;
            this.btnChangeUsername.Text = "Process Username Change";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(281, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 31);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // manageAccountUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 203);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.txtConfirmNewUsername);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.txtCurrentUsername);
            this.Controls.Add(this.lblConfirmUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 242);
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "manageAccountUsername";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Account Username";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manageAccountUsername_FormClosing);
            this.Load += new System.EventHandler(this.manageAccountUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblConfirmUsername;
        private System.Windows.Forms.TextBox txtCurrentUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtConfirmNewUsername;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Button btnCancel;
    }
}