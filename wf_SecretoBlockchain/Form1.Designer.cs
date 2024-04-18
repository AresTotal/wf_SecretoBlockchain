namespace wf_SecretoBlockchain
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            ClientsLogs = new ListBox();
            Logs = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 2;
            label1.Text = "Хост:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 43);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 4;
            label2.Text = "Порт:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 72);
            button1.Name = "button1";
            button1.Size = new Size(216, 32);
            button1.TabIndex = 5;
            button1.Text = "Подключение";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ClientsLogs
            // 
            ClientsLogs.FormattingEnabled = true;
            ClientsLogs.ItemHeight = 15;
            ClientsLogs.Location = new Point(12, 110);
            ClientsLogs.Name = "ClientsLogs";
            ClientsLogs.Size = new Size(216, 319);
            ClientsLogs.TabIndex = 6;
            // 
            // Logs
            // 
            Logs.FormattingEnabled = true;
            Logs.ItemHeight = 15;
            Logs.Location = new Point(234, 20);
            Logs.Name = "Logs";
            Logs.Size = new Size(554, 409);
            Logs.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(Logs);
            Controls.Add(ClientsLogs);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Сервер-Хост";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private ListBox ClientsLogs;
        private ListBox Logs;
    }
}
