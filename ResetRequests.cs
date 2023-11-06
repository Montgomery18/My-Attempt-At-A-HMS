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
    public partial class ResetRequests : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;
        public ResetRequests(string access)
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
            List<string> tableAndDataColumns = new List<string> { "Reset_Requests", "Reset_id", "Username", "New_Password" };
            List<string> alias = new List<string> { "Reset Password id", "Username", "New Password" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, "Reset_id", false, "", "", false, "", "", "");
            dataGridView.DataSource = dataTable;
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

        private void picButtonApprove_Click(object sender, EventArgs e)
        {
            if (numSelectedRequest.Value == 0 || numAccountToReset.Value == 0)
            {
                MessageBox.Show("Please select the Reset Password id and the Account id");
            }
            else
            {
                string newPassword = "";
                foreach (DataRow data in dataTable.Rows)
                {
                    if (Convert.ToDecimal(data["Reset Password id"]) == numSelectedRequest.Value)
                    {
                        newPassword = data["New Password"].ToString();
                        break;
                    }
                }
                List<string> tableAndDataColumns = new List<string> { "Accounts", "Password" };
                List<string> updatedData = new List<string> { newPassword };
                List<string> updatedLinkingData = new List<string> { "" };
                cRUD.EditData(tableAndDataColumns, updatedData, "Account_id", numAccountToReset.Value.ToString(), false, "", "", updatedLinkingData);
                List<string> tableAndDataColumnsForDelete = new List<string> { "Reset_Requests", "Username", "New_Password" };
                List<string> otherTables = new List<string> { "" };
                cRUD.DeleteData(tableAndDataColumnsForDelete, "Reset_id", numSelectedRequest.Value.ToString(), false, otherTables, false, "", "");
                loadData();
                MessageBox.Show("Request Approved");
            }
        }

        private void picButtonDeny_Click(object sender, EventArgs e)
        {
            if (numSelectedRequest.Value == 0 || numAccountToReset.Value == 0)
            {
                MessageBox.Show("Please select the Reset Password id and the Account id");
            }
            else
            {
                List<string> tableAndDataColumnsForDelete = new List<string> { "Reset_Requests", "Username", "New_Password" };
                List<string> otherTables = new List<string> { "" };
                cRUD.DeleteData(tableAndDataColumnsForDelete, "Reset_id", numSelectedRequest.Value.ToString(), false, otherTables, false, "", "");
                loadData();
                MessageBox.Show("Request Denied");
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
