using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_1__2_семестр_
{
    public class ArrayVector
    {
        private int[] coordinates;

        public ArrayVector()
        {
            coordinates = new int[5];
        }

        public ArrayVector(int razmer)
        {
            coordinates = new int[razmer];
        }


        public void SetElement(int index, int znachenie)
        {
            coordinates[index] = znachenie;
        }

        public int GetElement(int index)
        {
            return coordinates[index];
        }

        public int GetRazmer()
        {
            return coordinates.Length;
        }

        public double GetNorm()
        {
            int sum = 0;
            for (int i = 0; i < coordinates.Length; i++)
            {
                sum += coordinates[i] * coordinates[i];
            }
            double result = Math.Sqrt(sum);
            return result;
        }


        public int SumPositivesFromChetIndex()
        {
            int sum = 0;
            bool hasPositiveChetnoye = false;
            for (int i = 0; i < coordinates.Length; i++)
            {
                if ((coordinates[i] > 0) && (i  % 2 == 0))
                {
                    hasPositiveChetnoye = true;
                    sum += coordinates[i];
                }
            }
            if (hasPositiveChetnoye)
            {
                return sum;
            }
            else
            {
                throw new Exception("Нет положительных элементов с четными номерами");
            }
        }

        public int SummLessFromNechetIndex()
        {
            int sum = 0;
            bool hasLessFromNechetIndex = false;
            for (int i = 0; i < coordinates.Length; i++)
            {
                sum += Math.Abs(coordinates[i]);
            }

            double average = sum / coordinates.Length;
            int result = 0;

            for (int i = 0; i < coordinates.Length; i++)
            {
                if ((i % 2 != 0) && (coordinates[i] < average))
                {
                    result += coordinates[i];
                    hasLessFromNechetIndex = true;
                }
            }
            if (hasLessFromNechetIndex)
            {
                return result;
            }
            else
            {
                throw new Exception("Нет тех элементов массива, которые имеют нечетные номера и одновременно меньше среднего значения всех модулей элементов массива");
            }
        }


        public int MultChet()
        {
            int result = 1;
            bool hasPositiveChet = false;
            for (int i = 0; i < coordinates.Length; i++)
            {
                if ((coordinates[i] > 0) && (coordinates[i] % 2 == 0))
                {
                    result *= coordinates[i];
                    hasPositiveChet = true;
                }
            }
            if (hasPositiveChet)
            {
                return result;
            }
            else
            {
                throw new Exception("Нет четных положительных элементов(по значению)");
            }
        }

        public int MultNechet()
        {
            int result = 1;
            bool hasNechet = false;
            for (int i = 0; i < coordinates.Length; i++)
            {
                if ((coordinates[i] % 2 != 0) && (coordinates[i] % 3 != 0))
                {
                    result *= coordinates[i];
                    hasNechet = true;
                }
            }
            if (hasNechet)
            {
                return result;
            }
            else
            {
                throw new Exception("Нет нечетных элементов(по значению), не делящихся на три");
            }
        }

        public void SortUp()
        {
            for (int j = 0; j < coordinates.Length - 1; j++)
            {
                for (int i = 0; i < coordinates.Length - j - 1; i++)
                {
                    if (coordinates[i] > coordinates[i + 1])
                    {
                        int v = coordinates[i];
                        coordinates[i] = coordinates[i + 1];
                        coordinates[i + 1] = v;
                    }
                }
            }
        }

        public void SortDown()
        {
            for (int j = 0; j < coordinates.Length - 1; j++)
            {
                for (int i = 0; i < coordinates.Length - j - 1; i++)
                {
                    if (coordinates[i] < coordinates[i + 1])
                    {
                        int v = coordinates[i];
                        coordinates[i] = coordinates[i + 1];
                        coordinates[i + 1] = v;
                    }
                }
            }
        }

        override public String ToString()
        {
            return "[" + string.Join(", ", coordinates) + "]";
        }

        //public void PrintArray(int[,] mass)
        //{
        //    for (int i = 0; i < mass.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < mass.GetLength(1); j++)
        //        {
        //            Console.Write("\t" + mass[i, j] + " ");
        //        }
        //        Console.WriteLine("\n");
        //    }
        //}
    }
}
