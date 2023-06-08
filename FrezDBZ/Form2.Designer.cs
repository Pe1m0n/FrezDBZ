namespace FrezDBZ
{
    partial class Form2
    {

        public bool cancalkCv = false;

        public double Kv;
        public double Kmv;
        public double Kpv;
        public double Kuv;
        public double Ktu;
        public double Ktc;
        public double Kfv;
        public double Kr;
        public double Kov;
        public double nv;
        public double Kmp;
        public double Cv;
        public double x;
        public double y;
        public double m;
        public double T;


        public double Vp;

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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox4 = new ComboBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            comboBox5 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(234, 15);
            label1.TabIndex = 0;
            label1.Text = "Материал обрабатываемой поверхности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Материал резца";
            // 
            // button1
            // 
            button1.Location = new Point(379, 742);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 4;
            button1.Text = "Расчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Сталь угреродистая C<0,6%", "Сталь угреродистая C>0,6%", "Сталь хромоникелевая, хромомолибденованадиевая", "Сталь хромомарганцовистая, хромокремнистая, хромокремнемарганцовистая, хромоникельмолибденовая, хромомолибденоалюминиевая", "Сталь хромованадиевая", "Сталь марганцовистая", "Сталь хромоникельвольфрамовая, хромомолибденовая", "Сталь хромоалюминиевая", "Сталь хромоникельванадиевая", "Быстрорежущие стали", "Медные гетерогенные сплавы", "Медные свинцовистые сплавы при основной гетерогенной структуре", "Медные гомогенные сплавы", "Медные сплавы с сожержание свинца < 10% при основной гомогенной структуре", "Медь", "Медные сплавы с содержание свинца > 15%", "Силумин", "Дюралюминий", "Серый чугун", "Ковкий чугун" });
            comboBox1.Location = new Point(27, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Т5К10", "Т5К12В", "Т14К8", "Т15К6", "Т30К4", "ВК8", "ВК6", "ВК4", "ВК3", "ВК2", "Р18", "Р6М5", "9ХС", "У12А", "ХВГ" });
            comboBox2.Location = new Point(28, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(233, 23);
            comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 26);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 7;
            label3.Text = "Прочность стали/чугуна";
            label3.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "0";
            textBox1.Visible = false;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 10;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.Location = new Point(26, 130);
            label4.Name = "label4";
            label4.Size = new Size(203, 35);
            label4.TabIndex = 9;
            label4.Text = "Число одновременно работающих интсруметов";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 12;
            textBox3.KeyPress += textBox1_KeyPress;
            // 
            // label5
            // 
            label5.Location = new Point(265, 130);
            label5.Name = "label5";
            label5.Size = new Size(232, 30);
            label5.TabIndex = 11;
            label5.Text = "Число одновремменно обслуживаемых станков";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(265, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 23);
            textBox4.TabIndex = 16;
            textBox4.KeyPress += textBox2_KeyPress;
            // 
            // label6
            // 
            label6.Location = new Point(265, 205);
            label6.Name = "label6";
            label6.Size = new Size(194, 17);
            label6.TabIndex = 15;
            label6.Text = "Получаемый размер d";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(25, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 23);
            textBox5.TabIndex = 14;
            textBox5.KeyPress += textBox2_KeyPress;
            // 
            // label7
            // 
            label7.Location = new Point(26, 205);
            label7.Name = "label7";
            label7.Size = new Size(193, 17);
            label7.TabIndex = 13;
            label7.Text = "Начальный диаметр обработки D";
            // 
            // comboBox3
            // 
            comboBox3.AllowDrop = true;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Наружное продольное точение", "Подрезание", "Отрезание", "Фасонное точение" });
            comboBox3.Location = new Point(26, 278);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(234, 23);
            comboBox3.TabIndex = 18;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 260);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 17;
            label8.Text = "Вид обработки";
            // 
            // comboBox4
            // 
            comboBox4.AllowDrop = true;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "20", "30", "45", "60", "75", "90" });
            comboBox4.Location = new Point(263, 278);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(234, 23);
            comboBox4.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 260);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 19;
            label9.Text = "Главный угол в плане";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(25, 344);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(233, 23);
            textBox6.TabIndex = 22;
            textBox6.KeyPress += textBox2_KeyPress;
            // 
            // label10
            // 
            label10.Location = new Point(25, 326);
            label10.Name = "label10";
            label10.Size = new Size(203, 15);
            label10.TabIndex = 21;
            label10.Text = "Подача (S)";
            // 
            // comboBox5
            // 
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.Enabled = false;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Без напаек", "С напайками" });
            comboBox5.Location = new Point(263, 344);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(236, 23);
            comboBox5.TabIndex = 23;
            // 
            // label11
            // 
            label11.Location = new Point(263, 326);
            label11.Name = "label11";
            label11.Size = new Size(203, 15);
            label11.TabIndex = 24;
            label11.Text = "Тип Резца";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 394);
            label12.Name = "label12";
            label12.Size = new Size(145, 15);
            label12.TabIndex = 25;
            label12.Text = "Скорость резания (Vp) = ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveBorder;
            label13.Location = new Point(169, 394);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 26;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 857);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(comboBox5);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(comboBox4);
            Controls.Add(label9);
            Controls.Add(comboBox3);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Расчет режимов резания";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion





        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox4;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private ComboBox comboBox5;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}