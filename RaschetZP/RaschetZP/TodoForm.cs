using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaschetZP
{
    public partial class TodoForm : Form
    {
        private string saveFilePath = "tasks.txt"; // Файл для сохранения задач

        public TodoForm()
        {
            InitializeComponent();

            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);

            // Настраиваем внешний вид CheckedListBox
            checkedListBox1.CheckOnClick = true; // Отмечается сразу по клику

            // Добавляем обработчики событий для существующих элементов
            //button_taskadd.Click += Button_taskadd_Click;
            //button1_save.Click += Button1_save_Click;
            //button1_load.Click += Button1_load_Click;

            // После создания checkedListBox1 добавь:
            checkedListBox1.DoubleClick += new EventHandler(CheckedListBox1_DoubleClick);
            checkedListBox1.KeyDown += new KeyEventHandler(CheckedListBox1_KeyDown);

            // Автоматически загружаем задачи при запуске
            LoadTasks();
        }

        // КНОПКА "СОХРАНИТЬ"
        private void Button1_save_Click(object sender, EventArgs e)
        {
            SaveTasks();
        }

        // КНОПКА "ЗАГРУЗИТЬ"
        private void Button1_load_Click(object sender, EventArgs e)
        {
            LoadTasks();
        }

        // СОХРАНЕНИЕ ЗАДАЧ В ФАЙЛ
        private void SaveTasks()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(saveFilePath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        string task = checkedListBox1.Items[i].ToString();
                        bool isCompleted = checkedListBox1.GetItemChecked(i);

                        // Сохраняем в формате: [статус]|текст_задачи
                        string status = isCompleted ? "1" : "0";
                        writer.WriteLine($"{status}|{task}");
                    }
                }

                MessageBox.Show($"Задачи сохранены!\nФайл: {saveFilePath}",
                              "Сохранение успешно",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении задач:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        // ЗАГРУЗКА ЗАДАЧ ИЗ ФАЙЛА
        private void LoadTasks()
        {
            try
            {
                if (!File.Exists(saveFilePath))
                {
                    MessageBox.Show("Файл с задачами не найден.\nСначала сохраните задачи.",
                                  "Файл не найден",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    return;
                }

                // Спрашиваем подтверждение, если уже есть задачи
                if (checkedListBox1.Items.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Текущие задачи будут заменены. Продолжить?",
                        "Подтверждение загрузки",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                        return;
                }

                // Очищаем текущий список
                checkedListBox1.Items.Clear();

                // Читаем файл и добавляем задачи
                string[] lines = File.ReadAllLines(saveFilePath, Encoding.UTF8);
                int loadedCount = 0;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Разбираем строку: [статус]|текст_задачи
                    string[] parts = line.Split('|');
                    if (parts.Length >= 2)
                    {
                        string status = parts[0];
                        string taskText = parts[1];

                        // Добавляем задачу
                        int index = checkedListBox1.Items.Add(taskText);

                        // Устанавливаем статус выполнения
                        if (status == "1")
                        {
                            checkedListBox1.SetItemChecked(index, true);
                        }

                        loadedCount++;
                    }
                }

                MessageBox.Show($"Загружено задач: {loadedCount}",
                              "Загрузка завершена",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке задач:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        // Автоматическая загрузка при запуске (без сообщений)
        private void LoadTasksSilent()
        {
            try
            {
                if (File.Exists(saveFilePath))
                {
                    checkedListBox1.Items.Clear();
                    string[] lines = File.ReadAllLines(saveFilePath, Encoding.UTF8);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] parts = line.Split('|');
                        if (parts.Length >= 2)
                        {
                            string status = parts[0];
                            string taskText = parts[1];
                            int index = checkedListBox1.Items.Add(taskText);

                            if (status == "1")
                            {
                                checkedListBox1.SetItemChecked(index, true);
                            }
                        }
                    }
                }
            }
            catch
            {
                // Игнорируем ошибки при автоматической загрузке
            }
        }

        // Добавление примеров задач (если файла нет)
        private void AddExampleTasks()
        {
            if (checkedListBox1.Items.Count == 0)
            {
                checkedListBox1.Items.Add("Проверить расчет зарплаты");
                checkedListBox1.Items.Add("Обновить базу сотрудников");
                checkedListBox1.Items.Add("Подготовить отчет за месяц");
            }
        }

        // КНОПКА "ДОБАВИТЬ ЗАДАЧУ"
        private void Button_taskadd_Click(object sender, EventArgs e)
        {
            string newTask = ShowInputDialog("Введите новую задачу:");

            if (!string.IsNullOrEmpty(newTask))
            {
                checkedListBox1.Items.Add(newTask);
                // Автосохранение при добавлении новой задачи (опционально)
                // SaveTasks();
            }
        }

        // Простой диалог для ввода текста
        private string ShowInputDialog(string text)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Новая задача",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 200 }; // Надпись "Введите задачу"
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 240 }; // Текстовое поле
            Button confirmation = new Button() { Text = "Добавить", Left = 175, Width = 85, Top = 80, DialogResult = DialogResult.OK }; // Кнопка подтверждения

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        // УДАЛЕНИЕ ЗАДАЧИ ПРИ ДВОЙНОМ КЛИКЕ
        private void CheckedListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                string taskText = checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString();
                DialogResult result = MessageBox.Show($"Удалить задачу:\n\"{taskText}\"?",
                    "Удаление задачи",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                }
            }
        }

        // УДАЛЕНИЕ ВЫПОЛНЕННЫХ ЗАДАЧ ПРИ НАЖАТИИ ПРОБЕЛА
        private void CheckedListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
            else if (e.KeyCode == Keys.Space && checkedListBox1.SelectedIndex != -1)
            {
                bool currentState = checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, !currentState);
            }
        }

        // УДАЛЕНИЕ ВСЕХ ЗАДАЧ
        private void button2_deleteall_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Удалить все задачи? Это действие нельзя отменить.",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    checkedListBox1.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Список задач уже пуст!",
                              "Информация",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

        // Автоматическое сохранение при закрытии формы
        /*protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                SaveTasks(); // Автосохранение при закрытии
            }
            base.OnFormClosing(e);
        }*/
    }
}