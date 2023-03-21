using System;

namespace Laboratornaya3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3\n Выполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("0.Выход\n" + "1.Ввод и обработка матриц;\n" + "2.Перевод из двоичной системы счисления в десятичную;");
                Console.Write("Выбранное задание: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }

        static int[,] Summa(int[,] m1, int[,] m2)
        {
            int r3 = m1.GetLength(0);
            int[,] summa = new int[r3, r3];
            for (int i = 0; i < r3; i++)
            {
                for (int j = 0; j < r3; j++)
                {
                    summa[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return summa;
        }

        static int[,] Raznost(int[,] m1, int[,] m2)
        {
            int r3 = m1.GetLength(0);
            int[,] raznost = new int[r3, r3];
            for (int i = 0; i < r3; i++)
            {
                for (int j = 0; j < r3; j++)
                {
                    raznost[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return raznost;
        }

        static int[,] MultiplyByNumber(int[,] matrix, int k)
        {
            int r3 = matrix.GetLength(0);
            int[,] result = new int[r3, r3];
            for (int i = 0; i < r3; i++)
            {
                for (int j = 0; j < r3; j++)
                {
                    result[i, j] = matrix[i, j] * k;
                }
            }
            return result;
        }

        static int[,] Multiply(int[,] matirx1, int[,] matrix2)
        {
            int r3 = matirx1.GetLength(0);
            int[,] result = new int[r3, r3];
            for (int i = 0; i < r3; i++)
            {
                for (int j = 0; j < r3; j++)
                {
                    for (int k = 0; k < r3; k++)
                    {
                        result[i, j] += matirx1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        static bool Equals(int[,] m1, int[,] m2)
        {
            int r3 = m1.GetLength(0);
            for (int i = 0; i < r3; i++)
            {
                for (int j = 0; j < r3; j++)
                {
                    if (m1[i, j] != m2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static int[,] Transpose(int[,] matrix)
        {
            int r3 = matrix.GetLength(0);
            int[,] result = new int[r3, r3];
            for (int i = 0; i < r3; i++)
            {
                for (int j = 0; j < r3; j++)
                {
                    result[i, j] = matrix[j, i];
                }
            }
            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("\t" + matrix[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        static void Task1()
        {
            Console.WriteLine("Ввод и обработка матриц:");
            Console.WriteLine("Введите размер квадратной матрицы, не превышающий 10");
            int r = Convert.ToInt32(Console.ReadLine());
            if ((r >= 10) || (r <= 0))
            {
                Console.WriteLine("Размер неправильный");
                return;
            }
            Console.WriteLine("Для матрицы 1");
            int[,] m1 = new int[r, r];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.WriteLine("Введите целое значения:");
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\t" + "Матрица 1:" + "\n");
            PrintMatrix(m1);

            int[,] m2 = new int[r, r];
            if (r > 10)
            {
                Console.WriteLine("Размер больше 10. Попробуйте ещё раз");
                return;
            }
            Console.WriteLine("Для матрицы 2");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.WriteLine("Введите целое значения:");
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\t" + "Матрица 2:" + "\n");
            PrintMatrix(m2);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите пункт меню: ");
                Console.WriteLine("0.Выход\n" + "1.Сложение матриц;\n" + "2.Вычитание матриц;\n" + "3.Умножение матрицы на число;\n" +
                    "4.Умножение матриц;\n" + "5.Сравнение матриц;\n" + "6.Транспонирование матрицы;\n");
                Console.Write("Выбранный пункт меню: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("1.Сложение матриц:");
                        PrintMatrix(Summa(m1, m2));
                        break;
                    case "2":
                        Console.WriteLine("2.Вычитание матриц:");
                        PrintMatrix(Raznost(m1, m2));
                        break;
                    case "3":
                        Console.WriteLine("3.Умножение матрицы на число:");
                        Console.Write("Введите число: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Какую матрицу умножить на число?\n 1 - матрица 1\n 2 - матрица 2");
                        Console.Write("Выбранный пункт меню: ");
                        string menu3 = Console.ReadLine();
                        switch (menu3)
                        {
                            case "1":
                                PrintMatrix(MultiplyByNumber(m1, k));
                                break;
                            case "2":
                                PrintMatrix(MultiplyByNumber(m2, k));
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("4.Умножение матриц:");
                        PrintMatrix(Multiply(m1, m2));
                        break;
                    case "5":
                        Console.WriteLine("5.Сравнение матриц;\n");
                        Console.WriteLine(Equals(m1, m2) ? "Равны" : "Не равны");
                        break;
                    case "6":
                        Console.WriteLine("6.Транспонирование матрицы:");
                        Console.WriteLine("Какую матрицу транспонировать?\n 1 - матрица 1\n 2 - матрица 2");
                        Console.Write("Выбранный пункт меню: ");
                        string menu6 = Console.ReadLine();
                        switch (menu6)
                        {
                            case "1":
                                PrintMatrix(Transpose(m1));
                                break;
                            case "2":
                                PrintMatrix(Transpose(m2));
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2: Перевод из двоичной системы счисления в десятичную");
            Console.WriteLine("Введите целое неотрицательное число");
            int num10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Исходное число:\n" + num10);
            int numberOfDigits = Convert.ToInt32(Math.Ceiling(Math.Log2(num10)));
            int[] mass = new int[numberOfDigits];
            int i = 0;
            Console.WriteLine("Число в двоичной системе счисления:\n");
            while (num10 >= 1)
            {
                int a = num10 % 2;
                mass[mass.Length - 1 - i] = a;
                i++;
                num10 = num10 / 2;
            }
            PrintMassiv(mass);
            Console.WriteLine("\n");
            mass = LeftPad(mass);
            PrintMassiv(mass);
            Console.WriteLine("\n");
            for (i = 0; i < 3; i++)
            {
                int v = mass[mass.Length - i - 7];
                mass[mass.Length - i - 7] = mass[mass.Length - i - 1];
                mass[mass.Length - i - 1] = v;
            }
            Console.WriteLine("Новое число в двоичной системе счисления:");
            PrintMassiv(mass);
            Console.WriteLine("\n");
            Console.WriteLine("Новое число в десятичной системе счисления:");
            Console.WriteLine(From2To10(mass));
        }

        static void PrintMassiv(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i]);
            }
        }
        static double From2To10(int[] mass)
        {
            double result = 0;
            for (int i = (mass.Length - 1); i >= 0; i--)
            {
                result += mass[i] * Math.Pow(2, mass.Length - 1 - i);
            }
            return result;
        }
        static int[] LeftPad(int[] mass)
        {
            if (mass.Length >= 9)
            {
                return mass;
            }
            int[] newMass = new int[9];
            for (int i = 0; i < mass.Length; i++)
            {
                newMass[newMass.Length - 1 - i] = mass[mass.Length - 1 - i];
            }
            return newMass;
        }
    }
}