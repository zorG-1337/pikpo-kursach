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

namespace PIKPO_KURSACH.FormsFromAdminPanel
{
    public partial class book_catalog : Form
    {
        private SQLiteCommandBuilder builder = null;
        private SQLiteDataAdapter sqliteDataAdapter = null;
        private SQLiteConnection sQLiteConnection = null;
        private DataSet dataSet = null;
        private bool cmdRow = false;

        public book_catalog()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqliteDataAdapter = new SQLiteDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Books", sQLiteConnection); // 1 Пареметр - SQL запрос,
                                                                                                                          // 2 - Экземпляр класса SQLiteConnection
                builder = new SQLiteCommandBuilder(sqliteDataAdapter);

                builder.GetInsertCommand();
                builder.GetDeleteCommand();
                builder.GetUpdateCommand();

                dataSet = new DataSet();

                sqliteDataAdapter.Fill(dataSet, "Books"); // Заполняем DataSet с помощью SQLiteDataAdapter
                                                          // Передаем dataSet и имя таблицы, которую мы создадим в dataSet и заполним с помощью SQLiteDataAdapter

                dgvViewer.DataSource = dataSet.Tables["Books"]; // Устанавливаем таблицу из dataSet

                for (int i = 0; i < dgvViewer.Rows.Count; i++) // Переопределяем все ячейки в 7 колонке и делаем их linkLabel
                {
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, i] = link; // Обращаемся к ячейке, как к элементу в двумерном массиве.
                                            // Указываем индекс колонки и индекс строки (linkLabel)
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                dataSet.Tables["Books"].Clear(); // Т.к мы не работаем напрямую с БД, а работаем с "посредником" в виде dataSet.
                                                 // Поэтому перед заполнением с помощью dataSet SQLiteDataAdapter'а очищаем таблицу,
                                                 // которая храниться в dataSet, чтобы не дублировались данные. Сами данные БД не пострадают

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

        private void dgvViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    string cmd = dgvViewer.Rows[e.RowIndex].Cells[6].Value.ToString(); // Получили текст из линк лейбла

                    if (cmd == "Delete")
                    {
                        if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dgvViewer.Rows.RemoveAt(rowIndex); // Удаляем строку из DataGridView
                            dataSet.Tables["Books"].Rows[rowIndex].Delete(); // Удаляем строку из датасет
                            sqliteDataAdapter.Update(dataSet, "Books"); // Обновляем БД
                        }
                    }
                    else if (cmd == "Insert")
                    {
                        int rowIndex = dgvViewer.Rows.Count - 2;
                        DataRow row = dataSet.Tables["Books"].NewRow(); // Ссылка на новую строку, которую создадим в dataSet

                        // Заносим в новую строку все те данные, которые записали в строке в DataGridView 
                        row["authors"] = dgvViewer.Rows[rowIndex].Cells["authors"].Value;
                        row["title"] = dgvViewer.Rows[rowIndex].Cells["title"].Value;
                        row["description"] = dgvViewer.Rows[rowIndex].Cells["description"].Value;
                        row["price"] = dgvViewer.Rows[rowIndex].Cells["price"].Value;
                        row["count"] = dgvViewer.Rows[rowIndex].Cells["count"].Value;

                        // Добавляем в dataSet новую строку, которую только что заполнили данными
                        dataSet.Tables["Books"].Rows.Add(row);
                        dataSet.Tables["Books"].Rows.RemoveAt(dataSet.Tables["Books"].Rows.Count - 1);
                        dgvViewer.Rows.RemoveAt(dgvViewer.Rows.Count - 2);
                        dgvViewer.Rows[e.RowIndex].Cells[6].Value = "Delete";

                        // С помощью SQLiteDataAdapter обновляем БД и заносим в нее строку, которую только что добавили в DataGridView и в dataSet
                        sqliteDataAdapter.Update(dataSet, "Books");
                        cmdRow = false;
                    }
                    else if (cmd == "Update")
                    {
                        // Ячейкам нужной нам строки по индексу в dataSet в таблице Books присваиваем значение из ячеек редактируемой строки, которая нам нужна в DataGridView
                        dataSet.Tables["Books"].Rows[e.RowIndex]["authors"] = dgvViewer.Rows[e.RowIndex].Cells["authors"].Value;
                        dataSet.Tables["Books"].Rows[e.RowIndex]["title"] = dgvViewer.Rows[e.RowIndex].Cells["title"].Value;
                        dataSet.Tables["Books"].Rows[e.RowIndex]["description"] = dgvViewer.Rows[e.RowIndex].Cells["description"].Value;
                        dataSet.Tables["Books"].Rows[e.RowIndex]["price"] = dgvViewer.Rows[e.RowIndex].Cells["price"].Value;
                        dataSet.Tables["Books"].Rows[e.RowIndex]["count"] = dgvViewer.Rows[e.RowIndex].Cells["count"].Value;

                        sqliteDataAdapter.Update(dataSet, "Books"); // Обновляем БД
                        dgvViewer.Rows[e.RowIndex].Cells[6].Value = "Delete";
                    }
                    UpdateData();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void dgvViewer_UserAddedRow(object sender, DataGridViewRowEventArgs e) // Для команды Insert
        {
            try
            {
                if (cmdRow == false)
                {
                    cmdRow = true; // Добавляем новую строку
                    int lastRow = dgvViewer.Rows.Count - 2;
                    DataGridViewRow row = dgvViewer.Rows[lastRow];
                    DataGridViewLinkCell link = new DataGridViewLinkCell();

                    dgvViewer[6, lastRow] = link;
                    row.Cells["Delete"].Value = "Insert";

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка: " + exp.Message);
            }
        }

        private void dgvViewer_CellValueChanged(object sender, DataGridViewCellEventArgs e) // Для команды Update
        {
            try
            {
                if (cmdRow == false)
                {
                    int rowIndex = dgvViewer.SelectedCells[0].RowIndex; // Получаем индекс строки выделенной ячейки
                    DataGridViewRow edit = dgvViewer.Rows[rowIndex]; // Присваиваем строку по индексу, котороую записали в rowIndex
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, rowIndex] = link;
                    edit.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка: " + exp.Message);
            }
        }

        private void dgvViewer_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(columnValue); // Отписываем событие у Control.KeyPress
            if (dgvViewer.CurrentCell.ColumnIndex == 4 || dgvViewer.CurrentCell.ColumnIndex == 5) // Индекс ячейки для валидации
            {
                TextBox txt = e.Control as TextBox; // Приведение типа ячейки к TextBox

                if (txt != null)
                {
                    txt.KeyPress += new KeyPressEventHandler(columnValue); // Если textbox != null, подписываем событие и в кач-ве метода передаем columnValye
                }
            }
        }

        private void columnValue(object sender, KeyPressEventArgs e)
        {
            // Проверка на то, что введена цифра, а не любая другая кнопка
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                (dgvViewer.DataSource as DataTable).DefaultView.RowFilter = $"authors LIKE '%{textBox_search.Text}'";
            }
            else
            {
                (dgvViewer.DataSource as DataTable).DefaultView.RowFilter = null;
            }
        }

        private void book_catalog_Load(object sender, EventArgs e)
        {
            sQLiteConnection = new SQLiteConnection("Data Source = C:\\Kursach_pikpo-main\\PIKPO_KURSACH\\DataBase\\database.db");
            sQLiteConnection.Open();
            LoadData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}