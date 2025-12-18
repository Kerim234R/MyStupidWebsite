namespace RaschetZP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 99);
            label1.Name = "label1";
            label1.Size = new Size(532, 39);
            label1.TabIndex = 1;
            label1.Text = "Калькулятор Заработной Платы";
            label1.DoubleClick += label1_DoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 2;
            button1.Text = "Калькулятор";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 124);
            button2.Name = "button2";
            button2.Size = new Size(142, 50);
            button2.TabIndex = 3;
            button2.Text = "База Данных";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(12, 180);
            button3.Name = "button3";
            button3.Size = new Size(142, 50);
            button3.TabIndex = 4;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(306, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 244);
            panel1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(12, 68);
            button4.Name = "button4";
            button4.Size = new Size(142, 50);
            button4.TabIndex = 8;
            button4.Text = "Калькулятор (проф)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(495, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 244);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(65, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 244);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(820, 525);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Калькулятор заработной платы";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
