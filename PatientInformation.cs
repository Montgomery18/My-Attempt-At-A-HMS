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
    public partial class PatientInformation : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public PatientInformation(string accesss)
        {
            InitializeComponent();
            accessLevel = accesss;
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
            List<string> tableAndDataColumns = new List<string> { "Patients", "Patient_id", "Firstname || ' ' || Lastname", "DOB", "Gender", "Contact_Number", "Email", "Address" };
            List<string> alias = new List<string> { "Patient id", "Patient Name", "Date of Birth", "Gender", "Phone Number", "Email", "Address" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, tableAndDataColumns[1], false, "", "", false, "", "", "");
            dataTable.DefaultView.RowFilter = "[Patient id] <> '0'";
            dataGridView.DataSource = dataTable;
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
                        case "N":
                            panelCreate.Visible = true;
                            break;
                        case "R":
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
                        case "N":
                            panelDelete.Visible = true;
                            break;
                        case "R":
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
                        case "N":
                            panelEdit.Visible = true;
                            break;
                        case "R":
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
            if (txtCreateFirstname.Text == "" && txtCreateSurname.Text == "")
            {
                MessageBox.Show("Please enter at least the patients firstname and surname");
            }
            else
            {
                bool alreadyExists = false;
                foreach (DataRow data in dataTable.Rows)
                {
                    if ((txtCreateFirstname.Text + "' '" + txtCreateSurname.Text) == data["Patient Name"].ToString() && cRUD.CleanUpDate(datetimpickCreateDOB.Value.ToString()) == data["Date of Birth"].ToString() && txtCreateGender.Text == data["Gender"].ToString() && txtCreatePhoneNumber.Text == data["Phone Number"].ToString() && txtCreateEmail.Text == data["Email"].ToString() && txtCreateAddress.Text == data["Address"].ToString())
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
                    string tableAndColumns = "Patients (Firstname, Lastname, DOB, Gender, Contact_Number, Email, Address)";
                    List<string> userInput = new List<string> { txtCreateFirstname.Text, txtCreateSurname.Text, cRUD.CleanUpDate(datetimpickCreateDOB.Value.ToString()), txtCreateGender.Text, txtCreatePhoneNumber.Text, txtCreateEmail.Text, txtCreateAddress.Text };
                    cRUD.CreateData(tableAndColumns, userInput);
                    loadData();
                    MessageBox.Show("Entry Created");
                    txtCreateFirstname.Text = "";
                    txtCreateSurname.Text = "";
                    datetimpickCreateDOB.Value = DateTime.Now;
                    txtCreateGender.Text = "";
                    txtCreatePhoneNumber.Text = "";
                    txtCreateEmail.Text = "";
                    txtCreateAddress.Text = "";
                }
            }
        }

        private void picButtonUndoEntry_Click(object sender, EventArgs e)
        {

        }

        private void picButtonDeletion_Click(object sender, EventArgs e)
        {
            if (numEntryToDelete.Value == 0)
            {
                MessageBox.Show("Please enter the entry to be deleted");
            }
            else
            {
                List<string> tableAndDataColumns = new List<string> { "Patients", "Firstname", "Lastname", "DOB", "Gender", "Contact_Number", "Email", "Address" };
                List<string> otherTables = new List<string> { "Conditions", "Appointments", "Diagnosis_Details", "Lab_Test_Results" };
                cRUD.DeleteData(tableAndDataColumns, "Patient_id", numEntryToDelete.Value.ToString(), true, otherTables, false, "", "");
                loadData();
                MessageBox.Show("Entry Deleted");
                numEntryToDelete.Value = 0;
            }
        }

        private void picButtonUndoDeletion_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectIDToEdit_Click(object sender, EventArgs e)
        {
            if (numEntryToEdit.Value == 0)
            {
                MessageBox.Show("Please enter the entry to be edited");
            }
            else
            {
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Patient id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Patient Name") && row.IsNull("Date of Birth") && row.IsNull("Gender") && row.IsNull("Phone Number") && row.IsNull("Email") && row.IsNull("Address"))
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        string patientName = row["Patient Name"].ToString();
                        List<string> firstnameAndSurname = patientName.Split(" ").ToList();
                        txtEditFirstname.Text = firstnameAndSurname[0];
                        txtEditSurname.Text = firstnameAndSurname[1];
                        datetimpickEditDOB.Value = Convert.ToDateTime(row["Date of Birth"]);
                        txtEditGender.Text = row["Gender"].ToString();
                        txtEditPhoneNumber.Text = row["Phone Number"].ToString();
                        txtEditEmail.Text = row["Email"].ToString();
                        txtEditAddress.Text = row["Address"].ToString();
                    }
                }
                txtEditFirstname.Enabled = true;
                txtEditSurname.Enabled = true;
                datetimpickEditDOB.Enabled = true;
                txtEditGender.Enabled = true;
                txtEditPhoneNumber.Enabled = true;
                txtEditEmail.Enabled = true;
                txtEditAddress.Enabled = true;
                picButtonSubmitChanges.Enabled = true;
            }
        }

        private void picButtonSubmitChanges_Click(object sender, EventArgs e)
        {
            if (numEntryToEdit.Value == 0)
            {
                MessageBox.Show("Invalid id");
            }
            else
            {
                List<string> tableAndDataColumns = new List<string> { "Patients", "Firstname", "Lastname", "DOB", "Gender", "Contact_Number", "Email", "Address" };
                List<string> updatedData = new List<string> { txtEditFirstname.Text, txtEditSurname.Text, cRUD.CleanUpDate(datetimpickEditDOB.Value.ToString()), txtEditGender.Text, txtEditPhoneNumber.Text, txtEditEmail.Text, txtEditAddress.Text };
                List<string> updatedLinkingData = new List<string> { "" };
                cRUD.EditData(tableAndDataColumns, updatedData, "Patient_id", numEntryToEdit.Value.ToString(), false, "", "", updatedLinkingData);
                loadData();
                MessageBox.Show("Entry Edited");
                txtEditFirstname.Text = "";
                txtEditSurname.Text = "";
                datetimpickEditDOB.Value = DateTime.Now;
                txtEditGender.Text = "";
                txtEditPhoneNumber.Text = "";
                txtEditEmail.Text = "";
                txtEditAddress.Text = "";
                numEntryToEdit.Value = 0;
                txtEditFirstname.Enabled = false;
                txtEditSurname.Enabled = false;
                datetimpickEditDOB.Enabled = false;
                txtEditGender.Enabled = false;
                txtEditPhoneNumber.Enabled = false;
                txtEditEmail.Enabled = false;
                txtEditAddress.Enabled = false;
                picButtonSubmitChanges.Enabled = false;
            }
        }

        private void picButtonUndoChanges_Click(object sender, EventArgs e)
        {

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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Patient id", "", true, Convert.ToInt64(numUDSearch.Value));
                }
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnHideButton_Click(object sender, EventArgs e)
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
