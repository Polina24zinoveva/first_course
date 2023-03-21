namespace OP_Laboratornaya9
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Raketka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Raketka)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Raketka
            // 
            this.Raketka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(85)))), ((int)(((byte)(26)))));
            this.Raketka.Location = new System.Drawing.Point(1033, 250);
            this.Raketka.Name = "Raketka";
            this.Raketka.Size = new System.Drawing.Size(40, 117);
            this.Raketka.TabIndex = 1;
            this.Raketka.TabStop = false;
            this.Raketka.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1074, 644);
            this.Controls.Add(this.Raketka);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(82)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Raketka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Raketka;
    }
}