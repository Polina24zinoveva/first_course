using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_6
{
    class Array
    {
        private int rows;
        private int columns;

        public Array(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        public int[,] Creation()
        {
            int[,] mass = new int[rows, columns];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mass[i, j] = random.Next(-100, 100);
                }
            }
            return mass;
        }
        
        private int ColumnSumm(int n, int[,] mass)
        {
            int summ = 0;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                summ += mass[i, n];
            }    
            return summ;
        }

        private void SwapColumns(int[,]mass, int n1, int n2)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                int v = mass[i, n1];
                mass[i, n1] = mass[i, n2];
                mass[i, n2] = v;
            }
        }

        public int[,] SortColumsA(int[,] mass)
        {
            for(int j = 0; j < mass.GetLength(1) - 1; j++)
            {
                for (int i = 0; i < mass.GetLength(1) - 1; i++)
                {
                    if (ColumnSumm(i, mass) > ColumnSumm(i + 1, mass))
                    {
                        SwapColumns(mass, i, i + 1);
                    }
                }
            }            
            return mass;
        }
        public int[,] SortColumsD(int[,] mass)
        {
            for (int j = 0; j < mass.GetLength(1) - 1; j++)
            {
                for (int i = 0; i < mass.GetLength(1) - 1; i++)
                {
                    if (ColumnSumm(i, mass) < ColumnSumm(i + 1, mass))
                    {
                        SwapColumns(mass, i, i + 1);
                    }
                }
            }
            return mass;
        }
        public void PrintArray(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write("\t" + mass[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}