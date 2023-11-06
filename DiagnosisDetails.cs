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
    public partial class DiagnosisDetails : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public DiagnosisDetails(string access)
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
            List<string> tableAndDataColumns = new List<string> { "Diagnosis_Details", "Diagnosis_Details.Diagnosis_id", "Patients.Patient_id", "Patients.Firstname || ' ' || Patients.Lastname", "Diagnosis_Procedure", "Diagnosis_Results", "Date_Performed", "Staff.Staff_id", "Staff.Firstname || ' ' || Staff.Lastname" };
            List<string> alias = new List<string> { "Diagnosis id", "Patient id", "Patient Name", "Procedure", "Results", "Date Performed", "Staff id", "Staff Responsible" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, "Diagnosis_id", true, "Patients", "Patient_id", true, "Staff_Assigned_Diagnosis", "Staff", "Staff_id");
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
                        case "D":
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
                        case "D":
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
                        case "D":
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
                MessageBox.Show("Please enter the ID of the patient who had/is having the diagnosis");
            }
            else if (numCreateDoctorID.Value == 0)
            {
                MessageBox.Show("Please enter the ID of the doctor responsible for the diagnosis");
            }
            else
            {
                bool alreadyExists = false;
                foreach (DataRow data in dataTable.Rows)
                {
                    if (numCreatePatientID.Value.ToString() == data["Patient id"].ToString() && richtxtCreateDiagnosisProcedure.Text == data["Procedure"].ToString() && richtxtCreateDiagnosisResult.Text == data["Results"].ToString() && cRUD.CleanUpDate(datetimpickCreateDatePerformed.Value.ToString()) == data["Date Performed"].ToString())
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                if (alreadyExists == true)
                {
                    MessageBox.Show("This entry already exists");
                }
                else
                {
                    string tableAndColumns = "Diagnosis_Details (Patient_id, Diagnosis_Procedure, Diagnosis_Results, Date_Performed)";
                    List<string> userInput = new List<string> { numCreatePatientID.Value.ToString(), richtxtCreateDiagnosisProcedure.Text, richtxtCreateDiagnosisResult.Text, cRUD.CleanUpDate(datetimpickCreateDatePerformed.Value.ToString()) };
                    List<string> userInputIDs = new List<string> { numCreateDoctorID.Value.ToString(), numCreateExtraStaffID.Value.ToString() };
                    List<string> tableToLinkTable = new List<string> { "Diagnosis_Details", "Diagnosis_id", "Staff_Assigned_Diagnosis", "Staff_id", "Patient_id", "Diagnosis_Procedure", "Diagnosis_Results", "Date_Performed" }; ;
                    cRUD.CreateData(tableAndColumns, userInput);
                    cRUD.linkTableFilling(tableToLinkTable, userInput, userInputIDs);
                    loadData();
                    dataGridView.Columns["Diagnosis_id"].Visible = false;
                    MessageBox.Show("Entry Created");
                    numCreatePatientID.Value = 0;
                    richtxtCreateDiagnosisProcedure.Text = "";
                    richtxtCreateDiagnosisResult.Text = "";
                    datetimpickCreateDatePerformed.Value = DateTime.Now;
                    numCreateDoctorID.Value = 0;
                    numEditExtraStaffID.Value = 0;
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
                List<string> tableAndDataColumns = new List<string> { "Diagnosis_Details", "Patient_id", "Diagnosis_Procedure", "Diagnosis_Results", "Date_Performed" };
                List<string> otherTables = new List<string> { "" };
                cRUD.DeleteData(tableAndDataColumns, "Diagnosis_id", numEntryToDelete.Value.ToString(), false, otherTables, true, "Staff_Assigned_Diagnosis", "Staff_id");
                List<string> tableAndDataColumnsToUpdate = new List<string> { "Diagnosis_Details", "Patient_id" };
                List<string> placeHolder = new List<string> { "0" };
                List<string> updatedLinkingValues = new List<string> { "" };
                cRUD.EditData(tableAndDataColumnsToUpdate, placeHolder, "Diagnosis_id", numEntryToDelete.Value.ToString(), false, "", "", updatedLinkingValues);
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
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Diagnosis id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Procedure") && row.IsNull("Results"))
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        switch (counter)
                        {
                            case 0:
                                numEditPatientID.Value = Convert.ToDecimal(row["Patient id"]);
                                richtxtEditDiagnosisProcedure.Text = row["Procedure"].ToString();
                                richtxtEditDiagnosisResult.Text = row["Results"].ToString();
                                datetimpickEditDatePerformed.Value = Convert.ToDateTime(row["Date Performed"]);
                                numEditDoctorID.Value = Convert.ToDecimal(row["Staff id"]);
                                break;
                            default:
                                numEditExtraStaffID.Value = Convert.ToDecimal(row["Staff id"]);
                                break;
                        }
                        counter++;
                    }
                }
                numEditPatientID.Enabled = true;
                richtxtEditDiagnosisProcedure.Enabled = true;
                richtxtEditDiagnosisResult.Enabled = true;
                datetimpickEditDatePerformed.Enabled = true;
                numEditDoctorID.Enabled = true;
                numEditExtraStaffID.Enabled = true;
                picButtonSubmitChanges.Enabled = true;
            }
        }

        private void picButtonSubmitChanges_Click(object sender, EventArgs e)
        {
            List<string> tableAndDataColumns = new List<string> { "Diagnosis_Details", "Patient_id", "Diagnosis_Procedure", "Diagnosis_Results", "Date_Performed" };
            List<string> updatedData = new List<string> { Convert.ToString(numEditPatientID.Value), richtxtEditDiagnosisProcedure.Text, richtxtEditDiagnosisResult.Text, cRUD.CleanUpDate(datetimpickEditDatePerformed.Value.ToString()) };
            List<string> updatedLinkingData = new List<string> { numEditDoctorID.Value.ToString(), numEditExtraStaffID.Value.ToString() };
            cRUD.EditData(tableAndDataColumns, updatedData, "Diagnosis_id", numEntryToEdit.Value.ToString(), true, "Staff_Assigned_Diagnosis", "Staff_id", updatedLinkingData);
            loadData();
            MessageBox.Show("Entry Edited");
            numEditPatientID.Value = 0;
            richtxtEditDiagnosisProcedure.Text = "";
            richtxtEditDiagnosisResult.Text = "";
            datetimpickEditDatePerformed.Value = DateTime.Now;
            numEditDoctorID.Value = 0;
            numEditExtraStaffID.Value = 0;
            numEntryToEdit.Value = 0;
            numEditPatientID.Enabled = false;
            richtxtEditDiagnosisProcedure.Enabled = false;
            richtxtEditDiagnosisResult.Enabled = false;
            datetimpickEditDatePerformed.Enabled = false;
            numEditDoctorID.Enabled = false;
            numEditExtraStaffID.Enabled = false;
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Diagnosis id", "", true, Convert.ToInt64(numUDSearch.Value));
                }
            }
        }

        private void numShowDiagnosisDetailsEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (numUDSearchDiagnosisDetails.Value == 0)
                {
                    MessageBox.Show("Please enter a search parameter before pressing enter");
                }
                else
                {
                    richtxtDiagnosisProcedure.Text = "";
                    richtxtDiagnosisResult.Text = "";
                    List<string> dataToShow = new List<string> { "Procedure", "Results" };
                    List<string> dataInMoreDetail = searchFunctions.ShowDataClearly(dataTable, dataToShow, "Diagnosis id", Convert.ToInt64(numUDSearchDiagnosisDetails.Value));
                    try
                    {
                        richtxtDiagnosisProcedure.Text = dataInMoreDetail[0];
                        richtxtDiagnosisResult.Text = dataInMoreDetail[1];
                    }
                    catch
                    {
                        richtxtDiagnosisProcedure.Text = "Invalid Staff ID";
                        richtxtDiagnosisResult.Text = "Invalid Staff ID";
                    }
                }
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnHideData_Click(object sender, EventArgs e)
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
