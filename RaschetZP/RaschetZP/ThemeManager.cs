using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace RaschetZP
{
    public static class ThemeManager
    {
        private static string currentTheme = "Светлая";
        private static string settingsFile = "theme_settings.txt";

        public static void LoadTheme()
        {
            if (File.Exists(settingsFile))
            {
                try
                {
                    string savedTheme = File.ReadAllText(settingsFile);
                    if (!string.IsNullOrEmpty(savedTheme))
                    {
                        currentTheme = savedTheme;
                    }
                }
                catch
                {
                    currentTheme = "Светлая";
                }
            }
            ApplyThemeToAllOpenForms();
        }

        public static void ChangeTheme(string themeName, Form form)
        {
            currentTheme = themeName;
            try
            {
                File.WriteAllText(settingsFile, themeName);
            }
            catch { }
            ApplyThemeToAllOpenForms();
        }

        public static void ApplyTheme(Form form)
        {
            ApplySpecificTheme(currentTheme, form);
        }

        public static string GetCurrentTheme()
        {
            return currentTheme;
        }

        private static void ApplyThemeToAllOpenForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                ApplySpecificTheme(currentTheme, form);
            }
        }

        private static void ApplySpecificTheme(string themeName, Form form)
        {
            // Применяем тему к форме
            switch (themeName)
            {
                case "Зелёная":
                    form.BackColor = Color.LightGreen;
                    form.ForeColor = Color.DarkGreen;
                    break;
                case "Тёмная":
                    form.BackColor = Color.FromArgb(45, 45, 48);
                    form.ForeColor = Color.White;
                    break;
                case "Синяя":
                    form.BackColor = Color.FromArgb(0, 78, 148);
                    form.ForeColor = Color.White;
                    break;
                case "Светлая":
                default:
                    form.BackColor = SystemColors.Control;
                    form.ForeColor = SystemColors.ControlText;
                    break;
            }

            // Применяем тему ко всем контролам
            ApplyThemeToControls(form.Controls, themeName);
        }

        private static void ApplyThemeToControls(Control.ControlCollection controls, string themeName)
        {
            foreach (Control control in controls)
            {
                // ОСОБАЯ обработка для MenuStrip
                if (control is MenuStrip menuStrip)
                {
                    ApplyThemeToMenuStrip(menuStrip, themeName);
                    continue;
                }

                // Обычные контролы
                ApplyThemeToControl(control, themeName);

                // Рекурсивно для вложенных контролов
                if (control.HasChildren)
                {
                    ApplyThemeToControls(control.Controls, themeName);
                }
            }
        }

        public static void ApplyThemeToMenuStrip(MenuStrip menuStrip, string themeName)
        {
            switch (themeName)
            {
                case "Зелёная":
                    menuStrip.BackColor = Color.DarkGreen;
                    menuStrip.ForeColor = Color.White;
                    break;
                case "Тёмная":
                    menuStrip.BackColor = Color.FromArgb(30, 30, 30);
                    menuStrip.ForeColor = Color.White;
                    break;
                case "Синяя":
                    menuStrip.BackColor = Color.FromArgb(0, 60, 120);
                    menuStrip.ForeColor = Color.White;
                    break;
                case "Светлая":
                    menuStrip.BackColor = SystemColors.Highlight;
                    menuStrip.ForeColor = Color.White;
                    break;
                default:
                    menuStrip.BackColor = SystemColors.MenuBar;
                    menuStrip.ForeColor = SystemColors.MenuText;
                    break;
            }

            // Стилизуем все элементы меню
            foreach (ToolStripItem item in menuStrip.Items)
            {
                item.BackColor = menuStrip.BackColor;
                item.ForeColor = menuStrip.ForeColor;

                // Для выпадающих меню
                if (item is ToolStripMenuItem menuItem)
                {
                    ApplyThemeToDropDownItems(menuItem.DropDownItems, themeName);
                }
            }
        }

        private static void ApplyThemeToDropDownItems(ToolStripItemCollection items, string themeName)
        {
            foreach (ToolStripItem item in items)
            {
                item.BackColor = GetMenuBackgroundColor(themeName);
                item.ForeColor = GetMenuForeColor(themeName);

                if (item is ToolStripMenuItem menuItem)
                {
                    ApplyThemeToDropDownItems(menuItem.DropDownItems, themeName);
                }
            }
        }

        private static Color GetMenuBackgroundColor(string themeName)
        {
            return themeName switch
            {
                "Зелёная" => Color.Green,
                "Тёмная" => Color.FromArgb(45, 45, 48),
                "Синяя" => Color.FromArgb(0, 78, 148),
                "Светлая" => SystemColors.Highlight,
                _ => SystemColors.Menu
            };
        }

        private static Color GetMenuForeColor(string themeName)
        {
            return themeName switch
            {
                "Зелёная" => Color.White,
                "Тёмная" => Color.White,
                "Синяя" => Color.White,
                _ => SystemColors.MenuText
            };
        }

        private static void ApplyThemeToControl(Control control, string themeName)
        {
            if (control is DataGridView dataGridView)
            {
                // Фиксируем черный текст и стандартные цвета для DataGridView
                dataGridView.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView.DefaultCellStyle.BackColor = SystemColors.Window;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dataGridView.RowHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dataGridView.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dataGridView.EnableHeadersVisualStyles = true;
                return; // Выходим, чтобы не применять дальше тему к DataGridView
            }

            switch (themeName)
            {
                case "Зелёная":
                    ApplyGreenTheme(control);
                    break;
                case "Тёмная":
                    ApplyDarkTheme(control);
                    break;
                case "Синяя":
                    ApplyBlueTheme(control);
                    break;
                case "Светлая":
                default:
                    ApplyLightTheme(control);
                    break;
            }
        }

        private static void ApplyGreenTheme(Control control)
        {
            if (control is Panel || control is GroupBox)
            {
                control.BackColor = Color.MediumSeaGreen;
                control.ForeColor = Color.White;
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = Color.Honeydew;
                textBox.ForeColor = Color.DarkGreen;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (control is Button button)
            {
                button.BackColor = Color.ForestGreen;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
            }
            else if (control is Label label)
            {
                label.ForeColor = Color.DarkGreen;
            }
            else if (control is ComboBox combo)
            {
                combo.BackColor = Color.Honeydew;
                combo.ForeColor = Color.DarkGreen;
            }
            else if (control is CheckBox check)
            {
                check.ForeColor = Color.DarkGreen;
            }
        }

        private static void ApplyDarkTheme(Control control)
        {
            if (control is Panel || control is GroupBox)
            {
                control.BackColor = Color.FromArgb(63, 63, 70);
                control.ForeColor = Color.White;
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = Color.FromArgb(37, 37, 38);
                textBox.ForeColor = Color.White;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (control is Button button)
            {
                button.BackColor = Color.FromArgb(0, 122, 204);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
            }
            else if (control is Label label)
            {
                label.ForeColor = Color.White;
            }
            else if (control is ComboBox combo)
            {
                combo.BackColor = Color.FromArgb(37, 37, 38);
                combo.ForeColor = Color.White;
            }
            else if (control is CheckBox check)
            {
                check.ForeColor = Color.White;
            }
            else if (control is DataGridView dataGridView)
            {
                dataGridView.BackgroundColor = Color.FromArgb(63, 63, 70);
                dataGridView.ForeColor = Color.White;
            }
        }

        private static void ApplyBlueTheme(Control control)
        {
            if (control is Panel || control is GroupBox)
            {
                control.BackColor = Color.FromArgb(0, 58, 108);
                control.ForeColor = Color.White;
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = Color.FromArgb(0, 38, 78);
                textBox.ForeColor = Color.White;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (control is Button button)
            {
                button.BackColor = Color.FromArgb(0, 98, 184);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
            }
            else if (control is Label label)
            {
                label.ForeColor = Color.White;
            }
            else if (control is ComboBox combo)
            {
                combo.BackColor = Color.FromArgb(0, 38, 78);
                combo.ForeColor = Color.White;
            }
            else if (control is CheckBox check)
            {
                check.ForeColor = Color.White;
            }
        }

        private static void ApplyLightTheme(Control control)
        {
            if (control is Panel || control is GroupBox)
            {
                control.BackColor = SystemColors.Control;
                control.ForeColor = SystemColors.ControlText;
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = SystemColors.Window;
                textBox.ForeColor = SystemColors.WindowText;
                textBox.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (control is Button button)
            {
                button.BackColor = SystemColors.ButtonFace;
                button.ForeColor = SystemColors.ControlText;
                button.FlatStyle = FlatStyle.Standard;
            }
            else if (control is Label label)
            {
                label.ForeColor = SystemColors.ControlText;
            }
            else if (control is ComboBox combo)
            {
                combo.BackColor = SystemColors.Window;
                combo.ForeColor = SystemColors.WindowText;
            }
            else if (control is CheckBox check)
            {
                check.ForeColor = SystemColors.ControlText;
            }
        }
    }
}