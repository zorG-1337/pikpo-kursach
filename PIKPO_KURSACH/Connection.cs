using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIKPO_KURSACH
{

    class Connection
    {
        //SQLiteConnection conn = new SQLiteConnection("Data Source = D:/DB/database.db");
        SQLiteConnection conn = new SQLiteConnection("Data Source = C:\\Kursach_pikpo-main\\PIKPO_KURSACH\\DataBase\\database.db");

        public bool Open()
        {
            try
            {
                conn = new SQLiteConnection("Data Source = C:\\Kursach_pikpo-main\\PIKPO_KURSACH\\DataBase\\database.db");
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public SQLiteDataReader ExecuteReader(string sql)
        {
            try
            {
                SQLiteDataReader reader;
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                int affected;
                SQLiteTransaction mytransaction = conn.BeginTransaction();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}

