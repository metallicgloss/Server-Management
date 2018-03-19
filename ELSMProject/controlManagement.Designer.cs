namespace ELSM_Project
{
    partial class controlManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlManagement));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.btnCreateCommand = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblServerControl = new System.Windows.Forms.Label();
            this.btnServerStatus = new System.Windows.Forms.Button();
            this.btnRunCommand = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(171, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCommand.FlatAppearance.BorderSize = 0;
            this.btnDeleteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(528, 453);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(240, 46);
            this.btnDeleteCommand.TabIndex = 57;
            this.btnDeleteCommand.Text = "Delete Command";
            this.btnDeleteCommand.UseVisualStyleBackColor = true;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCommand.FlatAppearance.BorderSize = 0;
            this.btnEditCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCommand.Location = new System.Drawing.Point(286, 453);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(240, 46);
            this.btnEditCommand.TabIndex = 56;
            this.btnEditCommand.Text = "Edit Command";
            this.btnEditCommand.UseVisualStyleBackColor = true;
            this.btnEditCommand.Click += new System.EventHandler(this.btnEditCommand_Click);
            // 
            // btnCreateCommand
            // 
            this.btnCreateCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCommand.FlatAppearance.BorderSize = 0;
            this.btnCreateCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCommand.Location = new System.Drawing.Point(44, 453);
            this.btnCreateCommand.Name = "btnCreateCommand";
            this.btnCreateCommand.Size = new System.Drawing.Size(240, 46);
            this.btnCreateCommand.TabIndex = 55;
            this.btnCreateCommand.Text = "Create Command";
            this.btnCreateCommand.UseVisualStyleBackColor = true;
            this.btnCreateCommand.Click += new System.EventHandler(this.btnCreateCommand_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(44, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(723, 1);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // lblServerControl
            // 
            this.lblServerControl.AutoSize = true;
            this.lblServerControl.BackColor = System.Drawing.Color.Transparent;
            this.lblServerControl.Font = new System.Drawing.Font("Raleway ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServerControl.Location = new System.Drawing.Point(307, 66);
            this.lblServerControl.Name = "lblServerControl";
            this.lblServerControl.Size = new System.Drawing.Size(197, 29);
            this.lblServerControl.TabIndex = 53;
            this.lblServerControl.Text = "Control Servers";
            // 
            // btnServerStatus
            // 
            this.btnServerStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServerStatus.FlatAppearance.BorderSize = 0;
            this.btnServerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerStatus.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStatus.Location = new System.Drawing.Point(408, 501);
            this.btnServerStatus.Name = "btnServerStatus";
            this.btnServerStatus.Size = new System.Drawing.Size(360, 46);
            this.btnServerStatus.TabIndex = 52;
            this.btnServerStatus.Text = "Server Status";
            this.btnServerStatus.UseVisualStyleBackColor = true;
            this.btnServerStatus.Click += new System.EventHandler(this.btnServerStatus_Click);
            // 
            // btnRunCommand
            // 
            this.btnRunCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunCommand.FlatAppearance.BorderSize = 0;
            this.btnRunCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCommand.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCommand.Location = new System.Drawing.Point(44, 501);
            this.btnRunCommand.Name = "btnRunCommand";
            this.btnRunCommand.Size = new System.Drawing.Size(361, 46);
            this.btnRunCommand.TabIndex = 51;
            this.btnRunCommand.Text = "Run Command";
            this.btnRunCommand.UseVisualStyleBackColor = true;
            this.btnRunCommand.Click += new System.EventHandler(this.btnRunCommand_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(44, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(724, 258);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.VirtualMode = true;
            // 
            // controlManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ELSM_Project.Properties.Resources.imgBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 601);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteCommand);
            this.Controls.Add(this.btnEditCommand);
            this.Controls.Add(this.btnCreateCommand);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblServerControl);
            this.Controls.Add(this.btnServerStatus);
            this.Controls.Add(this.btnRunCommand);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1146, 640);
            this.Name = "controlManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Servers";
            this.Load += new System.EventHandler(this.serverControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.Button btnCreateCommand;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblServerControl;
        private System.Windows.Forms.Button btnServerStatus;
        private System.Windows.Forms.Button btnRunCommand;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}