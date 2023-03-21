using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_6
{
    public class SteppedArray
    {
        private int razmer;
        public SteppedArray(int razmer)
        {
            this.razmer = razmer;
        }
        public int[][] Creation()
        {
            int[][] mass = new int[razmer][];
            for (int i = 0; i < razmer; i++)
            {
                Console.WriteLine("Введите длину {0} цепи", i + 1);
                int k = Convert.ToInt32(Console.ReadLine());
                mass[i] = new int[k];
                for (int j = 0; j < k ; j ++)
                {
                    Console.Write("Введите целое число: ");
                    mass[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return mass;
        }

        private int CountElements(int[][] mass)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                count += mass[i].Length;
            }
            return count;
        }

        public int[][] SortAscending(int[][] mass)
        {
            int[] oneMass = ToOneDimentionalArray(mass);
            oneMass = InsertionSort(oneMass);
            FillSteppedArray(mass, oneMass);
            return mass;
        }

        public int[][] SortDescending(int[][] mass)
        {
            int[] oneMass = ToOneDimentionalArray(mass);
            oneMass = InsertionSort(oneMass);
            oneMass = Reverse(oneMass);
            FillSteppedArray(mass, oneMass);
            return mass;
        }

        private static int[] Reverse(int[] oneMass)
        {
            int[] oneMass2 = new int[oneMass.Length];
            for (int i = oneMass2.Length - 1; i > -1; i--)
            {
                oneMass2[i] = oneMass[oneMass.Length - 1 - i];
            }

            return oneMass2;
        }

        private static void FillSteppedArray(int[][] mass, int[] oneMass)
        {
            int z = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    mass[i][j] = oneMass[z];
                    z++;
                }
            }
        }

        private int[] ToOneDimentionalArray(int[][] mass)
        {
            int[] oneMass = new int[CountElements(mass)];
            int z = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    oneMass[z] = mass[i][j];
                    z++;
                }
            }
            return oneMass;
        }

        private int[] InsertionSort(int[] mass)
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
        private int[] Copy(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }

        public void PrintArray(int[][] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write(mass[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
