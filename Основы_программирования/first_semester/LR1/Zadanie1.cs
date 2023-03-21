using System;

namespace Laba1
{
    class Zadanie1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite ugol v gradusah");
            double a = Convert.ToDouble(Console.ReadLine());
            double x = a * Math.PI / 180;
            double z1 = Math.Cos(x) + Math.Sin(x) + Math.Cos(3 * x) + Math.Cos(3 * x);
            double z2 = 2 * Math.Sqrt(2) * Math.Cos(x) * Math.Cos((Math.PI / 4) + 2 * x);
            Console.WriteLine("z1:" + z1 + " " + "z2:" + z2);
        }
    }   
}
            