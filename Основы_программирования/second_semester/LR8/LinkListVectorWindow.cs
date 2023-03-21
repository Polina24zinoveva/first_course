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
    public partial class LinkListVectorWindow : Form
    {
        LinkListVector vector;
        int zadanie;
        public LinkListVectorWindow()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void ArrayVectorWindow_Load(object sender, EventArgs e)
        {

        }


        private void textBoxVector_TextChanged(object sender, EventArgs e) { }

        private void textBoxVector_Click(object sender, EventArgs e)
        {
            textBoxVector.ForeColor = Color.Black;
            textBoxVector.Font = new Font("Microsoft Sans Serif", 8);
            textBoxVector.Clear();
        }

        private void razmerTextBox_TextChanged(object sender, EventArgs e) {}

        private void razmerButton_Click(object sender, EventArgs e) 
        {
            VvodVectora.Enabled = true;
            textBoxVector.Enabled = true;
        }

        private void textBoxVector_TextChanged_1(object sender, EventArgs e) {}

        private void VvodVectora_Click_1(object sender, EventArgs e)
        {
            Modulbutton.Enabled = true;
            ChisloCoordbutton.Enabled = true;
            VuvodPoIndexbutton.Enabled = true;
            VvodPoIndexbutton.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;

            VvodVectora.Enabled = false;
            textBoxVector.Enabled = false;
            string vectorString = textBoxVector.Text;
            string[] vectirsStringMass = vectorString.Split(' ');

            vector = new LinkListVector(vectirsStringMass.Length);
            try
            {
                for (int i = 0; i < vectirsStringMass.Length; i++)
                {
                    vector[i] = Convert.ToInt32(vectirsStringMass[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.VuvodVectora.Text = vector.ToString();
        }

        private void Modulbutton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            this.reshenieZadaniya.Text = "Модуль вектора: " + vector.GetNorm();
        }

        private void ChisloCoordbutton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            this.reshenieZadaniya.Text = vector.ToString();
        }

        private void VuvodPoIndexbutton_Click(object sender, EventArgs e)
        {
            zadanie = 3;
            reshenieZadaniya.Clear();
            VvodChislaLabel.Visible = true;
            VvodChislaString.Visible = true;
            VvodChislaButton.Visible = true;

            VvodChislaString.Enabled = true;
            VvodChislaButton.Enabled = true;
        }

        private void VvodPoIndexbutton_Click(object sender, EventArgs e)
        {
            zadanie = 4;
            reshenieZadaniya.Clear();
            VvodChislaLabel.Visible = true;
            VvodChislaString.Visible = true;
            VvodChislaButton.Visible = true;

            VvodChislaString.Enabled = true;
            VvodChislaButton.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            vector.RemoveFromHead();
            this.reshenieZadaniya.Text = "Вектор: " + vector;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            vector.RemoveFromTail();
            this.reshenieZadaniya.Text = "Вектор: " + vector;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zadanie = 7;
            reshenieZadaniya.Clear();

            VvodIndexString.Enabled = true;
            VvodIndexaButton.Enabled = true;

            VvodIndexa.Visible = true;
            VvodIndexString.Visible = true;
            VvodIndexaButton.Visible = true;

            VvodChislaLabel.Visible = true;
            VvodChislaString.Visible = true;
            VvodChislaButton.Visible = true;

            VvodChislaString.Enabled = false;
            VvodChislaButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zadanie = 8;
            reshenieZadaniya.Clear();

            VvodIndexa.Visible = true;
            VvodIndexString.Visible = true;
            VvodIndexaButton.Visible = true;

            VvodIndexString.Enabled = true;
            VvodIndexaButton.Enabled = true;
        }

        private void VvodChislaLabel_Click(object sender, EventArgs e)
        {

        }

        private void VvodChislaString_TextChanged(object sender, EventArgs e)
        {

        }

        private void VvodChislaButton_Click(object sender, EventArgs e)
        {
            if (zadanie == 3)
            {
                VvodChislaLabel.Visible = false;
                VvodChislaString.Visible = false;
                VvodChislaButton.Visible = false;
                int chislo = Convert.ToInt32(VvodChislaString.Text);
                vector.AddToHead(chislo);
                this.reshenieZadaniya.Text = "Полученный вектор: " + vector.ToString();
                VvodChislaString.Clear();
            }
            if (zadanie == 4)
            {
                VvodChislaLabel.Visible = false;
                VvodChislaString.Visible = false;
                VvodChislaButton.Visible = false;
                int chislo = Convert.ToInt32(VvodChislaString.Text);
                vector.AddToTail(chislo);
                this.reshenieZadaniya.Text = "Полученный вектор: " + vector.ToString();
                VvodChislaString.Clear();
            }
            if (zadanie == 7)
            {
                try
                {
                    this.reshenieZadaniya.Text = "Исходный вектор " + vector.ToString();

                    int index = Convert.ToInt32(VvodIndexString.Text);
                    if (index < 0)
                    {
                        throw new Exception("Error while executing program:\n" + "Введен отрицательный индекс! " + index);
                    }
                    int chislo = Convert.ToInt32(VvodChislaString.Text);
                    vector.AddAtPosition(index, chislo);
                    this.reshenieZadaniya.Text = "Полученный вектор: " + vector.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                VvodIndexa.Visible = false;
                VvodIndexString.Visible = false;
                VvodIndexaButton.Visible = false;

                VvodChislaLabel.Visible = false;
                VvodChislaString.Visible = false;
                VvodChislaButton.Visible = false;

                VvodIndexString.Clear();
                VvodChislaString.Clear();
            }
           

        }

        private void VvodIndexaButton_Click(object sender, EventArgs e)
        {
            if (zadanie == 7)
            {
                VvodChislaString.Enabled = true;
                VvodChislaButton.Enabled = true;

                VvodIndexString.Enabled = false;
                VvodIndexaButton.Enabled = false;

            }
            if (zadanie == 8)
            {
                VvodIndexa.Visible = false;
                VvodIndexString.Visible = false;
                VvodIndexaButton.Visible = false;
                int index = Convert.ToInt32(VvodIndexString.Text);
                vector.RemoveAtPosition(index);
                this.reshenieZadaniya.Text = "Полученный вектор: " + vector.ToString();
                VvodIndexString.Clear();
            }
        }

        private void VvodIndexa_Click(object sender, EventArgs e)
        {

        }

        private void VvodIndexString_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkListVectorWindow_Load(object sender, EventArgs e)
        {

        }

        private void VuvodVectora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
