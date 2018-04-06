namespace ELSM_Project
{
    partial class ticketReply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketReply));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPostReply = new System.Windows.Forms.Button();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.txtReply = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPostReply = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(579, 594);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(541, 31);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPostReply
            // 
            this.btnPostReply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPostReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostReply.FlatAppearance.BorderSize = 0;
            this.btnPostReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostReply.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostReply.Location = new System.Drawing.Point(36, 594);
            this.btnPostReply.Name = "btnPostReply";
            this.btnPostReply.Size = new System.Drawing.Size(540, 31);
            this.btnPostReply.TabIndex = 44;
            this.btnPostReply.Text = "Submit Reply";
            this.btnPostReply.UseVisualStyleBackColor = false;
            this.btnPostReply.Click += new System.EventHandler(this.btnNewCommand_Click);
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.AutoScroll = true;
            this.pnlConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfiguration.Location = new System.Drawing.Point(36, 31);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Size = new System.Drawing.Size(1084, 277);
            this.pnlConfiguration.TabIndex = 50;
            // 
            // txtReply
            // 
            this.txtReply.Location = new System.Drawing.Point(36, 381);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(1084, 195);
            this.txtReply.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(164, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 1);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // lblPostReply
            // 
            this.lblPostReply.AutoSize = true;
            this.lblPostReply.BackColor = System.Drawing.Color.Transparent;
            this.lblPostReply.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostReply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPostReply.Location = new System.Drawing.Point(533, 329);
            this.lblPostReply.Name = "lblPostReply";
            this.lblPostReply.Size = new System.Drawing.Size(92, 19);
            this.lblPostReply.TabIndex = 54;
            this.lblPostReply.Text = "Post Reply";
            // 
            // ticketReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 649);
            this.ControlBox = false;
            this.Controls.Add(this.lblPostReply);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.pnlConfiguration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPostReply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1182, 688);
            this.MinimumSize = new System.Drawing.Size(1182, 688);
            this.Name = "ticketReply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Management";
            this.Load += new System.EventHandler(this.serverControlEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPostReply;
        private System.Windows.Forms.Panel pnlConfiguration;
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPostReply;
    }
}