namespace RaschetZP
{
    partial class TodoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoForm));
            button_taskadd = new Button();
            checkedListBox1 = new CheckedListBox();
            button1_save = new Button();
            button2_deleteall = new Button();
            button1_load = new Button();
            SuspendLayout();
            // 
            // button_taskadd
            // 
            button_taskadd.BackColor = SystemColors.ActiveCaption;
            button_taskadd.Location = new Point(12, 12);
            button_taskadd.Name = "button_taskadd";
            button_taskadd.Size = new Size(363, 42);
            button_taskadd.TabIndex = 0;
            button_taskadd.Text = "Добавить задачу";
            button_taskadd.UseVisualStyleBackColor = false;
            button_taskadd.Click += Button_taskadd_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 60);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(363, 224);
            checkedListBox1.TabIndex = 1;
            // 
            // button1_save
            // 
            button1_save.BackColor = SystemColors.ActiveCaption;
            button1_save.Location = new Point(12, 290);
            button1_save.Name = "button1_save";
            button1_save.Size = new Size(102, 29);
            button1_save.TabIndex = 2;
            button1_save.Text = "Сохранить";
            button1_save.UseVisualStyleBackColor = false;
            button1_save.Click += Button1_save_Click;
            // 
            // button2_deleteall
            // 
            button2_deleteall.BackColor = SystemColors.ActiveCaption;
            button2_deleteall.Location = new Point(232, 290);
            button2_deleteall.Name = "button2_deleteall";
            button2_deleteall.Size = new Size(143, 29);
            button2_deleteall.TabIndex = 3;
            button2_deleteall.Text = "Удалить задачи";
            button2_deleteall.UseVisualStyleBackColor = false;
            button2_deleteall.Click += button2_deleteall_Click;
            // 
            // button1_load
            // 
            button1_load.BackColor = SystemColors.ActiveCaption;
            button1_load.Location = new Point(120, 290);
            button1_load.Name = "button1_load";
            button1_load.Size = new Size(102, 29);
            button1_load.TabIndex = 4;
            button1_load.Text = "Загрузить";
            button1_load.UseVisualStyleBackColor = false;
            button1_load.Click += Button1_load_Click;
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 323);
            Controls.Add(button1_load);
            Controls.Add(button2_deleteall);
            Controls.Add(button1_save);
            Controls.Add(checkedListBox1);
            Controls.Add(button_taskadd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(405, 550);
            MinimumSize = new Size(405, 370);
            Name = "TodoForm";
            Text = "Список задач";
            ResumeLayout(false);
        }

        #endregion

        private Button button_taskadd;
        private CheckedListBox checkedListBox1;
        // Элементы создающиеся при нажатии
        private TextBox textBox_newtask;
        private Button button_delete;
        private Button button_clearcompleted;
        private Button button1_save;
        private Button button2_deleteall;
        private Button button1_load;
    }
}