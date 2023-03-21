using System;

namespace Laboratornaya_4
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

        static void Task()
        {
            Console.WriteLine("Лабораторная работа №4\nВыполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine("Выберете с чем работать:\n1 - ArrayVector\n" +
                                  "2 - LinkedListVector\n3 - Vectors\n0 - выход");
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

        static void Task1() //ArrayVector
        {
            Console.WriteLine("ArrayVector:");
            ArrayVector vector = ReadVector();
            while (true)
            {
                Console.WriteLine("Выберете задание:\n1 - Вывести элемент по индексу\n2 - Ввести элемент по индексу\n" +
                    "3 - Узнать модуль вектора\n4 - Узнать число координат вектора и его значения\n0 - выход");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        try
                        {
                            int index = VvodIndexa();
                            Console.WriteLine("Элемент под" + index + " индексом: " + vector[index]);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Исходный вектор" + vector);
                            int index = VvodIndexa();
                            int chislo = VvodChisla();
                            vector[index] = chislo;
                            Console.WriteLine("Полученный вектор" + vector);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Модуль вектора: " + vector.GetNorm());
                        break;
                    case "4":
                        Console.WriteLine(vector);
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }

        }

        static void Task2() //LinkedListVector
        {
            Console.WriteLine("LinkedListVector:");
            Console.Write("Вы будете вводить длину массива? \n1 - да, 0 - нет: ");
            string x = Console.ReadLine();
            LinkListVector vector;
            if ((x == "1") || (x == "0"))
            {
                if (x == "1")
                {
                    Console.Write("Введите длину вектора: ");
                    int razmer = Convert.ToInt32(Console.ReadLine());
                    if (razmer < 1)
                    {
                        //Console.WriteLine("Неправильная длина вектора!");
                        throw new Exception("Неправильная длина вектора!");
                    }
                    else
                    {
                        vector = new LinkListVector(razmer);
                    }
                }
                else
                {
                    vector = new LinkListVector();
                }

                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write("Введите " + i + " элемент: ");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    vector[i] = chislo;
                }
            }
            else
            {
                throw new Exception("Неверное значение!");
            }

            while (true)
            {
                Console.WriteLine("Выберете задание:\n1 - Узнать модуль вектора\n2 - Узнать число координат вектора\n" +
                                  "3 - Добавить элемент в начало\n4 - Добавить элемент в конец\n5 - Удалить элемент из начала\n" +
                                  "6 - Удалить элемент из конца\n7 - Добавить элемент в заданную позицию\n" +
                                  "8 - Удалить элемент из заданной позиции\n0 - выход");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Модуль вектора: " + vector.GetNorm());
                        break;
                    case "2":
                        Console.WriteLine("Число координат вектора: " + vector.Length);
                        break;
                    case "3":
                        try
                        {
                            vector.AddToHead(VvodChisla());
                            Console.WriteLine("Вектор: " + vector);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            vector.AddToTail(VvodChisla());
                            Console.WriteLine("Вектор: " + vector);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        vector.RemoveFromHead();
                        Console.WriteLine("Вектор: " + vector);
                        break;
                    case "6":
                        vector.RemoveFromTail();
                        Console.WriteLine("Вектор: " + vector);
                        break;
                    case "7":
                        try
                        {
                            vector.AddAtPosition(VvodIndexa(), VvodChisla());
                            Console.WriteLine("Вектор: " + vector);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "8":
                        try
                        {
                            vector.RemoveAtPosition(VvodIndexa());
                            Console.WriteLine("Вектор: " + vector);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }

        static void Task3() //Vectors
        {
            Console.WriteLine("Первый вектор:");
            ArrayVector vector1 = ReadVector();

            Console.WriteLine("Второй вектор:");
            ArrayVector vector2 = ReadVector();
            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Сложение двух векторов\n" + "2.Скалярное произведение двух векторов\n" +
                                  "3.Получение модуля(длины) вектора\n" + "0.Выход");
                Console.Write("Выбранное задание: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Сумма векторов: "); 
                        Vectors.Sum(vector1, vector2);
                        break;
                    case "2":
                        Console.WriteLine("Скалярное произведение векторов: "); 
                        Vectors.Scalar(vector1, vector2);
                        break;
                    case "3":
                        Console.WriteLine("Длину какого вектора найти?\n 1 - вектор 1\n 2 - вектор 2");
                        Console.Write("Выбранный пункт меню: ");
                        string menu1 = Console.ReadLine();
                        switch (menu1)
                        {
                            case "1":
                                Console.WriteLine("Длина вектора: " + Vectors.GetNorm2(vector1));
                                break;
                            case "2":
                                Console.WriteLine("Длина вектора: " + Vectors.GetNorm2(vector2));
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
            Console.Write("Вы будете вводить длину массива? \n1 - да, 0 - нет: ");
            string x = Console.ReadLine();
            ArrayVector vector;
            if ((x == "1") || (x == "0"))
            {
                if (x == "1")
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
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write("Введите " + i + " элемент: ");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    vector[i] = chislo;
                }

                return vector;
            }
            else
            {
                throw new Exception("Неверное значение!");
            }
        }

        //private static int VvodChisla()
        //{
        //    Console.Write("Введите целое число:");
        //    int value = Convert.ToInt32(Console.ReadLine());
        //    return value;
        //    //throw new ArgumentException();
        //}
        private static int VvodChisla()
        {
            Console.Write("Введите целое число:");
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        private static int VvodIndexa()
        {
            Console.Write("Введите индекс:");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index < 0)
            {
                throw new Exception("Error while executing program:\n" + "Введен отрицательный индекс! " + index);
            }
            return index;
        }
    }
}
