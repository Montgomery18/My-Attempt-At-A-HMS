using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace Hospital_Management_System
{
    internal class MainCRUDFormsDataManagement
    {
        private SQLiteConnection sql_Connect = new SQLiteConnection(@"data source = Hospital Management System Database.db");
        private SQLiteCommand sql_Commands;
        private SQLiteDataAdapter dataAdapter;
        private DataTable table = new DataTable();

        public DataTable ViewData(List<string> tableAndColumns, List<string> alias, string mainid, bool hasLinkedData, string linkedTableName, string firstidLink, bool hasLinkTable, string linkingTableName, string tableLinkingTableConnectTo, string secondidLink)
        {
            string tableName = tableAndColumns[0];
            tableAndColumns.RemoveAt(0);
            string listConvertedToString = "";
            for (int i = 0; i < tableAndColumns.Count; i++)
            {
                listConvertedToString = listConvertedToString + tableAndColumns[i] + " as \"" + alias[i] + "\"," ;
            }
            listConvertedToString = listConvertedToString.Remove(listConvertedToString.Length - 1);
            sql_Connect.Open();
            string query;
            if (hasLinkedData == true)
            {
                if (hasLinkTable == true)
                {
                    query = "Select " + listConvertedToString + " From " + tableName + " Inner Join " + linkedTableName + " on " + (tableName + "." + firstidLink) + "=" + (linkedTableName + "." + firstidLink) + " Inner Join " + linkingTableName + " on " + (tableName + "." + mainid) + "=" + (linkingTableName + "." + mainid) + " Inner Join " + tableLinkingTableConnectTo + " on " + (linkingTableName + "." + secondidLink) + "=" + (tableLinkingTableConnectTo + "." + secondidLink) + " Order by " + (tableName + "." + mainid);
                }
                else
                {
                    query = "Select " + listConvertedToString + " From " + tableName + " Inner Join " + linkedTableName + " on " + (tableName + "." + firstidLink) + "=" + (linkedTableName + "." + firstidLink) + " Order By " + (tableName + "." + mainid);
                }
                sql_Commands = new SQLiteCommand(query, sql_Connect);
                dataAdapter = new SQLiteDataAdapter(sql_Commands);
                dataAdapter.Fill(table);
                sql_Commands.Dispose();
                dataAdapter.Dispose();
                sql_Connect.Close();
                return table;
            }
            else
            {
                query = "Select " + listConvertedToString + " From " + tableName + " Order By " + mainid;
                sql_Commands = new SQLiteCommand(query, sql_Connect);
                dataAdapter = new SQLiteDataAdapter(sql_Commands);
                dataAdapter.Fill(table);
                sql_Commands.Dispose();
                dataAdapter.Dispose();
                sql_Connect.Close();
                return table;
            }
        }
        public string CleanUpDate(string date)
        {
            date = date.Remove(10);
            date = date.Substring(6, 4) + "/" + date.Substring(3,2) + "/" + date.Substring(0,2);
            return date;
        }

        public void CreateData(string tableOnAndColumnsInsertFormat, List<string> dataToCreate)
        {
            sql_Connect.Open();
            string listConvertedToString = "";
            foreach (string data in dataToCreate)
            {
                listConvertedToString = listConvertedToString + "\"" + data + "\",";
            }
            listConvertedToString = listConvertedToString.Remove(listConvertedToString.Length - 1);
            string query = "Insert Into " + tableOnAndColumnsInsertFormat + " Values(" + listConvertedToString + ")";
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            sql_Commands.ExecuteNonQuery();
            sql_Commands.Dispose();
            sql_Connect.Close();
        }

        public void linkTableFilling(List<string> itemsToLinkTable, List<string> createdData, List<string>keysToAdd)
        {
            string formsTable = itemsToLinkTable[0];
            itemsToLinkTable.RemoveAt(0);
            string primaryKey = itemsToLinkTable[0];
            itemsToLinkTable.RemoveAt(0);
            string linkTable = itemsToLinkTable[0];
            itemsToLinkTable.RemoveAt(0);
            string linkTableColumn = itemsToLinkTable[0];
            itemsToLinkTable.RemoveAt(0);
            string merged = "";
            for (int i = 0; i < itemsToLinkTable.Count; i++)
            {
                merged = merged + (itemsToLinkTable[i] + "=\"" + createdData[i] + "\" And ");
            }
            merged = merged.Remove(merged.Length - 4);
            sql_Connect.Open();
            string query = "Select " + primaryKey + " From " + formsTable + " where (" + merged + ")";
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            dataAdapter = new SQLiteDataAdapter(sql_Commands);
            dataAdapter.Fill(table);
            string id = "";
            foreach (DataRow row in table.Rows)
            {
                id = row[primaryKey].ToString();
            }
            foreach (string key in keysToAdd)
            {
                if (Convert.ToInt32(key) != 0)
                {
                    query = "Insert Into " + linkTable + " (" + primaryKey + ", " + linkTableColumn + ") Values(" + id + ", " + key + ")";
                    sql_Commands = new SQLiteCommand(query, sql_Connect);
                    sql_Commands.ExecuteNonQuery();
                }
            }
            sql_Commands.Dispose();
            dataAdapter.Dispose();
            table.Dispose();
            sql_Connect.Close();
        }

        public void DeleteData(List<string> tableAndDataColumns, string primaryKey, string primaryKeyValue, bool hasKeyInOtherTable, List<string> otherTable, bool hasLinkingTable, string linkingTable, string linkedID)
        {
            string tableToUpdate = tableAndDataColumns[0];
            tableAndDataColumns.RemoveAt(0);
            string listConvertedToString = "";
            foreach(string data in tableAndDataColumns)
            {
                listConvertedToString = listConvertedToString + data + "=null,";
            }
            listConvertedToString = listConvertedToString.Remove(listConvertedToString.Length - 1);
            sql_Connect.Open();
            string query = "Update " + tableToUpdate + " Set " + listConvertedToString + " Where (" + primaryKey + "=" + primaryKeyValue + ")";
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            sql_Commands.ExecuteNonQuery();
            if (hasKeyInOtherTable == true)
            {
                foreach (string data in otherTable)
                {
                    query = "Update " + data + " Set " + primaryKey + "=0 Where (" + primaryKey + "=" + primaryKeyValue + ")";
                    sql_Commands = new SQLiteCommand(query, sql_Connect);
                    sql_Commands.ExecuteNonQuery();
                }
            }
            if (hasLinkingTable == true)
            {
                query = "Update " + linkingTable + " Set " + linkedID + "=0 Where (" + primaryKey + "=" + primaryKeyValue + ")";
                sql_Commands = new SQLiteCommand(query, sql_Connect);
                sql_Commands.ExecuteNonQuery();
            }
            sql_Commands.Dispose();
            sql_Connect.Close();
        }

        public void EditData(List<string> tableAndDataColumns, List<string> updatedData, string primaryKey, string primaryKeyValue, bool hasLinkingTable, string linkingTable, string linkingTableColumn, List<string> updatedLinkingValues)
        {
            string tableToUpdate = tableAndDataColumns[0];
            tableAndDataColumns.RemoveAt(0);
            string listConvertedToString = "";
            for (int i = 0; i < tableAndDataColumns.Count; i++)
            {
                listConvertedToString = listConvertedToString + tableAndDataColumns[i] + "='" + updatedData[i] + "',";
            }
            listConvertedToString = listConvertedToString.Remove(listConvertedToString.Length - 1);
            sql_Connect.Open();
            string query = "Update " + tableToUpdate + " Set " + listConvertedToString + " where (" + primaryKey + "=" + primaryKeyValue + ")";
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            sql_Commands.ExecuteNonQuery();
            if (hasLinkingTable == true)
            {
                query = "Delete From " + linkingTable + " where (" + primaryKey + "=" + primaryKeyValue + ")";
                sql_Commands = new SQLiteCommand(query, sql_Connect);
                sql_Commands.ExecuteNonQuery();
                foreach (string data in updatedLinkingValues)
                {
                    if (data != "0")
                    {
                        query = "Insert Into " + linkingTable + "(" + primaryKey + "," + linkingTableColumn + ") Values(" + primaryKeyValue + "," + data + ")";
                        sql_Commands = new SQLiteCommand(query, sql_Connect);
                        sql_Commands.ExecuteNonQuery();
                    }
                }
            }
            sql_Commands.Dispose();
            sql_Connect.Close();
        }
    }
}
