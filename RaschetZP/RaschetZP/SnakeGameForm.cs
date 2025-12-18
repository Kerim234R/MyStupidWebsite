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
    public partial class SnakeGameForm : Form
    {
        // Основные переменные игры
        private List<Point> snake; // Список точек змейки
        private Point food;        // Позиция еды
        private string direction = "right"; // Направление движения
        private int score = 0;     // Счет
        private bool isGameRunning = false; // Идет ли игра
        private Random random = new Random(); // Для случайных чисел

        // Размеры игрового поля в клетках
        private const int gridSize = 20; // Размер одной клетки
        private int widthInCells;  // Ширина в клетках
        private int heightInCells; // Высота в клетках

        public SnakeGameForm()
        {
            InitializeComponent();
            ThemeManager.LoadTheme();
            ThemeManager.ApplyTheme(this);
            this.FormClosing += (s, args) => Application.Exit();

            // Меню из user control
            UserControlMenuStrip menu = new UserControlMenuStrip();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
            menu.BringToFront();

            // Рассчитываем размеры поля
            widthInCells = pictureBox1.Width / gridSize;
            heightInCells = pictureBox1.Height / gridSize;
            pictureBox1.Focus();
            // Запускаем инициализацию
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Создаем змейку из 3 сегментов
            snake = new List<Point>();
            snake.Add(new Point(5, 5)); // Голова
            snake.Add(new Point(4, 5)); // Тело
            snake.Add(new Point(3, 5)); // Хвост

            // Создаем первую еду
            GenerateFood();

            // Сбрасываем счет и направление
            score = 0;
            direction = "right";
            isGameRunning = false;

            // Обновляем статистику
            UpdateStats();

            // Настраиваем таймер
            timer1.Interval = 200; // Скорость игры (мс)
            timer1.Tick += Timer1_Tick;

            // Настраиваем отрисовку
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void GenerateFood()
        {
            // Создаем еду в случайном месте
            food = new Point(
                random.Next(0, widthInCells),
                random.Next(0, heightInCells)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isGameRunning)
            {
                isGameRunning = true;
                timer1.Start();
                pictureBox1.Focus(); // Фокус для обработки клавиш
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isGameRunning)
            {
                isGameRunning = false;
                timer1.Stop();
                button2.Text = "Продолжить";
            }
            else
            {
                isGameRunning = true;
                timer1.Start();
                button2.Text = "Пауза";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            InitializeGame();
            isGameRunning = true;
            timer1.Start();
            button2.Text = "Пауза";
            pictureBox1.Focus();
        }

        private void UpdateStats()
        {
            textBox1.Text = score.ToString();
            textBox2.Text = (200 - timer1.Interval).ToString();
            textBox3.Text = "Управление:\nСтрелки - движение\nПробел - пауза\nR - рестарт";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!isGameRunning) return;

            // Двигаем змейку
            MoveSnake();

            // Проверяем, съела ли змейка еду
            if (snake[0] == food)
            {
                score += 10;
                // Увеличиваем змейку
                snake.Add(new Point(-1, -1)); // Временная точка
                GenerateFood();
            }

            // Перерисовываем поле
            pictureBox1.Invalidate();
            UpdateStats();
        }

        private void MoveSnake()
        {
            // Сохраняем старые позиции (двигаем тело)
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            // Двигаем голову в нужном направлении
            Point head = snake[0];
            switch (direction)
            {
                case "up":
                    head.Y--;
                    break;
                case "down":
                    head.Y++;
                    break;
                case "left":
                    head.X--;
                    break;
                case "right":
                    head.X++;
                    break;
            }
            snake[0] = head;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Очищаем поле
            g.Clear(Color.LightGray);

            // Рисуем змейку
            foreach (Point segment in snake)
            {
                g.FillRectangle(Brushes.Green,
                              segment.X * gridSize,
                              segment.Y * gridSize,
                              gridSize, gridSize);
            }

            // Рисуем голову другим цветом
            if (snake.Count > 0)
            {
                g.FillRectangle(Brushes.DarkGreen,
                              snake[0].X * gridSize,
                              snake[0].Y * gridSize,
                              gridSize, gridSize);
            }

            // Рисуем еду
            g.FillEllipse(Brushes.Red,
                         food.X * gridSize,
                         food.Y * gridSize,
                         gridSize, gridSize);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (isGameRunning)
            {
                switch (keyData)
                {
                    case Keys.Up:
                        if (direction != "down") direction = "up";
                        return true;
                    case Keys.Down:
                        if (direction != "up") direction = "down";
                        return true;
                    case Keys.Left:
                        if (direction != "right") direction = "left";
                        return true;
                    case Keys.Right:
                        if (direction != "left") direction = "right";
                        return true;
                    case Keys.Space:
                        button2_Click(null, EventArgs.Empty); // Пауза
                        return true;
                    case Keys.R:
                        button3_Click(null, EventArgs.Empty); // Рестарт
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SnakeGameForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }
    }
}
