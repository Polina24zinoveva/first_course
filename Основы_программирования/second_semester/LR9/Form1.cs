using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Laboratornaya9
{
    public partial class Form1 : Form
    {
        public static int scorost = 0;
        bool Vverh;
        bool Vnis = true;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Location = new Point(130, 210);
            timer1.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            scorost = LevelBox.SelectedIndex;
            this.Hide();
            Game gameWindow = new Game();
            gameWindow.Show();
                      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool UZ = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Top < this.Height - 202 && Vnis == true)
            {
                pictureBox2.Top += 2;
            }
            if (pictureBox2.Top == this.Height - 202 && Vnis == true)
            {
                Vnis = false;
                Vverh = true;
            }
            if (pictureBox2.Top > 200 && Vverh == true)
            {
                pictureBox2.Top -= 2;
            }
            if (pictureBox2.Top == 200 && Vverh == true)
            {
                Vnis = true;
                Vverh = false;
            }
        }

        private void LevelBox_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
