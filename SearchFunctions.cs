using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    internal class SearchFunctions
    {
        public DataView SearchBar(DataTable dataTable, string column, string searchParameterString, bool canSearchById, long searchParameterInt)
        {
            if (canSearchById == false)
            {
                EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() where data.Field<string>(column).Contains(searchParameterString) select data;
                DataView searchedTable = query.AsDataView();
                return searchedTable;
            }
            else
            {
                EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() where data.Field<Int64>(column) == searchParameterInt select data;
                DataView searchedTable = query.AsDataView();
                return searchedTable;
            }
        }
        
        public DataTable EntryToEditOrAddToArchive(DataTable dataTable, string primaryKey, long primaryKeyValue)
        {
            EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() where data.Field<Int64>(primaryKey) == primaryKeyValue select data;
            DataView searchedTable = query.AsDataView();
            DataTable searchedDataTable = searchedTable.ToTable();
            return searchedDataTable;
        }

        public List<string> ShowDataClearly(DataTable dataTable, List<string> columnsWithTheData, string primaryKey, long primaryKeyValue)
        {
            EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() where data.Field<Int64>(primaryKey) == primaryKeyValue select data;
            DataView searchedTable = query.AsDataView();
            List<string> DataToShow = new List<string>();
            for (int i = 0; i < columnsWithTheData.Count; i++)
            {
                foreach (DataRow row in searchedTable.ToTable().Rows)
                {
                    DataToShow.Add(row[columnsWithTheData[i]].ToString());
                }
            }
            return DataToShow;
        }

        public DataTable FilterData(DataTable dataTable, string columnFiltered, bool AsceDesc)
        {
            if (AsceDesc == true)
            {
                EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() orderby data.Field<string>(columnFiltered) select data;
                DataView dataView = query.AsDataView();
                return dataView.ToTable();
            }
            else
            {
                EnumerableRowCollection<DataRow> query = from data in dataTable.AsEnumerable() orderby data.Field<string>(columnFiltered) descending select data;
                DataView dataView = query.AsDataView();
                return dataView.ToTable();
            }
        }
    }
}
