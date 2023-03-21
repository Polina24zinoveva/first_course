using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OP_Laboratornaya9
{
    public partial class Game : Form
    {
        Thread th;
        public Game()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(DvigenieRaketki); // при нажатии кнопок 
        }
        Random random = new Random();
        int xMyacha = 0;
        int yMyacha = 0;
        int skorost = 2;
        int count = 0;
        int maxCount = 0;

        bool SverhyStena;
        bool SlevaStena;
        

        private void Myach_Click(object sender, EventArgs e){}

        private void DvigenieRaketki(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (Raketka.Top >= 20)
                {
                    Raketka.Top -= 40;

                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (Raketka.Top <= this.Height - Raketka.Height - 60)
                {
                    Raketka.Top += 40;

                }
            }
        }
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            Raketka.Top = e.Y;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            count = 0;
            this.Text = "Ваш счет: " + count + ",  " + "Лучший счёт: " + maxCount;

            //Myach.Location = new Point(0, random.Next(this.Height));
            xMyacha = 0;
            yMyacha = random.Next(this.Height);

            SverhyStena = true;
            SlevaStena = false;
            if (Form1.scorost >= 0)
            {
                skorost = Form1.scorost + 3;
            }
            timer1.Enabled = true;
        }

        private void Game_Paint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Orange), xMyacha, yMyacha, 20, 20);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(xMyacha + 20 > Raketka.Left)
            //if (Myach.Right > Raketka.Left)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                }
                timer1.Enabled = false;
                var result = MessageBox.Show("Вы проиграли(" + Environment.NewLine + "Ваш счет: " + count + ",  " + "Лучший счёт: " + maxCount + Environment.NewLine + "Сыграть еще раз?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Game_Load(sender, e);

                }
                else
                {
                    this.Hide();
                    Form1 menu = new Form1();
                    menu.Show();
                }

                count = 0;    
            }

            th = new Thread(Koordinaty);
            th.Start();

        }

        private void Koordinaty()
        {
            
            Invoke((MethodInvoker)(() =>                            // делегат, который может выполнить код в управляемом коде
            {
                if (xMyacha + 22 >= Raketka.Left &&                     //Правая сторона мяча >= левой стороны ракетки
                   xMyacha + 22 <= Raketka.Left + Raketka.Width &&      //Правая сторона мяча <= правой стороны ракетки
                   yMyacha + 22 >= Raketka.Top &&                       //Низ мяча >= верху ракетки  
                   yMyacha + 22 <= Raketka.Top + Raketka.Height)        //Низ мяча <= низу ракетки

                //    //отскок мяча
                //    if (Myach.Left + Myach.Width >= Raketka.Left &&                     //Правая сторона мяча >= левой стороны ракетки
                //   Myach.Left + Myach.Width <= Raketka.Left + Raketka.Width &&      //Правая сторона мяча <= правой стороны ракетки
                //   Myach.Top + Myach.Height >= Raketka.Top &&                       //Низ мяча >= верху ракетки  
                //   Myach.Top + Myach.Height <= Raketka.Top + Raketka.Height || Myach.Right >= Raketka.Left)        //Низ мяча <= низу ракетки
                    {
                    SlevaStena = false;
                    count += 1;
                    this.Text = "Ваш счет: " + count + ",  " + "Лучший счёт: " + maxCount;
                    //if (count % 3 == 0)
                    //{
                    //    skorost += 1;
                    //}

                }

                #region Все про полет мяча

                if (SlevaStena)          //направо
                {
                    //Myach.Left += skorost;
                    xMyacha += skorost;
                }
                else                     //налево
                {
                    xMyacha -= skorost;
                    //Myach.Left -= skorost;
                }

                if (SverhyStena)         //вниз
                {
                    yMyacha += skorost;
                    //Myach.Top += skorost;
                }
                else                     //наверх
                {
                    yMyacha -= skorost;
                    //Myach.Top -= skorost;
                }

                //if (Myach.Top >= this.Height - 60)  //если ударяется в нижнюю стену
                //{
                //    SverhyStena = false;
                //}
                if(yMyacha >= this.Height - 60)
                {
                    SverhyStena = false;
                }

                //if (Myach.Top <= 0)                 //если ударяется в верхнюю стену
                //{
                //    SverhyStena = true;
                //}
                if (yMyacha <= 0)                 //если ударяется в верхнюю стену
                {
                    SverhyStena = true;
                }

                //if (Myach.Left <= 0)                //если ударяется в левую стену
                //{
                //    SlevaStena = true;
                //}
                if (xMyacha <= 0)                //если ударяется в левую стену
                {
                    SlevaStena = true;
                }

                #endregion
                Refresh();
            }));


            }
        }
}
