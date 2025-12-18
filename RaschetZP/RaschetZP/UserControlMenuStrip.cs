using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaschetZP
{
    public partial class UserControlMenuStrip : UserControl
    {
        public UserControlMenuStrip()
        {
            InitializeComponent();

            //ThemeManager.LoadTheme();
            //ThemeManager.ApplyTheme(this);
        }

        public void ApplyThemeToMenu()
        {
            ThemeManager.ApplyThemeToMenuStrip(menuStrip1, ThemeManager.GetCurrentTheme());
        }

        //Кнопки полоски меню
        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Базовый калькулятор
        private void калькуляторЗПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string message = "Вы уже находитесь здесь!";
            //MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Calczp calcczpform = new Calczp();
            ThemeManager.ApplyTheme(calcczpform);
            calcczpform.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }
        //Вернуться в меню
        private void вернутьсяВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            ThemeManager.ApplyTheme(mainform);
            mainform.Show();

            // ИСПРАВЛЕНИЕ: Получаем родительскую форму и скрываем её
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }
        //справка о программе
        protected void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Калькулятор заработной платы v1.0\n\n" +
                    "Разработано для расчёта ЗП\n" +
                    "Функции:\n" +
                    "- Учет сотрудников\n" +
                    "- Профессиональный расчет ЗП\n\n" +
                    "2025 год";
            MessageBox.Show(message, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Вызов списка задач
        private void списокЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodoForm todoform = new TodoForm();
            todoform.Show();
        }

        // Обработчики для выбора темы
        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ИСПРАВЛЕНИЕ: Передаем родительскую форму
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                ThemeManager.ChangeTheme("Светлая", parentForm);
            }
        }
        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                ThemeManager.ChangeTheme("Тёмная", parentForm);
            }
        }
        private void синяяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                ThemeManager.ChangeTheme("Синяя", parentForm);
            }
        }

        private void зелёнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                ThemeManager.ChangeTheme("Зелёная", parentForm);
            }
        }

        private void калькуляторЗаработнойПлатыпрофToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfCalczp profCalczp = new ProfCalczp();
            ThemeManager.ApplyTheme(profCalczp);
            profCalczp.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }

        private void базаДанныхСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            ThemeManager.ApplyTheme(db);
            db.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }

        private void менеджерДолжностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJobs job = new FormJobs();
            job.Show();
        }

        private void инструкцияПоИспользованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Путь к вашему файлу инструкции
            string instructionPath = Path.Combine(Application.StartupPath, "Мануал к Калькулятору ЗП.pdf");

            // Проверка существования файла
            if (!File.Exists(instructionPath))
            {
                MessageBox.Show($"Файл инструкции не найден по пути:\n{instructionPath}",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Открытие файла с помощью стандартной программы
                Process.Start(new ProcessStartInfo(instructionPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть инструкцию:\n{ex.Message}",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}