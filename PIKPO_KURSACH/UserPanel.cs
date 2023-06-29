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

namespace PIKPO_KURSACH
{
    public partial class UserPanel : Form
    {
        private SQLiteCommandBuilder builder = null;
        private SQLiteDataAdapter sqliteDataAdapter = null;
        private SQLiteConnection sQLiteConnection = null;
        private DataSet dataSet = null;

        Connection con = new Connection();

        public string login;
        public string password;

        public void import(string _l, string _p)
        {
            login = _l;
            password = _p;
        }

        public UserPanel()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            try
            {
                dataSet.Tables["Books"].Clear();
                sqliteDataAdapter.Fill(dataSet, "Books");
                dgvViewer.DataSource = dataSet.Tables["Books"];

                for (int i = 0; i < dgvViewer.Rows.Count; i++)
                {
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, i] = link;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                sqliteDataAdapter = new SQLiteDataAdapter("SELECT *, 'Buy' AS [Buy] FROM Books", sQLiteConnection);
                builder = new SQLiteCommandBuilder(sqliteDataAdapter);
                dataSet = new DataSet();
                sqliteDataAdapter.Fill(dataSet, "Books");
                dgvViewer.DataSource = dataSet.Tables["Books"];

                for (int i = 0; i < dgvViewer.Rows.Count; i++)
                {
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, i] = link;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            sQLiteConnection = new SQLiteConnection("Data Source = C:\\Kursach_pikpo-main\\PIKPO_KURSACH\\DataBase\\database.db");
            sQLiteConnection.Open();
            LoadData();
            sQLiteConnection.Close();
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            FormsForUserPanel.Profile profile = new FormsForUserPanel.Profile(login, password);
            profile.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    string cmd = dgvViewer.Rows[e.RowIndex].Cells[6].Value.ToString(); // Получили текст из линк лейбла

                    if (cmd == "Buy")
                    {
                        if (MessageBox.Show("Подтеврдить покупку?", "Покупка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int buy = Convert.ToInt32(dataSet.Tables["Books"].Rows[e.RowIndex]["count"]);
                            int count = 0;
                            int counter = 0;
                            if (buy != 0)
                            {
                                try
                                {
                                    dataSet.Tables["Books"].Rows[e.RowIndex]["count"] = Convert.ToInt32(dgvViewer.Rows[e.RowIndex].Cells["count"].Value) - 1;
                                    sqliteDataAdapter.Update(dataSet, "Books");
                                    dgvViewer.Rows[e.RowIndex].Cells[6].Value = "Buy";
                                    counter = Convert.ToInt32(dataSet.Tables["Books"].Rows[e.RowIndex]["count"]);
                                    counter = 105;

                                    con.Open();
                                    SQLiteDataReader row;
                                    string query = "SELECT * FROM Users WHERE login = ('" + login + "')";
                                    row = con.ExecuteReader(query);
                                    string add = "UPDATE Users SET buy = buy + 1 WHERE login = ('" + login + "')";
                                    //con.Open();
                                    con.ExecuteNonQuery(add);

                                    UpdateData();

                                    row.Close();
                                    con.Close();
                                }
                                catch (Exception exp)
                                {
                                    MessageBox.Show("Ошибка подключения к БД " + exp.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Книги нет в наличии");
                            }
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (search_textBox1.Text != "")
            {
                (dgvViewer.DataSource as DataTable).DefaultView.RowFilter = $"authors LIKE '%{search_textBox1.Text}'";
            }
            else
            {
                (dgvViewer.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }
    }
}
