
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Отправлены = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.info1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// Отправлены
			// 
			this.Отправлены.Location = new System.Drawing.Point(22, 134);
			this.Отправлены.Name = "Отправлены";
			this.Отправлены.Size = new System.Drawing.Size(153, 46);
			this.Отправлены.TabIndex = 0;
			this.Отправлены.Text = "Записать данные";
			this.Отправлены.UseVisualStyleBackColor = true;
			this.Отправлены.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(46, 91);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(116, 20);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(408, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 19);
			this.label1.TabIndex = 8;
			this.label1.Text = "Закончился тонер";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Label2.Location = new System.Drawing.Point(408, 253);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(107, 19);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "Заправленные";
			this.Label2.Click += new System.EventHandler(this.Заправленные_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Картридж";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(68, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Фамилия";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// info1
			// 
			this.info1.Location = new System.Drawing.Point(15, 169);
			this.info1.Name = "info1";
			this.info1.Size = new System.Drawing.Size(166, 42);
			this.info1.TabIndex = 17;
			this.info1.Text = "вывод заправленных";
			this.info1.UseVisualStyleBackColor = true;
			this.info1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Вывод заправленных";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(255, 275);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(439, 220);
			this.dataGridView1.TabIndex = 22;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowDrop = true;
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(255, 31);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(439, 209);
			this.dataGridView2.TabIndex = 23;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(725, 192);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 48);
			this.button1.TabIndex = 24;
			this.button1.Text = "перевести в заправленные";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// dataGridView4
			// 
			this.dataGridView4.AllowUserToAddRows = false;
			this.dataGridView4.AllowUserToDeleteRows = false;
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Location = new System.Drawing.Point(296, 301);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(471, 219);
			this.dataGridView4.TabIndex = 27;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(413, 279);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(161, 19);
			this.label7.TabIndex = 28;
			this.label7.Text = "отданная оргх техника";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(498, 697);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(160, 41);
			this.button3.TabIndex = 30;
			this.button3.Text = "Технику вернули";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 158);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 43);
			this.button2.TabIndex = 29;
			this.button2.Text = "отдать технику";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_3);
			// 
			// textBox3
			// 
			this.textBox3.AccessibleName = "";
			this.textBox3.Location = new System.Drawing.Point(21, 22);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 31;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBox5);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Location = new System.Drawing.Point(31, 301);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(210, 219);
			this.panel1.TabIndex = 32;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(53, 96);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(111, 13);
			this.label9.TabIndex = 36;
			this.label9.Text = "Инвентарный номер";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(78, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "Фамилия";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(78, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = "техника";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(22, 112);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(159, 20);
			this.textBox5.TabIndex = 33;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(22, 66);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(159, 20);
			this.textBox4.TabIndex = 32;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox8);
			this.panel2.Controls.Add(this.textBox7);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.Отправлены);
			this.panel2.Location = new System.Drawing.Point(20, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(210, 209);
			this.panel2.TabIndex = 33;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(22, 101);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(153, 20);
			this.textBox8.TabIndex = 16;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(22, 33);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(153, 20);
			this.textBox7.TabIndex = 15;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dateTimePicker2);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.info1);
			this.panel3.Controls.Add(this.dateTimePicker1);
			this.panel3.Location = new System.Drawing.Point(20, 276);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(210, 220);
			this.panel3.TabIndex = 34;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(45, 130);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(117, 20);
			this.dateTimePicker2.TabIndex = 37;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(87, 114);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(37, 13);
			this.label11.TabIndex = 35;
			this.label11.Text = "конец";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(78, 59);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 35;
			this.label10.Text = "Начало";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(725, 346);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(160, 41);
			this.button4.TabIndex = 35;
			this.button4.Text = "Вывод данных";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(725, 45);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(160, 39);
			this.button5.TabIndex = 36;
			this.button5.Text = "Удаление";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(2, -2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(983, 613);
			this.tabControl1.TabIndex = 37;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button7);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.button5);
			this.tabPage1.Controls.Add(this.Label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dataGridView2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(975, 587);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "запись картриджей";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(725, 120);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(160, 43);
			this.button7.TabIndex = 37;
			this.button7.Text = "отправить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button9);
			this.tabPage2.Controls.Add(this.button8);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.textBox9);
			this.tabPage2.Controls.Add(this.panel4);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Controls.Add(this.dataGridView4);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.dataGridView3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(975, 587);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "База и основа записей";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(825, 36);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(107, 34);
			this.button9.TabIndex = 36;
			this.button9.Text = "Удаление из запасов";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(825, 135);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(107, 36);
			this.button8.TabIndex = 35;
			this.button8.Text = "изменить данные картриджа";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(772, 93);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(207, 13);
			this.label16.TabIndex = 34;
			this.label16.Text = "увеличение и уменьшение картриджей ";
			this.label16.Click += new System.EventHandler(this.label16_Click);
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(854, 109);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(24, 20);
			this.textBox9.TabIndex = 33;
			this.textBox9.Text = "+/-";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.textBox6);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.textBox2);
			this.panel4.Location = new System.Drawing.Point(31, 36);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(206, 204);
			this.panel4.TabIndex = 8;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(27, 141);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(137, 49);
			this.button6.TabIndex = 9;
			this.button6.Text = "запись в базу картриджей";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(28, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(137, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(28, 115);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(137, 20);
			this.textBox6.TabIndex = 4;
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(69, 99);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(65, 13);
			this.label15.TabIndex = 7;
			this.label15.Text = "количество";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(38, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(109, 13);
			this.label13.TabIndex = 5;
			this.label13.Text = "инвентарный номер";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(69, 60);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 13);
			this.label14.TabIndex = 6;
			this.label14.Text = "картридж";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(28, 76);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(137, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(358, 20);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(238, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "количество картриджей находиться в запасе";
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(287, 36);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(471, 208);
			this.dataGridView3.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 609);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Cartridge and Tech";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Отправлены;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button info1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

