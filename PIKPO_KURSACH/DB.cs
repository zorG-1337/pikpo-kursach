using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIKPO_KURSACH
{
    class DB
    {
        private string login, password;
        Connection con = new Connection();

        public void add_user(string login, string password)
        {
            this.login = login;
            this.password = password;

            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            string add = "INSERT INTO Users ('login', 'password', 'buy') VALUES ('" + login + "', '" + password + "', '" + 0 + "')";
            con.ExecuteNonQuery(add);

            row.Close();
            con.Close();
        }

        public bool check_user(string login, string password)
        {
            this.login = login;
            this.password = password;
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            try
            {
                if(row.HasRows)
                {
                    while(row.Read())
                    {
                        string id = row["id"].ToString();
                        string userlogin = row["login"].ToString();
                        string userpassword = row["password"].ToString();

                        if(this.login == userlogin && this.password == userpassword)
                        {
                            row.Close();
                            con.Close();
                            return true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка подключения к БД " + ex.Message);
            }
            return false;
        }

        public bool check_admin(string login, string password)
        {
            this.login = login;
            this.password = password;

            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            try
            {
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string id = row["id"].ToString();
                        string adminlogin = row["login"].ToString();
                        string adminpassword = row["password"].ToString();
                        adminlogin = "admin";
                        adminpassword = "123";

                        if (this.login == adminlogin && this.password == adminpassword)
                        {
                            row.Close();
                            con.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка подключения к БД " + ex.Message);
            }
            return false;
        }
    }
}