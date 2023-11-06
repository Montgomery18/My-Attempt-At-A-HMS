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
    public partial class ViewNurseDoctorID : Form
    {
        private string accessLevel;
        private DataTable dataTable;
        private MainCRUDFormsDataManagement cRUD;
        private SearchFunctions searchFunctions;
        private bool logoutState;

        public ViewNurseDoctorID(string access)
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
            dataLoad();
        }

        private void dataLoad()
        {
            dataTable.Clear();
            List<string> tableAndDataColumns = new List<string> { "Staff", "Staff_id", "Firstname || ' ' || Lastname", "Staff_Roles_Details.Roles_Details_id","Staff_Roles_Details.Roles" };
            List<string> alias = new List<string> { "Staff id", "Staff Name", "Role id","Role" };
            dataTable = cRUD.ViewData(tableAndDataColumns, alias, tableAndDataColumns[1], true, "Staff_Roles_Details", "Roles_Details_id", false, "", "", "");
            EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() where data.Field<Int64>("Role id") == 1 || data.Field<Int64>("Role id") == 2 || data.Field<Int64>("Role id") == 3 || data.Field<Int64>("Role id") == 4 select data;
            DataView dataView = query.AsDataView();
            dataTable = dataView.ToTable();
            dataGridView.DataSource = dataTable;
            dataGridView.Columns["Role id"].Visible = false;
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

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            dataLoad();
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
