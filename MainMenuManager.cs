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
    public partial class MainMenuManager : Form
    {
        private string accessLevel;

        public MainMenuManager()
        {
            InitializeComponent();
            accessLevel = "M";
        }

        private void picButtonStaffInformation_Click(object sender, EventArgs e)
        {
            StaffInformation staffInformation = new StaffInformation(accessLevel);
            Hide();
            staffInformation.ShowDialog();
            if (staffInformation.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonArchive_Click(object sender, EventArgs e)
        {
            Archive archive = new Archive(accessLevel);
            Hide();
            archive.ShowDialog();
            if (archive.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonJobRoles_Click(object sender, EventArgs e)
        {
            JobRoles jobRoles = new JobRoles(accessLevel);
            Hide();
            jobRoles.ShowDialog();
            if (jobRoles.getLogoutState() == true)
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
