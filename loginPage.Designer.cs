namespace Hospital_Management_System
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxUsernameInput = new System.Windows.Forms.TextBox();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.txtBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblWrongUserOrPass = new System.Windows.Forms.Label();
            this.picButtonLogin = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxUsername.BackColor = System.Drawing.Color.White;
            this.txtboxUsername.Enabled = false;
            this.txtboxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxUsername.Location = new System.Drawing.Point(45, 62);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.txtboxUsername.MaxLength = 0;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.ReadOnly = true;
            this.txtboxUsername.Size = new System.Drawing.Size(107, 29);
            this.txtboxUsername.TabIndex = 0;
            this.txtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxUsernameInput
            // 
            this.txtBoxUsernameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsernameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsernameInput.Location = new System.Drawing.Point(152, 62);
            this.txtBoxUsernameInput.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.txtBoxUsernameInput.MaxLength = 20;
            this.txtBoxUsernameInput.Name = "txtBoxUsernameInput";
            this.txtBoxUsernameInput.PlaceholderText = "Enter your username";
            this.txtBoxUsernameInput.Size = new System.Drawing.Size(270, 29);
            this.txtBoxUsernameInput.TabIndex = 1;
            this.txtBoxUsernameInput.WordWrap = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblLoginTitle.Location = new System.Drawing.Point(189, 10);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(89, 37);
            this.lblLoginTitle.TabIndex = 3;
            this.lblLoginTitle.Text = "Login";
            // 
            // txtBoxPasswordInput
            // 
            this.txtBoxPasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPasswordInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPasswordInput.Location = new System.Drawing.Point(152, 122);
            this.txtBoxPasswordInput.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.txtBoxPasswordInput.MaxLength = 24;
            this.txtBoxPasswordInput.Name = "txtBoxPasswordInput";
            this.txtBoxPasswordInput.PlaceholderText = "Enter your password";
            this.txtBoxPasswordInput.Size = new System.Drawing.Size(270, 29);
            this.txtBoxPasswordInput.TabIndex = 5;
            this.txtBoxPasswordInput.UseSystemPasswordChar = true;
            this.txtBoxPasswordInput.WordWrap = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPassword.BackColor = System.Drawing.Color.White;
            this.txtBoxPassword.Enabled = false;
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(45, 122);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.txtBoxPassword.MaxLength = 0;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.ReadOnly = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(107, 29);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWrongUserOrPass
            // 
            this.lblWrongUserOrPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrongUserOrPass.AutoSize = true;
            this.lblWrongUserOrPass.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongUserOrPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblWrongUserOrPass.ForeColor = System.Drawing.Color.Red;
            this.lblWrongUserOrPass.Location = new System.Drawing.Point(130, 154);
            this.lblWrongUserOrPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWrongUserOrPass.Name = "lblWrongUserOrPass";
            this.lblWrongUserOrPass.Size = new System.Drawing.Size(206, 19);
            this.lblWrongUserOrPass.TabIndex = 6;
            this.lblWrongUserOrPass.Text = "Incorrect username or password";
            this.lblWrongUserOrPass.Visible = false;
            // 
            // picButtonLogin
            // 
            this.picButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonLogin.Image = global::Hospital_Management_System.Properties.Resources.LoginButton;
            this.picButtonLogin.Location = new System.Drawing.Point(142, 176);
            this.picButtonLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonLogin.Name = "picButtonLogin";
            this.picButtonLogin.Size = new System.Drawing.Size(183, 44);
            this.picButtonLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonLogin.TabIndex = 7;
            this.picButtonLogin.TabStop = false;
            this.picButtonLogin.Click += new System.EventHandler(this.picButtonLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(56, 65);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(61, 125);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblResetPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblResetPassword.Location = new System.Drawing.Point(189, 238);
            this.lblResetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(88, 15);
            this.lblResetPassword.TabIndex = 8;
            this.lblResetPassword.Text = "Reset Password";
            this.lblResetPassword.Click += new System.EventHandler(this.lblResetPassword_Click);
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblCreateAccount.ForeColor = System.Drawing.Color.Blue;
            this.lblCreateAccount.Location = new System.Drawing.Point(189, 285);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(89, 15);
            this.lblCreateAccount.TabIndex = 9;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(466, 322);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.picButtonLogin);
            this.Controls.Add(this.lblWrongUserOrPass);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBoxPasswordInput);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.txtBoxUsernameInput);
            this.Controls.Add(this.txtboxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtboxUsername;
        private TextBox txtBoxUsernameInput;
        private Label lblLoginTitle;
        private TextBox txtBoxPasswordInput;
        private TextBox txtBoxPassword;
        private Label lblWrongUserOrPass;
        private PictureBox picButtonLogin;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblResetPassword;
        private Label lblCreateAccount;
    }
}