using System;

namespace Laboratornaya4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №4\n Выполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Десятичный счётчик\n" + "2.Многочлен\n" + "0.Выход");
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

        static void Task1()
        {

            Console.WriteLine("Задание 1. Десятичный счётчик\n");
            Console.WriteLine("Введите рабочий диапазон\n");
            Console.WriteLine("Введите целое минимальное значение:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое максимальное значение:");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое начальное значение:");
            int value = Convert.ToInt32(Console.ReadLine());
            if ((value < min) || (value > max))
            {
                Console.WriteLine("Начальное значение не в рабочем диапазоне. Начальному значению присвоено минимальное значение.");
                value = min;
            }

            if (min <= max)
            {
                Counter counter = new Counter(max, min, value);
                while (true)
                {
                    Console.WriteLine("Выберете пункт меню:\n");
                    Console.WriteLine("1.Увеличение счётчика на 1 единицу\n" + "2.Уменьшение счётчика на 1 единицу\n" + "3.Узнать значение счётчика\n" + "0.Выход");
                    Console.Write("Выбранный пункт: ");
                    string menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "0":
                            return;
                        case "1":
                            Console.WriteLine("Значение увеличино на 1");
                            counter.Increase();
                            break;
                        case "2":
                            Console.WriteLine("Значение уменьшено на 1");
                            counter.Decrease();
                            break;
                        case "3":
                            Console.WriteLine("Текущее значение счётчика:");
                            counter.State();
                            break;
                        default:
                            Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Не правильный диапазон. Повторите ввод.");
            }
        }


        static void Task2()
        {
            Console.WriteLine("Задание 2. Многочлен\n");
            Console.WriteLine("Введите коеффициены многочлена");
            Console.WriteLine("Введите a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c:");
            double c = Convert.ToDouble(Console.ReadLine());

            Polynomial polynomial = new Polynomial(a, b, c);
            polynomial.Roots();
        }
    }
}
