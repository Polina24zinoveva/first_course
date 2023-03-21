namespace OP_Laboratornaya8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonArrayVector = new System.Windows.Forms.Button();
            this.buttonLinkListVector = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 190);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(148, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(857, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выполнила: Зиновьева Полина, студентка группы 6103-020302D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(439, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(474, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберете задание";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonArrayVector
            // 
            this.buttonArrayVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonArrayVector.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonArrayVector.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrayVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.buttonArrayVector.Location = new System.Drawing.Point(444, 304);
            this.buttonArrayVector.Name = "buttonArrayVector";
            this.buttonArrayVector.Size = new System.Drawing.Size(285, 74);
            this.buttonArrayVector.TabIndex = 3;
            this.buttonArrayVector.Text = "ArrayVector";
            this.buttonArrayVector.UseVisualStyleBackColor = false;
            this.buttonArrayVector.Click += new System.EventHandler(this.buttonArrayVector_Click);
            // 
            // buttonLinkListVector
            // 
            this.buttonLinkListVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonLinkListVector.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLinkListVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.buttonLinkListVector.Location = new System.Drawing.Point(444, 395);
            this.buttonLinkListVector.Name = "buttonLinkListVector";
            this.buttonLinkListVector.Size = new System.Drawing.Size(285, 74);
            this.buttonLinkListVector.TabIndex = 4;
            this.buttonLinkListVector.Text = "LinkListVector";
            this.buttonLinkListVector.UseVisualStyleBackColor = false;
            this.buttonLinkListVector.Click += new System.EventHandler(this.buttonLinkListVector_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.button3.Location = new System.Drawing.Point(444, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 74);
            this.button3.TabIndex = 5;
            this.button3.Text = "Задания лабораторной №5";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.buttonExit.Location = new System.Drawing.Point(444, 576);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(285, 74);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1178, 704);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLinkListVector);
            this.Controls.Add(this.buttonArrayVector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лабораторная 8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonArrayVector;
        private System.Windows.Forms.Button buttonLinkListVector;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonExit;
    }
}

