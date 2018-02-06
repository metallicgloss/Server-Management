namespace ELSM_Project
{
    partial class backupNodeDelete
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
            this.btnDeleteServer = new System.Windows.Forms.Button();
            this.lblHostname = new System.Windows.Forms.Label();
            this.cmboHostname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0; // Set variable to 0
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
            // btnDeleteServer
            // 
            this.btnDeleteServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteServer.FlatAppearance.BorderSize = 0; // Set variable to 0
            this.btnDeleteServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteServer.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteServer.Location = new System.Drawing.Point(36, 84);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(206, 31);
            this.btnDeleteServer.TabIndex = 44;
            this.btnDeleteServer.Text = "Process Server Deletion";
            this.btnDeleteServer.UseVisualStyleBackColor = false;
            this.btnDeleteServer.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.BackColor = System.Drawing.Color.Transparent;
            this.lblHostname.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHostname.Location = new System.Drawing.Point(33, 34);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(83, 18);
            this.lblHostname.TabIndex = 38;
            this.lblHostname.Text = "Hostname:";
            // 
            // cmboHostname
            // 
            this.cmboHostname.FormattingEnabled = true;
            this.cmboHostname.Location = new System.Drawing.Point(178, 33);
            this.cmboHostname.Name = "cmboHostname";
            this.cmboHostname.Size = new System.Drawing.Size(310, 21);
            this.cmboHostname.TabIndex = 46;
            // 
            // backupNodeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteServer);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.cmboHostname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(544, 178);
            this.MinimumSize = new System.Drawing.Size(544, 178);
            this.Name = "backupNodeDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Server";
            this.Load += new System.EventHandler(this.backupNodeDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteServer;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.ComboBox cmboHostname;
    }
}