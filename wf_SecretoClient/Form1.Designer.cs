namespace wf_SecretoClient
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Logs = new ListBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label7 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            dashboard = new Panel();
            button8 = new ReaLTaiizor.Controls.Button();
            label9 = new Label();
            settings = new Panel();
            button1 = new ReaLTaiizor.Controls.Button();
            button2 = new ReaLTaiizor.Controls.Button();
            label8 = new Label();
            about = new Panel();
            richTextBox1 = new RichTextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            dashboard.SuspendLayout();
            settings.SuspendLayout();
            about.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 53);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 8;
            label2.Text = "Порт:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 80);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 6;
            label1.Text = "Хост:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 5;
            // 
            // Logs
            // 
            Logs.FormattingEnabled = true;
            Logs.ItemHeight = 15;
            Logs.Location = new Point(14, 53);
            Logs.Name = "Logs";
            Logs.Size = new Size(447, 244);
            Logs.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 303);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(447, 90);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 276);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(285, 23);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(87, 252);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 15;
            label3.Text = "Публичный ключ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(87, 302);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 16;
            label4.Text = "Приватный ключ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(16, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(285, 23);
            textBox5.TabIndex = 17;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 355);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 23);
            textBox6.TabIndex = 19;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(16, 355);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 18;
            label5.Text = "Nonce";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(105, 151);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 21;
            label6.Text = "Общий ключ";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(16, 175);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(285, 23);
            textBox7.TabIndex = 20;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 42);
            panel1.TabIndex = 23;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(741, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(42, 5);
            label7.Name = "label7";
            label7.Size = new Size(187, 30);
            label7.TabIndex = 1;
            label7.Text = "ДЗОС-1 КЛИЕНТ ";
            // 
            // btnHam
            // 
            btnHam.BackgroundImage = (Image)resources.GetObject("btnHam.BackgroundImage");
            btnHam.BackgroundImageLayout = ImageLayout.Center;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(3, 4);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(33, 33);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button5);
            sidebar.Controls.Add(button6);
            sidebar.Controls.Add(button7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 42);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(53, 633);
            sidebar.TabIndex = 24;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Padding = new Padding(5, 0, 0, 0);
            button4.Size = new Size(241, 48);
            button4.TabIndex = 0;
            button4.Text = "Основное меню";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 57);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 0, 0, 0);
            button5.Size = new Size(241, 48);
            button5.TabIndex = 1;
            button5.Text = "Настройки сети";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 111);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 0, 0, 0);
            button6.Size = new Size(241, 48);
            button6.TabIndex = 26;
            button6.Text = "Справка";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 165);
            button7.Name = "button7";
            button7.Padding = new Padding(5, 0, 0, 0);
            button7.Size = new Size(241, 48);
            button7.TabIndex = 27;
            button7.Text = "Выйти";
            button7.UseVisualStyleBackColor = true;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // dashboard
            // 
            dashboard.BorderStyle = BorderStyle.FixedSingle;
            dashboard.Controls.Add(button8);
            dashboard.Controls.Add(label9);
            dashboard.Controls.Add(Logs);
            dashboard.Controls.Add(textBox3);
            dashboard.Location = new Point(59, 45);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(478, 462);
            dashboard.TabIndex = 25;
            dashboard.Visible = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BorderColor = Color.FromArgb(32, 34, 37);
            button8.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button8.EnteredColor = Color.FromArgb(32, 34, 37);
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button8.Image = null;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.InactiveColor = Color.FromArgb(32, 34, 37);
            button8.Location = new Point(81, 399);
            button8.Name = "button8";
            button8.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button8.PressedColor = Color.FromArgb(165, 37, 37);
            button8.Size = new Size(285, 40);
            button8.TabIndex = 28;
            button8.Text = "Отправить сообщение";
            button8.TextAlignment = StringAlignment.Center;
            button8.Click += button8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(14, 12);
            label9.Name = "label9";
            label9.Size = new Size(325, 21);
            label9.TabIndex = 24;
            label9.Text = "ЗАЩИЩЁННЫЙ ОБМЕН СООБЩЕНИЯМИ";
            // 
            // settings
            // 
            settings.BorderStyle = BorderStyle.FixedSingle;
            settings.Controls.Add(button1);
            settings.Controls.Add(button2);
            settings.Controls.Add(label8);
            settings.Controls.Add(textBox1);
            settings.Controls.Add(label1);
            settings.Controls.Add(textBox2);
            settings.Controls.Add(label2);
            settings.Controls.Add(label6);
            settings.Controls.Add(textBox4);
            settings.Controls.Add(textBox7);
            settings.Controls.Add(label3);
            settings.Controls.Add(textBox6);
            settings.Controls.Add(label4);
            settings.Controls.Add(label5);
            settings.Controls.Add(textBox5);
            settings.Location = new Point(543, 45);
            settings.Name = "settings";
            settings.Size = new Size(327, 390);
            settings.TabIndex = 26;
            settings.Visible = false;
            settings.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(16, 209);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(285, 40);
            button1.TabIndex = 30;
            button1.Text = "Сгенерировать общий ключ";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(32, 34, 37);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(32, 34, 37);
            button2.Location = new Point(16, 108);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(285, 40);
            button2.TabIndex = 29;
            button2.Text = "Подключение к серверу";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += button2_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(16, 12);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 23;
            label8.Text = "НАСТРОЙКИ СЕТИ";
            // 
            // about
            // 
            about.BorderStyle = BorderStyle.FixedSingle;
            about.Controls.Add(richTextBox1);
            about.Controls.Add(label10);
            about.Location = new Point(543, 445);
            about.Name = "about";
            about.Size = new Size(327, 194);
            about.TabIndex = 27;
            about.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(17, 39);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 136);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "Проект курсовой работы\nДецентрализованный мессенджер\nСделал Шаймиев Аскар\nГруппа: 21ОИБ-1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(17, 15);
            label10.Name = "label10";
            label10.Size = new Size(238, 21);
            label10.TabIndex = 25;
            label10.Text = "СПРАВОЧНАЯ ИНФОРМАЦИЯ";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(880, 675);
            Controls.Add(about);
            Controls.Add(settings);
            Controls.Add(sidebar);
            Controls.Add(dashboard);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Клиент";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            dashboard.ResumeLayout(false);
            dashboard.PerformLayout();
            settings.ResumeLayout(false);
            settings.PerformLayout();
            about.ResumeLayout(false);
            about.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private ListBox Logs;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Panel panel1;
        private PictureBox btnHam;
        private Label label7;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel dashboard;
        private Panel settings;
        private Label label9;
        private Label label8;
        private Panel about;
        private RichTextBox richTextBox1;
        private Label label10;
        private ReaLTaiizor.Controls.Button button8;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
    }
}
