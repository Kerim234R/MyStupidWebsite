using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RaschetZP
{
    public partial class DataBase : Form
    {
        int n, m, i, j;
        public DataBase()
        {
            InitializeComponent();
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);

            this.FormClosing += (s, args) => Application.Exit();
            LoadJobsToComboBoxes();

            // Меню из user control
            UserControlMenuStrip menu = new UserControlMenuStrip();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
            menu.BringToFront();
            menu.ApplyThemeToMenu();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox3.Enabled = false;
        }

        // Очистка полей
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox_find.Text = string.Empty;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Детей с инвалидностью не может быть больше чем детей
            if (numericUpDown2.Value > numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
                MessageBox.Show("Детей с инвалидностью не может быть больше чем общее количество детей!", "Ошибка");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Логика блокировки полей в зависимости от типа занятости
            if (comboBox2.SelectedItem?.ToString() == "Совместительство")
            {
                textBox3.Enabled = true;  // Оклад по совместительству
                textBox4.Enabled = false; // Доплата
                comboBox3.Enabled = true;
            }
            else if (comboBox2.SelectedItem?.ToString() == "Совмещение")
            {
                textBox3.Enabled = false; // Оклад по совместительству
                textBox4.Enabled = true;  // Доплата
                comboBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                comboBox3.Enabled = false;
            }
        }

        // Добавить строку
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите ФИО сотрудника!", "Ошибка");
                return;
            }

            int rownumber = dataGridView1.Rows.Add();
            dataGridView1.Rows[rownumber].Cells["Column1"].Value = rownumber + 1; // айди
            dataGridView1.Rows[rownumber].Cells["Column2"].Value = textBox1.Text; // ФИО
            dataGridView1.Rows[rownumber].Cells["Column3"].Value = comboBox1.SelectedItem?.ToString() ?? ""; // Должность
            dataGridView1.Rows[rownumber].Cells["Column4"].Value = comboBox2.SelectedItem?.ToString() ?? ""; // Вид занятости
            dataGridView1.Rows[rownumber].Cells["Column5"].Value = textBox2.Text; // Оклад
            dataGridView1.Rows[rownumber].Cells["Column6"].Value = comboBox2.Enabled ? comboBox2.SelectedItem?.ToString() : ""; // Должность по совместительству
            dataGridView1.Rows[rownumber].Cells["Column7"].Value = textBox3.Text; // Оклад по совмест
            dataGridView1.Rows[rownumber].Cells["Column8"].Value = textBox4.Text; // Доплата
            dataGridView1.Rows[rownumber].Cells["Column9"].Value = numericUpDown3.Value; // Стаж
            dataGridView1.Rows[rownumber].Cells["Column10"].Value = numericUpDown4.Value; // Квалификация
            dataGridView1.Rows[rownumber].Cells["Column11"].Value = numericUpDown5.Value; // Вредность условий труда
            dataGridView1.Rows[rownumber].Cells["Column12"].Value = numericUpDown1.Value; // Дети
            dataGridView1.Rows[rownumber].Cells["Column13"].Value = numericUpDown2.Value; // Инвалидность у детей
        }

        // Найти строку
        private void button7_Click(object sender, EventArgs e)
        {
            string searchText = textBox_find.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска!", "Ошибка");
                return;
            }

            bool found = false;

            // Снимаем выделение со всех строк
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
            }

            // Ищем по всем столбцам
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Совпадений не найдено!", "Поиск");
            }
        }

        // Проверка на ввод цифр
        private void numbercheck(object sender, KeyPressEventArgs e)// Проверка на ввод чисел
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        // Проверка ввода ФИО (только буквы)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!((c >= 'а' && c <= 'я') ||
                (c >= 'А' && c <= 'Я') ||
                c == 'Ё' || c == 'ё' ||
                c == ' ' || // пробел для ФИО
                c == (char)8 ||
                c == (char)9 ||
                c == (char)13))
            {
                e.Handled = true;
            }
        }

        // Удалить строку
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Ошибка");
            }
        }

        // Удалить всё
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить все данные?", "Подтверждение",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Таблица уже пуста!", "Информация");
            }
        }

        // Сохранить
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                n = dataGridView1.RowCount;
                m = dataGridView1.ColumnCount;

                using (StreamWriter sw = File.CreateText("employee_data.txt"))
                {
                    sw.WriteLine(Convert.ToString(n));
                    sw.WriteLine(Convert.ToString(m));

                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < m; j++)
                        {
                            string value = dataGridView1[j, i].Value?.ToString() ?? "";
                            sw.WriteLine(value);
                        }
                    }
                }
                MessageBox.Show("Данные успешно сохранены!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        // Загрузить
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("employee_data.txt"))
                {
                    MessageBox.Show("Файл с данными не найден!", "Ошибка");
                    return;
                }

                using (StreamReader f = new StreamReader("employee_data.txt"))
                {
                    n = Convert.ToInt32(f.ReadLine());
                    m = Convert.ToInt32(f.ReadLine());

                    dataGridView1.Rows.Clear();

                    for (i = 0; i < n - 1; i++)
                    {
                        int rownumber = dataGridView1.Rows.Add();
                        for (j = 0; j < m; j++)
                        {
                            string value = f.ReadLine() ?? "";
                            dataGridView1.Rows[rownumber].Cells[j].Value = value;
                        }
                    }
                }
                MessageBox.Show("Данные успешно загружены!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка");
            }
        }

        // В DataBase.cs
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Получаем данные из выбранной строки
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Открываем калькулятор
                ProfCalczp calcForm = new ProfCalczp();

                // Заполняем данные в калькулятор
                calcForm.textBox_FIO.Text = row.Cells["Column2"].Value?.ToString() ?? "";
                calcForm.comboBox_job.Text = row.Cells["Column3"].Value?.ToString() ?? "";
                calcForm.comboBox_zanyatost.Text = row.Cells["Column4"].Value?.ToString() ?? "";
                calcForm.textBox_oklad.Text = row.Cells["Column5"].Value?.ToString() ?? "";
                calcForm.textBox_doplata.Text = row.Cells["Column8"].Value?.ToString() ?? "";
                calcForm.comboBox_sovmest.Text = row.Cells["Column6"].Value?.ToString() ?? "";
                calcForm.textBox_okladsovmest.Text = row.Cells["Column7"].Value?.ToString() ?? "";

                calcForm.numericUpDown_staz.Text = row.Cells["Column9"].Value?.ToString() ?? "";
                calcForm.numericUpDown_kval.Text = row.Cells["Column10"].Value?.ToString() ?? "";
                calcForm.numericUpDown_vred.Text = row.Cells["Column11"].Value?.ToString() ?? "";

                SetupChildrenInCalculator(calcForm, row);

                this.Hide(); // или calcForm.ShowDialog() если хочешь модальное окно
                calcForm.Show();
                ThemeManager.LoadTheme();
                ThemeManager.ApplyTheme(calcForm);
            }
        }

        // ДЕТЕЙ
        private void SetupChildrenInCalculator(ProfCalczp calcForm, DataGridViewRow row)
        {
            // Сначала сбрасываем все галочки
            calcForm.checkBox_child1.Checked = false;
            calcForm.checkBox_child2.Checked = false;
            calcForm.checkBox_child3.Checked = false;
            calcForm.checkBox_invalid1.Checked = false;
            calcForm.checkBox_invalid2.Checked = false;
            calcForm.checkBox_invalid3.Checked = false;

            // Получаем сколько всего детей из базы данных
            string childrenText = row.Cells["Column12"].Value?.ToString() ?? "0";
            string invalidText = row.Cells["Column13"].Value?.ToString() ?? "0";

            int totalChildren = 0;
            int invalidChildren = 0;

            // Пробуем преобразовать текст в числа
            int.TryParse(childrenText, out totalChildren);
            int.TryParse(invalidText, out invalidChildren);

            // Ставим галочки на чекбоксы детей
            if (totalChildren >= 1) calcForm.checkBox_child1.Checked = true;
            if (totalChildren >= 2) calcForm.checkBox_child2.Checked = true;
            if (totalChildren >= 3) calcForm.checkBox_child3.Checked = true;

            // Ставим галочки на чекбоксы инвалидности
            if (invalidChildren >= 1) calcForm.checkBox_invalid1.Checked = true;
            if (invalidChildren >= 2) calcForm.checkBox_invalid2.Checked = true;
            if (invalidChildren >= 3) calcForm.checkBox_invalid3.Checked = true;
        }

        // Метод для загрузки должностей в комбобоксы
        private void LoadJobsToComboBoxes()
        {
            try
            {
                List<string> jobs = FormJobs.GetJobsList();

                // Очищаем комбобоксы
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();

                // Добавляем должности в оба комбобокса
                foreach (string job in jobs)
                {
                    comboBox1.Items.Add(job);
                    comboBox3.Items.Add(job);
                }

                // Если есть должности, выбираем первую
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                if (comboBox3.Items.Count > 0)
                {
                    comboBox3.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке должностей: {ex.Message}", "Ошибка");
            }
        }
    }
}
