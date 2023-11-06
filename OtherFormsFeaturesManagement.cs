using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class OtherFormsFeaturesManagement
    {
        private SQLiteConnection sql_Connect = new SQLiteConnection(@"data source = Hospital Management System Database.db");
        private SQLiteCommand sql_Commands;
        private SQLiteDataAdapter dataAdapter;
        private DataTable table = new DataTable();

        public string Login(string username, string password)
        {
            table.Clear();
            sql_Connect.Open();
            string query = "Select Username, Password, Access_Level From Accounts";
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            dataAdapter = new SQLiteDataAdapter(sql_Commands);
            dataAdapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["Username"].ToString().ToLower() == username.Trim() && row["Password"].ToString() == password.Trim())
                {
                    sql_Commands.Dispose();
                    dataAdapter.Dispose();
                    table.Dispose();
                    sql_Connect.Close();
                    return row["Access_Level"].ToString();
                }
            }
            sql_Commands.Dispose();
            dataAdapter.Dispose();
            table.Dispose();
            sql_Connect.Close();
            return "IC";
        }

        public bool AccCreationAccReset(string username, string password, string tableAccOrReset, string column)
        {
            sql_Connect.Open();
            string query = "Select Username, " + column + " From " + tableAccOrReset;
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            dataAdapter = new SQLiteDataAdapter(sql_Commands);
            dataAdapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["Username"].ToString() == username && row[column].ToString() == password)
                {
                    sql_Commands.Dispose();
                    dataAdapter.Dispose();
                    table.Dispose();
                    sql_Connect.Close();
                    return true;
                }
            }
            query = "Insert Into " + tableAccOrReset + "(Username," + column + ") Values('" + username + "','" + password + "')";
            sql_Commands = new SQLiteCommand(query, sql_Connect);
            sql_Commands.ExecuteNonQuery();
            sql_Commands.Dispose();
            dataAdapter.Dispose();
            table.Dispose();
            sql_Connect.Close();
            return false;
        }
    }
}
