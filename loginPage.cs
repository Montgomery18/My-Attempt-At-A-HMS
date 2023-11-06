using System.Drawing.Text;

namespace Hospital_Management_System
{
    public partial class LoginPage : Form
    {
        private OtherFormsFeaturesManagement credentialsCheck;

        public LoginPage()
        {
            InitializeComponent();
            credentialsCheck = new OtherFormsFeaturesManagement();
        }

        private void picButtonLogin_Click(object sender, EventArgs e)
        {
            string Access = credentialsCheck.Login(txtBoxUsernameInput.Text.ToLower(), txtBoxPasswordInput.Text);
            switch (Access)
            {
                case "D":
                    MainMenuDoctor mainMenuDoctor = new MainMenuDoctor();
                    Hide();
                    mainMenuDoctor.ShowDialog();
                    ResetLoginPage();
                    Show();
                    break;
                case "N":
                    MainMenuNurse mainMenuNurse = new MainMenuNurse();
                    Hide();
                    mainMenuNurse.ShowDialog();
                    ResetLoginPage();
                    Show();
                    break;
                case "R":
                    MainMenuReceptionist mainMenuReceptionist = new MainMenuReceptionist();
                    Hide();
                    mainMenuReceptionist.ShowDialog();
                    ResetLoginPage();
                    Show();
                    break;
                case "M":
                    MainMenuManager mainMenuManager = new MainMenuManager();
                    Hide();
                    mainMenuManager.ShowDialog();
                    ResetLoginPage();
                    Show();
                    break;
                case "SA":
                    MainMenuSysAdmin mainMenuSysAdmin = new MainMenuSysAdmin();
                    Hide();
                    mainMenuSysAdmin.ShowDialog();
                    ResetLoginPage();
                    Show();
                    break;
                case "IC":
                    lblWrongUserOrPass.Visible = true;
                    break;
                default:
                    MainMenuNoAccess mainMenuNoAccess = new MainMenuNoAccess();
                    Hide();
                    mainMenuNoAccess.ShowDialog();
                    ResetLoginPage();
                    Show();
                    break;
            }
        }

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            Hide();
            resetPassword.ShowDialog();
            ResetLoginPage();
            Show();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            Hide();
            createAccount.ShowDialog();
            ResetLoginPage();
            Show();
        }

        private void ResetLoginPage()
        {
            lblWrongUserOrPass.Visible = false;
            txtBoxUsernameInput.Text = "";
            txtBoxPasswordInput.Text = "";
        }
    }
}