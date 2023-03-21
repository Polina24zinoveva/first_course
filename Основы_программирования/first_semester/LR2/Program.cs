using System;

namespace Laboratornaya2
{
    class Program
    {
        static void Task1()
        {
            double x, y, xmin, xmax, dx;
            Console.WriteLine("Вывод таблицы значений функции:");
            Console.WriteLine("Введите xmin:");
            xmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите xmax:");
            xmax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите dx:");
            dx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n Ввод значений функции на интервале от {0} до {1} на экран\n", xmin, xmax);
            Console.WriteLine("\tx\t\ty\n");
            for (x = xmin; x <= xmax; x += dx)
            {
                if ((x >= -7) && (x <= 11))
                {
                    if (x < -3)
                    {
                        y = 3;
                    }
                    else
                    {
                        if (x < 3)
                        {
                            y = -1 * (Math.Sqrt(9 - x * x)) + 3;
                        }
                        else
                        {
                            if (x < 6)
                            {
                                y = 9 - 2 * x;
                            }
                            else
                            {
                                y = x - 9;
                            }
                        }
                    }
                Console.WriteLine("{0,10:0.00}{1,16:0.00}", x, y);
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                    break;
                }
            }
        }
        static void Task2()
        {
            Console.WriteLine("Для десяти выстрелов, координаты которых задаются с клавиатуры, вывести текстовое сообщение о попадании в мишень");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tx\t\ty\t\tПопадание");
            int n = 1;
            do
            {
                Console.WriteLine(n + ")\n");
                Console.WriteLine("Введите значение x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение y:");
                double y = Convert.ToDouble(Console.ReadLine());
                if ((x >= 0 && y >= 0) || (x <= 0 && y <= 0))
                {
                    if (x * x + y * y <= 2 * 2)
                    {
                        Console.WriteLine("{0,35:0.00}{1,16:0.00}{2,19}", x, y, "Popalo");
                    }
                    else
                    {
                        Console.WriteLine("{0,35:0.00}{1,16:0.00}{2,22}", x, y, "Ne popalo");
                    }
                }
                else
                {
                    if (x < 0 && y > 0)
                    {
                        if (y <= x + 2)
                        {
                            Console.WriteLine("{0,35:0.00}{1,16:0.00}{2,19}", x, y, "Popalo");
                        }
                        else
                        {
                            Console.WriteLine("{0,35:0.00}{1,16:0.00}{2,19}", x, y, "Ne popalo");
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0,35:0.00}{1,16:0.00}{2,19}", x, y, "Ne popalo");
                    }
                }
                n++;
            } while (n < 11);
        }
        static void Task3()
        {
            Console.WriteLine("Вычислить сумму ряда с заданной точностью и подсчитать количество членов в ряду");
            Console.Write("Введите заданную точность погрешности: ");
            double precision = Convert.ToDouble(Console.ReadLine());      //precision - точность
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double summ = Math.PI / 2;
            if (x > 1)
            {
                double k;                                     //k  - n элемент
                int n = 0;
                do
                {
                    k = Math.Pow((-1), n + 1) / ((2 * n + 1) * Math.Pow(x, (2 * n + 1)));
                    summ += k;
                    n++;
                }
                while (Math.Abs(k) > precision);
                Console.WriteLine("Сумма ряда = " + summ);
                Console.WriteLine("Количество членов в ряду = " + n);
            }
            else
            {
                Console.WriteLine("Неверное значение x");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2\n Выполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите пункт меню: ");
                Console.WriteLine("0.Выход\n" + "1.Таблица значений функции;\n" + "2.Серия выстрелов по мишени;\n" + "3.Сумма ряда с заданной точностью;");
                Console.Write("Выбранный пункт меню: ");
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
    }
}
