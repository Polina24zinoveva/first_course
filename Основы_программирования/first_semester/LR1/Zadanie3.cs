using System;

namespace Laba1

{
    class Zadanie3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Vvedite x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (IsPopalo(x, y))
            {
                Console.WriteLine("Popalo");
            }
            else
            {
                Console.WriteLine("Nie Popalo");
            }
        }    

        static bool IsPopalo(double x, double y)
        {
            if ((x >= 0 && y >= 0) || (x <= 0 && y <= 0))
            {
                if (x * x + y * y <= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (x < 0 && y > 0)
            {
                if (y <= x + 2) // y = x + 2
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }
    }
}
