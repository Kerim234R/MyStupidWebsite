namespace RaschetZP
{
    partial class DataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox_find = new TextBox();
            button7 = new Button();
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            comboBox3 = new ComboBox();
            label20 = new Label();
            groupBox3 = new GroupBox();
            label17 = new Label();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label16 = new Label();
            numericUpDown3 = new NumericUpDown();
            label15 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label19 = new Label();
            label18 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1858, 321);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 40;
            // 
            // Column2
            // 
            Column2.HeaderText = "ФИО";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 320;
            // 
            // Column3
            // 
            Column3.HeaderText = "Должность";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 145;
            // 
            // Column4
            // 
            Column4.HeaderText = "Вид занятости";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 145;
            // 
            // Column5
            // 
            Column5.HeaderText = "Оклад";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Должность по совместительству";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 145;
            // 
            // Column7
            // 
            Column7.HeaderText = "Оклад по совместительству";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 140;
            // 
            // Column8
            // 
            Column8.HeaderText = "Доплата по совмещению";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "Надбавка за стаж";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Надбавка за квалификацию";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Надбавка за вредность условий труда";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Количество детей";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // Column13
            // 
            Column13.HeaderText = "Детей с инвалидностью";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 125;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 190);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_find);
            groupBox1.Controls.Add(button7);
            groupBox1.Location = new Point(317, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 99);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // textBox_find
            // 
            textBox_find.Location = new Point(33, 26);
            textBox_find.Name = "textBox_find";
            textBox_find.Size = new Size(176, 27);
            textBox_find.TabIndex = 7;
            // 
            // button7
            // 
            button7.Location = new Point(33, 59);
            button7.Name = "button7";
            button7.Size = new Size(176, 29);
            button7.TabIndex = 6;
            button7.Text = "Найти строку";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 166);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Кнопки";
            // 
            // button6
            // 
            button6.Location = new Point(157, 49);
            button6.Name = "button6";
            button6.Size = new Size(137, 29);
            button6.TabIndex = 5;
            button6.Text = "Загрузить БД";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(157, 18);
            button5.Name = "button5";
            button5.Size = new Size(137, 29);
            button5.TabIndex = 4;
            button5.Text = "Сохранить БД";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 82);
            button4.Name = "button4";
            button4.Size = new Size(137, 29);
            button4.TabIndex = 3;
            button4.Text = "Очистить поля";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 116);
            button3.Name = "button3";
            button3.Size = new Size(137, 29);
            button3.TabIndex = 2;
            button3.Text = "Удалить всё";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 50);
            button2.Name = "button2";
            button2.Size = new Size(137, 29);
            button2.TabIndex = 1;
            button2.Text = "Удалить строку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 18);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 0;
            button1.Text = "Добавить строку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(607, 372);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 190);
            panel2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(370, 117);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(333, 28);
            comboBox3.TabIndex = 36;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(15, 120);
            label20.Name = "label20";
            label20.Size = new Size(235, 20);
            label20.TabIndex = 35;
            label20.Text = "Должность по совместительству";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(numericUpDown5);
            groupBox3.Controls.Add(numericUpDown4);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(numericUpDown3);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(758, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 130);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Надбавки";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(178, 30);
            label17.Name = "label17";
            label17.Size = new Size(21, 20);
            label17.TabIndex = 33;
            label17.Text = "%";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(133, 85);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(39, 27);
            numericUpDown5.TabIndex = 30;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(133, 53);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(39, 27);
            numericUpDown4.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(178, 92);
            label16.Name = "label16";
            label16.Size = new Size(21, 20);
            label16.TabIndex = 32;
            label16.Text = "%";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(133, 23);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(39, 27);
            numericUpDown3.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(178, 60);
            label15.Name = "label15";
            label15.Size = new Size(21, 20);
            label15.TabIndex = 31;
            label15.Text = "%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 23);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 22;
            label11.Text = "Стаж";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 55);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 24;
            label10.Text = "Квалификация";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 87);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 27;
            label9.Text = "Вредность";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Location = new Point(1014, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 133);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Информация о детях";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(187, 60);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(39, 27);
            numericUpDown2.TabIndex = 26;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(187, 30);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(39, 27);
            numericUpDown1.TabIndex = 25;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 60);
            label19.Name = "label19";
            label19.Size = new Size(175, 20);
            label19.TabIndex = 24;
            label19.Text = "Детей с инвалидностью";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 32);
            label18.Name = "label18";
            label18.Size = new Size(133, 20);
            label18.TabIndex = 23;
            label18.Text = "Количество детей";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(709, 92);
            label14.Name = "label14";
            label14.Size = new Size(21, 20);
            label14.TabIndex = 30;
            label14.Text = "%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(709, 58);
            label13.Name = "label13";
            label13.Size = new Size(34, 20);
            label13.TabIndex = 29;
            label13.Text = "руб";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(709, 22);
            label12.Name = "label12";
            label12.Size = new Size(34, 20);
            label12.TabIndex = 28;
            label12.Text = "руб";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 86);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 21;
            label8.Text = "Доплата";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(576, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 27);
            textBox4.TabIndex = 20;
            textBox4.KeyPress += numbercheck;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(576, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 27);
            textBox3.TabIndex = 19;
            textBox3.KeyPress += numbercheck;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 51);
            label7.Name = "label7";
            label7.Size = new Size(200, 20);
            label7.TabIndex = 18;
            label7.Text = "Оклад по совместительству";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(576, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 27);
            textBox2.TabIndex = 17;
            textBox2.KeyPress += numbercheck;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(370, 18);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 16;
            label6.Text = "Оклад";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Основная работа", "Совместительство", "Совмещение" });
            comboBox2.Location = new Point(129, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 28);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Основная работа";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 86);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 14;
            label5.Text = "Вид занятости";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 51);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 12;
            label4.Text = "Должность";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 11;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 18);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "ФИО";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 166);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 9;
            label2.Text = "Поля для заполнения";
            // 
            // DataBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 574);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DataBase";
            Text = "База данных сотрудников";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Label label1;
        private TextBox textBox_find;
        private Button button7;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private Label label12;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label19;
        private Label label18;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private Label label17;
        private ComboBox comboBox3;
        private Label label20;
    }
}