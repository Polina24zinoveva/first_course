using System;

namespace Лабораторная_1__2_семестр_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Task();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while executing program:\n" + e.Message);
            }
        }

        private static void Task()
        {
            Console.WriteLine("Лабораторная работа №1\nВыполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine("Выберете с чем работать:\n1 - ArrayVector\n2 - Vectors\n0 - выход");
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
        private static void Task1()
        {
            Console.WriteLine("ArrayVector:");
            ArrayVector vector = ReadVector();
            while (true)
            {
                Console.WriteLine("Выберете задание:\n1 - Установка элемента массива по индексу\n2 - Чтение элемента по индексу\n" +
                    "3 - Получение модуля(длины) вектора\n4 - Посчитать сумму всех положительных элементов массива с четными номерами\n" +
                    "5 - Посчитать сумму тех элементов массива, которые имеют нечетные номера и одновременно меньше среднего значения всех модулей элементов массива\n" +
                    "6 - Посчитать произведения всех четных положительных элементов(по значению)\n" +
                    "7 - Посчитать произведения всех нечетных элементов(по значению), не делящихся на три\n" +
                    "8 - Сортировка массива по возрастанию\n" +
                    "9 - Сортировка массива по убыванию\n0 - выход");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Введите индекс: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цклое число: ");
                        int znachenie = Convert.ToInt32(Console.ReadLine());
                        if (index < vector.GetRazmer())
                        {
                            vector.SetElement(index, znachenie);
                            Console.WriteLine("Новый вектор: " + vector);
                        }
                        else
                        {
                            throw new Exception("Неверный индекс! " + index);
                        } 
                        break;
                    case "2":
                        Console.WriteLine("Введите индекс: ");
                        int indexx = Convert.ToInt32(Console.ReadLine());
                        if (indexx < vector.GetRazmer())
                        {
                            Console.WriteLine(indexx + " элемент " + vector.GetElement(indexx));
                        }
                        else
                        {
                            throw new Exception("Неверный индекс! " + indexx);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Длина вектора: " + vector.GetNorm());
                        break;
                    case "4":
                        Console.WriteLine("Сумма всех положительных элементов массива с четными номерами: " + vector.SumPositivesFromChetIndex());
                        break;
                    case "5":
                        Console.WriteLine("Сумма тех элементов массива, которые имеют нечетные номера и одновременно меньше среднего значения всех модулей элементов массива: " + vector.SummLessFromNechetIndex());
                        break;
                    case "6":
                        Console.WriteLine("Произведение всех четных положительных элементов(по значению): " + vector.MultChet());
                        break;
                    case "7":
                        Console.WriteLine("Произведение всех нечетных элементов(по значению), не делящихся на три: " + vector.MultNechet());
                        break;
                    case "8":
                        vector.SortUp();
                        Console.WriteLine("Отсортированный массив: " + vector);
                        break;
                    case "9":
                        vector.SortDown();
                        Console.WriteLine("Отсортированный массив: " + vector);
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }


        private static void Task2()
        {
            Console.WriteLine("Первый вектор:");
            ArrayVector vector1 = ReadVector();

            Console.WriteLine("Второй вектор:");
            ArrayVector vector2 = ReadVector();

            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Сложение двух векторов\n2.Скалярное произведение двух векторов\n" +
                    "3.Умножение вектора на число\n4.Получение модуля(длины) вектора\n0.Выход");
                Console.Write("Выбранное задание: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Сумма векторов: " + Vectors.Sum(vector1, vector2));
                        break;
                    case "2":
                        Console.WriteLine("Скалярное произведение векторов: " + Vectors.Scalar(vector1, vector2));
                        break;
                    case "3":
                        Console.Write("Введите целое число: ");
                        int chislo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Какой вектор умножить на число?\n 1 - вектор 1\n 2 - вектор 2");
                        Console.Write("Выбранный пункт меню: ");
                        string menu3 = Console.ReadLine();
                        switch (menu3)
                        {
                            case "1":
                                Console.WriteLine("Полученный вектор: " + Vectors.NumberMult(vector1, chislo));
                                break;
                            case "2":
                                Console.WriteLine("Полученный вектор: " + Vectors.NumberMult(vector2, chislo));
                                break;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Длину какого вектора найти?\n 1 - вектор 1\n 2 - вектор 2");
                        Console.Write("Выбранный пункт меню: ");
                        string menu4 = Console.ReadLine();
                        switch (menu4)
                        {
                            case "1":
                                Console.WriteLine("Длина вектора: " + Vectors.GetNorm(vector1));
                                break;
                            case "2":
                                Console.WriteLine("Длина вектора: " + Vectors.GetNorm(vector2));
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }

        private static ArrayVector ReadVector()
        {
            Console.WriteLine("Вы будете вводить длину массива? \n1 - да, 0 - нет");
            int x = Convert.ToInt32(Console.ReadLine());
            ArrayVector vector;
            if (x== 1)
            {
                Console.Write("Введите длину вектора: ");
                int razmer = Convert.ToInt32(Console.ReadLine());
                if (razmer < 1)
                {
                    Console.WriteLine("Неправильная длина вектора!");
                    throw new Exception();
                }
                else
                {
                    vector = new ArrayVector(razmer);
                }
            }
            else
            {
                vector = new ArrayVector();
            }

            for (int i = 0; i < vector.GetRazmer(); i++)
            {
                Console.WriteLine("Введите " + i + " элемент");
                int chislo = Convert.ToInt32(Console.ReadLine());
                vector.SetElement(i, chislo);
            }

            return vector;
        }
    }
}
