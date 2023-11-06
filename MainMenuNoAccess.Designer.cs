namespace Hospital_Management_System
{
    partial class MainMenuNoAccess
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
            this.lblNoAccessLevelTitle = new System.Windows.Forms.Label();
            this.lblAccessLevelMessage = new System.Windows.Forms.Label();
            this.picButtonLogout = new System.Windows.Forms.PictureBox();
            this.pictureBoxLungLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLungLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoAccessLevelTitle
            // 
            this.lblNoAccessLevelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoAccessLevelTitle.AutoSize = true;
            this.lblNoAccessLevelTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNoAccessLevelTitle.Location = new System.Drawing.Point(164, 9);
            this.lblNoAccessLevelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoAccessLevelTitle.Name = "lblNoAccessLevelTitle";
            this.lblNoAccessLevelTitle.Size = new System.Drawing.Size(220, 37);
            this.lblNoAccessLevelTitle.TabIndex = 49;
            this.lblNoAccessLevelTitle.Text = "No Access Level";
            // 
            // lblAccessLevelMessage
            // 
            this.lblAccessLevelMessage.AutoSize = true;
            this.lblAccessLevelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccessLevelMessage.Location = new System.Drawing.Point(81, 62);
            this.lblAccessLevelMessage.Name = "lblAccessLevelMessage";
            this.lblAccessLevelMessage.Size = new System.Drawing.Size(386, 42);
            this.lblAccessLevelMessage.TabIndex = 50;
            this.lblAccessLevelMessage.Text = "Your account doesn\'t currently have an access level,\r\nplease contact the system a" +
    "dministrator to change this\r\n";
            this.lblAccessLevelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picButtonLogout
            // 
            this.picButtonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonLogout.BackColor = System.Drawing.Color.Transparent;
            this.picButtonLogout.Image = global::Hospital_Management_System.Properties.Resources.LogoutButton;
            this.picButtonLogout.Location = new System.Drawing.Point(184, 122);
            this.picButtonLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonLogout.Name = "picButtonLogout";
            this.picButtonLogout.Size = new System.Drawing.Size(181, 41);
            this.picButtonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonLogout.TabIndex = 57;
            this.picButtonLogout.TabStop = false;
            this.picButtonLogout.Click += new System.EventHandler(this.picButtonLogout_Click);
            // 
            // pictureBoxLungLogo
            // 
            this.pictureBoxLungLogo.Image = global::Hospital_Management_System.Properties.Resources.LungLogo;
            this.pictureBoxLungLogo.Location = new System.Drawing.Point(241, 345);
            this.pictureBoxLungLogo.Name = "pictureBoxLungLogo";
            this.pictureBoxLungLogo.Size = new System.Drawing.Size(66, 58);
            this.pictureBoxLungLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLungLogo.TabIndex = 76;
            this.pictureBoxLungLogo.TabStop = false;
            // 
            // MainMenuNoAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(548, 406);
            this.Controls.Add(this.pictureBoxLungLogo);
            this.Controls.Add(this.picButtonLogout);
            this.Controls.Add(this.lblAccessLevelMessage);
            this.Controls.Add(this.lblNoAccessLevelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuNoAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Access Level";
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLungLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNoAccessLevelTitle;
        private Label lblAccessLevelMessage;
        private PictureBox picButtonLogout;
        private PictureBox pictureBoxLungLogo;
    }
}