namespace OP_Laboratornaya8
{
    partial class Task3Window
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
            this.BackToMenu = new System.Windows.Forms.Button();
            this.VvodIndexaButton = new System.Windows.Forms.Button();
            this.VvodIndexString = new System.Windows.Forms.TextBox();
            this.VvodIndexa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reshenieZadaniya = new System.Windows.Forms.TextBox();
            this.Klonbutton = new System.Windows.Forms.Button();
            this.Sortbutton = new System.Windows.Forms.Button();
            this.MaxCoordButton = new System.Windows.Forms.Button();
            this.MinCoordbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VuvodVectora = new System.Windows.Forms.TextBox();
            this.VvodVectora = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVector = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.BackToMenu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.BackToMenu.Location = new System.Drawing.Point(524, 624);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(130, 70);
            this.BackToMenu.TabIndex = 2;
            this.BackToMenu.Text = "Вернуться в меню";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // VvodIndexaButton
            // 
            this.VvodIndexaButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VvodIndexaButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodIndexaButton.Location = new System.Drawing.Point(880, 399);
            this.VvodIndexaButton.Name = "VvodIndexaButton";
            this.VvodIndexaButton.Size = new System.Drawing.Size(47, 38);
            this.VvodIndexaButton.TabIndex = 40;
            this.VvodIndexaButton.Text = "✓";
            this.VvodIndexaButton.UseVisualStyleBackColor = false;
            this.VvodIndexaButton.Visible = false;
            this.VvodIndexaButton.Click += new System.EventHandler(this.VvodIndexaButton_Click);
            // 
            // VvodIndexString
            // 
            this.VvodIndexString.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodIndexString.Location = new System.Drawing.Point(836, 403);
            this.VvodIndexString.Name = "VvodIndexString";
            this.VvodIndexString.Size = new System.Drawing.Size(38, 32);
            this.VvodIndexString.TabIndex = 39;
            this.VvodIndexString.Visible = false;
            this.VvodIndexString.TextChanged += new System.EventHandler(this.VvodIndexString_TextChanged);
            // 
            // VvodIndexa
            // 
            this.VvodIndexa.AutoSize = true;
            this.VvodIndexa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodIndexa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.VvodIndexa.Location = new System.Drawing.Point(633, 401);
            this.VvodIndexa.Name = "VvodIndexa";
            this.VvodIndexa.Size = new System.Drawing.Size(197, 29);
            this.VvodIndexa.TabIndex = 38;
            this.VvodIndexa.Text = "Введите индекс:";
            this.VvodIndexa.Visible = false;
            this.VvodIndexa.Click += new System.EventHandler(this.VvodIndexa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label5.Location = new System.Drawing.Point(611, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Решение задания:";
            // 
            // reshenieZadaniya
            // 
            this.reshenieZadaniya.Enabled = false;
            this.reshenieZadaniya.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reshenieZadaniya.Location = new System.Drawing.Point(836, 452);
            this.reshenieZadaniya.Multiline = true;
            this.reshenieZadaniya.Name = "reshenieZadaniya";
            this.reshenieZadaniya.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.reshenieZadaniya.Size = new System.Drawing.Size(296, 197);
            this.reshenieZadaniya.TabIndex = 36;
            this.reshenieZadaniya.WordWrap = false;
            this.reshenieZadaniya.TextChanged += new System.EventHandler(this.reshenieZadaniya_TextChanged);
            // 
            // Klonbutton
            // 
            this.Klonbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.Klonbutton.Enabled = false;
            this.Klonbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Klonbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.Klonbutton.Location = new System.Drawing.Point(27, 608);
            this.Klonbutton.Name = "Klonbutton";
            this.Klonbutton.Size = new System.Drawing.Size(296, 68);
            this.Klonbutton.TabIndex = 35;
            this.Klonbutton.Text = "Клонирование";
            this.Klonbutton.UseVisualStyleBackColor = false;
            this.Klonbutton.Click += new System.EventHandler(this.Klonbutton_Click);
            // 
            // Sortbutton
            // 
            this.Sortbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.Sortbutton.Enabled = false;
            this.Sortbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sortbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.Sortbutton.Location = new System.Drawing.Point(27, 532);
            this.Sortbutton.Name = "Sortbutton";
            this.Sortbutton.Size = new System.Drawing.Size(296, 70);
            this.Sortbutton.TabIndex = 34;
            this.Sortbutton.Text = "Сортировка по возрастанию модуля";
            this.Sortbutton.UseVisualStyleBackColor = false;
            this.Sortbutton.Click += new System.EventHandler(this.Sortbutton_Click);
            // 
            // MaxCoordButton
            // 
            this.MaxCoordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.MaxCoordButton.Enabled = false;
            this.MaxCoordButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxCoordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.MaxCoordButton.Location = new System.Drawing.Point(27, 456);
            this.MaxCoordButton.Name = "MaxCoordButton";
            this.MaxCoordButton.Size = new System.Drawing.Size(296, 70);
            this.MaxCoordButton.TabIndex = 33;
            this.MaxCoordButton.Text = "Вектор с максимальным числом координат";
            this.MaxCoordButton.UseVisualStyleBackColor = false;
            this.MaxCoordButton.Click += new System.EventHandler(this.MaxCoordButton_Click);
            // 
            // MinCoordbutton
            // 
            this.MinCoordbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.MinCoordbutton.Enabled = false;
            this.MinCoordbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinCoordbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.MinCoordbutton.Location = new System.Drawing.Point(27, 382);
            this.MinCoordbutton.Name = "MinCoordbutton";
            this.MinCoordbutton.Size = new System.Drawing.Size(296, 68);
            this.MinCoordbutton.TabIndex = 32;
            this.MinCoordbutton.Text = "Вектор с минимальным числом координат";
            this.MinCoordbutton.UseVisualStyleBackColor = false;
            this.MinCoordbutton.Click += new System.EventHandler(this.MinCoordbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label4.Location = new System.Drawing.Point(62, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Выберете задание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(842, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = " Введенный вектор:";
            // 
            // VuvodVectora
            // 
            this.VuvodVectora.Enabled = false;
            this.VuvodVectora.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VuvodVectora.Location = new System.Drawing.Point(836, 170);
            this.VuvodVectora.Multiline = true;
            this.VuvodVectora.Name = "VuvodVectora";
            this.VuvodVectora.Size = new System.Drawing.Size(296, 138);
            this.VuvodVectora.TabIndex = 29;
            this.VuvodVectora.UseWaitCursor = true;
            this.VuvodVectora.WordWrap = false;
            this.VuvodVectora.TextChanged += new System.EventHandler(this.VuvodVectora_TextChanged);
            // 
            // VvodVectora
            // 
            this.VvodVectora.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VvodVectora.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodVectora.Location = new System.Drawing.Point(350, 170);
            this.VvodVectora.Name = "VvodVectora";
            this.VvodVectora.Size = new System.Drawing.Size(47, 38);
            this.VvodVectora.TabIndex = 28;
            this.VvodVectora.Text = "✓";
            this.VvodVectora.UseVisualStyleBackColor = false;
            this.VvodVectora.Click += new System.EventHandler(this.VvodVectora_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введите массив векторов:";
            // 
            // textBoxVector
            // 
            this.textBoxVector.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVector.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxVector.Location = new System.Drawing.Point(27, 170);
            this.textBoxVector.Multiline = true;
            this.textBoxVector.Name = "textBoxVector";
            this.textBoxVector.Size = new System.Drawing.Size(296, 138);
            this.textBoxVector.TabIndex = 26;
            this.textBoxVector.Text = "Введите числа через пробел  Каждый вектор пишите с новой строки";
            this.textBoxVector.Click += new System.EventHandler(this.textBoxVector_Click);
            this.textBoxVector.TextChanged += new System.EventHandler(this.textBoxVector_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 109);
            this.panel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.label6.Location = new System.Drawing.Point(436, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "Задания лабораторной 5";
            // 
            // Task3Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1178, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VvodIndexaButton);
            this.Controls.Add(this.VvodIndexString);
            this.Controls.Add(this.VvodIndexa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reshenieZadaniya);
            this.Controls.Add(this.Klonbutton);
            this.Controls.Add(this.Sortbutton);
            this.Controls.Add(this.MaxCoordButton);
            this.Controls.Add(this.MinCoordbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VuvodVectora);
            this.Controls.Add(this.VvodVectora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVector);
            this.Controls.Add(this.BackToMenu);
            this.Name = "Task3Window";
            this.Text = "Задания лабораторной 5 Window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Button VvodIndexaButton;
        private System.Windows.Forms.TextBox VvodIndexString;
        private System.Windows.Forms.Label VvodIndexa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reshenieZadaniya;
        private System.Windows.Forms.Button Klonbutton;
        private System.Windows.Forms.Button Sortbutton;
        private System.Windows.Forms.Button MaxCoordButton;
        private System.Windows.Forms.Button MinCoordbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VuvodVectora;
        private System.Windows.Forms.Button VvodVectora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}