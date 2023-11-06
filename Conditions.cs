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
    public partial class Conditions : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public Conditions(string access)
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
            List<string> tableAndDataColumns = new List<string> { "Conditions", "Condition_id", "Patients.Patient_id", "Patients.Firstname || ' ' || Patients.Lastname", "Condition", "Date_Began", "Date_Resolved", "On_Going" };
            List<string> alias = new List<string> { "Condition id", "Patient id", "Patient Name", "Condition", "Date Began", "Date Resolved", "On Going" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, "Condition_id", true, "Patients", "Patient_id", false, "", "", "");
            dataGridView.DataSource = dataTable;
            dataGridView.Columns["Patient id"].Visible = false;
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
                MessageBox.Show("Please enter the ID of the patient the condition applies to");
            }
            else
            {
                bool alreadyExists = false;
                foreach (DataRow data in dataTable.Rows)
                {
                    if (numCreatePatientID.Value.ToString() == data["Patient id"].ToString() && txtCreateCondition.Text == data["Condition"].ToString() && cRUD.CleanUpDate(datetimpickCreateDateBegan.Value.ToString()) == data["Date Began"].ToString() && cRUD.CleanUpDate(datetimpickCreateDateResolved.Value.ToString()) == data["Date Resolved"].ToString() && comboCreateOnGoing.Text == data["On Going"].ToString())
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
                    string tableAndColumns = "Conditions (Patient_id, Condition, Date_Began, Date_Resolved, On_Going)";
                    List<string> userInput = new List<string> { numCreatePatientID.Value.ToString(), txtCreateCondition.Text, cRUD.CleanUpDate(datetimpickCreateDateBegan.Value.ToString()), cRUD.CleanUpDate(datetimpickCreateDateResolved.Value.ToString()), comboCreateOnGoing.Text };
                    cRUD.CreateData(tableAndColumns, userInput);
                    loadData();
                    MessageBox.Show("Entry Created");
                    numCreatePatientID.Value = 0;
                    txtCreateCondition.Text = "";
                    datetimpickEditDateBegan.Value = DateTime.Now;
                    datetimpickEditDateResolved.Value = DateTime.Now;
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
                List<string> tableAndDataColumns = new List<string> { "Conditions", "Patient_id", "Condition", "Date_Began", "Date_Resolved", "On_Going" };
                List<string> otherTables = new List<string> { "" };
                cRUD.DeleteData(tableAndDataColumns, "Condition_id", numEntryToDelete.Value.ToString(), false, otherTables, false, "", "");
                List<string> tableAndDataColumnsToUpdate = new List<string> { "Conditions", "Patient_id" };
                List<string> placeHolder = new List<string> { "0" };
                List<string> updatedLinkingValues = new List<string> { "" };
                cRUD.EditData(tableAndDataColumnsToUpdate, placeHolder, "Condition_id", numEntryToDelete.Value.ToString(), false, "", "", updatedLinkingValues);
                loadData();
                MessageBox.Show("Entry Deleted");
                numEntryToDelete.Value = 0;
            }
        }

        private void btnSelectIDToEdit_Click(object sender, EventArgs e) // Minor issue with submitting it then clicking it again
        {
            if (numEntryToEdit.Value == 0)
            {
                MessageBox.Show("Please enter the entry to be edited");
            }
            else
            {
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Condition id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Condition") && row.IsNull("Date Began") && row.IsNull("Date Resolved") && row.IsNull("On Going")) 
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        numEditPatientID.Value = Convert.ToDecimal(row["Patient id"]);
                        txtEditCondition.Text = row["Condition"].ToString();
                        datetimpickEditDateBegan.Value = Convert.ToDateTime(row["Date Began"]);
                        datetimpickEditDateResolved.Value = Convert.ToDateTime(row["Date Resolved"]);
                        for (int i = 0; i < comboEditGoingOn.Items.Count; i++)
                        {
                            if (comboEditGoingOn.Items[i].ToString() == row["On Going"].ToString())
                            {
                                comboEditGoingOn.SelectedIndex = i;
                            }
                        }
                    }
                }
                numEditPatientID.Enabled = true;
                txtEditCondition.Enabled = true;
                datetimpickEditDateBegan.Enabled = true;
                datetimpickEditDateResolved.Enabled = true;
                comboEditGoingOn.Enabled = true;
                picButtonSubmitChanges.Enabled = true;
            }
        }

        private void picButtonSubmitChanges_Click(object sender, EventArgs e)
        {
            List<string> tableAndDataColumns = new List<string> { "Conditions", "Patient_id", "Condition", "Date_Began", "Date_Resolved", "On_Going" };
            List<string> updatedData = new List<string> { numEditPatientID.Value.ToString(), txtEditCondition.Text, cRUD.CleanUpDate(datetimpickEditDateBegan.Value.ToString()), cRUD.CleanUpDate(datetimpickEditDateResolved.Value.ToString()), comboEditGoingOn.Text };
            List<string> updatedLinkingData = new List<string> { "" };
            cRUD.EditData(tableAndDataColumns, updatedData, "Condition_id", numEntryToEdit.Value.ToString(), false, "", "", updatedLinkingData);
            loadData();
            MessageBox.Show("Entry Edited");
            numEditPatientID.Value = 0;
            txtEditCondition.Text = "";
            datetimpickEditDateBegan.Value = DateTime.Now;
            datetimpickEditDateResolved.Value = DateTime.Now;
            comboEditGoingOn.Text = "";
            numEntryToEdit.Value = 0;
            numEditPatientID.Enabled = false;
            txtEditCondition.Enabled = false;
            datetimpickEditDateBegan.Enabled = false;
            datetimpickEditDateResolved.Enabled = false;
            comboEditGoingOn.Enabled = false;
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Condition id", "", true, Convert.ToInt64(numUDSearch.Value));
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
