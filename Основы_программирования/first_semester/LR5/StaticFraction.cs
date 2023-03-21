using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_5
{
    class StaticFraction
    {
        private int numerator = 0;  // Числитель
        private int denominator = 1;  // Знаменатель


        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    Console.WriteLine("Нельзя делить на 0!");
                }
            }
        }


        public StaticFraction()
        {
        }

        public StaticFraction(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            else
            {
                Console.WriteLine("Нельзя делить на 0!");
            }
        }
        public StaticFraction Reduce()
        {
            StaticFraction result = new StaticFraction(numerator, denominator);
            if ((result.numerator < 0) && (result.denominator < 0))
            {
                result.numerator = Math.Abs(result.numerator);
                result.denominator = Math.Abs(result.denominator);
            }
            else if ((result.numerator > 0) && (result.denominator < 0))
            {
                result.numerator = -1 * result.numerator;
                result.denominator = Math.Abs(result.denominator);
            }
            int k = Math.Min(result.numerator, result.denominator);
            for (int i = 2; i <= k; i++)
            {
                while ((result.numerator % i == 0) && (result.denominator % i == 0))
                {
                    result.numerator = result.numerator / i;
                    result.denominator = result.denominator / i;
                }
            }
            return result;
        }

        public void Info()
        {
            Console.WriteLine(numerator + "/" + denominator);
        }
        public static StaticFraction Add(StaticFraction x, StaticFraction y)
        {
            return new StaticFraction(x.numerator * y.denominator + y.numerator * x.denominator, x.denominator * y.denominator).Reduce();
        }
        public static StaticFraction Subtract(StaticFraction x, StaticFraction y)
        {
            return new StaticFraction(x.numerator * y.denominator - y.numerator * x.denominator, x.denominator * y.denominator).Reduce();
        }
        public static StaticFraction Multiply(StaticFraction x, StaticFraction y)
        {
            return new StaticFraction(x.numerator * y.numerator, y.denominator * x.denominator).Reduce();
        }
        public static StaticFraction Divide(StaticFraction x, StaticFraction y)
        {
            return new StaticFraction(x.numerator * y.denominator, y.numerator * x.denominator).Reduce();
        }

        public static StaticFraction operator +(StaticFraction x, StaticFraction y) { return new StaticFraction(x.numerator * y.denominator + y.numerator * x.denominator, x.denominator * y.denominator).Reduce(); }

        public static StaticFraction operator -(StaticFraction x, StaticFraction y) { return new StaticFraction(x.numerator * y.denominator - y.numerator * x.denominator, x.denominator * y.denominator).Reduce(); }

        public static StaticFraction operator *(StaticFraction x, StaticFraction y) { return new StaticFraction(x.numerator * y.numerator, y.denominator * x.denominator).Reduce(); }

        public static StaticFraction operator /(StaticFraction x, StaticFraction y) { return new StaticFraction(x.numerator* y.denominator, y.numerator* x.denominator).Reduce(); }

    }
}
