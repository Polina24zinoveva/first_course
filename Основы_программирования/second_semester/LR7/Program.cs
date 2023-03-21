using System;

namespace OP_Laboratornaya7
{
    class Program
    {
        delegate void Del();

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
            PrintInfo();
            try
            {
                Del del = PrintInfo;
                int zadanie = 1000;
                while (zadanie != 0)
                {
                    Console.Write("Введите номер задания: ");
                    zadanie = Convert.ToInt32(Console.ReadLine());
                    if (zadanie == 0)
                    {
                        del += Exit;
                    }
                    else if (zadanie == 1)
                    {
                        del += Task1;
                    }
                    else if (zadanie == 2)
                    {
                        del += Task2;
                    }
                    else if (zadanie == 3)
                    {
                        del += Task3;
                    }
                    else
                    {
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                    }
                }
                del -= PrintInfo;
                Console.WriteLine();
                del();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        static void Task1() //ArrayVector
        {
            Console.WriteLine("Задание 1: ArrayVector.");
            ArrayVector vector = ReadVectorA();
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
                            Console.WriteLine("Элемент под " + index + " индексом: " + vector[index]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Исходный вектор " + vector);
                            int index = VvodIndexa();
                            int chislo = VvodChisla();
                            vector[index] = chislo;
                            Console.WriteLine("Полученный вектор " + vector);
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
            Console.WriteLine("Задание 2: LinkedListVector.");
            LinkListVector vector = ReadVectorL();

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

        static void Task3() //Задания лабораторной №5
        {
            Console.WriteLine("Задание 3: Задания лабораторной №5.");

            Console.Write("Введите размер массива: ");
            int razmer = Convert.ToInt32(Console.ReadLine());
            IVectorable[] mass = new IVectorable[razmer];
            for (int j = 0; j < razmer; j++)
            {
                Console.WriteLine("Какой тип вектора? 1 - ArrayVector; 2 - LinkListVector");
                Console.Write("Выбранное задание: ");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        {
                            mass[j] = ReadVectorA();
                        }
                        break;
                    case "2":
                        {
                            mass[j] = ReadVectorL();
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Вектор с минимальным числом координат: ");
            IVectorable min = mass[0];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (min.CompareTo(mass[i + 1]) == 1)
                {
                    min = mass[i + 1];
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length == min.Length)
                {
                    Console.WriteLine(mass[i]);
                }
            }

            Console.WriteLine("Вектор с максимальным числом координат: ");
            IVectorable max = mass[0];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (max.CompareTo(mass[i + 1]) == -1)
                {
                    max = mass[i + 1];
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i].Length == max.Length)
                {
                    Console.WriteLine(mass[i]);
                }
            }

            Console.WriteLine("Массив до сортировки по возрастанию модулей: ");
            Print(mass);
            Array.Sort(mass, new Comparer());
            Console.WriteLine("Массив после сортировки по возрастанию модулей: ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(i + " элемент: " + mass[i] + ", модуль: " + mass[i].GetNorm());
            }

            int k = 0;
            try
            {
                Console.WriteLine("Какой вектор хотите клонировать?");
                k = Convert.ToInt32(Console.ReadLine());
                if ((k < 0) || (k >= mass.Length))
                {
                    Console.WriteLine("Неверный вектор. Произойдет клонирование 0 вектора");
                    k = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            IVectorable ishodnuy = mass[k];
            Console.Write("Исходный вектор: " + ishodnuy + "\n");
            IVectorable klon = (IVectorable)mass[k].Clone();
            Console.WriteLine("Клонированный вектор: " + klon);

            Console.WriteLine("Проверка клона:");
            try
            {
                Console.WriteLine("Какой элемент заменить?");
                int index = VvodIndexa();
                if (index >= klon.Length)
                {
                    throw new Exception("Неверный номер элемента");
                }
                int znachenie = VvodChisla();
                klon[index] = znachenie;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Write("Исходный вектор: " + ishodnuy + "\n");
            Console.WriteLine("Клонированный вектор: " + klon);

            if (klon.Equals(ishodnuy))
            {
                Console.WriteLine("Векторы равны!");
            }
            else
            {
                Console.WriteLine("Векторы не равны!");
            }
        }
        static void Exit()
        {
            return;
        }
        static void PrintInfo()
        {
            Console.WriteLine("Лабораторная работа №7\nВыполнила: Зиновьева Полина, студентка группы 6103-020302D");
            Console.WriteLine("Задания:\n1 - ArrayVector\n2 - LinkedListVector\n3 - Задания лабораторной №5\n0 - выход\nВведите траекторию выполнения программы.");
        }
        private static ArrayVector ReadVectorA()
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
        private static LinkListVector ReadVectorL()
        {
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
                return vector;
            }
            else
            {
                throw new Exception("Неверное значение!");
            }

        }
        private static int VvodChisla()
        {
            Console.Write("Введите целое число: ");
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }
        private static int VvodIndexa()
        {
            Console.Write("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index < 0)
            {
                throw new Exception("Error while executing program:\n" + "Введен отрицательный индекс! " + index);
            }
            return index;
        }
        public static void Print(IVectorable[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(i + " элемент: " + mass[i]);
            }
        }
    }

}
