using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OP_Laboratornaya6
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
            Console.WriteLine("Лабораторная работа №6\nВыполнила: Зиновьева Полина, студентка группы 6103-020302D");
            while (true)
            {
                Console.WriteLine("Выберете с чем работать:\n" +
                    "1 - Запись векторов в байтовый поток\n2 - Чтение векторов из байтового потока\n" +
                    "3 - Запись векторов в символьный поток\n4 - Чтение векторов из сивольного потока \n" +
                    "5 - Сериализация векторов\n0 - Выход\nВаш выбор: ");
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
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }
        static void Task1()
        {
            try
            {
                Console.WriteLine("Запись вектора в байтовый поток");
                IVectorable[] vectors = ReadMassVectors();
                try
                {
                    FileStream file1 = new FileStream("task.dat", FileMode.Append, FileAccess.Write); //Append - если файл существует, то текст добавляется в конец файл. Если файла нет, то он создается.Файл открывается только для записи. Write - Доступ для записи в файл (Create Если файл уже существует, он будет перезаписан.)
                    Vectors v = new Vectors();
                    v.OutputVector(vectors, file1);
                    file1.Close();
                    Console.WriteLine("Вектор записан в файл task.dat");
                }
                catch (IOException)
                {
                    Console.WriteLine("Ошибка ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ");
            }
        }
        static void Task2()
        {
            try
            {
                try
                {
                    using (FileStream file2 = new FileStream("task.dat", FileMode.Open, FileAccess.Read))
                    {
                        Vectors v = new Vectors();
                        IVectorable[] vectors = v.InputVector(file2);
                        Console.WriteLine("Чтение вектора с файла task.dat через байтовый поток");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
        static void Task3()
        {
            try
            {
                Console.WriteLine("Запись вектора в символьный поток");
                IVectorable[] vectors = ReadMassVectors();
                try
                {
                    StreamWriter file3 = new StreamWriter("task.txt");
                    Vectors v = new Vectors();
                    v.WriteVector(vectors, file3);
                    file3.Close();
                    Console.WriteLine("Вектор записан в файл task.txt");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
        static void Task4()
        {
            try
            {
                try
                {
                    using (StreamReader file4 = new StreamReader("task.txt"))
                    {
                        Vectors v = new Vectors();
                        IVectorable[] vectors = v.ReadVector(file4);
                        Console.WriteLine("Чтение вектора с файла task.txt через символьный поток");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
        static void Task5()   //сериализация - процесс передачи состояния объекта в поток байтовс целью сохранения его в памяти или др
        {
            try
            {
                Console.Write("Введите количество координат вектора: ");
                int razmer = Convert.ToInt32(Console.ReadLine());
                IVectorable vector1 = new ArrayVector(razmer);
                Console.WriteLine("Введите координаты вектора:");
                //int y = Console.CursorTop;            //Возвращает или задает позицию строки курсора в буферной области.
                //for (int i = 0; i < razmer; i++)
                //{
                //    Console.SetCursorPosition(4 * i, y);
                //    vector1[i] = Convert.ToInt32(Console.ReadLine());
                //}
                for (int i = 0; i < vector1.Length; i++)
                {
                    Console.Write("Введите " + i + " элемент: ");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    vector1[i] = chislo;
                }
                BinaryFormatter binFormat = new BinaryFormatter();     
                using (FileStream stream = new FileStream("task2.bin", FileMode.Create, FileAccess.Write))
                {
                    binFormat.Serialize(stream, vector1);
                }
                Console.WriteLine("Вектор сохранен в файл task2.bin с помощью метода сериализации");
                using (FileStream stream1 = new FileStream("task2.bin", FileMode.Open, FileAccess.Read))
                {
                    IVectorable vector2 = (IVectorable)binFormat.Deserialize(stream1);
                    Console.WriteLine();
                    Console.WriteLine("Прочитанный с потока вектор:");
                    Console.WriteLine(vector2.ToString());
                    Console.WriteLine("Исходный вектор: ");
                    Console.WriteLine(vector1.ToString());
                    if (vector2.Equals(vector1))
                    {
                        Console.WriteLine("Векторы равны!");
                    }
                    else
                    {
                        Console.WriteLine("Векторы не равны!");
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }

        private static IVectorable[] ReadMassVectors()
        {
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
            return mass;
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
