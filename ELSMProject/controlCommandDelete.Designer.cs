namespace ELSM_Project
{
    partial class controlCommandDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlCommandDelete));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.cmboName = new System.Windows.Forms.ComboBox();
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
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCommand.FlatAppearance.BorderSize = 0;
            this.btnDeleteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCommand.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(36, 84);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(206, 31);
            this.btnDeleteCommand.TabIndex = 44;
            this.btnDeleteCommand.Text = "Process Command Deletion";
            this.btnDeleteCommand.UseVisualStyleBackColor = false;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.BackColor = System.Drawing.Color.Transparent;
            this.lblCommandName.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCommandName.Location = new System.Drawing.Point(33, 34);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(131, 18);
            this.lblCommandName.TabIndex = 38;
            this.lblCommandName.Text = "Command Name:";
            // 
            // cmboName
            // 
            this.cmboName.FormattingEnabled = true;
            this.cmboName.Location = new System.Drawing.Point(178, 33);
            this.cmboName.Name = "cmboName";
            this.cmboName.Size = new System.Drawing.Size(310, 21);
            this.cmboName.TabIndex = 46;
            // 
            // controlCommandDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 139);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteCommand);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.cmboName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(544, 178);
            this.MinimumSize = new System.Drawing.Size(544, 178);
            this.Name = "controlCommandDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Command";
            this.Load += new System.EventHandler(this.serverControlDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.ComboBox cmboName;
    }
}