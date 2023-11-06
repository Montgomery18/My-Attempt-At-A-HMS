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
    public partial class MainMenuNoAccess : Form
    {
        public MainMenuNoAccess()
        {
            InitializeComponent();
        }

        private void picButtonLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
