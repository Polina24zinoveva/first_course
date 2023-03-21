using System;

namespace Лабораторная_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5\n Выполнила: Зиновьева Полина, студентка группы 6103-020302D");
            Console.WriteLine("Введите числитель первой дроби:");
            int numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первой дроби:");
            int denominator1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите числитель второй дроби:");
            int numerator2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второй дроби:");
            int denominator2 = Convert.ToInt32(Console.ReadLine());
            if ((denominator1 == 0) || (denominator2 == 0))
            {
                Console.WriteLine("Нельзя делить на 0!");
                return;
            }
            Fraction x = new Fraction(numerator1, denominator1);
            Fraction y = new Fraction(numerator2, denominator2);

            StaticFraction xS = new StaticFraction(numerator1, denominator1);
            StaticFraction yS = new StaticFraction(numerator2, denominator2);

            while (true)
            {
                Console.WriteLine("Выберите методы: ");
                Console.WriteLine("1.Статические методы\n" + "2.Обычные методы\n" + "0.Выход");
                Console.Write("Выбранный метод: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Task1(xS, yS);
                        break;
                    case "2":
                        Task2(x, y);
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
            }
        }

        static void Task1(StaticFraction x, StaticFraction y)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Сумма\n" + "2.Разность\n" + "3.Умножение\n" + "4.Деление\n" + "0.Выход");
                Console.Write("Выбранное задание: ");
                string menu3 = Console.ReadLine();
                switch (menu3)
                {
                    case "0":
                        return;
                    case "1":
                        StaticFraction add = StaticFraction.Add(x, y);
                        Console.Write("Решение методом: ");
                        add.Info();
                        Console.Write("Решение операцией '+': ");
                        (x + y).Info();
                        break;
                    case "2":
                        StaticFraction subtract = StaticFraction.Subtract(x, y);
                        Console.Write("Решение методом: ");
                        subtract.Info();
                        Console.Write("Решение операцией '-': ");
                        (x - y).Info();
                        break;
                    case "3":
                        StaticFraction multiply = StaticFraction.Multiply(x, y);
                        Console.Write("Решение методом: ");
                        multiply.Info();
                        Console.Write("Решение операцией '*': ");
                        (x * y).Info();
                        break;
                    case "4":
                        StaticFraction divide = StaticFraction.Divide(x, y);
                        Console.Write("Решение методом: ");
                        divide.Info();
                        Console.Write("Решение операцией '/': ");
                        (x / y).Info();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }
        static void Task2(Fraction x, Fraction y)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Сумма\n" + "2.Разность\n" + "3.Умножение\n" + "4.Деление\n" + "0.Выход");
                Console.Write("Выбранное задание: ");
                string menu2 = Console.ReadLine();
                switch (menu2)
                {
                    case "0":
                        return;
                    case "1":
                        Fraction add = x.Add(y);
                        add.Info();
                        break;
                    case "2":
                        Fraction subtract = x.Subtract(y);
                        subtract.Info();
                        break;
                    case "3":
                        Fraction multiply = x.Multiply(y);
                        multiply.Info();
                        break;
                    case "4":
                        Fraction divide = x.Divide(y);
                        divide.Info();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }
    }
}
