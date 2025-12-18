using System.Text;

namespace RaschetZP
{
    public partial class ProfCalczp : Form
    {
        public ProfCalczp()
        {
            InitializeComponent();
            SetupToolTips();
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);
            this.FormClosing += (s, args) => Application.Exit();
            LoadJobsToComboBoxes();

            // Добавляем меню, только если его еще нет
            if (!this.Controls.OfType<UserControlMenuStrip>().Any())
            {
                UserControlMenuStrip menu = new UserControlMenuStrip();
                menu.Dock = DockStyle.Top;
                this.Controls.Add(menu);
                menu.BringToFront();
            }
        }

        private void checkBox_child1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_invalid1.Enabled = checkBox_child1.Checked;
        }

        private void checkBox_child2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_invalid2.Enabled = checkBox_child2.Checked;
        }

        private void checkBox_child3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_invalid3.Enabled = checkBox_child3.Checked;
        }

        private void comboBox_zanyatost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_zanyatost.SelectedIndex == 2)
            {
                comboBox_sovmest.Enabled = true; //comboBox_zanyatost.SelectedIndex == 2;
                textBox_okladsovmest.Enabled = true;

                textBox_doplata.Enabled = false;
            }
            else if (comboBox_zanyatost.SelectedIndex == 1)
            {
                comboBox_sovmest.Enabled = false;
                textBox_okladsovmest.Enabled = false;

                textBox_doplata.Enabled = true;
            }
            else
            {
                comboBox_sovmest.Enabled = false;
                textBox_okladsovmest.Enabled = false;
                textBox_doplata.Enabled = false;
            }
        }

        private void numbercheck(object sender, KeyPressEventArgs e)// Проверка на ввод чисел
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private bool ValidateInput()
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("Отработанных дней не может быть больше рабочих!", "Ошибка");
                return false;
            }
            return true;
        }

        private void SetupToolTips() // Текстовые подсказки при наведении курсора на элемент интерфейса
        {
            var tips = new Dictionary<Control, string>
            {
                // {label19, "" }, - макет

                {button_clearall, "Очистить все поля" },
                {button_zp, "Рассчитать заработную плату" },
                {button_export, "Экспортировать расчёт в .txt документ" },
                {label39, "Представление детальной информации о каждом вычислении в расчёте" },
                {textBox_allresults, "Представление детальной информации о каждом вычислении в расчёте" },
                {label41, "Показ итоговой заработной платы" },
                {textBox_zpresult, "Показ итоговой заработной платы" },

                // Блок 1
                {label1, "Данный блок содержит основные данные сотрудника" },
                {textBox_oklad, "Введите ваш оклад" },
                {comboBox_job, "Укажите вашу должность" },
                {comboBox_zanyatost, "Выберите тип занятости: \n• Основная работа - нет дополнительных работ \n• Совмещение - разблокируется поле доплаты \n• Совместительство - разблокируются поля для указания второй должности " },
                {comboBox_sovmest, "Укажите должность по совместительству" },
                {textBox_okladsovmest, "Введите оклад по совместительству" },
                {numericUpDown1, "Укажите количество отработанных дней" },
                {numericUpDown2, "Укажите количество всех рабочих дней" },
                {textBox_doplata, "Введите процент доплаты" },
                {textBox_FIO, "Введите ФИО сотрудника. \n Только в случае если генерируете отчёт!!!" },
                // Блок 2
                {label13, "Данный блок содержит данные о начислениях: \n• Коэффициенты \n• Надбавки \n• Премии" },
                {label19, "Укажите коэффициенты региона" },
                {label16, "Введите возможные надбавки" },
                {label17, "Введите возможные премии" },

                {numericUpDown_severkoef, "Надбавка за климатические условия в %" },
                {numericUpDown_rayonkoef, "Надбавка за район в котором проходит работа в %" },

                {numericUpDown_staz, "Надбавка за стаж работы в %" },
                {numericUpDown_kval, "Надбавка за уровень квалификации в %" },
                {numericUpDown_vred, "Надбавка за вредность условий труда в %" },

                {textBox_premmes, "Премия по итогам месяца" },
                {textBox_prembol, "Оплата больничного счёта" },
                {textBox_premmater, "Материальная помощь сотруднику" },
                {textBox_premotp, "Выплата отпускных" },
                {textBox_premstimul, "Выплата стимулирующей премии" },
                {textBox_premproch, "Прочие дополнительные премии и начисления" },

                // Блок 3
                {label42, "Укажите имеются ли у сотрудника дети \n• Высчитывает налоговые вычеты на детей" },

                {radioButton1, "Сотрудник является родным отцом/матерью детей \n• Необходимо для рассчёта вычета в случае инвалидности у ребёнка" },
                {radioButton2, "Сотрудник является опекуном детей \n• Необходимо для рассчёта вычета в случае инвалидности у ребёнка" },

                {checkBox_child1, "Наличие ребёнка у сотрудника" },
                {checkBox_child2, "Наличие ребёнка у сотрудника" },
                {checkBox_child3, "Наличие ребёнка у сотрудника" },

                {checkBox_invalid1, "Наличие инвалидности у ребёнка" },
                {checkBox_invalid2, "Наличие инвалидности у ребёнка" },
                {checkBox_invalid3, "Наличие инвалидности у ребёнка" },

                // Блок 4
                {label43, "Информация о удержаниях с заработной платы" },

                {textBox_profsoyuz, "Удержания по профсоюзным взносам" },
                {textBox_alim, "Удержания по алиментам необходимых для выплаты у сотрудника" },
                {textBox_ispol, "Удержания по исполнительным листам" },
                {textBox_prochee, "Прочие удержания" },

                
                /*{ textBox_doplata, "Введите процент доплаты за совмещение (например: 30)" },
                { comboBox_zanyatost, "Выберите вид занятости:\n• Основная работа\n• Совмещение (+% к окладу)\n• Совместительство (отдельный оклад)" },
                { numericUpDown_staz, "Надбавка за стаж работы в %" },
                { numericUpDown_vred, "Надбавка за вредные условия труда в %" },
                { textBox_premmater, "Материальная помощь (не облагается НДФЛ до 4000 руб в год)" },
                { checkBox_child1, "Отметьте если есть ребенок для налогового вычета" },
                { comboBox1, "Возраст ребенка влияет на размер налогового вычета" },
                { checkBox_invalid1, "Для ребенка-инвалида размер вычета увеличивается" },
                // ... добавь остальные элементы*/
            };

            foreach (var tip in tips)
            {
                toolTip1.SetToolTip(tip.Key, tip.Value);
            }
        }

        private void button_clearall_Click(object sender, EventArgs e)
        {
            textBox_alim.Text = "";
            textBox_allresults.Text = "";
            textBox_doplata.Text = "";
            textBox_ispol.Text = "";
            textBox_oklad.Text = "";
            textBox_okladsovmest.Text = "";
            textBox_prembol.Text = "";
            textBox_premmater.Text = "";
            textBox_premmes.Text = "";
            textBox_premotp.Text = "";
            textBox_premproch.Text = "";
            textBox_premstimul.Text = "";
            textBox_prochee.Text = "";
            textBox_profsoyuz.Text = "";
            textBox_zpresult.Text = "";

            comboBox_job.Text = "";
            comboBox_sovmest.Text = "";
            comboBox_zanyatost.Text = "";

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown_kval.Value = 0;
            numericUpDown_rayonkoef.Value = 0;
            numericUpDown_severkoef.Value = 0;
            numericUpDown_staz.Value = 0;
            numericUpDown_vred.Value = 0;

            checkBox_child1.Checked = false;
            checkBox_child2.Checked = false;
            checkBox_child3.Checked = false;
            checkBox_invalid1.Checked = false;
            checkBox_invalid2.Checked = false;
            checkBox_invalid3.Checked = false;
        }

        // Вычисления
        private double CalculateBaseSalary() // Базовые вычисления Блока 1
        {
            double oklad = double.Parse(textBox_oklad.Text);
            int workedDays = (int)numericUpDown1.Value;
            int totalDays = (int)numericUpDown2.Value;

            // Оклад по отработанным дням
            double baseSalary = (oklad / totalDays) * workedDays;

            // В зависимости от вида занятости
            string zanyatost = comboBox_zanyatost.SelectedItem.ToString();

            if (zanyatost == "Совмещение")
            {
                double doplataPercent = double.Parse(textBox_doplata.Text);
                baseSalary += baseSalary * (doplataPercent / 100);
            }
            else if (zanyatost == "Совместительство")
            {
                double okladSovmest = double.Parse(textBox_okladsovmest.Text);
                double SovmestSalary = (okladSovmest / totalDays) * workedDays;
                baseSalary += SovmestSalary;
            }

            return baseSalary;
        }

        private double CalculateAllowances(double baseSalary) // Надбавки
        {
            double totalAllowances = 0;

            // Надбавка за стаж
            if (numericUpDown_staz.Value > 0)
                totalAllowances += baseSalary * ((double)numericUpDown_staz.Value / 100);

            // Надбавка за квалификацию
            if (numericUpDown_kval.Value > 0)
                totalAllowances += baseSalary * ((double)numericUpDown_kval.Value / 100);

            // Надбавка за вредность
            if (numericUpDown_vred.Value > 0)
                totalAllowances += baseSalary * ((double)numericUpDown_vred.Value / 100);

            return totalAllowances;
        }

        private double CalculateBonuses() // Премии
        {
            double totalBonuses = 0;

            // Все премии просто суммируем
            if (!string.IsNullOrEmpty(textBox_premmes.Text))
                totalBonuses += double.Parse(textBox_premmes.Text);

            if (!string.IsNullOrEmpty(textBox_premstimul.Text))
                totalBonuses += double.Parse(textBox_premstimul.Text);

            if (!string.IsNullOrEmpty(textBox_premmater.Text))
                totalBonuses += double.Parse(textBox_premmater.Text);

            if (!string.IsNullOrEmpty(textBox_prembol.Text))
                totalBonuses += double.Parse(textBox_prembol.Text);

            if (!string.IsNullOrEmpty(textBox_premotp.Text))
                totalBonuses += double.Parse(textBox_premotp.Text);

            if (!string.IsNullOrEmpty(textBox_premproch.Text))
                totalBonuses += double.Parse(textBox_premproch.Text);

            return totalBonuses;
        }

        private double ApplyCoefficients(double amount) // Коэффициенты
        {
            double result = amount;

            // Районный коэффициент
            if (numericUpDown_rayonkoef.Value > 0)
                result += result * ((double)numericUpDown_rayonkoef.Value / 100);

            // Северный коэффициент
            if (numericUpDown_severkoef.Value > 0)
                result += result * ((double)numericUpDown_severkoef.Value / 100);

            return result;
        }

        private double CalculateNDFL(double taxableAmount)
        {
            double childDeductions = 0;

            // Проверяем, доступны ли вычеты на детей
            //if (IsChildDeductionAvailable())
            childDeductions = CalculateChildVichet();


            // Налоговая база (не может быть меньше 0)
            double taxBase = Math.Max(0, taxableAmount - childDeductions);

            // НДФЛ 13%
            return taxBase * 0.13;
        }

        private double CalculateChildVichet()
        {
            double childvichet = 0;
            int children = 0;
            int children_invalid = 0;

            // Считаем количество детей
            if (checkBox_child1.Checked) children++;
            if (checkBox_child2.Checked) children++;
            if (checkBox_child3.Checked) children++;

            // Базовые вычеты по количеству детей
            if (children == 1) childvichet = 1400;
            else if (children == 2) childvichet = 2800;
            else if (children >= 3) childvichet = 6000;

            // Считаем детей-инвалидов
            if (checkBox_invalid1.Checked) children_invalid++;
            if (checkBox_invalid2.Checked) children_invalid++;
            if (checkBox_invalid3.Checked) children_invalid++;

            // Дополнительные вычеты за инвалидность
            if (radioButton1.Checked) // Родитель
            {
                childvichet += 12000 * children_invalid;
            }
            else // Опекун
            {
                childvichet += 6000 * children_invalid;
            }

            return childvichet;
        }

        /*private bool IsChildDeductionAvailable()
        {
            double monthlyBaseSalary = CalculateBaseSalary(); // Твой метод
            double yearlyBaseSalary = monthlyBaseSalary * 12;

            // Вычеты перестают действовать при доходе свыше 350 тыс. рублей в год
            return yearlyBaseSalary <= 450000;
        }*/

        // Вывод информации о расчёте
        private void DisplayResults(double baseSalary, double allowances, double bonuses,
                   double withCoefficients, double ndfl, double otherDeductions, double finalSalary)
        {
            StringBuilder details = new StringBuilder();

            // Детальная информация о расчёте
            details.AppendLine("ДЕТАЛЬНЫЙ РАСЧЁТ ЗАРАБОТНОЙ ПЛАТЫ");
            details.AppendLine("=================================");
            details.AppendLine($"ФИО сотрудника: {textBox_FIO.Text}");
            details.AppendLine($"Должность: {comboBox_job.Text}");
            details.AppendLine($"Вид занятости: {comboBox_zanyatost.Text}");
            details.AppendLine($"Отработано дней: {numericUpDown1.Value} из {numericUpDown2.Value}");
            details.AppendLine();

            // Блок 1: Основные начисления
            details.AppendLine("ОСНОВНЫЕ НАЧИСЛЕНИЯ:");
            details.AppendLine($"─ Оклад по отработанным дням: {baseSalary:C}");

            if (comboBox_zanyatost.SelectedIndex == 1) // Совмещение
            {
                double doplataPercent = double.Parse(textBox_doplata.Text);
                double doplataAmount = baseSalary * (doplataPercent / 100);
                details.AppendLine($"─ Доплата за совмещение ({doplataPercent}%): {doplataAmount:C}");
            }
            else if (comboBox_zanyatost.SelectedIndex == 2) // Совместительство
            {
                double okladSovmest = double.Parse(textBox_okladsovmest.Text);
                double sovmestSalary = (okladSovmest / (int)numericUpDown2.Value) * (int)numericUpDown1.Value;
                details.AppendLine($"─ Оклад по совместительству: {sovmestSalary:C}");
            }

            details.AppendLine($"─ Надбавки: {allowances:C}");
            if (numericUpDown_staz.Value > 0)
                details.AppendLine($"  • За стаж ({numericUpDown_staz.Value}%): {baseSalary * ((double)numericUpDown_staz.Value / 100):C}");
            if (numericUpDown_kval.Value > 0)
                details.AppendLine($"  • За квалификацию ({numericUpDown_kval.Value}%): {baseSalary * ((double)numericUpDown_kval.Value / 100):C}");
            if (numericUpDown_vred.Value > 0)
                details.AppendLine($"  • За вредность ({numericUpDown_vred.Value}%): {baseSalary * ((double)numericUpDown_vred.Value / 100):C}");

            details.AppendLine($"─ Премии: {bonuses:C}");
            if (!string.IsNullOrEmpty(textBox_premmes.Text))
                details.AppendLine($"  • Итог месяца: {double.Parse(textBox_premmes.Text):C}");
            if (!string.IsNullOrEmpty(textBox_premstimul.Text))
                details.AppendLine($"  • Стимулирующая: {double.Parse(textBox_premstimul.Text):C}");
            if (!string.IsNullOrEmpty(textBox_premmater.Text))
                details.AppendLine($"  • Материальная помощь: {double.Parse(textBox_premmater.Text):C}");
            if (!string.IsNullOrEmpty(textBox_prembol.Text))
                details.AppendLine($"  • Больничный: {double.Parse(textBox_prembol.Text):C}");
            if (!string.IsNullOrEmpty(textBox_premotp.Text))
                details.AppendLine($"  • Отпускные: {double.Parse(textBox_premotp.Text):C}");
            if (!string.IsNullOrEmpty(textBox_premproch.Text))
                details.AppendLine($"  • Прочие: {double.Parse(textBox_premproch.Text):C}");

            details.AppendLine($"─ Сумма до коэффициентов: {baseSalary + allowances + bonuses:C}");

            // Блок 2: Коэффициенты
            details.AppendLine();
            details.AppendLine("КОЭФФИЦИЕНТЫ:");
            if (numericUpDown_rayonkoef.Value > 0)
            {
                double rayonAmount = (baseSalary + allowances + bonuses) * ((double)numericUpDown_rayonkoef.Value / 100);
                details.AppendLine($"─ Районный ({numericUpDown_rayonkoef.Value}%): {rayonAmount:C}");
            }
            if (numericUpDown_severkoef.Value > 0)
            {
                double severAmount = (baseSalary + allowances + bonuses) * ((double)numericUpDown_severkoef.Value / 100);
                details.AppendLine($"─ Северный ({numericUpDown_severkoef.Value}%): {severAmount:C}");
            }
            details.AppendLine($"─ Итого после коэффициентов: {withCoefficients:C}");

            // Блок 3: Налоги и вычеты
            details.AppendLine();
            details.AppendLine("НАЛОГИ И ВЫЧЕТЫ:");

            // Налоговые вычеты на детей
            double childDeductions = CalculateChildVichet();
            if (childDeductions > 0)
            {
                details.AppendLine($"─ Налоговые вычеты на детей: {childDeductions:C}");

                int children = 0;
                if (checkBox_child1.Checked) children++;
                if (checkBox_child2.Checked) children++;
                if (checkBox_child3.Checked) children++;

                details.AppendLine($"  • Количество детей: {children}");
                if (children == 1) details.AppendLine($"  • Базовый вычет: 1,400 руб");
                else if (children == 2) details.AppendLine($"  • Базовый вычет: 2,800 руб");
                else if (children >= 3) details.AppendLine($"  • Базовый вычет: 6,000 руб");

                int invalidChildren = 0;
                if (checkBox_invalid1.Checked) invalidChildren++;
                if (checkBox_invalid2.Checked) invalidChildren++;
                if (checkBox_invalid3.Checked) invalidChildren++;

                if (invalidChildren > 0)
                {
                    string status = radioButton1.Checked ? "родитель" : "опекун";
                    double invalidBonus = radioButton1.Checked ? 12000 : 6000;
                    details.AppendLine($"  • Дети-инвалиды: {invalidChildren} ({status})");
                    details.AppendLine($"  • Доп. вычет за инвалидность: {invalidBonus * invalidChildren:C}");
                }
            }

            details.AppendLine($"─ НДФЛ (13%): {ndfl:C}");
            details.AppendLine($"─ Налоговая база: {withCoefficients - childDeductions:C}");

            // Прочие удержания
            if (otherDeductions > 0)
            {
                details.AppendLine($"─ Прочие удержания: {otherDeductions:C}");
                if (!string.IsNullOrEmpty(textBox_alim.Text))
                    details.AppendLine($"  • Алименты: {double.Parse(textBox_alim.Text):C}");
                if (!string.IsNullOrEmpty(textBox_ispol.Text))
                    details.AppendLine($"  • Исполнительные листы: {double.Parse(textBox_ispol.Text):C}");
                if (!string.IsNullOrEmpty(textBox_profsoyuz.Text))
                    details.AppendLine($"  • Профсоюзные взносы: {double.Parse(textBox_profsoyuz.Text):C}");
                if (!string.IsNullOrEmpty(textBox_prochee.Text))
                    details.AppendLine($"  • Прочее: {double.Parse(textBox_prochee.Text):C}");
            }

            // Итог
            details.AppendLine();
            details.AppendLine("ИТОГО:");
            details.AppendLine($"─ Начислено: {withCoefficients:C}");
            details.AppendLine($"─ Удержано: {ndfl + otherDeductions:C}");
            details.AppendLine($"─ К выплате: {finalSalary:C}");
            details.AppendLine();
            details.AppendLine($"Дата расчёта: {DateTime.Now:dd.MM.yyyy HH:mm}");

            textBox_allresults.Text = details.ToString();
            textBox_zpresult.Text = finalSalary.ToString("F2");
        }
        /*private void DisplayResults(double baseSalary, double allowances, double bonuses,
                           double withCoefficients, double ndfl, double otherDeductions, double finalSalary)
        {
            StringBuilder details = new StringBuilder();

            details.AppendLine($"Оклад по отработанным дням: {baseSalary:C}");
            details.AppendLine($"Надбавки: {allowances:C}");
            details.AppendLine($"Премии: {bonuses:C}");
            details.AppendLine($"После коэффициентов: {withCoefficients:C}");
            details.AppendLine($"НДФЛ: {ndfl:C}");
            details.AppendLine($"Прочие удержания: {otherDeductions:C}");
            details.AppendLine("──────────────────────────────");
            details.AppendLine($"ИТОГО НА РУКИ: {finalSalary:C}");

            textBox_allresults.Text = details.ToString();
            textBox_zpresult.Text = finalSalary.ToString("F2");
        }*/

        private void button_zp_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка валидности данных
                if (!ValidateInput()) //Inputs
                    return;

                // Проверка обязательных полей
                if (string.IsNullOrEmpty(textBox_oklad.Text))
                {
                    MessageBox.Show("Введите оклад!", "Ошибка");
                    return;
                }

                if (comboBox_zanyatost.SelectedItem == null)
                {
                    MessageBox.Show("Выберите вид занятости!", "Ошибка");
                    return;
                }

                // Проверка для совмещения
                if (comboBox_zanyatost.SelectedIndex == 1 && string.IsNullOrEmpty(textBox_doplata.Text))
                {
                    MessageBox.Show("Для совмещения введите процент доплаты!", "Ошибка");
                    return;
                }

                // Проверка для совместительства
                if (comboBox_zanyatost.SelectedIndex == 2)
                {
                    if (string.IsNullOrEmpty(textBox_okladsovmest.Text))
                    {
                        MessageBox.Show("Для совместительства введите оклад по совместительству!", "Ошибка");
                        return;
                    }
                    /*if (comboBox_sovmest.SelectedItem == null)
                    {
                        MessageBox.Show("Для совместительства выберите тип совместительства!", "Ошибка");
                        return;
                    }*/
                }

                // Основные расчеты
                double baseSalary = CalculateBaseSalary();
                double allowances = CalculateAllowances(baseSalary);
                double bonuses = CalculateBonuses();

                // Сумма до применения коэффициентов
                double beforeCoefficients = baseSalary + allowances + bonuses;

                // Применяем коэффициенты
                double withCoefficients = ApplyCoefficients(beforeCoefficients);

                // Расчет налогов и удержаний
                double ndfl = CalculateNDFL(withCoefficients);
                double otherDeductions = CalculateOtherDeductions();

                // Итоговая зарплата
                double finalSalary = withCoefficients - ndfl - otherDeductions;

                // Показываем результаты
                DisplayResults(baseSalary, allowances, bonuses, withCoefficients,
                              ndfl, otherDeductions, finalSalary);
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных числовых значений!", "Ошибка формата");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }

        private double CalculateOtherDeductions()
        {
            double totalDeductions = 0;

            if (!string.IsNullOrEmpty(textBox_alim.Text))
                totalDeductions += double.Parse(textBox_alim.Text);

            if (!string.IsNullOrEmpty(textBox_ispol.Text))
                totalDeductions += double.Parse(textBox_ispol.Text);

            if (!string.IsNullOrEmpty(textBox_profsoyuz.Text))
                totalDeductions += double.Parse(textBox_profsoyuz.Text);

            if (!string.IsNullOrEmpty(textBox_prochee.Text))
                totalDeductions += double.Parse(textBox_prochee.Text);

            return totalDeductions;
        }

        /*private bool ValidateInputs()
        {
            // Проверка отработанных дней
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("Отработанных дней не может быть больше рабочих!", "Ошибка");
                return false;
            }

            // Проверка оклада
            if (string.IsNullOrEmpty(textBox_oklad.Text) || !double.TryParse(textBox_oklad.Text, out double oklad) || oklad <= 0)
            {
                MessageBox.Show("Введите корректный оклад!", "Ошибка");
                return false;
            }

            return true;
        }*/

        // Метод для загрузки должностей в комбобоксы
        private void LoadJobsToComboBoxes()
        {
            try
            {
                List<string> jobs = FormJobs.GetJobsList();

                // Очищаем комбобоксы
                comboBox_job.Items.Clear();
                comboBox_sovmest.Items.Clear();

                // Добавляем должности в оба комбобокса
                foreach (string job in jobs)
                {
                    comboBox_job.Items.Add(job);
                    comboBox_sovmest.Items.Add(job);
                }

                // Если есть должности, выбираем первую
                if (comboBox_job.Items.Count > 0)
                {
                    comboBox_job.SelectedIndex = 0;
                }
                if (comboBox_sovmest.Items.Count > 0)
                {
                    comboBox_sovmest.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке должностей: {ex.Message}", "Ошибка");
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли результаты для экспорта
            if (string.IsNullOrEmpty(textBox_allresults.Text) || textBox_allresults.Text == "Представление детальной информации о каждом вычислении в расчёте")
            {
                MessageBox.Show(
                    "Сначала выполните расчет заработной платы!",
                    "Нет данных для экспорта",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Используем наш класс для генерации отчета
            ReportGenerator.ExportReportToFile(this);
        }
    }
}
