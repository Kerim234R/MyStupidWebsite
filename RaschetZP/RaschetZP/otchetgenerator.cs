using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RaschetZP
{
    public static class ReportGenerator
    {
        public static string GenerateDetailedReport(ProfCalczp form)
        {
            StringBuilder report = new StringBuilder();

            // Шапка отчета
            report.AppendLine("==================================================================================");
            report.AppendLine("                     ДЕТАЛЬНЫЙ РАСЧЕТ ЗАРАБОТНОЙ ПЛАТЫ");
            report.AppendLine("==================================================================================");
            report.AppendLine($"Дата формирования: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            report.AppendLine();

            // Раздел 1: Основные данные сотрудника
            report.AppendLine("1. ОСНОВНЫЕ ДАННЫЕ СОТРУДНИКА");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            report.AppendLine($"   ФИО сотрудника: {form.textBox_FIO.Text}");
            report.AppendLine($"   Должность: {form.comboBox_job.Text}");
            report.AppendLine($"   Вид занятости: {form.comboBox_zanyatost.Text}");
            report.AppendLine($"   Оклад: {form.textBox_oklad.Text} руб.");
            report.AppendLine($"   Отработано дней: {form.numericUpDown1.Value} из {form.numericUpDown2.Value}");
            report.AppendLine();

            // Дополнительная информация в зависимости от вида занятости
            if (form.comboBox_zanyatost.SelectedIndex == 1) // Совмещение
            {
                report.AppendLine($"   Доплата за совмещение: {form.textBox_doplata.Text}%");
            }
            else if (form.comboBox_zanyatost.SelectedIndex == 2) // Совместительство
            {
                report.AppendLine($"   Должность по совместительству: {form.comboBox_sovmest.Text}");
                report.AppendLine($"   Оклад по совместительству: {form.textBox_okladsovmest.Text} руб.");
            }
            report.AppendLine();

            // Раздел 2: Коэффициенты
            report.AppendLine("2. РЕГИОНАЛЬНЫЕ КОЭФФИЦИЕНТЫ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            if (form.numericUpDown_rayonkoef.Value > 0)
                report.AppendLine($"   • Районный коэффициент: {form.numericUpDown_rayonkoef.Value}%");
            if (form.numericUpDown_severkoef.Value > 0)
                report.AppendLine($"   • Северный коэффициент: {form.numericUpDown_severkoef.Value}%");
            if (form.numericUpDown_rayonkoef.Value == 0 && form.numericUpDown_severkoef.Value == 0)
                report.AppendLine("   • Региональные коэффициенты не применяются");
            report.AppendLine();

            // Раздел 3: Надбавки
            report.AppendLine("3. НАДБАВКИ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            if (form.numericUpDown_staz.Value > 0)
                report.AppendLine($"   • За стаж: {form.numericUpDown_staz.Value}%");
            if (form.numericUpDown_kval.Value > 0)
                report.AppendLine($"   • За квалификацию: {form.numericUpDown_kval.Value}%");
            if (form.numericUpDown_vred.Value > 0)
                report.AppendLine($"   • За вредные условия: {form.numericUpDown_vred.Value}%");
            if (form.numericUpDown_staz.Value == 0 && form.numericUpDown_kval.Value == 0 && form.numericUpDown_vred.Value == 0)
                report.AppendLine("   • Надбавки не применяются");
            report.AppendLine();

            // Раздел 4: Премии и дополнительные выплаты
            report.AppendLine("4. ПРЕМИИ И ДОПОЛНИТЕЛЬНЫЕ ВЫПЛАТЫ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            double totalBonuses = 0;

            if (!string.IsNullOrEmpty(form.textBox_premmes.Text))
            {
                double premMes = double.Parse(form.textBox_premmes.Text);
                report.AppendLine($"   • Итог месяца: {premMes} руб.");
                totalBonuses += premMes;
            }
            if (!string.IsNullOrEmpty(form.textBox_premstimul.Text))
            {
                double premStimul = double.Parse(form.textBox_premstimul.Text);
                report.AppendLine($"   • Стимулирующая: {premStimul} руб.");
                totalBonuses += premStimul;
            }
            if (!string.IsNullOrEmpty(form.textBox_premmater.Text))
            {
                double premMater = double.Parse(form.textBox_premmater.Text);
                report.AppendLine($"   • Материальная помощь: {premMater} руб.");
                totalBonuses += premMater;
            }
            if (!string.IsNullOrEmpty(form.textBox_prembol.Text))
            {
                double premBol = double.Parse(form.textBox_prembol.Text);
                report.AppendLine($"   • Больничный: {premBol} руб.");
                totalBonuses += premBol;
            }
            if (!string.IsNullOrEmpty(form.textBox_premotp.Text))
            {
                double premOtp = double.Parse(form.textBox_premotp.Text);
                report.AppendLine($"   • Отпускные: {premOtp} руб.");
                totalBonuses += premOtp;
            }
            if (!string.IsNullOrEmpty(form.textBox_premproch.Text))
            {
                double premProch = double.Parse(form.textBox_premproch.Text);
                report.AppendLine($"   • Прочие начисления: {premProch} руб.");
                totalBonuses += premProch;
            }

            if (totalBonuses == 0)
                report.AppendLine("   • Дополнительные выплаты отсутствуют");
            else
                report.AppendLine($"   • Всего дополнительных выплат: {totalBonuses} руб.");
            report.AppendLine();

            // Раздел 5: Налоговые вычеты
            report.AppendLine("5. НАЛОГОВЫЕ ВЫЧЕТЫ НА ДЕТЕЙ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            int childrenCount = 0;
            int invalidChildrenCount = 0;

            if (form.checkBox_child1.Checked) childrenCount++;
            if (form.checkBox_child2.Checked) childrenCount++;
            if (form.checkBox_child3.Checked) childrenCount++;

            if (form.checkBox_invalid1.Checked) invalidChildrenCount++;
            if (form.checkBox_invalid2.Checked) invalidChildrenCount++;
            if (form.checkBox_invalid3.Checked) invalidChildrenCount++;

            report.AppendLine($"   • Количество детей: {childrenCount}");
            if (invalidChildrenCount > 0)
                report.AppendLine($"   • Детей с инвалидностью: {invalidChildrenCount}");

            string parentStatus = form.radioButton1.Checked ? "родитель" : "опекун";
            report.AppendLine($"   • Статус: {parentStatus}");

            double childDeduction = CalculateChildDeduction(form);
            report.AppendLine($"   • Сумма налогового вычета: {childDeduction} руб.");
            report.AppendLine();

            // Раздел 6: Удержания
            report.AppendLine("6. УДЕРЖАНИЯ ИЗ ЗАРАБОТНОЙ ПЛАТЫ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            double totalDeductions = 0;

            if (!string.IsNullOrEmpty(form.textBox_alim.Text))
            {
                double alim = double.Parse(form.textBox_alim.Text);
                report.AppendLine($"   • Алименты: {alim} руб.");
                totalDeductions += alim;
            }
            if (!string.IsNullOrEmpty(form.textBox_ispol.Text))
            {
                double ispol = double.Parse(form.textBox_ispol.Text);
                report.AppendLine($"   • Исполнительные листы: {ispol} руб.");
                totalDeductions += ispol;
            }
            if (!string.IsNullOrEmpty(form.textBox_profsoyuz.Text))
            {
                double prof = double.Parse(form.textBox_profsoyuz.Text);
                report.AppendLine($"   • Профсоюзные взносы: {prof} руб.");
                totalDeductions += prof;
            }
            if (!string.IsNullOrEmpty(form.textBox_prochee.Text))
            {
                double proch = double.Parse(form.textBox_prochee.Text);
                report.AppendLine($"   • Прочие удержания: {proch} руб.");
                totalDeductions += proch;
            }

            if (totalDeductions == 0)
                report.AppendLine("   • Дополнительные удержания отсутствуют");
            else
                report.AppendLine($"   • Всего удержаний: {totalDeductions} руб.");
            report.AppendLine();

            // Раздел 7: Итоговый расчет (из textBox_allresults)
            report.AppendLine("7. ИТОГОВЫЙ РАСЧЕТ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            report.AppendLine(form.textBox_allresults.Text);

            // Раздел 8: Примечания
            report.AppendLine("8. ПРИМЕЧАНИЯ");
            report.AppendLine("──────────────────────────────────────────────────────────────────────────────────");
            report.AppendLine("• Расчет выполнен с помощью программы 'Профессиональный калькулятор ЗП'");
            report.AppendLine("• Все суммы указаны в российских рублях");
            report.AppendLine("• Дата расчета соответствует текущей системной дате");

            return report.ToString();
        }

        private static double CalculateChildDeduction(ProfCalczp form)
        {
            // Дублируем логику расчета вычетов из ProfCalczp
            double childvichet = 0;
            int children = 0;
            int children_invalid = 0;

            if (form.checkBox_child1.Checked) children++;
            if (form.checkBox_child2.Checked) children++;
            if (form.checkBox_child3.Checked) children++;

            if (children == 1) childvichet = 1400;
            else if (children == 2) childvichet = 2800;
            else if (children >= 3) childvichet = 6000;

            if (form.checkBox_invalid1.Checked) children_invalid++;
            if (form.checkBox_invalid2.Checked) children_invalid++;
            if (form.checkBox_invalid3.Checked) children_invalid++;

            if (form.radioButton1.Checked)
            {
                childvichet += 12000 * children_invalid;
            }
            else
            {
                childvichet += 6000 * children_invalid;
            }

            return childvichet;
        }

        public static bool ExportReportToFile(ProfCalczp form)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                saveFileDialog.Title = "Экспорт детального отчета";
                saveFileDialog.FileName = $"Зарплатный_отчет_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                // Устанавливаем начальную директорию - рабочий стол
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string report = GenerateDetailedReport(form);
                    File.WriteAllText(saveFileDialog.FileName, report, Encoding.UTF8);

                    // Показываем информационное окно с путем к файлу
                    string directory = Path.GetDirectoryName(saveFileDialog.FileName);
                    string fileName = Path.GetFileName(saveFileDialog.FileName);

                    MessageBox.Show(
                        $"Отчет успешно экспортирован!\n\n" +
                        $"Файл: {fileName}\n" +
                        $"Папка: {directory}\n\n" +
                        $"Для открытия отчета перейдите в указанную папку и откройте файл {fileName}",
                        "Экспорт завершен",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при экспорте отчета:\n{ex.Message}",
                    "Ошибка экспорта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return false;
        }
    }
}