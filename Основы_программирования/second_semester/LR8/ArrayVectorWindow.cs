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
    public partial class ArrayVectorWindow : Form
    {
        IVectorable vector;
        int zadanie;
        public ArrayVectorWindow()
        {
            InitializeComponent();
        }

        private void ArrayVectorWindow_Load(object sender, EventArgs e)
        {

        }


        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }


        private void textBoxVector_TextChanged(object sender, EventArgs e) { }

        private void textBoxVector_Click(object sender, EventArgs e)
        {
            textBoxVector.ForeColor = Color.Black;
            textBoxVector.Font = new Font("Tahoma", 10);
            textBoxVector.Clear();
        }

        private void VvodVectora_Click(object sender, EventArgs e)
        {
            VuvodPoIndexbutton.Enabled = true;
            VvodPoIndexbutton.Enabled = true;
            Modulbutton.Enabled = true;
            ChisloCoordbutton.Enabled = true;
            reshenieZadaniya.Enabled = true;

            VvodVectora.Enabled = false;
            textBoxVector.Enabled = false;
            string vectorString = textBoxVector.Text;
            string[] vectirsStringMass = vectorString.Split(' ');
            vector = new ArrayVector(vectirsStringMass.Length);
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

        private void label3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void VuvodVectora_TextChanged(object sender, EventArgs e) { }



        private void VuvodPoIndexbutton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            zadanie = 1;
            VvodIndexString.Enabled = true;
            VvodIndexa.Visible = true;
            VvodIndexString.Clear();
            VvodIndexString.Visible = true;
            VvodIndexaButton.Visible = true;
        }

        private void VvodPoIndexbutton_Click(object sender, EventArgs e)
        {
            reshenieZadaniya.Clear();
            zadanie = 2;
            VvodIndexString.Enabled = true;
            VvodIndexa.Visible = true;
            VvodIndexString.Clear();
            VvodIndexString.Visible = true;
            VvodIndexaButton.Visible = true;

            VvodChislaLabel.Visible = true;
            VvodChislaString.Clear();
            VvodChislaString.Visible = true;
            VvodChislaButton.Visible = true;

            
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

        private void reshenieZadaniya_TextChanged(object sender, EventArgs e) { }

        private void VvodIndexa_Click(object sender, EventArgs e) { }

        private void VvodIndexString_TextChanged(object sender, EventArgs e) { }

        private void VvodIndexaButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                VvodIndexString.Enabled = false;
                int index = Convert.ToInt32(VvodIndexString.Text);
                if (index < 0)
                {
                    throw new Exception("Error while executing program:\n" + "Введен отрицательный индекс! " + index);
                }
                if (zadanie == 1)
                {
                    VvodIndexa.Visible = false;
                    VvodIndexString.Visible = false;
                    VvodIndexaButton.Visible = false;
                    this.reshenieZadaniya.Text = "Элемент под " + index + " индексом: " + vector[index];

                }
                else
                {
                    VvodChislaButton.Enabled = true;
                    VvodIndexaButton.Enabled = false;
                    VvodIndexa.Visible = true;
                    VvodIndexString.Visible = true;
                    VvodIndexaButton.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VvodChislaString.Enabled = true;
        }

        private void VvodChislaLabel_Click(object sender, EventArgs e) {}

        private void VvodChislaString_TextChanged(object sender, EventArgs e){}

        private void VvodChislaButton_Click(object sender, EventArgs e) 
        {
            VvodIndexa.Visible = false;
            VvodIndexString.Visible = false;
            VvodIndexaButton.Visible = false;

            VvodChislaString.Enabled = false;
            VvodChislaLabel.Visible = false;
            VvodChislaString.Visible = false;
            VvodChislaButton.Visible = false;

            VvodIndexaButton.Enabled = true;
            VvodChislaButton.Enabled = false;
            try
            {

                this.reshenieZadaniya.Text = "Исходный вектор " + vector.ToString() + Environment.NewLine;

                int index = Convert.ToInt32(VvodIndexString.Text);
                if (index < 0)
                {
                    throw new Exception("Error while executing program:\n" + "Введен отрицательный индекс! " + index);
                }
                int chislo = Convert.ToInt32(VvodChislaString.Text);
                vector[index] = chislo;
                this.reshenieZadaniya.Text += "Полученный вектор: " + vector.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //static void Task1()
        //{
        //    try
        //    {
        //        Console.Write("Введите индекс: ");
        //        int index = Convert.ToInt32(Console.ReadLine());
        //        if (index < 0)
        //        {
        //            throw new Exception("Error while executing program:\n" + "Введен отрицательный индекс! " + index);
        //        }
        //        Console.WriteLine("Элемент под " + index + " индексом: " + vector[index]);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
    }
}
