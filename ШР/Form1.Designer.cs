namespace ШР
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            heigth = new NumericUpDown();
            width = new NumericUpDown();
            depth = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)heigth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depth).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Высота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 62);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Ширина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 92);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Глубина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 121);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Форма крыши";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 151);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 4;
            label5.Text = "Форма вент.\r\nотверстии в крыше";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 202);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 5;
            label6.Text = "Исполнение дна";
            // 
            // heigth
            // 
            heigth.Location = new Point(127, 28);
            heigth.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            heigth.Minimum = new decimal(new int[] { 800, 0, 0, 0 });
            heigth.Name = "heigth";
            heigth.Size = new Size(120, 23);
            heigth.TabIndex = 6;
            heigth.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // width
            // 
            width.Location = new Point(127, 57);
            width.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            width.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            width.Name = "width";
            width.Size = new Size(120, 23);
            width.TabIndex = 7;
            width.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // depth
            // 
            depth.Location = new Point(127, 89);
            depth.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            depth.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            depth.Name = "depth";
            depth.Size = new Size(120, 23);
            depth.TabIndex = 8;
            depth.Value = new decimal(new int[] { 200, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "односкатная", "двухскатная" });
            comboBox1.Location = new Point(147, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "большие прорез.", "маленькие прорез." });
            comboBox2.Location = new Point(147, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "с цоколем", "без цоколя" });
            comboBox3.Location = new Point(147, 199);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(107, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 295);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(depth);
            Controls.Add(width);
            Controls.Add(heigth);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)heigth).EndInit();
            ((System.ComponentModel.ISupportInitialize)width).EndInit();
            ((System.ComponentModel.ISupportInitialize)depth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown heigth;
        private NumericUpDown width;
        private NumericUpDown depth;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
    }
}