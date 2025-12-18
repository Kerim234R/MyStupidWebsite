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
    public partial class FormJobs : Form
    {
        public string saveFilePath2 = "jobslist.txt"; // Файл для сохранения должностей
        public FormJobs()
        {
            InitializeComponent();
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                //textBox1.Text += "\n" + textBox2.Text + "\n";
                //textBox2.Text = string.Empty;
                StringBuilder sb = new StringBuilder();

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    sb.AppendLine(textBox2.Text);
                    textBox1.Text += sb.ToString();
                    textBox2.Text = string.Empty;
                } else
                {
                    sb.AppendLine();
                    sb.Append(textBox2.Text);
                    textBox1.Text += sb.ToString();
                    textBox2.Text = string.Empty;
                    /*if (needtoplaceextra == true)
                    {
                        sb.AppendLine();
                        sb.Append(textBox2.Text);
                        textBox1.Text += sb.ToString();
                        textBox2.Text = string.Empty;
                    } else
                    {
                        sb.AppendLine(textBox2.Text);
                        textBox1.Text += sb.ToString();
                        textBox2.Text = string.Empty;
                    }*/
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw2 = new StreamWriter(saveFilePath2, false, Encoding.UTF8))
                {
                    sw2.Write(textBox1.Text);
                }
                MessageBox.Show("Должности успешно сохранены!", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(saveFilePath2))
                {
                    using (StreamReader sr = new StreamReader(saveFilePath2, Encoding.UTF8))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                    MessageBox.Show("Должности успешно загружены!", "Успех");
                }
                else
                {
                    MessageBox.Show("Файл с должностями не найден!", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка");
            }
        }

        // Метод для получения списка должностей (будет использоваться в других формах)
        public static List<string> GetJobsList()
        {
            List<string> jobs = new List<string>();
            string filePath = "jobslist.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                jobs.Add(line.Trim());
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Если файл не найден или ошибка чтения, вернем пустой список
            }

            return jobs;
        }
    }
}
