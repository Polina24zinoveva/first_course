using System;

namespace OP_Ladoratornaya3
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
            Console.WriteLine("Лабораторная работа №3\nВыполнила: Зиновьева Полина, студентка группы 6103-020302D");
            
            Console.Write("Введите колличество сотрудников: ");
            int razmer = Convert.ToInt32(Console.ReadLine());
            if (razmer <= 0)
            {
                throw new ArgumentException("Неправильный размер!");

            }

            Employee[] employees = new Employee[razmer];
            for (int i = 0; i < razmer; )
            {
                try
                {
                    Console.WriteLine(i + 1 + " Работник:");
                    employees[i] = ReadEmployees();
                    i++;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

            while (true)
            {
                Console.WriteLine("Выберите задание: ");
                Console.WriteLine("1.Вывести информацию обо всех сотрудниках\n" + "2.Вывести информацию о сотрудниках заданной должности\n" +
                                  "3.Вывести информацию о менеджерах, зарплата которых больше средней зарплаты всех клерков\n" +
                                  "4.Вывести информацию о сотрудниках, принятых позже босса\n" + "0.Выход");
                Console.Write("Выбранное задание: ");
                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Все сотрудники:");
                        for (int i = 0; i < employees.Length; i++)
                        {
                            Console.WriteLine(employees[i]);
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Выберете должность: \n1 - Manager\n2 - Boss\n3 - Clerk\n4 - Salesman");
                            string a = Console.ReadLine();
                            if (a == "1")
                            {
                                Vacancies vacancies = Vacancies.Manager;
                                RequiredPosition(employees, vacancies);
                            }
                            else if (a == "2")
                            {
                                Vacancies vacancies = Vacancies.Boss;
                                RequiredPosition(employees, vacancies);
                            }
                            else if (a == "3")
                            {
                                Vacancies vacancies = Vacancies.Clerk;
                                RequiredPosition(employees, vacancies);
                            }
                            else if (a == "4")
                            {
                                Vacancies vacancies = Vacancies.Salesman;
                                RequiredPosition(employees, vacancies);
                            }
                            else
                            {
                                throw new Exception("Неверный символ!");
                            }
                            
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "3" :
                        try
                        {
                            int n = 0;
                            int count = 0;
                            double averageClerkSalary = AverageClerkSalary(employees);
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (Vacancies.Manager == employees[i].vacancies && employees[i].salary > averageClerkSalary)
                                {
                                    count++;
                                    n++;
                                }
                            }
                            Employee[] managers = new Employee[count];
                            n = 0;
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (Vacancies.Manager == employees[i].vacancies && employees[i].salary > averageClerkSalary)
                                {
                                    managers[n] = employees[i];
                                    n++;
                                }
                            }

                            if (n == 0)
                            {
                                Console.WriteLine("Нет менеджеров, зарплата которых больше средней зарплаты всех клерков");
                            }
                            else
                            {
                                for (int j = 0; j < managers.Length - 1; j++)
                                {
                                    for (int i = 0; i < managers.Length - j - 1; i++)
                                    {
                                        if (managers[i].name[0] > managers[i + 1].name[0])
                                        {
                                            Employee v = managers[i];
                                            managers[i] = managers[i + 1];
                                            managers[i + 1] = v;
                                        }
                                    }
                                }
                                Console.WriteLine("Менеджеры, зарплата которых больше средней зарплаты всех клерков:");
                                for (int i = 0; i < managers.Length; i++)
                                {
                                    Console.WriteLine(managers[i]);
                                }
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "4" :
                        DateTime data = new DateTime();
                        bool havingABoss = false;
                        for (int i = 0; i < employees.Length; i++)
                        {
                            if (employees[i].vacancies == Vacancies.Boss)
                            {
                                data = employees[i].hiredate;
                                havingABoss = true;
                            }
                            
                        }
                        if (havingABoss != true)
                        {
                            Console.WriteLine("Нет босса!");
                        }
                        else
                        {
                            int k = 0;
                            int countt = 0;
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i].hiredate > data)
                                {
                                    countt++;
                                    k++;
                                }
                            }
                            Employee[] newEmployee = new Employee[countt];
                            k = 0;
                            for (int i = 0; i < employees.Length; i++)
                            {
                                if (employees[i].hiredate > data)
                                {
                                    newEmployee[k] = employees[i];
                                    k++;
                                }
                            }
                            if (k == 0)
                            {
                                Console.WriteLine("Нет сотрудников, принятых позже босса");
                            }
                            else
                            {
                                for (int j = 0; j < newEmployee.Length - 1; j++)
                                {
                                    for (int i = 0; i < newEmployee.Length - j - 1; i++)
                                    {
                                        if (newEmployee[i].name[0] > newEmployee[i + 1].name[0])
                                        {
                                            Employee v = newEmployee[i];
                                            newEmployee[i] = newEmployee[i + 1];
                                            newEmployee[i + 1] = v;
                                        }
                                    }
                                }
                                Console.WriteLine("Сотрудники, принятые позже босса:");
                                for (int i = 0; i < newEmployee.Length; i++)
                                {
                                    Console.WriteLine(newEmployee[i]);
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
            
        }

        private static Employee ReadEmployees()
        {
            Console.Write("Введите фамилию сотрудника: ");
            string name = Console.ReadLine();
            
            Console.Write("Введите зарплату: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (salary < 0)
            {
                throw new Exception("Зарплата не может быть отрицательным числом!");
            }    
        
            Console.Write("Введите дату приёма на работу: ");
            DateTime hiredate = Convert.ToDateTime(Console.ReadLine());
            DateTime min = new DateTime(1922,01,01);
            if ((hiredate < min) || (hiredate > DateTime.Today))
            {
                throw new Exception("Неверная дата!");
            }

            Console.WriteLine("Выберете должность: \n1 - Manager\n2 - Boss\n3 - Clerk\n4 - Salesman");
            Console.Write("Выбранный пункт: ");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Vacancies vacancies = Vacancies.Manager; 
                Employee employee = new Employee(name, vacancies, salary, hiredate);
                return employee;
            }
            else if (a == "2")
            {
                Vacancies vacancies = Vacancies.Boss; 
                Employee employee = new Employee(name, vacancies, salary, hiredate);
                return employee;
            }
            else if (a == "3")
            {
                Vacancies vacancies = Vacancies.Clerk; 
                Employee employee = new Employee(name, vacancies, salary, hiredate);
                return employee;
            }
            else if (a == "4")
            {
                Vacancies vacancies = Vacancies.Salesman;
                Employee employee = new Employee(name, vacancies, salary, hiredate);
                return employee;
            }
            else
            {
                throw new Exception("Неверный символ!");
            }
        }

        private static void RequiredPosition(Employee[] employees, Vacancies vacancies)
        {
            bool nalichieCotrudnika = false;
            for (int i = 0; i < employees.Length; i++)
            {
                if (vacancies == employees[i].vacancies)
                {
                    Console.WriteLine(employees[i]);
                    nalichieCotrudnika = true;
                }
            }
            if (nalichieCotrudnika == false)
            {
                Console.WriteLine("Таких сотрудников нет");
            }
        }

        private static double AverageClerkSalary(Employee[] employees)
        {
            double sum = 0;
            double count = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].vacancies == Vacancies.Clerk)
                {
                    sum += employees[i].salary;
                    count++;
                }
                
            }
            if (count == 0)
            {
                throw new Exception("Клерков нет!");
            }
            else
            {
                double result = sum / count;
                return result;
            }
            
        }
    }
}
