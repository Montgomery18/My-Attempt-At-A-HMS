using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AccountManagement : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public AccountManagement(string access)
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
            List<string> tableAndDataColumns = new List<string> { "Accounts", "Accounts.Account_id","Username", "Password", "Access_Level"};
            List<string> alias = new List<string> { "Account id","Username", "Password", "Access Level" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, "Account_id", false, "", "", false, "", "", "");
            dataGridView.DataSource = dataTable;
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
                        case "SA":
                            panelDelete.Visible = true;
                            break;
                        default:
                            MessageBox.Show("You do not have the correct access to Delete data");
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
                        case "SA":
                            panelEdit.Visible = true;
                            break;
                        default:
                            MessageBox.Show("You do not have the correct access to Edit data");
                            break;
                    }
                    break;
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
                List<string> tableAndDataColumns = new List<string> { "Accounts", "Username", "Password", "Access_Level" };
                List<string> otherTables = new List<string> { "Staff" };
                cRUD.DeleteData(tableAndDataColumns, "Account_id", numEntryToDelete.Value.ToString(), true, otherTables, false, "", "");
                loadData();
                MessageBox.Show("Entry Deleted");
                numEntryToDelete.Value = 0;
            }
        }

        private void btnSelectIDToEdit_Click(object sender, EventArgs e)
        {
            comboEditAccessLevel.Text = "";
            numEditStaffMemberID.Value = 0;
            if (numEntryToEdit.Value == 0)
            {
                MessageBox.Show("Please enter the entry to be edited");
            }
            else
            {
                foreach (DataRow row in searchFunctions.EntryToEditOrAddToArchive(dataTable, "Account id", Convert.ToInt64(numEntryToEdit.Value)).Rows)
                {
                    if (row.IsNull("Username") && row.IsNull("Password") && row.IsNull("Access Level"))
                    {
                        MessageBox.Show("This entry is currently empty, consider filling it");
                    }
                    else
                    {
                        txtEditUsername.Text = row["Username"].ToString();
                        txtEditPassword.Text = row["Password"].ToString();
                        for (int i = 0; i < comboEditAccessLevel.Items.Count; i++)
                        {
                            if (comboEditAccessLevel.Items[i].ToString() == row["Access Level"].ToString())
                            {
                                comboEditAccessLevel.SelectedIndex = i;
                            }
                        }
                    }
                }
                txtEditUsername.Enabled = true;
                txtEditPassword.Enabled = true;
                comboEditAccessLevel.Enabled = true;
                numEditStaffMemberID.Enabled = true;
                picButtonSubmitChanges.Enabled = true;
            }
        }

        private void picButtonSubmitChanges_Click(object sender, EventArgs e)
        {
            if (numEditStaffMemberID.Value == 0)
            {
                MessageBox.Show("Please Assign the account a staff member");
            }
            else
            {
                List<string> tableAndDataColumns1 = new List<string> { "Accounts", "Username", "Password", "Access_Level" };
                List<string> updatedData1 = new List<string> { txtEditUsername.Text, txtEditPassword.Text, comboEditAccessLevel.Text };
                List<string> updatedLinkingData1 = new List<string> { "" };
                cRUD.EditData(tableAndDataColumns1, updatedData1, "Account_id", numEntryToEdit.Value.ToString(), false, "", "", updatedLinkingData1);
                List<string> tableAndDataColumns2 = new List<string> { "Staff", "Account_id" };
                List<string> updatedData2 = new List<string> { numEditStaffMemberID.Value.ToString() };
                List<string> updatedLinkingData2 = new List<string> { "" };
                cRUD.EditData(tableAndDataColumns2, updatedData2, "Staff_id", numEntryToEdit.Value.ToString(), false, "", "", updatedLinkingData2);
                loadData();
                MessageBox.Show("Entry Edited");
                txtEditUsername.Text = "";
                txtEditPassword.Text = "";
                comboEditAccessLevel.Text = "";
                numEditStaffMemberID.Value = 0;
                numEntryToEdit.Value = 0;
                txtEditUsername.Enabled = false;
                txtEditPassword.Enabled = false;
                comboEditAccessLevel.Enabled = false;
                numEditStaffMemberID.Enabled = false;
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Username", txtBoxSearch.Text, false, 0);
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
                    dataGridView.DataSource = searchFunctions.SearchBar(dataTable, "Account id", "", true, Convert.ToInt64(numUDSearch.Value));
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
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Username", true);
        }

        private void btnReverseAlphabeticallyFilter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = searchFunctions.FilterData(dataTable, "Username", false);
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
