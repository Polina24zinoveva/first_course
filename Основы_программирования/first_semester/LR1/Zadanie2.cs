using System;

namespace Laba1
{
    class Zadanie2
    {
        static void Main2(string[] args)
        {
            double y = 0;
            Console.WriteLine("Vvedite x");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x >= -7 && x < -3)
            {
                y = 3;
            }
            else if (x >= -3 && x < -3)
            {
                y = Math.Sqrt(9 - (x + 3) * (x + 3));  //(x+3)^2 + y*y = 9
            }                                          // y = sqrt(9 - (x+3)^2
            else if (x >= 3 && x < 6)
            {
                y = 9 - 2 * x;    // y = 9 - 2x
            }
            else if (x >= 6 && x <= 11)
            {
                y = x - 9;
            }
            
            if (x < -7 || x > 11)
            {
                Console.WriteLine("Funkciya nie opredelena");
            }
            else
            {
                Console.WriteLine(y);
            }
            //{
            //    Console.WriteLine("Функция не определена");
            //}
        }
    }
}
