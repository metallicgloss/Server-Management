namespace ELSM_Project
{
    partial class controlCommandRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlCommandRun));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRunCommand = new System.Windows.Forms.Button();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.cmboCommands = new System.Windows.Forms.ComboBox();
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
            // btnRunCommand
            // 
            this.btnRunCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRunCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunCommand.FlatAppearance.BorderSize = 0;
            this.btnRunCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCommand.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCommand.Location = new System.Drawing.Point(36, 111);
            this.btnRunCommand.Name = "btnRunCommand";
            this.btnRunCommand.Size = new System.Drawing.Size(540, 31);
            this.btnRunCommand.TabIndex = 44;
            this.btnRunCommand.Text = "Process Run Command";
            this.btnRunCommand.UseVisualStyleBackColor = false;
            this.btnRunCommand.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.BackColor = System.Drawing.Color.Transparent;
            this.lblCommandName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCommandName.Location = new System.Drawing.Point(40, 32);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(131, 18);
            this.lblCommandName.TabIndex = 48;
            this.lblCommandName.Text = "Command Name:";
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.AutoScroll = true;
            this.pnlConfiguration.Location = new System.Drawing.Point(36, 65);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(1084, 24);
            this.pnlConfiguration.TabIndex = 50;
            // 
            // cmboCommands
            // 
            this.cmboCommands.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmboCommands.FormattingEnabled = true;
            this.cmboCommands.Location = new System.Drawing.Point(271, 29);
            this.cmboCommands.Name = "cmboCommands";
            this.cmboCommands.Size = new System.Drawing.Size(849, 21);
            this.cmboCommands.TabIndex = 51;
            // 
            // controlCommandRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 167);
            this.ControlBox = false;
            this.Controls.Add(this.cmboCommands);
            this.Controls.Add(this.pnlConfiguration);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRunCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "controlCommandRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run Command";
            this.Load += new System.EventHandler(this.serverControlRunCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Panel pnlConfiguration;
        private System.Windows.Forms.ComboBox cmboCommands;
    }
}