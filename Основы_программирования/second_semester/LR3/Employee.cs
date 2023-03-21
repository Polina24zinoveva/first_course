using System;
using System.Collections.Generic;
using System.Text;

namespace OP_Ladoratornaya3
{
    enum Vacancies
    {
        Manager,   //менеджер
        Boss,      //босс
        Clerk,     //клерк
        Salesman   //продавец
    }
    struct Employee
    {
        public string name;                //имя
        public Vacancies vacancies;        //вакансия
        public int salary;                 //зарплата
        public DateTime hiredate;          //дата приема на работу
        
        public Employee(string name, Vacancies vacancies, int salary, DateTime hiredate)
        {
            this.name = name;
            this.vacancies = vacancies;
            this.salary = salary;
            this.hiredate = hiredate;
        }

        public override string ToString()
        {
            return "Сотрудник: " + name + "\nДолжность: " + vacancies + "\nЗарплата: " + salary + "\nДата приема на работу: " + hiredate.ToShortDateString();
        }
    }
}
