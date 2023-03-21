using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_6
{
    class Sorting
    {
        private int razmer;

        public Sorting()
        {

        }
        public Sorting(int razmer)
        {
            this.razmer = razmer;
        }

        public int[] Input()
        {
            int[] mass = new int[razmer];
            Console.WriteLine("Введите массив");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("Введите целое число:");
                mass[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            }
            return mass;
        }

        public int[] BubbleSort(int[] mass)
        {
            int[] mass1 = Copy(mass);
            for (int j = 1; j < mass1.Length - 1; j++)
            {
                for (int i = 0; i < mass1.Length - 1; i++)
                {
                    if (mass1[i] > mass1[i + 1])
                    {
                        int v = mass1[i];
                        mass1[i] = mass1[i + 1];
                        mass1[i + 1] = v;
                    }
                }
            }
            return mass1;
        }
        public int[] InsertionSort(int[] mass)
        {
            int[] mass1 = Copy(mass);
            for (int i = 1; i < mass1.Length; i++)
            {
                int v = mass1[i];
                int j = i - 1;
                while ((j >= 0) && (v < mass1[j]))
                {
                    mass1[j + 1] = mass1[j];
                    j = j - 1;
                }
                mass1[j + 1] = v;
            }
            return mass1;
        }
        public int[] SelectionSort(int[] mass)
        {
            int[] mass1 = Copy(mass);
            for (int j = 0; j < mass1.Length - 1; j++)
            {
                int min = mass1[j];
                int imin = j;
                for (int i = j + 1; i < mass1.Length; i++)
                {
                    if (mass1[i] < min)
                    {
                        min = mass1[i];
                        imin = i;
                    }
                }
                mass1[imin] = mass1[j];
                mass1[j] = min;
            }
            return mass1;
        }

        private int[] Copy(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }

        public void PrintArray(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
}
