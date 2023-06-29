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

namespace PIKPO_KURSACH.FormsForAdminPanel
{
    public partial class Users : Form
    {
        private SQLiteCommandBuilder builder = null;
        private SQLiteDataAdapter sqliteDataAdapter = null;
        private SQLiteConnection sQLiteConnection = null;
        private DataSet dataSet = null;

        Connection con = new Connection();

        public Users()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqliteDataAdapter = new SQLiteDataAdapter("SELECT * FROM Users", sQLiteConnection);
                builder = new SQLiteCommandBuilder(sqliteDataAdapter);

                dataSet = new DataSet();

                sqliteDataAdapter.Fill(dataSet, "Users");

                dgView.DataSource = dataSet.Tables["Users"];

                for (int i = 0; i < dgView.Rows.Count; i++)
                {
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            sQLiteConnection = new SQLiteConnection("Data Source = C:\\Kursach_pikpo-main\\PIKPO_KURSACH\\DataBase\\database.db");
            sQLiteConnection.Open();
            LoadData();
            sQLiteConnection.Close();
        }
    }
}
