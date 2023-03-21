﻿#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include <windows.h>
#include <stdio.h>
#include <conio.h>
using namespace std;


/*
   Написать программу, которая создаёт в текстовом режиме файл в текущем
   каталоге с именем, вводимым с клавиатуры, и заполняет его произвольными
   предложениями, которые также вводятся с клавиатуры. Слова в предложениях
   отделяются как минимум одним пробелом. После ввода последнего предложения
   файл закрывается. Построить в оперативной памяти массив записей (структур)
   вида <номер_предложения, количество_слов>, анализируя предложения файла.
   Отсортировать полученный массив по возрастанию значений поля
   "количество_слов". Результирующий массив вывести на экран. Для сортировки
   элементов массива использовать стандартную функцию в стиле языка С -qsort().
*/


struct Strings                          //структура записи предложений
{
	int numberString;                   //номер_предложения
	int counterWords;                   //количество_слов
};

int compare(const void* arg1, const void* arg2)     //сравнение 2х структур
{
	return(((Strings*)arg1)->counterWords - ((Strings*)arg2)->counterWords);
}
class TextFile
{

private:
	char* fileName;                 //строка - имя файла
	char* filestring;               //строка - набор записей (куча строчек)
	FILE* file;                     //ссылка на файл
	struct Strings* masStruct;      //массив структур
	int countStruct = 0;            //число структур
public:
	TextFile(char* fileName)        // создание файла записей
	{
		file = fopen(fileName, "wt");                    //file = открываем файл. Тип работы с файлом "wt"- открывает текстовый файл для записи.
		
		filestring = (char*)malloc(sizeof(char) * 256);  //выделяем память для filestring на 256 символов
		puts("Введите текст. Для окончания написания текста оставьте пустую строчку");      //вывод на консоль
		int c = getchar();                               //c считывает "\n", который добавляет puts
		while (gets_s(filestring, sizeof(char) * 256)[0] != '\0')  //пока 1 символ в строке != '\0'(т.е. не пустая строка)
		{
			fputs(filestring, file);                     //запись строки filestring в файл
			fputc('\n', file);                           //запись символа '\n' в файл
		}
		fclose(file);                                    //закрываем файл
	}

	void Set(char* fileName) // Формирование набора структур
	{
		int countWordsInThisStruct = 0;
		file = fopen(fileName, "rt");         //открываем файл. Тип работы с файлом "rt" - открывает текстовый файл для чтения.
		char* string = (char*)malloc(sizeof(char) * 256);  //выделяем память для filestring на 256 символов
		fgets(string, 256, file);

		while (string != NULL)
		{
			if (feof(file) != 0)              //если достигнут конец файла (feof проверяет, достигнут ли конец файла)
			{
				fclose(file);                 //закрываем файл        
				break;                        //выходим из цикла
			}	
			
			char* newString = _strdup(string);
			char* word = strtok(newString, " ");
			while (word != NULL)             //по словам
			{
				countWordsInThisStruct++;
				word = strtok(NULL, " ");
			}

			masStruct = (Strings*)realloc(masStruct, sizeof(Strings) * (countStruct + 1));    //увеличивваем память masStruct до sizeof(Strings*) * (countStruct + 1)
			masStruct[countStruct].numberString = countStruct + 1;                            //numberString у masStruct = countStruct + 1(чтоб начиналось с 1, а не с 0)
			masStruct[countStruct].counterWords = countWordsInThisStruct;                     //counterWords у masStruct = countWords
			countWordsInThisStruct = 0;
			countStruct++;
			fgets(string, 256, file);

		}
		fclose(file);                 //закрываем файл        
	}
	void Sort() // Сортировка набора структур
	{
		qsort(masStruct, countStruct, sizeof(Strings), compare); //Указатель на первый элемент сортируемого массива, Количество элементов в сортируемом массиве, Размер одного элемента массива в байтах, Функция, которая сравнивает два элемента
	}
	void OutPut() // Отображение массива структур
	{
		for (int index = 0; index < countStruct; index++)
		{
			printf("Номер предложения: %i  \t  Количество слов: %i\n", masStruct[index].numberString, masStruct[index].counterWords);
		}
	}
	~TextFile()// Деструктор
	{
		free(this->filestring);
		free(this->fileName);
	}
};



int main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	puts("Лабораторная работа №2\nВыполнила студентка группы 6103-020302D Зиновьева Полина");
	puts("Задание: Написать программу, которая создаёт в текстовом режиме файл в текущем каталоге с именем, вводимым с клавиатуры," 
		"и заполняет его произвольными предложениями, которые также вводятся с клавиатуры.Слова в предложениях отделяются как минимум"  
		"одним пробелом.После ввода последнего предложения файл закрывается.Построить в оперативной памяти массив записей(структур) вида" 
		"<номер_предложения, количество_слов>, анализируя предложения файла.Отсортировать полученный массив по возрастанию значений поля" 
		"'количество_слов'.Результирующий массив вывести на экран.Для сортировки элементов массива использовать стандартную функцию в" 
		"стиле языка С - qsort().");
	puts("Введите название файла: ");
	char* fileName = (char*)malloc(sizeof(char) * 15);  //выделение памяти для fileName
	scanf("%s", fileName);                              //считывание с консоли строку 
	strcat(fileName, ".txt");                           //объединение строки fileName со строкой ".txt"
	TextFile textfile(fileName);                        //создание нового экземпляра класса TextFile
	textfile.Set(fileName);
	textfile.Sort();
	textfile.OutPut();

}

// getchar - посимвольное считывание с консоли
// gets_s - построчное считывание с консоли
// fgetc - посимвольное считывание из файла
// fgets - построчное считывание из файла
// fputs - запись строки в файл
// fputc - запись символа в файл
// fopen() Функция fopen() открывает файл, имя которого указано аргументом fname, и возвращает свя­занный с ним указатель
// printf() Функция printf() записывает в stdout аргументы из списка arg-list под управлением строки, на которую указывает аргумент format.
// scanf() Функция scanf() является процедурой ввода общего назначения, считывающей данные из пото­ка stdin. 
// fprintf() Данные функции ведут себя так же, как и printf() и scanf(), за тем исключением, что работают с дисковыми файлами
// fscanf() Данные функции ведут себя так же, как и printf() и scanf(), за тем исключением, что работают с дисковыми файлами
// sprintf() Функция sprintf() идентична printf(), за исключением того, что вывод производится в массив
// qsort() Функция qsort() сортирует массив, на который указывает параметр base, используя quicksort
// lfind() Функции lfind() и lsearch() выполняют линейный поиск в массиве, на который указывает пара­метр base, и возвращают указатель на первый элемент, соответствующий ключу, на который ука­зывает параметр key
// lsearch() Функции lfind() и lsearch() выполняют линейный поиск в массиве, на который указывает пара­метр base, и возвращают указатель на первый элемент, соответствующий ключу, на который ука­зывает параметр key
// bsearch() Функция bsearch() выполняет двоичный поиск на отсортированном массиве, на который ука­зывает параметр base, и возвращает указатель на первое число, соответствующее ключу, на кото­рый указывает параметр key
// sscanf() Функция sscanf() идентична функции scanf() во всем, кроме того, что данные считываются из массива, указанного аргументом buf, а не из файла stdin
// feof() Функция feof проверяет, достигнут ли конец файла, связанного с потоком, через параметр filestream.Возвращается значение, отличное от нуля, если конец файла был действительно достигнут.
// ferror() Функция ferror() проверяет, имеются ли файловые ошибки в данном потоке stream. Возврат 0 означает отсутствие ошибок, а ненулевая величина указывает на наличие ошибки.
