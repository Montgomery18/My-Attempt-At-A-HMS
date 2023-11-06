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
    public partial class StaffInformation : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public StaffInformation(string access)
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
            List<string> tableAndDataColumns = new List<string> { "Staff", "Staff_id", "Account_id", "Firstname || ' ' || Lastname", "DOB", "Gender", "Contact_Number", "Email", "Address", "Staff_History", "Staff_Roles_Details.Roles_Details_id", "Staff_Roles_Details.Roles", "Staff_Roles_Details.Salary" };
            List<string> alias = new List<string> { "Staff id", "Account id", "Staff Name", "Date of Birth", "Gender", "Phone Number", "Email", "Address", "Staff History", "Role id", "Role", "Salary" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, tableAndDataColumns[1], true, "Staff_Roles_Details", "Roles_Details_id", false, "", "", "");
            dataTable.DefaultView.RowFilter = "[Staff id] <> '0'";
            dataGridView.DataSource = dataTable;
            dataGridView.Columns["Account id"].Visible = false;
            dataGridView.Columns["Role id"].Visible = false;
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
                        case "M":
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
                        case "M":
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
                        case "M":
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
                MessageBox.Show("Please enter the staff members firstname and surname");
            }
            else if (numCreateJobRoleID.Value == 0)
            {
                MessageBox.Show("Please enter the job role of the staff member");
            }
            else
            {
                bool alreadyExists = false;
                foreach (DataRow data in dataTable.Rows)
                {
                    if ((txtCreateFirstname.Text + "' '" + txtCreateSurname.Text) == data["Staff Name"].ToString() && cRUD.CleanUpDate(datetimpickCreateDOB.Value.ToString()) == data["Date of Birth"].ToString() && txtCreateGender.Text == data["Gender"].ToString() && txtCreatePhoneNumber.Text == data["Phone Number"].ToString() && txtCreateEmail.Text == data["Email"].ToString() && txtCreateAddress.Text == data["Address"].ToString())
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
                    string tableAndColumns = "Staff (Firstname, Lastname, DOB, Gender, Contact_Number, Email, Address, Staff_History, Roles_Details_id)";
                    List<string> userInput = new List<string> { txtCreateFirstname.Text, txtCreateSurname.Text, cRUD.CleanUpDate(datetimpickCreateDOB.Value.ToString()), txtCreateGender.Text, txtCreatePhoneNumber.Text, txtCreateEmail.Text, txtCreateAddress.Text, richtxtCreateStaffHistory.Text, numCreateJobRoleID.Value.ToString() };
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
                    richtxtCreateStaffHistory.Text = "";
                    numCreateJobRoleID.Value = 0;
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
                string tableAndColumns = "Staff_Archive (Firstname, Lastname, DOB, Gender, Contact_Number, Email, Address, Staff_History, Roles_Details_id)";
                List<string> staffDataToArchive = new List<string>();
                foreach(DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Staff id", Convert.ToInt64(numEntryToDelete.Value)).Rows)
                {
                    string staffName = row["Staff Name"].ToString();
                    List<string> firstnameAndSurname = staffName.Split(" ").ToList();
                    staffDataToArchive.Add(firstnameAndSurname[0]);
                    staffDataToArchive.Add(firstnameAndSurname[1]);
                    staffDataToArchive.Add(row["Date of Birth"].ToString());
                    staffDataToArchive.Add(row["Gender"].ToString());
                    staffDataToArchive.Add(row["Phone Number"].ToString());
                    staffDataToArchive.Add(row["Email"].ToString());
                    staffDataToArchive.Add(row["Address"].ToString());
                    staffDataToArchive.Add(row["Staff History"].ToString());
                    staffDataToArchive.Add(row["Role id"].ToString());
                }
                cRUD.CreateData(tableAndColumns, staffDataToArchive);
                List<string> tableAndDataColumns = new List<string> { "Staff", "Account_id", "Firstname", "Lastname", "DOB", "Gender", "Contact_Number", "Email", "Address", "Staff_History", "Roles_Details_id" };
                List<string> otherTables = new List<string> { "Staff_Assigned_Diagnosis", "Staff_Assigned_Appointments", "Staff_Responsible_For_Tests" };
                cRUD.DeleteData(tableAndDataColumns, "Staff_id", numEntryToDelete.Value.ToString(), true, otherTables, false, "", "");
                List<string> tableAndDataColumnsToUpdate = new List<string> { "Staff", "Roles_Details_id" };
                List<string> placeHolder = new List<string> { "0" };
                List<string> updatedLinkingValues = new List<string> { "" };
                cRUD.EditData(tableAndDataColumnsToUpdate, placeHolder, "Staff_id", numEntryToDelete.Value.ToString(), false, "", "", updatedLinkingValues);
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
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Staff id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Staff Name") && row.IsNull("Date of Birth") && row.IsNull("Gender") && row.IsNull("Phone Number") && row.IsNull("Email") && row.IsNull("Address") && row.IsNull("Staff History") && row.IsNull("Role id"))
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        string staffName = row["Staff Name"].ToString();
                        List<string> firstnameAndSurname = staffName.Split(" ").ToList();
                        txtEditFirstname.Text = firstnameAndSurname[0];
                        txtEditSurname.Text = firstnameAndSurname[1];
                        datetimpickEditDOB.Value = Convert.ToDateTime(row["Date of Birth"]);
                        txtEditGender.Text = row["Gender"].ToString();
                        txtEditPhoneNumber.Text = row["Phone Number"].ToString();
                        txtEditEmail.Text = row["Email"].ToString();
                        txtEditAddress.Text = row["Address"].ToString();
                        richtxtEditStaffHistory.Text = row["Staff History"].ToString();
                        numEditJobRoleID.Value = Convert.ToDecimal(row["Role id"]);
                    }
                }
                txtEditFirstname.Enabled = true;
                txtEditSurname.Enabled = true;
                datetimpickEditDOB.Enabled = true;
                txtEditGender.Enabled = true;
                txtEditPhoneNumber.Enabled = true;
                txtEditEmail.Enabled = true;
                txtEditAddress.Enabled = true;
                richtxtEditStaffHistory.Enabled = true;
                numEditJobRoleID.Enabled = true;
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
                List<string> tableAndDataColumns = new List<string> { "Patients", "Account_id", "Firstname", "Lastname", "DOB", "Gender", "Contact_Number", "Email", "Address", "Staff_History", "Roles_Details_id" };
                List<string> updatedData = new List<string> { txtEditFirstname.Text, txtEditSurname.Text, cRUD.CleanUpDate(datetimpickEditDOB.Value.ToString()), txtEditGender.Text, txtEditPhoneNumber.Text, txtEditEmail.Text, txtEditAddress.Text, richtxtEditStaffHistory.Text, numEditJobRoleID.Value.ToString() };
                List<string> updatedLinkingData = new List<string> { "" };
                cRUD.EditData(tableAndDataColumns, updatedData, "Staff_id", numEntryToEdit.Value.ToString(), false, "", "", updatedLinkingData);
                loadData();
                MessageBox.Show("Entry Edited");
                txtEditFirstname.Text = "";
                txtEditSurname.Text = "";
                datetimpickEditDOB.Value = DateTime.Now;
                txtEditGender.Text = "";
                txtEditPhoneNumber.Text = "";
                txtEditEmail.Text = "";
                txtEditAddress.Text = "";
                richtxtEditStaffHistory.Text = "";
                numEditJobRoleID.Value = 0;
                numEntryToEdit.Value = 0;
                txtEditFirstname.Enabled = false;
                txtEditSurname.Enabled = false;
                datetimpickEditDOB.Enabled = false;
                txtEditGender.Enabled = false;
                txtEditPhoneNumber.Enabled = false;
                txtEditEmail.Enabled = false;
                txtEditAddress.Enabled = false;
                richtxtEditStaffHistory.Enabled = false;
                numEditJobRoleID.Enabled = false;
                picButtonSubmitChanges.Enabled = false;
            }
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Staff Name", txtBoxSearch.Text, false, 0);
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Staff id", "", true, Convert.ToInt64(numUDSearch.Value));
                }
            }
        }

        private void numSearchForStaffHistoryEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (numUDSearchStaffHistoryID.Value == 0)
                {
                    MessageBox.Show("Please enter a search parameter before pressing enter");
                }
                else
                {
                    richtxtShowStaffHistory.Text = "";
                    List<string> dataToShow = new List<string> { "Staff History" };
                    List<string> dataInMoreDetail = searchFunctions.ShowDataClearly(dataTable, dataToShow, "Staff id", Convert.ToInt64(numUDSearchStaffHistoryID.Value));
                    try
                    {
                        richtxtShowStaffHistory.Text = dataInMoreDetail[0];
                    }
                    catch
                    {
                        richtxtShowStaffHistory.Text = "Invalid Staff ID";
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
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Staff Name", true);
        }

        private void btnReverseAlphabeticallyFilter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Staff Name", false);
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
