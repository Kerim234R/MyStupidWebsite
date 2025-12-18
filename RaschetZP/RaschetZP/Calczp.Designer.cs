namespace RaschetZP
{
    partial class Calczp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calczp));
            panel1 = new Panel();
            textBox4_prem = new TextBox();
            label4 = new Label();
            textBox3_alldayswork = new TextBox();
            label3 = new Label();
            textBox2_workeddays = new TextBox();
            label2 = new Label();
            textBox1_oklad = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            panel3 = new Panel();
            textBox5_children = new TextBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            label10 = new Label();
            textBox1_zp = new TextBox();
            label9 = new Label();
            button2 = new Button();
            panel5 = new Panel();
            textBox_details = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox4_prem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3_alldayswork);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2_workeddays);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1_oklad);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 92);
            panel1.TabIndex = 2;
            // 
            // textBox4_prem
            // 
            textBox4_prem.Location = new Point(74, 49);
            textBox4_prem.Name = "textBox4_prem";
            textBox4_prem.Size = new Size(150, 27);
            textBox4_prem.TabIndex = 7;
            textBox4_prem.Text = "0";
            textBox4_prem.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 49);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Премия";
            // 
            // textBox3_alldayswork
            // 
            textBox3_alldayswork.Location = new Point(442, 49);
            textBox3_alldayswork.Name = "textBox3_alldayswork";
            textBox3_alldayswork.Size = new Size(37, 27);
            textBox3_alldayswork.TabIndex = 5;
            textBox3_alldayswork.Text = "0";
            textBox3_alldayswork.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 52);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 4;
            label3.Text = "из";
            // 
            // textBox2_workeddays
            // 
            textBox2_workeddays.Location = new Point(348, 49);
            textBox2_workeddays.Name = "textBox2_workeddays";
            textBox2_workeddays.Size = new Size(37, 27);
            textBox2_workeddays.TabIndex = 3;
            textBox2_workeddays.Text = "0";
            textBox2_workeddays.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 10);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Отработано дней";
            // 
            // textBox1_oklad
            // 
            textBox1_oklad.Location = new Point(74, 10);
            textBox1_oklad.Name = "textBox1_oklad";
            textBox1_oklad.Size = new Size(150, 27);
            textBox1_oklad.TabIndex = 1;
            textBox1_oklad.Text = "0";
            textBox1_oklad.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Оклад";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 11);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 8;
            label5.Text = "Северный коэффициент";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 45);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 9;
            label6.Text = "Районный коэффициент";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 87);
            panel2.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Не применяется", "1.1", "1.15", "1.2", "1.25", "1.3" });
            comboBox2.Location = new Point(309, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 28);
            comboBox2.TabIndex = 11;
            comboBox2.Text = "Не применяется";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Не применяется", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7" });
            comboBox1.Location = new Point(309, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 28);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Не применяется";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 39);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 5;
            label8.Text = "Количество детей";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox5_children);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(311, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 72);
            panel3.TabIndex = 6;
            // 
            // textBox5_children
            // 
            textBox5_children.AllowDrop = true;
            textBox5_children.Location = new Point(144, 36);
            textBox5_children.Name = "textBox5_children";
            textBox5_children.Size = new Size(36, 27);
            textBox5_children.TabIndex = 7;
            textBox5_children.Text = "0";
            textBox5_children.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(5, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Наличие детей";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 486);
            label7.Name = "label7";
            label7.Size = new Size(712, 20);
            label7.TabIndex = 7;
            label7.Text = "* Это базовый калькулятор. Для более точных результатов используйте профессиональную версию!";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(565, 41);
            button1.Name = "button1";
            button1.Size = new Size(243, 92);
            button1.TabIndex = 8;
            button1.Text = "Рассчитать заработную плату";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox1_zp);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(565, 353);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 125);
            panel4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(202, 51);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 2;
            label10.Text = "руб";
            // 
            // textBox1_zp
            // 
            textBox1_zp.Location = new Point(7, 48);
            textBox1_zp.Name = "textBox1_zp";
            textBox1_zp.ReadOnly = true;
            textBox1_zp.Size = new Size(189, 27);
            textBox1_zp.TabIndex = 1;
            textBox1_zp.Text = "0";
            textBox1_zp.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 3);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 0;
            label9.Text = "Ваша ЗП составит";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(565, 139);
            button2.Name = "button2";
            button2.Size = new Size(243, 38);
            button2.TabIndex = 10;
            button2.Text = "Очистить поля";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(textBox_details);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(12, 232);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 251);
            panel5.TabIndex = 11;
            // 
            // textBox_details
            // 
            textBox_details.Location = new Point(3, 21);
            textBox_details.Multiline = true;
            textBox_details.Name = "textBox_details";
            textBox_details.ReadOnly = true;
            textBox_details.Size = new Size(283, 223);
            textBox_details.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(91, -2);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 0;
            label11.Text = "Детали расчёта";
            // 
            // Calczp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(820, 515);
            Controls.Add(panel5);
            Controls.Add(button2);
            Controls.Add(panel4);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calczp";
            Text = "Базовый калькулятор";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox textBox3_alldayswork;
        private Label label3;
        private TextBox textBox2_workeddays;
        private Label label2;
        private TextBox textBox1_oklad;
        private Label label1;
        private TextBox textBox4_prem;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label8;
        private Panel panel3;
        private TextBox textBox5_children;
        private CheckBox checkBox1;
        private Label label7;
        private Button button1;
        private Panel panel4;
        private Label label10;
        private TextBox textBox1_zp;
        private Label label9;
        private Button button2;
        private Panel panel5;
        private TextBox textBox_details;
        private Label label11;
    }
}