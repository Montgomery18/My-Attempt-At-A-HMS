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
    public partial class MainMenuNurse : Form
    {
        private string accessLevel;

        public MainMenuNurse()
        {
            InitializeComponent();
            accessLevel = "N";
        }

        private void picButtonPatientInformation_Click(object sender, EventArgs e)
        {
            PatientInformation patientInformation = new PatientInformation(accessLevel);
            Hide();
            patientInformation.ShowDialog();
            if (patientInformation.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonConditions_Click(object sender, EventArgs e)
        {
            Conditions conditions = new Conditions(accessLevel);
            Hide();
            conditions.ShowDialog();
            if (conditions.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picPatientDiagnoses_Click(object sender, EventArgs e)
        {
            DiagnosisDetails diagnosisDetails = new DiagnosisDetails(accessLevel);
            Hide();
            diagnosisDetails.ShowDialog();
            if (diagnosisDetails.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonAppointments_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments(accessLevel);
            Hide();
            appointments.ShowDialog();
            if (appointments.getLogoutState() == true)
            {
                Close();
            }
            Show();
        }

        private void picButtonMedicalStaff_Click(object sender, EventArgs e)
        {
            ViewNurseDoctorID medicalStaff = new ViewNurseDoctorID(accessLevel);
            Hide();
            medicalStaff.ShowDialog();
            if (medicalStaff.getLogoutState() == true)
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
