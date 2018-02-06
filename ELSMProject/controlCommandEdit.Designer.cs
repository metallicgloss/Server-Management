namespace ELSM_Project
{
    partial class controlCommandEdit
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
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.cmboCommands = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0; // Set variable to 0
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
            // btnEditCommand
            // 
            this.btnEditCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCommand.FlatAppearance.BorderSize = 0; // Set variable to 0
            this.btnEditCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommand.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCommand.Location = new System.Drawing.Point(36, 111);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(540, 31);
            this.btnEditCommand.TabIndex = 44;
            this.btnEditCommand.Text = "Process Command Edit";
            this.btnEditCommand.UseVisualStyleBackColor = false;
            this.btnEditCommand.Click += new System.EventHandler(this.btnNewCommand_Click);
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
            this.cmboCommands.FormattingEnabled = true;
            this.cmboCommands.Location = new System.Drawing.Point(271, 29);
            this.cmboCommands.Name = "cmboCommands";
            this.cmboCommands.Size = new System.Drawing.Size(849, 21);
            this.cmboCommands.TabIndex = 51;
            this.cmboCommands.SelectedIndexChanged += new System.EventHandler(this.cmboCommands_SelectedIndexChanged);
            // 
            // serverControlEdit
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
            this.Controls.Add(this.btnEditCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "serverControlEdit";
            this.Text = "Edit Command";
            this.Load += new System.EventHandler(this.serverControlEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Panel pnlConfiguration;
        private System.Windows.Forms.ComboBox cmboCommands;
    }
}