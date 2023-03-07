using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WebBrowser
{
    internal class SQLiteHandler
    {
        
        public static SQLiteConnection ConnectToDB()
        {
            SQLiteConnection conn = null;

            // creaza baza de date daca nu exista
            if (!File.Exists("BlockedKeywords.db"))
            {
                SQLiteConnection.CreateFile("BlockedKeywords.db");
            }
            try
            {
                conn = new SQLiteConnection("Data Source = BlockedKeywords.db; version = 3; Compress = True;");
                conn.Open();
            }
            catch(Exception e)
            { 
                Trace.WriteLine(e.Message);
            }

            // creaza tabelul daca nu exista 
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Keywords(id INTEGER PRIMARY KEY AUTOINCREMENT, Keyword TEXT)";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            return conn;
        }

        public static void DisconnectFromDB(SQLiteConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn = null;
            }
        }

        public static List<string> GetAllKeyWords(SQLiteConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                return null;
            }
            else
            {
                List<string> list = new List<string>();
                SQLiteDataReader reader = null;
                SQLiteCommand cmd = null;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Keyword FROM Keywords";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                return list;
            } 
        }

        public static void InsertKeyword(SQLiteConnection conn, string keyword)
        {
            if (conn.State == System.Data.ConnectionState.Open) 
            { 
                List<string> list = GetAllKeyWords(conn);
                var result = from x in list
                             where keyword.Equals(x)
                             select x;
                if (result.Count() > 0)
                    MessageBox.Show("Already existing keyword");
                else
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Keywords(Keyword) VALUES ('" + keyword + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added!");
                }
            }
        }

        public static void RemoveKeyword(SQLiteConnection conn, string keyword)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                List<string> list = GetAllKeyWords(conn);
                var result = from x in list
                            where keyword.Equals(x)
                            select x;
                if (result.Count() == 0)
                    MessageBox.Show("The keyword does not exist");
                else
                {
                    SQLiteCommand cmd = null;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Keywords WHERE Keyword= '" + keyword + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Removed!");
                }
            }
           
        }
    }
}
