namespace RaschetZP
{
    partial class FormJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJobs));
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(418, 253);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(179, 29);
            button1.TabIndex = 1;
            button1.Text = "Добавить должность";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(12, 306);
            button2.Name = "button2";
            button2.Size = new Size(179, 29);
            button2.TabIndex = 3;
            button2.Text = "Сохранить должности";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 341);
            button3.Name = "button3";
            button3.Size = new Size(179, 29);
            button3.TabIndex = 4;
            button3.Text = "Загрузить должности";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(197, 306);
            button4.Name = "button4";
            button4.Size = new Size(233, 29);
            button4.TabIndex = 5;
            button4.Text = "Очистить текстовое поле";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(197, 341);
            button5.Name = "button5";
            button5.Size = new Size(233, 29);
            button5.TabIndex = 6;
            button5.Text = "Очистить поле должностей";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormJobs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 406);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormJobs";
            Text = "FormJobs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}