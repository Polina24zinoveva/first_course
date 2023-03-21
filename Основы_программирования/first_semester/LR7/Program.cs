using System;

namespace Лабораторная_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №7\n Выполнила: Зиновьева Полина, студентка группы 6103-020302D");
            Console.WriteLine("Введите строку");
            string str = Convert.ToString(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("0.Выход\n" + "1.Подсчёт букв в строке\n" + "2.Средняя длина слова в строке\n" + "3.Замена слова\n" + "4.Подсчёт вхождений подстроки\n" + "5.Проверка на палиндром\n" + "6.Проверка на дату\n");
                Console.Write("Выбранное задание: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                { 
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine(Strings.CountLetters(str));
                        break;
                    case "2":
                        Console.WriteLine(Strings.AverageWordLength(str));
                        break;
                    case "3":
                        Console.WriteLine("Какое слово заменить? ");
                        string podstroka = Console.ReadLine();
                        Console.WriteLine("На слово заменить? ");
                        string newpodstroka = Console.ReadLine();
                        Console.WriteLine(Strings.ReplaceWord(str, podstroka, newpodstroka));
                        break;
                    case "4":
                        Console.WriteLine("Введите подстроку: ");
                        string podstroka4 = Console.ReadLine();
                        Console.WriteLine(Strings.SubstringCounter(str, podstroka4));
                        break;
                    case "5":
                        if (Strings.Palindrom(str) == true)
                        {
                            Console.WriteLine("Это палиндром!");
                        }
                        else
                        {
                            Console.WriteLine("Это не палиндром!");

                        }
                        break;
                    case "6":
                        if (Strings.Data(str) == true)
                        {
                            Console.WriteLine("Это формат!");
                        }
                        else
                        {
                            Console.WriteLine("Это не формат!");

                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }
    }
}
