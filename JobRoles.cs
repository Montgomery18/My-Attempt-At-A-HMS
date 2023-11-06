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
    public partial class JobRoles : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public JobRoles(string access)
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
            List<string> tableAndDataColumns = new List<string> { "Staff_Roles_Details", "Roles_Details_id", "Roles", "Salary" };
            List<string> alias = new List<string> { "Role id", "Role", "Salary" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, tableAndDataColumns[1], false, "", "", false, "", "", "");
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
            if (txtCreateJobRole.Text == "")
            {
                MessageBox.Show("Please enter the name of the job role");
            }
            else
            {
                bool alreadyExists = false;
                foreach (DataRow data in dataTable.Rows)
                {
                    if (txtCreateJobRole.Text == data["Role"].ToString() && numCreateSalary.Value.ToString() == data["Salary"].ToString())
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
                    string tableAndColumns = "Staff_Roles_Details (Roles, Salary)";
                    List<string> userInput = new List<string> { txtCreateJobRole.Text, numCreateSalary.Value.ToString() };
                    cRUD.CreateData(tableAndColumns, userInput);
                    loadData();
                    MessageBox.Show("Entry Added");
                    txtCreateJobRole.Text = "";
                    numCreateSalary.Value = 0;
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
                List<string> tableAndDataColumns = new List<string> { "Staff_Roles_Details", "Roles", "Salary" };
                List<string> otherTables = new List<string> { "Staff" };
                cRUD.DeleteData(tableAndDataColumns, "Roles_Details_id", numEntryToDelete.Value.ToString(), true, otherTables, false, "", "");
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
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Role id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Role") && row.IsNull("Salary"))
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        txtEditJobRole.Text = row["Role"].ToString();
                        numEditSalary.Value = Convert.ToDecimal(row["Salary"]);
                    }
                }
                txtEditJobRole.Enabled = true;
                numEditSalary.Enabled = true;
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
                List<string> tableAndDataColumns = new List<string> { "Staff_Roles_Details", "Roles", "Salary" };
                List<string> updatedData = new List<string> { txtEditJobRole.Text, numEditSalary.Value.ToString() };
                List<string> updatedLinkingData = new List<string> { "" };
                cRUD.EditData(tableAndDataColumns, updatedData, "Roles_Details_id", numEntryToEdit.Value.ToString(), false, "", "", updatedLinkingData);
                loadData();
                MessageBox.Show("Entry Edited");
                txtCreateJobRole.Text = "";
                numCreateSalary.Value = 0;
                numEntryToEdit.Value = 0;
                txtEditJobRole.Enabled = false;
                numEditSalary.Enabled = false;
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Role", txtBoxSearch.Text, false, 0);
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Role id", "", true, Convert.ToInt64(numUDSearch.Value));
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
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Role", true);
        }

        private void btnReverseAlphabeticallyFilter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Role", false);
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
