namespace ELSM_Project
{
    partial class backupRunProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backupRunProcess));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRunBackup = new System.Windows.Forms.Button();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(579, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(541, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRunBackup
            // 
            this.btnRunBackup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRunBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunBackup.FlatAppearance.BorderSize = 0;
            this.btnRunBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunBackup.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunBackup.Location = new System.Drawing.Point(36, 111);
            this.btnRunBackup.Name = "btnRunBackup";
            this.btnRunBackup.Size = new System.Drawing.Size(540, 31);
            this.btnRunBackup.TabIndex = 44;
            this.btnRunBackup.Text = "Process Backup Request";
            this.btnRunBackup.UseVisualStyleBackColor = false;
            this.btnRunBackup.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.AutoScroll = true;
            this.pnlConfiguration.Location = new System.Drawing.Point(36, 27);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(1084, 62);
            this.pnlConfiguration.TabIndex = 50;
            // 
            // backupRunProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 167);
            this.ControlBox = false;
            this.Controls.Add(this.pnlConfiguration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRunBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "backupRunProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run Command";
            this.Load += new System.EventHandler(this.serverControlRunCommand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRunBackup;
        private System.Windows.Forms.Panel pnlConfiguration;
    }
}