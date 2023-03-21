using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Laboratornaya8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonArrayVector_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArrayVectorWindow arrayVectorWindow = new ArrayVectorWindow();
            arrayVectorWindow.Show();
        }
        private void buttonLinkListVector_Click(object sender, EventArgs e)
        {
            this.Hide();
            LinkListVectorWindow linkListVectorWindow = new LinkListVectorWindow();
            linkListVectorWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task3Window task3Window = new Task3Window();
            task3Window.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
