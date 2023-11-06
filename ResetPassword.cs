using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class ResetPassword : Form
    {
        OtherFormsFeaturesManagement ResetPass;
        private Image WeakPass;
        private Image AlrightPass;
        private Image GoodPass;
        private Image StrongPass;

        public ResetPassword()
        {
            InitializeComponent();
            ResetPass = new OtherFormsFeaturesManagement();
            WeakPass = Image.FromFile("WeakPassword.png");
            AlrightPass = Image.FromFile("AlrightPassword.png");
            GoodPass = Image.FromFile("GoodPassword.png");
            StrongPass = Image.FromFile("StrongPassword.png");
        }

        private void picButtonRequestReset_Click(object sender, EventArgs e)
        {
            if (txtBoxUsernameInput.Text == "")
            {
                MessageBox.Show("Please enter your username");
            }
            else if (txtBoxPasswordInput.TextLength < 8)
            {
                MessageBox.Show("Please make sure your new password is longer then 8 characters");
            }
            else
            {
                ResetPass.AccCreationAccReset(txtBoxUsernameInput.Text, txtBoxPasswordInput.Text, "Reset_Requests", "New_Password");
                MessageBox.Show("Password Request Sucessfully Sent!");
                txtBoxUsernameInput.Text = "";
                txtBoxPasswordInput.Text = "";
            }
        }

        private void picButtonReturnToLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkPassword(object sender, EventArgs e)
        {
            if (txtBoxPasswordInput.Text.Length >= 8 && txtBoxPasswordInput.Text.Length < 12)
            {
                lblPasswordStrength.Text = "Password Strength - Alright";
                picPasswordStrength.Image = AlrightPass;
            }
            else if (txtBoxPasswordInput.Text.Length >= 12 && txtBoxPasswordInput.Text.Length < 16)
            {
                lblPasswordStrength.Text = "Password Strength - Good";
                picPasswordStrength.Image = GoodPass;
            }
            else if (txtBoxPasswordInput.Text.Length >= 16)
            {
                lblPasswordStrength.Text = "Password Strength - Strong";
                picPasswordStrength.Image = StrongPass;
            }
            else
            {
                lblPasswordStrength.Text = "Password Strength - To Weak";
                picPasswordStrength.Image = WeakPass;
            }
        }
    }
}
