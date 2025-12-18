namespace RaschetZP
{
    partial class UserControlMenuStrip
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлыToolStripMenuItem = new ToolStripMenuItem();
            базаДанныхСотрудниковToolStripMenuItem = new ToolStripMenuItem();
            калькуляторЗаработнойПлатыпрофToolStripMenuItem = new ToolStripMenuItem();
            калькуляторЗПToolStripMenuItem = new ToolStripMenuItem();
            вернутьсяВГлавноеМенюToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            темыToolStripMenuItem = new ToolStripMenuItem();
            светлаяToolStripMenuItem = new ToolStripMenuItem();
            тёмнаяToolStripMenuItem = new ToolStripMenuItem();
            синяяToolStripMenuItem = new ToolStripMenuItem();
            зелёнаяToolStripMenuItem = new ToolStripMenuItem();
            менеджерДолжностейToolStripMenuItem = new ToolStripMenuItem();
            программаToolStripMenuItem = new ToolStripMenuItem();
            инструкцияПоИспользованиюToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            списокЗадачToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Highlight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлыToolStripMenuItem, настройкиToolStripMenuItem, программаToolStripMenuItem, списокЗадачToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(838, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлыToolStripMenuItem
            // 
            файлыToolStripMenuItem.BackColor = SystemColors.Highlight;
            файлыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { базаДанныхСотрудниковToolStripMenuItem, калькуляторЗаработнойПлатыпрофToolStripMenuItem, калькуляторЗПToolStripMenuItem, вернутьсяВГлавноеМенюToolStripMenuItem, выходToolStripMenuItem });
            файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            файлыToolStripMenuItem.Size = new Size(70, 24);
            файлыToolStripMenuItem.Text = "Файлы";
            // 
            // базаДанныхСотрудниковToolStripMenuItem
            // 
            базаДанныхСотрудниковToolStripMenuItem.Name = "базаДанныхСотрудниковToolStripMenuItem";
            базаДанныхСотрудниковToolStripMenuItem.Size = new Size(363, 26);
            базаДанныхСотрудниковToolStripMenuItem.Text = "База данных сотрудников";
            базаДанныхСотрудниковToolStripMenuItem.ToolTipText = "Перейти базу данных сотрудников";
            базаДанныхСотрудниковToolStripMenuItem.Click += базаДанныхСотрудниковToolStripMenuItem_Click;
            // 
            // калькуляторЗаработнойПлатыпрофToolStripMenuItem
            // 
            калькуляторЗаработнойПлатыпрофToolStripMenuItem.Name = "калькуляторЗаработнойПлатыпрофToolStripMenuItem";
            калькуляторЗаработнойПлатыпрофToolStripMenuItem.Size = new Size(363, 26);
            калькуляторЗаработнойПлатыпрофToolStripMenuItem.Text = "Калькулятор заработной платы (проф)";
            калькуляторЗаработнойПлатыпрофToolStripMenuItem.ToolTipText = "Перейти в режим проф калькулятора для точных расчётов";
            калькуляторЗаработнойПлатыпрофToolStripMenuItem.Click += калькуляторЗаработнойПлатыпрофToolStripMenuItem_Click;
            // 
            // калькуляторЗПToolStripMenuItem
            // 
            калькуляторЗПToolStripMenuItem.Name = "калькуляторЗПToolStripMenuItem";
            калькуляторЗПToolStripMenuItem.Size = new Size(363, 26);
            калькуляторЗПToolStripMenuItem.Text = "Калькулятор заработной платы";
            калькуляторЗПToolStripMenuItem.ToolTipText = "Перейти в калькулятор заработной платы";
            калькуляторЗПToolStripMenuItem.Click += калькуляторЗПToolStripMenuItem_Click;
            // 
            // вернутьсяВГлавноеМенюToolStripMenuItem
            // 
            вернутьсяВГлавноеМенюToolStripMenuItem.Name = "вернутьсяВГлавноеМенюToolStripMenuItem";
            вернутьсяВГлавноеМенюToolStripMenuItem.Size = new Size(363, 26);
            вернутьсяВГлавноеМенюToolStripMenuItem.Text = "Вернуться в главное меню";
            вернутьсяВГлавноеМенюToolStripMenuItem.ToolTipText = "Перейти в главное меню";
            вернутьсяВГлавноеМенюToolStripMenuItem.Click += вернутьсяВГлавноеМенюToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.AccessibleDescription = "";
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(363, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.ToolTipText = "Выйти из программы";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { темыToolStripMenuItem, менеджерДолжностейToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(98, 24);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // темыToolStripMenuItem
            // 
            темыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { светлаяToolStripMenuItem, тёмнаяToolStripMenuItem, синяяToolStripMenuItem, зелёнаяToolStripMenuItem });
            темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            темыToolStripMenuItem.Size = new Size(254, 26);
            темыToolStripMenuItem.Text = "Темы";
            темыToolStripMenuItem.ToolTipText = "Сменяет цвета интерфейса";
            // 
            // светлаяToolStripMenuItem
            // 
            светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            светлаяToolStripMenuItem.Size = new Size(149, 26);
            светлаяToolStripMenuItem.Text = "Светлая";
            светлаяToolStripMenuItem.Click += светлаяToolStripMenuItem_Click;
            // 
            // тёмнаяToolStripMenuItem
            // 
            тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            тёмнаяToolStripMenuItem.Size = new Size(149, 26);
            тёмнаяToolStripMenuItem.Text = "Тёмная";
            тёмнаяToolStripMenuItem.Click += тёмнаяToolStripMenuItem_Click;
            // 
            // синяяToolStripMenuItem
            // 
            синяяToolStripMenuItem.Name = "синяяToolStripMenuItem";
            синяяToolStripMenuItem.Size = new Size(149, 26);
            синяяToolStripMenuItem.Text = "Синяя";
            синяяToolStripMenuItem.Click += синяяToolStripMenuItem_Click;
            // 
            // зелёнаяToolStripMenuItem
            // 
            зелёнаяToolStripMenuItem.Name = "зелёнаяToolStripMenuItem";
            зелёнаяToolStripMenuItem.Size = new Size(149, 26);
            зелёнаяToolStripMenuItem.Text = "Зелёная";
            зелёнаяToolStripMenuItem.Click += зелёнаяToolStripMenuItem_Click;
            // 
            // менеджерДолжностейToolStripMenuItem
            // 
            менеджерДолжностейToolStripMenuItem.Name = "менеджерДолжностейToolStripMenuItem";
            менеджерДолжностейToolStripMenuItem.Size = new Size(254, 26);
            менеджерДолжностейToolStripMenuItem.Text = "Менеджер должностей";
            менеджерДолжностейToolStripMenuItem.ToolTipText = "Открывает форму для редактирования списка должностей";
            менеджерДолжностейToolStripMenuItem.Click += менеджерДолжностейToolStripMenuItem_Click;
            // 
            // программаToolStripMenuItem
            // 
            программаToolStripMenuItem.BackColor = SystemColors.Highlight;
            программаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { инструкцияПоИспользованиюToolStripMenuItem, оПрограммеToolStripMenuItem });
            программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            программаToolStripMenuItem.Size = new Size(81, 24);
            программаToolStripMenuItem.Text = "Справка";
            // 
            // инструкцияПоИспользованиюToolStripMenuItem
            // 
            инструкцияПоИспользованиюToolStripMenuItem.Name = "инструкцияПоИспользованиюToolStripMenuItem";
            инструкцияПоИспользованиюToolStripMenuItem.Size = new Size(312, 26);
            инструкцияПоИспользованиюToolStripMenuItem.Text = "Инструкция по использованию";
            инструкцияПоИспользованиюToolStripMenuItem.ToolTipText = "Открывает инструкцию по использованию программы";
            инструкцияПоИспользованиюToolStripMenuItem.Click += инструкцияПоИспользованиюToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(312, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.ToolTipText = "Информация о программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // списокЗадачToolStripMenuItem
            // 
            списокЗадачToolStripMenuItem.Name = "списокЗадачToolStripMenuItem";
            списокЗадачToolStripMenuItem.Size = new Size(116, 24);
            списокЗадачToolStripMenuItem.Text = "Список задач";
            списокЗадачToolStripMenuItem.ToolTipText = "Список задач для просмотра и записи новых дел";
            списокЗадачToolStripMenuItem.Click += списокЗадачToolStripMenuItem_Click;
            // 
            // UserControlMenuStrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Name = "UserControlMenuStrip";
            Size = new Size(838, 31);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлыToolStripMenuItem;
        private ToolStripMenuItem базаДанныхСотрудниковToolStripMenuItem;
        private ToolStripMenuItem калькуляторЗаработнойПлатыпрофToolStripMenuItem;
        private ToolStripMenuItem калькуляторЗПToolStripMenuItem;
        private ToolStripMenuItem вернутьсяВГлавноеМенюToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem темыToolStripMenuItem;
        private ToolStripMenuItem светлаяToolStripMenuItem;
        private ToolStripMenuItem тёмнаяToolStripMenuItem;
        private ToolStripMenuItem синяяToolStripMenuItem;
        private ToolStripMenuItem программаToolStripMenuItem;
        private ToolStripMenuItem инструкцияПоИспользованиюToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem списокЗадачToolStripMenuItem;
        private ToolStripMenuItem зелёнаяToolStripMenuItem;
        private ToolStripMenuItem менеджерДолжностейToolStripMenuItem;
    }
}
