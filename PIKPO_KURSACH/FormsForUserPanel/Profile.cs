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

namespace PIKPO_KURSACH.FormsForUserPanel
{
    public partial class Profile : Form
    {
        Connection con = new Connection();

        public Profile(string _l, string _p)
        {
            InitializeComponent();
            LoginForm loginform = new LoginForm();

            importprof(_l, _p);
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    if (row["login"].ToString() == login.Text)
                    {
                        count.Text = row["buy"].ToString();
                        //count.Text = (Convert.ToInt32(count.Text) + Convert.ToInt32(buy)).ToString();
                    }
                }
            }
            row.Close();
            con.Close();
        }

        public void importprof(string _l, string _p)
        {
            login.Text = _l;
            password.Text = _p;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
