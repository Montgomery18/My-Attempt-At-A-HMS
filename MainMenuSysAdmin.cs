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
    public partial class MainMenuSysAdmin : Form
    {
        private string accessLevel;

        public MainMenuSysAdmin()
        {
            InitializeComponent();
            accessLevel = "SA";
        }

        private void picButtonAccountManagement_Click(object sender, EventArgs e)
        {
            AccountManagement accountManagement = new AccountManagement(accessLevel);
            Hide();
            accountManagement.ShowDialog();
            if (accountManagement.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonResetRequest_Click(object sender, EventArgs e)
        {
            ResetRequests resetRequests = new ResetRequests(accessLevel);
            Hide();
            resetRequests.ShowDialog();
            if (resetRequests.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonStaffNames_Click(object sender, EventArgs e)
        {
            StaffNames staffNames = new StaffNames(accessLevel);
            Hide();
            staffNames.ShowDialog();
            if (staffNames.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
