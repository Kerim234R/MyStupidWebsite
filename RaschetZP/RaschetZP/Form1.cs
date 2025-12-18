namespace RaschetZP
{
    public partial class Form1 : Form
    {
        public Form1()
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
            menu.ApplyThemeToMenu();
        }



        //Кнопки на экране
        private void button1_Click(object sender, EventArgs e)
        {
            Calczp calcczpform = new Calczp();
            calcczpform.Show();
            ThemeManager.ApplyTheme(calcczpform);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            SnakeGameForm snake = new SnakeGameForm();
            snake.Show();
            ThemeManager.ApplyTheme(snake);

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
