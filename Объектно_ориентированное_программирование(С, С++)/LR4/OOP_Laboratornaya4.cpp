#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
#include <list>
#include <algorithm>
#include <limits>
#include <string.h>
#include <Windows.h>
using namespace std;
/*Написать программу управления информацией о сотрудниках и их должностях, состоящей из трех списков:
1)	Динамически формируемый список сотрудников, хранящий записи вида:
{<Фамилия И.О> - символьная строка; <Табельный номер сотрудника> - четырёхзначное целое число};
2)	Динамически формируемый список должностей, хранящий записи вида:
{<Наименование_должности> - символьная строка переменной (должности не повторяются);
<количество_мест> – положительное целое число;}
3)	Динамически формируемый список индексов формата:
{<индекс_записи_в_списке_сотрудников>;
<индекс_записи_в_списке_должностей>}.
Список индексных записей фиксирует принадлежность должностей сотрудникам. Сотрудник может занимать только одну должность.
Не занятые сотрудниками должностные места являются вакансиями для приема новых сотрудников.
Индекс записи в списке сотрудников – это порядковый номер записи.
Индекс записи в списке должностей – это указатель записи в списке.
Программа должна обеспечивать выполнение следующих функций:
1.	Добавление должности в список должностей.
2.	Удаление не занятой должности из списка должностей.
3.	Прием сотрудника на вакантную должность.
4.	Увольнение сотрудника.
5.	По указанному имени вывод на экран занимаемой должности.
6.	Вывод на экран штатного расписания (списка всех сотрудников с их должностями).
*/
class Employees
{
private:
	string fullName;                     //имя сотрудника
	unsigned int employeeNumber;         //табельный номер сотрудника

public:
	Employees(string name, unsigned int number)        //конструктор
	{
		fullName = name; // Имя сотрудника
		employeeNumber = number; // Номер сотрудника
	}
	string getFullName()                //метод, чтобы узнать имя сотрудника
	{
		return fullName;
	}
	unsigned int getEmployeeNumber()   //метод, чтобы узнать табельный номер сотрудника
	{
		return employeeNumber;
	}
};


class Job
{
private:
	string jobTitle;                // Название должности 
	unsigned int numberOfSeats;     // Число мест 
public:
	Job(string title, unsigned int number)  //конструктор
	{
		jobTitle = title;           
		numberOfSeats = number;
	}
	string getJobTitle()           //метод, чтобы узнать название должности
	{
		return jobTitle;
	}
	unsigned int getNumberOfSeats()  //метод, чтобы узнать число мест
	{
		return numberOfSeats;
	}
	void decEmployeeNumber()         //метод удаления места
	{
		numberOfSeats--;
	}
	void incEmployeeNumber()         //метод добавления места
	{
		numberOfSeats++;
	}
};


struct Index
{
	unsigned int ind_employee; // индекс записи в списке сотрудников
	Job* ind_job;              // индекс записи в списке должностей
};



class Zadanie
{
public:
void AddNewJob(list<Job*>* jobs)    // Добавление должности в список
{
	try
	{
		cout << "Введите название должности: ";                  //вывод на консоль
		string nameNewTitle;                                     //объявляем переменную nameNewTitle
		std::getline(std::cin >> std::ws, nameNewTitle);         //??????????????
		
		cout << "Введите количество мест на данную должность: "; //вывод на консоль
		unsigned int numberOfSeats;                              //объявляем переменную numberOfSeats
		cin >> numberOfSeats;                                    //считываем с кончоли в numberOfSeats
		//unsigned int i = 0;                                      //??????????????
		
		//непонятно сделано
		for (auto& element : *jobs)                              //auto позволяет не указывать тип переменной явно, говоря компилятору, чтобы он сам определил фактический тип переменной
		{
			if (element->getJobTitle() == nameNewTitle)          //если в классе Job уже есть такая должность
			{
				throw "Должность с таким названием уже существует!"; //выбрасывам исключение
			}
		}
		Job* newJob = new Job(nameNewTitle, numberOfSeats);      //создаем новую должность(экземпляр класса Job) с nameNewTitle, numberOfSeats
		jobs->push_back(newJob);                                 //Добавление элемента newJob в вектор jobs
	}

	catch (char const* e)                                        //ловим исключения
	{
		cout << e << endl;
	}

}
void EmptyJobs(list <Job*>* jobs, list <Index>* ind) // вывод не занятой должности из списка должностей.
{
	int count = 0;
	//bool Flag = false;                                   //          
	//unsigned long index = 0;							 //объявляем переменную index
	cout << "\nНе занятые должности:\n" ;
	for (auto& element : *jobs) 						 //для каждого элемента jobs
	{													 
		if (jobs->size() == 0) 							 //если длина списка jobs = 0
		{												 
			return;										 //выходим
		}												 				

		else if (element->getNumberOfSeats() != 0) 		 //если у элемента(должности) количество мест != 0
		{
			cout << element->getJobTitle() + "\n";	    //выводим название должнасти на консоль
			count++;
		}
	}
	if (count <= 0)
	{
		"Таких должностей нет";
	}
}

void DeleteJobs(list<Job*>* jobs, list <Index>* idx, list <Employees>* emp)  // Удаление должности из списка
{ 
	bool buloYdalenie = true;
	try
	{
		cout << "\nВведите название должности: ";
		string name;
		getline(cin >> ws, name);                //ввод нужной должности
		//bool flag = false;
		unsigned long i = 0;                 //индекс
		unsigned long ind_employeE = 0;
		unsigned long ij = 0;
		if (jobs->size() == 0)               //если должностей вообще нет
		{
			throw "Операция невозможна";
		}
		while (buloYdalenie == true)
		{
			unsigned long i = 0;
			for (auto& index : *idx)               //удаляем из индексного файла сотрудника, если он занимает должность, которую надо удалить
			{
				if (index.ind_job->getJobTitle() == name)
				{
					ind_employeE = index.ind_employee;
					//ind_joB = index.ind_job.;
					list<Index>::iterator range_begin = idx->begin();     //задаем текущий первый(range_begin) элемент
					list<Index>::iterator range_end = idx->begin();       //задаем текущий последний(range_end) элемент
					advance(range_begin, i);                              //перемещение range_begin на index - 1 (если удаляем 3 элемент, то ставим range_begin = 2, range_end = 3, и удаляем между ними)
					advance(range_end, i + 1);                            //перемещение range_end на index вперед
					idx->erase(range_begin, range_end);                   //удаление одного элемента из idx

					buloYdalenie = true;

					for (int j = 0; j < emp->size(); j++)     //удаляем из файла сотрудников сотрудника, если он занимает должность, которую надо удалить
					{
						if (j == ind_employeE)                                   //находим индекс сотрудника в индексном файле
						{
							list<Employees>::iterator range_begin = emp->begin(); //задаем текущий первый(range_begin) элемент
							list<Employees>::iterator range_end = emp->begin();   //задаем текущий последний(range_end) элемент
							advance(range_begin, i);                              //перемещение range_begin на index (если удаляем 3 элемент, то ставим range_begin = 3, range_end = 4, и удаляем между ними)
							advance(range_end, i + 1);                            //перемещение range_end на index + 1 вперед
							emp->erase(range_begin, range_end);                   //удаление одного элемента из emp
							break;
						}
					}

					break;
				}
				i++;
				buloYdalenie = false;
			}

			for (auto& index : *idx)               // если что меняем индексный файл
			{
				if (index.ind_employee > i)
				{
					index.ind_employee = i;
					i++;
				}
			}
		}
		for (auto& element : *jobs)             //удаляем из должность
		{
			if (element->getJobTitle() == name)
			{
				delete element;                                         //удаляем элемент
				list<Job*>::iterator range_begin = jobs->begin();       //задаем текущий первый(range_begin) элемент
				list<Job*>::iterator range_end = jobs->begin();         //задаем текущий последний(range_end) элемент
				advance(range_begin, ij);                            //перемещение range_begin на index (если удаляем 3 элемент, то ставим range_begin = 3, range_end = 4, и удаляем между ними)
				advance(range_end, ij + 1);                          //перемещение range_end на index + 1 вперед
				jobs->erase(range_begin, range_end);                    //удаление одного элемента из jobs
				cout << "Должность " << name << " удалена\n";
				break;
			}
			ij++;
		}

		
	}
	catch (char const* e)
	{
		cout << e << endl;
	}
}

bool VuvodFreeVacancies(list <Job*>* jobs, list <Index>* ind) // Вывод вакансий
{ // Вывод вакансий
	bool freeVacanciesEst = false;
	for (auto& element : *jobs)
	{
		if (element->getNumberOfSeats() != 0)
		{
			cout << element->getJobTitle() + "\n";
			freeVacanciesEst = true;
		}
	}
	return freeVacanciesEst;

}

void CheckJobList(list<Job*>* jobs, string jobname)        // Проверка должности на существование
{ 
	for (auto& element : *jobs) 
	{
		if (element->getJobTitle() == jobname)
			return;
	}
	throw "Такой должности нет. Сначала добавьте должность в список должностей";
}

void AddNewEmployeeInJob(list<Job*>* jobs, list <Index>* ind, list<Employees>* emp, string name, unsigned int number, string jobsname) 
{  // Приём сотрудника на вакантную должность

	if ((number < 1000) || (number > 9999))                                     //проверка четырехзначного номера
	{
		throw "Табельный номер сотрудника должен быть четырехзначным числом";
	}
	Employees newEmploee(name, number);                                         //создание нового работника                                     
	emp->push_back(newEmploee);                                                 //добавление нового работника в список сотрудников emp
	Index indexStrukt;                                                          //создаем структурк indexStrukt
	unsigned long i = 0;                                                        //i
	for (auto& element : *emp)                                                  //для каждого элемента emp(для каждого работника)
	{
		if (element.getFullName() == name)                                      //если имя работника = имени(которое передали из main)
		{
			indexStrukt.ind_employee = i;                                       //записываем в indexStrykt, что индекс нового работника в списке работников = pndex
			break;																//заканчиваем
		}
		i++;                                                                    //i++
	}
	for (auto& element : *jobs)                                                 //для каждой должности
	{
		if (element->getJobTitle() == jobsname)                                 //если имя должности = должности(которое передали из main)
		{
			indexStrukt.ind_job = element;                                      //У indexStrukt в поле ind_job добавляем element
			element->decEmployeeNumber();										//умешьшаем количество местр в должности
			break;																//заканчиваем
		}
	}
	ind->push_back(indexStrukt);                                                //добавляем indexStrukt в ind


}

void dismissalEmployee(list <Employees>* emp, list <Job*>* jobs, list <Index>* idx) // Увольнение сотрудника
{ 
	try
	{
		cout << "Введите имя сотрудника: ";
		string name;                                                     
		getline(cin >> ws, name);                    //считываем строку 
		unsigned long i = 0;                         
		for (auto& element : *emp) 
		{
			if (element.getFullName() == name)       //если имя сотрудника в списке всех сотрудников = имени сотрудника, которого надо уволить 
			{
				list<Employees>::iterator range_begin = emp->begin(); //задаем текущий первый(range_begin) элемент
				list<Employees>::iterator range_end = emp->begin();   //задаем текущий последний(range_end) элемент
				advance(range_begin, i);                              //перемещение range_begin на index (если удаляем 3 элемент, то ставим range_begin = 3, range_end = 4, и удаляем между ними)
				advance(range_end, i + 1);                            //перемещение range_end на index + 1 вперед
				emp->erase(range_begin, range_end);                   //удаление одного элемента из emp
				break;
			}
			i++;
		}
		//if (i == emp->size()) throw "Такого сотрудника нет";
		for (auto& index : *idx)
		{
			if (i == 0)
			{
				if (index.ind_employee == i)                          //находим индекс сотрудника в индексном файле
				{
					index.ind_job->incEmployeeNumber();                   //у этого сотрудника по индексному файле находим его работу и увеличиваем кол-во мест     
					list<Index>::iterator range_begin = idx->begin();     //задаем текущий первый(range_begin) элемент
					list<Index>::iterator range_end = idx->begin();       //задаем текущий последний(range_end) элемент
					advance(range_begin, i);                          //перемещение range_begin на index - 1 (если удаляем 3 элемент, то ставим range_begin = 2, range_end = 3, и удаляем между ними)
					advance(range_end, i + 1);                                //перемещение range_end на index вперед
					idx->erase(range_begin, range_end);                   //удаление одного элемента из idx
					break;
				}

			}
			else if (index.ind_employee == i - 1)                          //находим индекс сотрудника в индексном файле
			{
				index.ind_job->incEmployeeNumber();                   //у этого сотрудника по индексному файле находим его работу и увеличиваем кол-во мест     
				list<Index>::iterator range_begin = idx->begin();     //задаем текущий первый(range_begin) элемент
				list<Index>::iterator range_end = idx->begin();       //задаем текущий последний(range_end) элемент
				advance(range_begin, i);                          //перемещение range_begin на index - 1 (если удаляем 3 элемент, то ставим range_begin = 2, range_end = 3, и удаляем между ними)
				advance(range_end, i + 1);                                //перемещение range_end на index вперед
				idx->erase(range_begin, range_end);                   //удаление одного элемента из idx

				break;
			}
			//break;
		}
		for (auto& index : *idx)
		{
			if (index.ind_employee > i)
			{
				index.ind_employee = i;
				i++;
			}
		}
		cout << "Сотрудник " << name << " уволен\n";
	}

	catch (char const* e)
	{
		cout << e << endl;
	}

}

void employeePosition(list <Employees>* emp, list <Job*>* jobs, list <Index>* idx) // Вывод должности по имени 
{ 
	try
	{
		cout << "Введите имя сотрудника: ";
		string name;
		getline(cin >> ws, name);
		unsigned long i = 0;
		for (auto& element : *emp) 
		{                                             //узнаем какой по счету нужный сотрудник в списке сотрудников
			if (element.getFullName() == name) 
			{
				break;
			}
			i++;
		}
		if (i >= emp->size()) throw "Такого сотрудника нет";
		for (auto& index : *idx) 
		{                                             //берем в idx нужную(i-тую) структуру и по ней находим должность
			if (index.ind_employee == i) 
			{
				cout << "Должность: " + index.ind_job->getJobTitle() + "\n";
				break;
			}
		}
	}

	catch (char const* e)
	{
		cout << e << endl;
	}

}

void stafflist(list <Employees>* emp, list <Job*>* jobs, list <Index>* idx) // Вывод расписания
{ 
	try
	{
		unsigned long i = 0;
		if (emp->size() == 0) throw "Штатного расписания нет из-за отсутствия сотрудников";
		for (auto& element : *emp) 
		{
			cout << "Сотрудник: " + element.getFullName();
			for (auto& index : *idx) 
			{
				if (index.ind_employee == i) 
				{
					cout << "; Должность: " + index.ind_job->getJobTitle() + "\n";
				}
			}
			i++;
		}
	}

	catch (char const* e)
	{
		cout << e << endl;
	}
}



};

int main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	list<Employees> employee;
	list<Job*> jobs;
	list<Index> idx;
	int menu;

	while (true)
	{
		try
		{
			system("cls");
			cout << "Лабораторная работа № 4. Выполнила: Зиновьева Полина, студентка группы 6103-020302D";
			cout << "\nМеню\n";
			cout << "1.Добавление должности в список должностей\n";
			cout << "2.Удаление не занятой должности из списка должностей.\n";
			cout << "3.Прием сотрудника на вакантную должность.\n";
			cout << "4.Увольнение сотрудника.\n";
			cout << "5.По указанному имени вывод на экран занимаемой должности.\n";
			cout << "6.Вывод на экран штатного расписания(списка всех сотрудников с их должностями).\n";
			cout << "0.Выход\n";
			cout << "Ваш выбор: ";
			Zadanie zadanie;
			cin >> menu;
			switch (menu)
			{
			case 1:
			{
				cout << endl;
				zadanie.AddNewJob(&jobs);
				system("pause");
				break;
			}
			case 2:
			{
				cout << endl;
				zadanie.EmptyJobs(&jobs, &idx);
				zadanie.DeleteJobs(&jobs, &idx, &employee);
				system("pause");
				break;
			}
			case 3:
			{
				try
				{
					cout << endl;
					cout << "\nСвободные должности для нового сотрудника:\n";
					if (zadanie.VuvodFreeVacancies(&jobs, &idx) == false)
					{
						cout << "Свободных вакансий нет!\n";
						system("pause");
						break;
					}
					cout << "\nВыберите должность для нового сотрудника: ";
					string jobsname;
					std::getline(std::cin >> std::ws, jobsname);
					zadanie.CheckJobList(&jobs, jobsname);
					cout << "Введите имя нового сотрудника: ";
					string name;
					std::getline(std::cin >> std::ws, name);
					cout << "Введите табельный номер сотрудника (четырехзначное число): ";
					unsigned int number;
					cin >> number;
					zadanie.AddNewEmployeeInJob(&jobs, &idx, &employee, name, number, jobsname);
					system("pause");
					break;
				}
				catch (char const* e)
				{
					cout << e << endl;
					system("pause");
					break;
				}

			}
			case 4:
			{
				cout << endl;
				zadanie.dismissalEmployee(&employee, &jobs, &idx);
				system("pause");
				break;
			}
			case 5:
			{
				cout << endl;
				zadanie.employeePosition(&employee, &jobs, &idx);
				system("pause");
				break;
			}
			case 6:
			{
				cout << endl;
				zadanie.stafflist(&employee, &jobs, &idx);
				system("pause");
				break;
			}
			case 0:
				return 0;
			default:
				cout << "Такого пункта в меню нет! Попробуйте еще раз\n";
				system("pause");
				break;
			}
		}
		catch (...)
		{
			cout << "Ошибка!" << endl;
			system("pause");
		}

	}
}


