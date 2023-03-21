using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Laboratornaya8
{
    public partial class Task3Window : Form
    {
        IVectorable[] mass;
        public Task3Window()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void textBoxVector_TextChanged(object sender, EventArgs e) {}

        private void textBoxVector_Click(object sender, EventArgs e)
        {
            textBoxVector.ForeColor = Color.Black;
            textBoxVector.Font = new Font("Tahoma", 10);
            textBoxVector.Clear();
        }

        private void VvodVectora_Click(object sender, EventArgs e)
        {
            MinCoordbutton.Enabled = true;
            MaxCoordButton.Enabled = true;
            Sortbutton.Enabled = true;
            Klonbutton.Enabled = true;
            reshenieZadaniya.Enabled = true;


            textBoxVector.Enabled = false;
            VvodVectora.Enabled = false;
            try
            {
                string[] vectorsStringMass = textBoxVector.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None); ;
                mass = new ArrayVector[vectorsStringMass.Length];
                for (int i = 0; i < vectorsStringMass.Length; i++)
                {
                    string[] vectorMassString = vectorsStringMass[i].Split(' ');
                    ArrayVector vectorMassInt = new ArrayVector(vectorMassString.Length);
                    for (int j = 0; j < vectorMassString.Length; j++)
                    {
                        vectorMassInt[j] = Convert.ToInt32(vectorMassString[j]);
                    }
                    mass[i] = vectorMassInt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < mass.Length; i++)
            {
                this.VuvodVectora.Text += i + " элемент: " + mass[i] + Environment.NewLine;
            }
            

        }

        private void VuvodVectora_TextChanged(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e) {}



        private void reshenieZadaniya_TextChanged(object sender, EventArgs e) {}

        private void MinCoordbutton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            IVectorable min = mass[0];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (min.CompareTo(mass[i + 1]) == 1)
                {
                    min = mass[i + 1];
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length == min.Length)
                {
                    this.reshenieZadaniya.Text += mass[i].ToString() + Environment.NewLine;
                }
            }
        }

        private void MaxCoordButton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            IVectorable max = mass[0];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (max.CompareTo(mass[i + 1]) == -1)
                {
                    max = mass[i + 1];
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length == max.Length)
                {
                    this.reshenieZadaniya.Text += mass[i].ToString() + Environment.NewLine;
                }
            }
        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            this.reshenieZadaniya.Text += "Массив до сортировки по возрастанию модулей: " + Environment.NewLine;
            for (int i = 0; i < mass.Length; i++)
            {
                this.reshenieZadaniya.Text += i + " элемент: " + mass[i] + Environment.NewLine;
            }
            Array.Sort(mass, new Comparer());
            this.reshenieZadaniya.Text += "Массив после сортировки по возрастанию модулей: " + Environment.NewLine;
            for (int i = 0; i < mass.Length; i++)
            {
                this.reshenieZadaniya.Text += i + " элемент: " + mass[i] + ", модуль: " + mass[i].GetNorm() + Environment.NewLine;
            }
        }

        private void Klonbutton_Click(object sender, EventArgs e)
        {
            VvodIndexString.Clear();
            reshenieZadaniya.Clear();
            this.reshenieZadaniya.Text = "Какой вектор хотите клонировать?";
            VvodIndexa.Visible = true;
            VvodIndexString.Visible = true;
            VvodIndexaButton.Visible = true;
        }

        private void VvodIndexString_TextChanged(object sender, EventArgs e) {}

        private void VvodIndexaButton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            VvodIndexa.Visible = false;
            VvodIndexString.Visible = false;
            VvodIndexaButton.Visible = false;

            int k = 0;
            try
            {
                k = Convert.ToInt32(VvodIndexString.Text);
                if ((k < 0) || (k >= mass.Length))
                {
                    this.reshenieZadaniya.Text += "Неверный вектор. Произойдет клонирование 0 вектора" + Environment.NewLine;
                    k = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            IVectorable ishodnuy = mass[k];
            this.reshenieZadaniya.Text += "Исходный вектор: " + ishodnuy + Environment.NewLine;
            IVectorable klon = (IVectorable)mass[k].Clone();
            this.reshenieZadaniya.Text += "Клонированный вектор: " + klon + Environment.NewLine;
            Thread.Sleep(1000);
            var result = MessageBox.Show("Хотите проверить клонирование?" + Environment.NewLine + "Значение 0 элемента будет заменено на - 1", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
    
                klon[0] = -1;

                this.reshenieZadaniya.Text = "Исходный вектор: " + ishodnuy + Environment.NewLine;
                this.reshenieZadaniya.Text += "Клонированный вектор: " + klon + Environment.NewLine;

                if (klon.Equals(ishodnuy))
                {
                    this.reshenieZadaniya.Text += "Векторы равны!";
                }
                else
                {
                    this.reshenieZadaniya.Text += "Векторы не равны!";

                }
            }
        }

        private void VvodIndexa_Click(object sender, EventArgs e) {}
    }
}
