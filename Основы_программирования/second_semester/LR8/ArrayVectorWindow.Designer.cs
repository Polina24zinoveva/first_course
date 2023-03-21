namespace OP_Laboratornaya8
{
    partial class ArrayVectorWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VvodVectora = new System.Windows.Forms.Button();
            this.VuvodVectora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VuvodPoIndexbutton = new System.Windows.Forms.Button();
            this.VvodPoIndexbutton = new System.Windows.Forms.Button();
            this.Modulbutton = new System.Windows.Forms.Button();
            this.ChisloCoordbutton = new System.Windows.Forms.Button();
            this.reshenieZadaniya = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VvodIndexa = new System.Windows.Forms.Label();
            this.VvodIndexaButton = new System.Windows.Forms.Button();
            this.VvodIndexString = new System.Windows.Forms.TextBox();
            this.VvodChislaButton = new System.Windows.Forms.Button();
            this.VvodChislaString = new System.Windows.Forms.TextBox();
            this.VvodChislaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.BackToMenu.TabIndex = 1;
            this.BackToMenu.Text = "Вернуться в меню";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(511, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "ArrayVector";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxVector
            // 
            this.textBoxVector.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVector.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxVector.Location = new System.Drawing.Point(222, 154);
            this.textBoxVector.Name = "textBoxVector";
            this.textBoxVector.Size = new System.Drawing.Size(271, 32);
            this.textBoxVector.TabIndex = 3;
            this.textBoxVector.Text = "Введите числа через пробел ";
            this.textBoxVector.Click += new System.EventHandler(this.textBoxVector_Click);
            this.textBoxVector.TextChanged += new System.EventHandler(this.textBoxVector_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(21, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите вектор:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VvodVectora
            // 
            this.VvodVectora.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VvodVectora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodVectora.Location = new System.Drawing.Point(499, 152);
            this.VvodVectora.Name = "VvodVectora";
            this.VvodVectora.Size = new System.Drawing.Size(47, 38);
            this.VvodVectora.TabIndex = 5;
            this.VvodVectora.Text = "✓";
            this.VvodVectora.UseVisualStyleBackColor = false;
            this.VvodVectora.Click += new System.EventHandler(this.VvodVectora_Click);
            // 
            // VuvodVectora
            // 
            this.VuvodVectora.Enabled = false;
            this.VuvodVectora.Font = new System.Drawing.Font("Tahoma", 10F);
            this.VuvodVectora.Location = new System.Drawing.Point(895, 158);
            this.VuvodVectora.Name = "VuvodVectora";
            this.VuvodVectora.Size = new System.Drawing.Size(240, 32);
            this.VuvodVectora.TabIndex = 9;
            this.VuvodVectora.TextChanged += new System.EventHandler(this.VuvodVectora_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(660, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = " Введенный вектор:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label4.Location = new System.Drawing.Point(122, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выберете задание:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VuvodPoIndexbutton
            // 
            this.VuvodPoIndexbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.VuvodPoIndexbutton.Enabled = false;
            this.VuvodPoIndexbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VuvodPoIndexbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.VuvodPoIndexbutton.Location = new System.Drawing.Point(87, 282);
            this.VuvodPoIndexbutton.Name = "VuvodPoIndexbutton";
            this.VuvodPoIndexbutton.Size = new System.Drawing.Size(284, 73);
            this.VuvodPoIndexbutton.TabIndex = 12;
            this.VuvodPoIndexbutton.Text = "Вывести элемент по индексу";
            this.VuvodPoIndexbutton.UseVisualStyleBackColor = false;
            this.VuvodPoIndexbutton.Click += new System.EventHandler(this.VuvodPoIndexbutton_Click);
            // 
            // VvodPoIndexbutton
            // 
            this.VvodPoIndexbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.VvodPoIndexbutton.Enabled = false;
            this.VvodPoIndexbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodPoIndexbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.VvodPoIndexbutton.Location = new System.Drawing.Point(87, 373);
            this.VvodPoIndexbutton.Name = "VvodPoIndexbutton";
            this.VvodPoIndexbutton.Size = new System.Drawing.Size(284, 73);
            this.VvodPoIndexbutton.TabIndex = 13;
            this.VvodPoIndexbutton.Text = "Ввести элемент по индексу";
            this.VvodPoIndexbutton.UseVisualStyleBackColor = false;
            this.VvodPoIndexbutton.Click += new System.EventHandler(this.VvodPoIndexbutton_Click);
            // 
            // Modulbutton
            // 
            this.Modulbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.Modulbutton.Enabled = false;
            this.Modulbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modulbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.Modulbutton.Location = new System.Drawing.Point(87, 462);
            this.Modulbutton.Name = "Modulbutton";
            this.Modulbutton.Size = new System.Drawing.Size(284, 73);
            this.Modulbutton.TabIndex = 14;
            this.Modulbutton.Text = "Узнать модуль вектора";
            this.Modulbutton.UseVisualStyleBackColor = false;
            this.Modulbutton.Click += new System.EventHandler(this.Modulbutton_Click);
            // 
            // ChisloCoordbutton
            // 
            this.ChisloCoordbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.ChisloCoordbutton.Enabled = false;
            this.ChisloCoordbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChisloCoordbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.ChisloCoordbutton.Location = new System.Drawing.Point(87, 553);
            this.ChisloCoordbutton.Name = "ChisloCoordbutton";
            this.ChisloCoordbutton.Size = new System.Drawing.Size(284, 73);
            this.ChisloCoordbutton.TabIndex = 15;
            this.ChisloCoordbutton.Text = "Узнать число координат вектора и его значения";
            this.ChisloCoordbutton.UseVisualStyleBackColor = false;
            this.ChisloCoordbutton.Click += new System.EventHandler(this.ChisloCoordbutton_Click);
            // 
            // reshenieZadaniya
            // 
            this.reshenieZadaniya.BackColor = System.Drawing.SystemColors.Window;
            this.reshenieZadaniya.Enabled = false;
            this.reshenieZadaniya.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reshenieZadaniya.Location = new System.Drawing.Point(871, 429);
            this.reshenieZadaniya.Multiline = true;
            this.reshenieZadaniya.Name = "reshenieZadaniya";
            this.reshenieZadaniya.Size = new System.Drawing.Size(264, 197);
            this.reshenieZadaniya.TabIndex = 16;
            this.reshenieZadaniya.TextChanged += new System.EventHandler(this.reshenieZadaniya_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.label5.Location = new System.Drawing.Point(612, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Решение задания:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // VvodIndexa
            // 
            this.VvodIndexa.AutoSize = true;
            this.VvodIndexa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodIndexa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.VvodIndexa.Location = new System.Drawing.Point(621, 320);
            this.VvodIndexa.Name = "VvodIndexa";
            this.VvodIndexa.Size = new System.Drawing.Size(197, 29);
            this.VvodIndexa.TabIndex = 18;
            this.VvodIndexa.Text = "Введите индекс:";
            this.VvodIndexa.Visible = false;
            this.VvodIndexa.Click += new System.EventHandler(this.VvodIndexa_Click);
            // 
            // VvodIndexaButton
            // 
            this.VvodIndexaButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VvodIndexaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodIndexaButton.Location = new System.Drawing.Point(915, 315);
            this.VvodIndexaButton.Name = "VvodIndexaButton";
            this.VvodIndexaButton.Size = new System.Drawing.Size(47, 38);
            this.VvodIndexaButton.TabIndex = 20;
            this.VvodIndexaButton.Text = "✓";
            this.VvodIndexaButton.UseVisualStyleBackColor = false;
            this.VvodIndexaButton.Visible = false;
            this.VvodIndexaButton.Click += new System.EventHandler(this.VvodIndexaButton_Click);
            // 
            // VvodIndexString
            // 
            this.VvodIndexString.BackColor = System.Drawing.SystemColors.Window;
            this.VvodIndexString.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodIndexString.Location = new System.Drawing.Point(871, 317);
            this.VvodIndexString.Name = "VvodIndexString";
            this.VvodIndexString.Size = new System.Drawing.Size(38, 36);
            this.VvodIndexString.TabIndex = 19;
            this.VvodIndexString.Visible = false;
            this.VvodIndexString.TextChanged += new System.EventHandler(this.VvodIndexString_TextChanged);
            // 
            // VvodChislaButton
            // 
            this.VvodChislaButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.VvodChislaButton.Enabled = false;
            this.VvodChislaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodChislaButton.Location = new System.Drawing.Point(915, 366);
            this.VvodChislaButton.Name = "VvodChislaButton";
            this.VvodChislaButton.Size = new System.Drawing.Size(47, 38);
            this.VvodChislaButton.TabIndex = 23;
            this.VvodChislaButton.Text = "✓";
            this.VvodChislaButton.UseVisualStyleBackColor = false;
            this.VvodChislaButton.Visible = false;
            this.VvodChislaButton.Click += new System.EventHandler(this.VvodChislaButton_Click);
            // 
            // VvodChislaString
            // 
            this.VvodChislaString.Enabled = false;
            this.VvodChislaString.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodChislaString.Location = new System.Drawing.Point(871, 368);
            this.VvodChislaString.Name = "VvodChislaString";
            this.VvodChislaString.Size = new System.Drawing.Size(38, 36);
            this.VvodChislaString.TabIndex = 22;
            this.VvodChislaString.Visible = false;
            this.VvodChislaString.TextChanged += new System.EventHandler(this.VvodChislaString_TextChanged);
            // 
            // VvodChislaLabel
            // 
            this.VvodChislaLabel.AutoSize = true;
            this.VvodChislaLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VvodChislaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.VvodChislaLabel.Location = new System.Drawing.Point(634, 371);
            this.VvodChislaLabel.Name = "VvodChislaLabel";
            this.VvodChislaLabel.Size = new System.Drawing.Size(184, 29);
            this.VvodChislaLabel.TabIndex = 21;
            this.VvodChislaLabel.Text = "Введите число:";
            this.VvodChislaLabel.Visible = false;
            this.VvodChislaLabel.Click += new System.EventHandler(this.VvodChislaLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 109);
            this.panel1.TabIndex = 24;
            // 
            // ArrayVectorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1178, 704);
            this.Controls.Add(this.VvodChislaButton);
            this.Controls.Add(this.VvodChislaString);
            this.Controls.Add(this.VvodChislaLabel);
            this.Controls.Add(this.VvodIndexaButton);
            this.Controls.Add(this.VvodIndexString);
            this.Controls.Add(this.VvodIndexa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reshenieZadaniya);
            this.Controls.Add(this.ChisloCoordbutton);
            this.Controls.Add(this.Modulbutton);
            this.Controls.Add(this.VvodPoIndexbutton);
            this.Controls.Add(this.VuvodPoIndexbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VuvodVectora);
            this.Controls.Add(this.VvodVectora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVector);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.panel1);
            this.Name = "ArrayVectorWindow";
            this.Text = "ArrayVector Window";
            this.Load += new System.EventHandler(this.ArrayVectorWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VvodVectora;
        private System.Windows.Forms.TextBox VuvodVectora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VuvodPoIndexbutton;
        private System.Windows.Forms.Button VvodPoIndexbutton;
        private System.Windows.Forms.Button Modulbutton;
        private System.Windows.Forms.Button ChisloCoordbutton;
        private System.Windows.Forms.TextBox reshenieZadaniya;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VvodIndexa;
        private System.Windows.Forms.Button VvodIndexaButton;
        private System.Windows.Forms.TextBox VvodIndexString;
        private System.Windows.Forms.Button VvodChislaButton;
        private System.Windows.Forms.TextBox VvodChislaString;
        private System.Windows.Forms.Label VvodChislaLabel;
        private System.Windows.Forms.Panel panel1;
    }
}