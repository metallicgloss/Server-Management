namespace ELSM_Project
{
    partial class accountSurname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountSurname));
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblConfirmUsername = new System.Windows.Forms.Label();
            this.txtCurrentSurname = new System.Windows.Forms.TextBox();
            this.txtNewSurname = new System.Windows.Forms.TextBox();
            this.txtConfirmSurname = new System.Windows.Forms.TextBox();
            this.btnChangeSurname = new System.Windows.Forms.Button();
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
            this.lblCurrentUsername.Size = new System.Drawing.Size(130, 18);
            this.lblCurrentUsername.TabIndex = 26;
            this.lblCurrentUsername.Text = "Current Surname:";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewUsername.Location = new System.Drawing.Point(33, 73);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(111, 18);
            this.lblNewUsername.TabIndex = 27;
            this.lblNewUsername.Text = "New Surname:";
            // 
            // lblConfirmUsername
            // 
            this.lblConfirmUsername.AutoSize = true;
            this.lblConfirmUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmUsername.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmUsername.Location = new System.Drawing.Point(33, 110);
            this.lblConfirmUsername.Name = "lblConfirmUsername";
            this.lblConfirmUsername.Size = new System.Drawing.Size(133, 18);
            this.lblConfirmUsername.TabIndex = 28;
            this.lblConfirmUsername.Text = "Confirm Surname:";
            // 
            // txtCurrentSurname
            // 
            this.txtCurrentSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentSurname.Location = new System.Drawing.Point(178, 33);
            this.txtCurrentSurname.Name = "txtCurrentSurname";
            this.txtCurrentSurname.ReadOnly = true;
            this.txtCurrentSurname.Size = new System.Drawing.Size(310, 20);
            this.txtCurrentSurname.TabIndex = 29;
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewSurname.Location = new System.Drawing.Point(178, 71);
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.Size = new System.Drawing.Size(310, 20);
            this.txtNewSurname.TabIndex = 30;
            // 
            // txtConfirmSurname
            // 
            this.txtConfirmSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmSurname.Location = new System.Drawing.Point(178, 109);
            this.txtConfirmSurname.Name = "txtConfirmSurname";
            this.txtConfirmSurname.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmSurname.TabIndex = 31;
            // 
            // btnChangeSurname
            // 
            this.btnChangeSurname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeSurname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeSurname.FlatAppearance.BorderSize = 0;
            this.btnChangeSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSurname.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSurname.Location = new System.Drawing.Point(36, 145);
            this.btnChangeSurname.Name = "btnChangeSurname";
            this.btnChangeSurname.Size = new System.Drawing.Size(206, 31);
            this.btnChangeSurname.TabIndex = 32;
            this.btnChangeSurname.Text = "Process Surname Change";
            this.btnChangeSurname.UseVisualStyleBackColor = false;
            this.btnChangeSurname.Click += new System.EventHandler(this.btnChangeSurname_Click);
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
            // accountSurname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 203);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeSurname);
            this.Controls.Add(this.txtConfirmSurname);
            this.Controls.Add(this.txtNewSurname);
            this.Controls.Add(this.txtCurrentSurname);
            this.Controls.Add(this.lblConfirmUsername);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblCurrentUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 242);
            this.MinimumSize = new System.Drawing.Size(544, 242);
            this.Name = "accountSurname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Account Surname";
            this.Load += new System.EventHandler(this.accountSurname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblConfirmUsername;
        private System.Windows.Forms.TextBox txtCurrentSurname;
        private System.Windows.Forms.TextBox txtNewSurname;
        private System.Windows.Forms.TextBox txtConfirmSurname;
        private System.Windows.Forms.Button btnChangeSurname;
        private System.Windows.Forms.Button btnCancel;
    }
}