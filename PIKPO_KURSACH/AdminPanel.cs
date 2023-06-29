using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PIKPO_KURSACH
{
    public partial class AdminPanel : Form
    {

        public string login;
        public string password;

        public void import(string _l, string _p)
        {
            login = _l;
            password = _p;
        }

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void book_catalog_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.book_catalog book_catalog = new FormsFromAdminPanel.book_catalog();
            book_catalog.Show();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            FormsForAdminPanel.Users users = new FormsForAdminPanel.Users();
            users.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
