using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya4
{
    class Polynomial
    {
        public double a, b, c;

        public Polynomial()
        {

        }

        public Polynomial(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Roots()
        {
            if (a == 0)
            {
                if (b != 0)
                {
                    double x = -1 * c / b;
                    Console.WriteLine("Решение уравнения: " + x);
                }
                if (b == 0)
                {
                    if (c != 0)
                    {
                        Console.WriteLine("Решений нет");
                    }
                    if (c == 0)
                    {
                        Console.WriteLine("Бесконечно много решений");
                    }
                }
            }
            if (a != 0) 
            {
                double deskriminant = b * b - 4 * a * c;
                if (deskriminant > 0)
                {
                    double x1 = (-1 * b + Math.Sqrt(deskriminant)) / (2 * a);
                    double x2 = (-1 * b - Math.Sqrt(deskriminant)) / (2 * a);
                    Console.Write("Решения уравнения: " + x1 + " ");
                    Console.WriteLine(x2);
                }
                if (deskriminant == 0)
                {
                    double x = (-1 * b) / (2 * a);
                    Console.WriteLine("Решение уравнения: " + x);
                }
                if (deskriminant < 0)
                {
                    Console.WriteLine("Решений нет");
                }
            }
        }
    }
}
