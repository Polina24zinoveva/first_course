using System;

namespace Лабораторная_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №6\n Выполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("0.Выход\n" + "1.Сортировка\n" + "2.Массивы\n" + "3.Ступенчатый массив\n");
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
                    case "3":
                        Task3();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.WriteLine("Введите размер массива");
            int razmer = Convert.ToInt32(Console.ReadLine());
            Sorting sorting = new Sorting(razmer);
            int[] mass = sorting.Input();
            Console.Write("Массив до сортировки: ");
            sorting.PrintArray(mass);
            Console.WriteLine("\n");

            Console.Write("Массив после сортировки пузырьком: ");
            sorting.PrintArray(sorting.BubbleSort(mass));
            Console.WriteLine("\n");

            Console.Write("Массив после сортировки вставкой: ");
            sorting.PrintArray(sorting.InsertionSort(mass));
            Console.WriteLine("\n");

            Console.Write("Массив после сортировки выбором: ");
            sorting.PrintArray(sorting.SelectionSort(mass));
            Console.WriteLine("\n");
        }

        static void Task2()
        {
            Console.WriteLine("Введите размер двумерного массива: ");
            Console.WriteLine("Введите колличество строк: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Array array = new Array(m, n);
            int[,] mass = array.Creation();
            Console.WriteLine("Массив до сортировки: ");
            array.PrintArray(mass);
            Console.WriteLine("Массив после сортировки по возрастанию: ");
            array.PrintArray(array.SortColumsA(mass));
            Console.WriteLine("Массив после сортировки по убыванию: ");
            array.PrintArray(array.SortColumsD(mass));
        }

        static void Task3()
        {
            Console.WriteLine("Введите размер массива");
            int razmer = Convert.ToInt32(Console.ReadLine());
            SteppedArray steppedArray = new SteppedArray(razmer);
            int[][] mass = steppedArray.Creation();
            Console.WriteLine("Массив до сортировки: ");
            steppedArray.PrintArray(mass);

            Console.WriteLine("Массив после сортировки по возрастанию: ");
            steppedArray.PrintArray(steppedArray.SortAscending(mass));
            Console.WriteLine("Массив после сортировки по убыванию: ");
            steppedArray.PrintArray(steppedArray.SortDescending(mass));
        }
    }
}
