using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaschetZP
{
    public partial class Calczp : Form
    {
        public Calczp()
        {
            InitializeComponent();
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);
            this.FormClosing += (s, args) => Application.Exit();

            // Добавляем меню, только если его еще нет
            if (!this.Controls.OfType<UserControlMenuStrip>().Any())
            {
                UserControlMenuStrip menu = new UserControlMenuStrip();
                menu.Dock = DockStyle.Top;
                this.Controls.Add(menu);
                menu.BringToFront();
            }

            //Закрываю текстбокс про детей в начале
            textBox5_children.Enabled = false;
        }

        //Кнопки на экране
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5_children.Enabled = checkBox1.Checked;

            if (!checkBox1.Checked)
                textBox5_children.Text = "0";
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double oklad = double.Parse(textBox1_oklad.Text);
                int workedDays = int.Parse(textBox2_workeddays.Text);
                int totalDays = int.Parse(textBox3_alldayswork.Text);
                double premia = double.Parse(textBox4_prem.Text);

                // ЗП за отработанные дни
                double zarplata = (oklad / totalDays) * workedDays + premia;
                double zarplataBezCoeff = zarplata;

                double severCoeff = GetCoefficientFromComboBox(comboBox1);
                double raionCoeff = GetCoefficientFromComboBox(comboBox2);
                zarplata = zarplata * severCoeff * raionCoeff;

                double zarplataSCoeff = zarplataBezCoeff * severCoeff * raionCoeff;

                double ndfl = CalculateNDFL(zarplata, checkBox1.Checked, textBox5_children.Text);

                // Финал ЗП
                double result = zarplata - ndfl;
                textBox1_zp.Text = result.ToString("F2");
                ShowCalculationDetails(oklad, workedDays, totalDays, premia, zarplataBezCoeff, severCoeff, raionCoeff, zarplataSCoeff, ndfl, result);
            }
            catch (Exception ex)
            {
                //Вывод сообщения об ошибке если что-то введено не так
                MessageBox.Show("Ошибка в данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Получение коэффициентов
        private double GetCoefficientFromComboBox(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null) return 1.0;

            string selected = comboBox.SelectedItem.ToString();
            if (selected == "Не применяется") return 1.0;

            //return double.Parse(selected);
            return double.Parse(selected, System.Globalization.CultureInfo.InvariantCulture);// Тут код чтобы строки нормально переводились в числа с точкой
        }

        // Функция для расчета НДФЛ (налога)
        private double CalculateNDFL(double zarplata, bool hasChildren, string childrenCountText)
        {
            // Стандартная ставка НДФЛ = 13%
            double ndflProcent = 0.13;
            double ndflBase = zarplata;

            // Вычет с налогов если есть дети
            if (hasChildren && int.TryParse(childrenCountText, out int childrenCount))
            {
                // На каждого ребенка вычет = 1400 рублей
                double vychetNaRebenka = 1400; // В проф версии нужно сделать более точную настройку
                // Считаем общий вычет (но не более чем на 3 детей)
                double totalVychet = Math.Min(childrenCount, 3) * vychetNaRebenka;
                ndflBase = Math.Max(0, zarplata - totalVychet);
            }

            //база_налога * 13%
            double ndfl = ndflBase * ndflProcent;
            return ndfl;
        }

        private void button2_Click(object sender, EventArgs e) // Очистка
        {
            textBox1_oklad.Text = "0";
            textBox2_workeddays.Text = "0";
            textBox3_alldayswork.Text = "0";
            textBox4_prem.Text = "0";
            textBox5_children.Text = "0";
            textBox1_zp.Text = "0";
            textBox_details.Text = "Все поля очищены";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            checkBox1.Checked = false;
        }

        // Вывод подробностей
        private void ShowCalculationDetails(double oklad, int workedDays, int totalDays, double premia,
                                  double zarplataBezCoeff, double severCoeff, double raionCoeff,
                                  double zarplataSCoeff, double ndfl, double result)
        {
            StringBuilder details = new StringBuilder();

            details.AppendLine($"Оклад: {oklad:C}");
            details.AppendLine($"Отработано: {workedDays} из {totalDays} дней");
            details.AppendLine($"Премия: {premia:C}");
            details.AppendLine($"ЗП до коэффициентов: {zarplataBezCoeff:C}");
            details.AppendLine($"Северный коэффициент: {severCoeff}");
            details.AppendLine($"Районный коэффициент: {raionCoeff}");
            details.AppendLine($"ЗП с коэффициентами: {zarplataSCoeff:C}");
            details.AppendLine($"НДФЛ: {ndfl:C}");
            details.AppendLine($"ИТОГО на руки: {result:C}");

            textBox_details.Text = details.ToString();
        }
    }
}
