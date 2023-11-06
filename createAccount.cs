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
    public partial class CreateAccount : Form
    {
        private OtherFormsFeaturesManagement createAcc;
        private Image WeakPass;
        private Image AlrightPass;
        private Image GoodPass;
        private Image StrongPass;
        private bool imageCheck;

        public CreateAccount()
        {
            InitializeComponent();
            createAcc = new OtherFormsFeaturesManagement();
            imageCheck = true;
            if (File.Exists("WeakPassword.png") && File.Exists("AlrightPassword.png") && File.Exists("GoodPassword.png") && File.Exists("StrongPassword.png"))
            {
                WeakPass = Image.FromFile("WeakPassword.png");
                AlrightPass = Image.FromFile("AlrightPassword.png");
                GoodPass = Image.FromFile("GoodPassword.png");
                StrongPass = Image.FromFile("StrongPassword.png");
            }
            else
            {
                imageCheck = false;
            }
        }

        private void picButtonCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtBoxUsernameInput.Text == "")
            {
                MessageBox.Show("Please enter a username");
            }
            else if (txtBoxPasswordInput.TextLength < 8)
            {
                MessageBox.Show("Please make sure your password is longer then 8 characters");
            }
            else
            {
                bool alreadyExists = createAcc.AccCreationAccReset(txtBoxUsernameInput.Text, txtBoxPasswordInput.Text, "Accounts", "Password");
                if (alreadyExists == false)
                {
                    MessageBox.Show("Account created,\nplease contact the system administrator so they can set your access level");
                }
                else
                {
                    MessageBox.Show("The account already exists");
                }
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
            if (imageCheck)
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
}
