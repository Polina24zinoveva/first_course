#define _CRT_SECURE_NO_WARNINGS
#pragma once
#include <iostream>
#include <windows.h>
#include <stdio.h>
#include<locale>
#include <conio.h>
#include <stdlib.h>
using namespace std;

//Написать программу, которая поддерживает индексированный доступ к файлу, содержащему произвольные символьные строки, 
//заканчивающиеся <\n>. Программа должна обеспечивать выполнение следующих действий:
//1) формирование файла записей и создание по его завершению индексного файла с записями вида <unsigned long idx>,
//в котором индексы располагаются в порядке следования строк в исходном файле;
//2) на основе исходного и индексного файлов сформировать файл с указанным именем, содержащий те же записи, но в 
//обратном порядке.

class RecordFile
{
private:
	//char* filestring;   // набор записей
	FILE* file;           // ссылка на файл записей
	FILE* idxFile;        // ссылка на файл индексов
public:
	RecordFile(char* fileName)  // создание файла записей
	{
		char* filestring;                                       //набор записей
		int countString = 0;                                    //задаем счетчик строк
		file = fopen(fileName, "wt");                           //открываем файл на запись 
		filestring = (char*)malloc(sizeof(char) * 256);         //выделяем память на 256 символов
		unsigned long indexMass[256];                           //массив индексов на 256 эл-в (unsigned long представляет целое число в диапазоне от 0 до 4 294 967 295. Занимает в памяти 4 байта (32 бита))
		if (file == NULL)                                       //если файл пустой, то ошибка 
		{
			puts("Ошибка открытия файла ");
		}
		else                                                    //иначе файл не пустой
		{
			puts("Заполните файл:");                            //вывод на консоль
			int simvol = getchar();                             //puts ставит в конце '\n' и этой переменной мы его убираем
			while (gets_s(filestring, sizeof(char) * 256)[0] != '\0')
			{
				indexMass[countString] = ftell(file);           //записываем в ind позицию начала строчки(в файле все записано подряд и в indexMass мы записываем, indexMass[0] = 0(0 строчка начинается с 0символа), indexMass[1]= 13(1 строчка начинается с 13 символа))
				fputs(filestring, file);                        //добавляем в файл строку filestring
				fputc('\n', file);                              //добавляем в файл символ '\n'
				countString++;                                  //увеличиваем счетчик слов
			}
			free(filestring);                                   //освобождение памяти filestring
			fclose(file);                                       //закрываем файл
		}
		idxFile = fopen("indexFile.dat", "wb");                 //создаем и открываем двоичный файл для индексов для записи
		for (int i = 0; i < countString; i++)                   //i = 0, пока i < счетчик строк, i++
		{
			fwrite(&indexMass[i], sizeof(unsigned long), 1, idxFile); //записываем в файл индекс(indexMass[0] = 0(0 строчка начинается с 0символа), ind[1]= 13(1 строчка начинается с 13 символа))
		}
		fclose(idxFile);                                        //закрываем файл
	}


	void ResFile(char* fileName) // Создание результирующего файла
	{
		FILE* newFile = fopen("resultFile.txt", "wt");                   //открываем resultFile.txt файл на запись
		idxFile = fopen("indexFile.dat", "rb");                          //открываем двоичный файл indexFile.DAT файл на чтение
		file = fopen(fileName, "rt");                                    //открываем исходный файл на чтение
		unsigned long* indexMass = (unsigned long*)malloc(sizeof(unsigned long) * 256); //
		int index = 0;                                                   //index = 0 (будет считать кол-во строк)
		while (!feof(idxFile))                                           //пока не достигли конца файла????
		{
			fread(&indexMass[index], sizeof(unsigned long), 1, idxFile);  //считываем в indexMass[index], sizeof(unsigned long) число байт, объемом 1 объект, из idx_file 
			index++;
		}
		index--;                                                         //уменьшаем индекс (3 цикла while -> index = 3, а строк 2)
		fseek(file, 0, SEEK_END);                                        //перемещаем указатель в файле на 0 байт для смещения от SEEK_END(конца) 
		unsigned long endPosition = ftell(file);                         //end = текущее значение указателя 
		for (int i = index - 1; i >= 0; i--)                             //идем по всем индексам (i = index - 1, т.к. нумерация с 0)
		{
			char stroki[100];                                            //строка в которую записываются все предложения
			fseek(file, indexMass[i], SEEK_SET);                         //перемещаем указатель в файле, смещение = h[i] от начала файла
			if (i == index - 1)                                          //если 
			{
				fread(stroki, sizeof(char), endPosition - indexMass[i], file);	    //считываем в st, sizeof(char) число байт, объемом end - h[i] байт, из файла
			}
			else 														 //иначе
			{
				fread(stroki, sizeof(char), indexMass[i + 1] - indexMass[i], file); //считываем в st, sizeof(char) число байт, объемом h[i + 1] - h[i] байт, из файла
			}
			fputs(strtok(stroki, "\n"), newFile);	                     //strtok нужен, т.к. в stroki  записываются несколько эл-в, а остальные 100-несколько эл-в остаются
			fputc('\n', newFile);										 //записываем в файл символ "\n" в newFile
		}
		free(indexMass);												 //освобождение памяти indexMass
		fclose(file);													 //закрываем файл
		fclose(newFile);												 //закрываем newFile
		fclose(idxFile);												 //закрываем файл индексов
	}

	~RecordFile()
	{
		//free(filestring);
		fclose(file);
		fclose(idxFile);
	}
};

int main()
{
	setlocale(LC_ALL, "Russian");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	puts("Лабораторная работа №3\nВыполнила студентка группы 6103-020302D Зиновьева Полина");
	puts("Введите название файла: ");
	char* fileName = (char*)malloc(sizeof(char) * 15);
	scanf("%s", fileName);
	strcat(fileName, ".txt");
	RecordFile recfile(fileName);
	recfile.ResFile(fileName);
	puts("Файлы успешно созданы");
}




//fseek() устанавливает позицию в потоке данных, заданным аргументом stream
//ftell() возвращает текущее значение указателя положения в файле для указанного потока