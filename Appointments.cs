using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Appointments : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public Appointments(string access)
        {
            InitializeComponent();
            accessLevel = access;
            dataTable = new DataTable();
            cRUD = new MainCRUDFormsDataManagement();
            searchFunctions = new SearchFunctions();
            logoutState = false;
        }

        private void formLoaded(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            dataTable.Clear();
            List<string> tableAndDataColumns = new List<string> { "Appointments", "Appointments.Appointment_id", "Patients.Patient_id", "Patients.Firstname || ' ' || Patients.Lastname","Room", "Date_On", "Staff.Staff_id", "Staff.Firstname || ' ' || Staff.Lastname" };
            List<string> alias = new List<string> { "Appointment id", "Patient id", "Patient Name", "Room", "Date", "Staff id", "Assigned Staff Names" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, "Appointment_id", true, "Patients", "Patient_id", true, "Staff_Assigned_Appointments", "Staff", "Staff_id");
            dataGridView.DataSource = dataTable;
            dataGridView.Columns["Patient id"].Visible = false;
            dataGridView.Columns["Staff id"].Visible = false;

        }

        private void picButtonCreateData_Click(object sender, EventArgs e)
        {
            switch (panelCreate.Visible)
            {
                case true:
                    panelCreate.Visible = false;
                    break;
                default:
                    switch (accessLevel)
                    {
                        case "R":
                            panelCreate.Visible = true;
                            break;
                        case "D":
                            panelCreate.Visible = true;
                            break;
                        case "N":
                            panelCreate.Visible = true;
                            break;
                        default:
                            MessageBox.Show("You do not have the correct access to create data");
                            break;
                    }
                    break;
            }
        }

        private void picButtonDeleteData_Click(object sender, EventArgs e)
        {
            switch (panelDelete.Visible)
            {
                case true:
                    panelDelete.Visible = false;
                    break;
                default:
                    switch (accessLevel)
                    {
                        case "R":
                            panelDelete.Visible = true;
                            break;
                        case "D":
                            panelDelete.Visible = true;
                            break;
                        case "N":
                            panelDelete.Visible = true;
                            break;
                        default:
                            MessageBox.Show("You do not have the correct access to delete data");
                            break;
                    }
                    break;
            }
        }

        private void picButtonEditData_Click(object sender, EventArgs e)
        {
            switch (panelEdit.Visible)
            {
                case true:
                    panelEdit.Visible = false;
                    break;
                default:
                    switch (accessLevel)
                    {
                        case "R":
                            panelEdit.Visible = true;
                            break;
                        case "D":
                            panelEdit.Visible = true;
                            break;
                        case "N":
                            panelEdit.Visible = true;
                            break;
                        default:
                            MessageBox.Show("You do not have the correct access to edit data");
                            break;
                    }
                    break;
            }
        }

        private void picButtonAddEntry_Click(object sender, EventArgs e)
        {
            if (numCreatePatientID.Value == 0)
            {
                MessageBox.Show("Please enter the ID of the patient attending the appointment");
            }
            else if (numCreateDoctorAssignedID.Value == 0)
            {
                MessageBox.Show("Please enter the ID of the doctor performing the appointment");
            }
            else
            {
                bool alreadyExists = false;
                foreach (DataRow data in dataTable.Rows)
                {
                    if (numCreatePatientID.Value.ToString() == data["Patient id"].ToString() && txtCreateRoom.Text == data["Room"].ToString() && cRUD.CleanUpDate(datetimpickCreateDateOn.Value.ToString()) == data["Date"].ToString())
                    {
                        alreadyExists = true;
                    }
                }
                if (alreadyExists == true)
                {
                    MessageBox.Show("This entry already exists");
                }
                else
                {
                    string tableAndColumns = "Appointments (Patient_id, Room, Date_On)";
                    List<string> userInput = new List<string> { numCreatePatientID.Value.ToString(), txtCreateRoom.Text, cRUD.CleanUpDate(datetimpickCreateDateOn.Value.ToString()) };
                    List<string> userInputIDs = new List<string> { numCreateDoctorAssignedID.Value.ToString(), numCreateNurseAssignedID.Value.ToString(), numCreateExtraStaffAssignedID.Value.ToString() };
                    List<string> tableToLinkTable = new List<string> { "Appointments", "Appointment_id", "Staff_Assigned_Appointments", "Staff_id", "Patient_id", "Room", "Date_On" }; ;
                    cRUD.CreateData(tableAndColumns, userInput);
                    cRUD.linkTableFilling(tableToLinkTable, userInput, userInputIDs);
                    loadData();
                    dataGridView.Columns["Appointment_id"].Visible = false;
                    MessageBox.Show("Entry Created");
                    numCreatePatientID.Value = 0;
                    txtCreateRoom.Text = "";
                    datetimpickCreateDateOn.Value = DateTime.Now;
                    numCreateDoctorAssignedID.Value = 0;
                    numCreateNurseAssignedID.Value = 0;
                    numCreateExtraStaffAssignedID.Value = 0;
                }
            }
        }

        private void picButtonDeletion_Click(object sender, EventArgs e)
        {
            if (numEntryToDelete.Value == 0)
            {
                MessageBox.Show("Please enter the entry to be deleted");
            }
            else
            {
                List<string> tableAndDataColumns = new List<string> { "Appointments", "Patient_id", "Room", "Date_On" };
                List<string> otherTables = new List<string> { "" };
                cRUD.DeleteData(tableAndDataColumns, "Appointment_id", numEntryToDelete.Value.ToString(), false, otherTables, true, "Staff_Assigned_Appointments", "Staff_id");
                List<string> tableAndDataColumnsToUpdate = new List<string> { "Appointments", "Patient_id" };
                List<string> placeHolder = new List<string> { "0" };
                List<string> updatedLinkingValues = new List<string> { "" };
                cRUD.EditData(tableAndDataColumnsToUpdate, placeHolder, "Appointment_id", numEntryToDelete.Value.ToString(), false, "", "", updatedLinkingValues);
                loadData();
                MessageBox.Show("Entry Deleted");
                numEntryToDelete.Value = 0;
            }
        }

        private void btnSelectIDToEdit_Click(object sender, EventArgs e)
        {
            if (numEntryToEdit.Value == 0)
            {
                MessageBox.Show("Please enter the entry to be edited");
            }
            else
            {
                int counter = 0;
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Appointment id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Room") && row.IsNull("Date"))
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        switch (counter)
                        {
                            case 0:
                                numEditPatientID.Value = Convert.ToDecimal(row["Patient id"]);
                                txtEditRoom.Text = row["Room"].ToString();
                                datetimpickEditDateOn.Value = Convert.ToDateTime(row["Date"]);
                                numEditDoctorAssignedID.Value = Convert.ToDecimal(row["Staff id"]);
                                break;
                            case 1:
                                numEditNurseAssignedID.Value = Convert.ToDecimal(row["Staff id"]);
                                break;
                            default:
                                numEditExtraStaffAssignedID.Value = Convert.ToDecimal(row["Staff id"]);
                                break;
                        }
                        counter++;
                    }
                }
                numEditPatientID.Enabled = true;
                txtEditRoom.Enabled = true;
                datetimpickEditDateOn.Enabled = true;
                numEditDoctorAssignedID.Enabled = true;
                numEditNurseAssignedID.Enabled = true;
                numEditExtraStaffAssignedID.Enabled = true;
                picButtonSubmitChanges.Enabled = true;
            }
        }

        private void picButtonSubmitChanges_Click(object sender, EventArgs e)
        {
            List<string> tableAndDataColumns = new List<string> { "Appointments", "Patient_id", "Room", "Date_On" };
            List<string> updatedData = new List<string> { Convert.ToString(numEditPatientID.Value), txtEditRoom.Text, cRUD.CleanUpDate(datetimpickEditDateOn.Value.ToString()) };
            List<string> updatedLinkingData = new List<string> { numEditDoctorAssignedID.Value.ToString(), numEditNurseAssignedID.Value.ToString(), numEditExtraStaffAssignedID.Value.ToString() };
            cRUD.EditData(tableAndDataColumns, updatedData, "Appointment_id", numEntryToEdit.Value.ToString(), true, "Staff_Assigned_Appointments", "Staff_id", updatedLinkingData);
            loadData();
            MessageBox.Show("Entry Edited");
            numEditPatientID.Value = 0;
            txtEditRoom.Text = "";
            datetimpickEditDateOn.Value = DateTime.Now;
            numEditDoctorAssignedID.Value = 0;
            numEditNurseAssignedID.Value = 0;
            numEditExtraStaffAssignedID.Value = 0;
            numEntryToEdit.Value = 0;
            numEditPatientID.Enabled = false;
            txtEditRoom.Enabled = false;
            datetimpickEditDateOn.Enabled = false;
            numEditDoctorAssignedID.Enabled = false;
            numEditNurseAssignedID.Enabled = false;
            numEditExtraStaffAssignedID.Enabled = false;
            picButtonSubmitChanges.Enabled = false;
        }

        private void txtSearchEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtBoxSearch.Text == "")
                {
                    MessageBox.Show("Please enter a search parameter before pressing enter");
                }
                else
                {
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Patient Name", txtBoxSearch.Text, false, 0);
                }
            }
        }

        private void numSearchEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (numUDSearch.Value == 0)
                {
                    MessageBox.Show("Please enter a search parameter before pressing enter");
                }
                else
                {
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Appointment id", "", true, Convert.ToInt64(numUDSearch.Value));
                }
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnHideDataFilter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = "";
        }

        private void btnSortAlphabeticallyFilter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Patient Name", true);
        }

        private void btnReverseAlphabeticallyFilter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Patient Name", false);
        }

        private void picButtonMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picButtonLogout_Click(object sender, EventArgs e)
        {
            logoutState = true;
            Hide();
        }

        public bool getLogoutState()
        {
            return logoutState;
        }
    }
}
