using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_5
{
    class Fraction
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


        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            else
            {
                Console.WriteLine("Нельзя делить на 0!");
                //throw new DivideByZeroException("Нельзя делить на 0!");

            }
        }


        public Fraction Add(Fraction f)
        {
            Fraction result = new Fraction();
            result.numerator = numerator * f.denominator + f.numerator * denominator;
            result.denominator = denominator * f.denominator;
            return result.Reduce();
        }
        public Fraction Subtract(Fraction f)
        {
            Fraction result = new Fraction();
            result.numerator = numerator * f.denominator - f.numerator * denominator;
            result.denominator = denominator * f.denominator;
            return result.Reduce();
        }
        public Fraction Multiply(Fraction f)
        {
            Fraction result = new Fraction();
            result.numerator = numerator * f.numerator;
            result.denominator = denominator * f.denominator;
            return result.Reduce();
        }
        public Fraction Divide(Fraction f)
        {
            Fraction result = new Fraction();
            if (numerator != 0)
            {
                result.numerator = numerator * f.denominator;
                result.denominator = denominator * f.numerator;
            }
            else
            {
                Console.WriteLine("Нельзя делить на 0!");
            }
            return result.Reduce();
        }


        public Fraction Reduce()
        {
            Fraction result = new Fraction(numerator, denominator);
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
    }
}
