#define _CRT_SECURE_NO_WARNINGS
#pragma once
#include <iostream>
#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>

using namespace std;

class Sentence
{
private:
	char* sentence; //строка
	char** arrayWords; //массив слов в строке
	int wordCount = 0;   //счетчик слов в строке
	const char* transcription[9] = { "[аа]","[бэ]","[вэ]","[гэ]","[дэ]","[йэ]","[жэ]","[зэ]", "[??]" };// транскрипция
public:
	int Length() 
	{ 
		return this->wordCount;                      //возвращаем wordCount у этого экземпляра класса
	}                               
	Sentence()       //конструктор без параметров
	{
		sentence = (char*)malloc(sizeof(char));  //(char*)то к какому типу приводим, malloc выделяем память для sentence в (размер одного символа) байт
		arrayWords = (char**)malloc(0);          //выделяем память для ArrayWords в 0 байт      
		*(this->sentence) = '\0';                //в sentence только '\0'
		this->wordCount = 0;                     //wordCount = 0             
	}


	Sentence(int dlina)  //конструктор с параметрами
	{
		sentence = (char*)malloc(sizeof(char) * (dlina + 1));  //выделяем память на нужное кол-во символов
		int counter = 0;                                       //счётчик = 0
		char simvol = (char)getchar();                         //считываем 1 символ
		while ((simvol != '\n') && (counter < dlina))          //ввод строки
		{
			sentence[counter] = simvol;                        //записываем в строку "sentence" символ
			counter++;                                         //увеличиваем счётчик
			simvol = (char)getchar();                          //cчитываем следующий символ
		}
		sentence[counter] = '\0';                              //заканчиваем строку терминальным 0
		arrayWords = (char**)malloc(0);                        //выделяем память для ArrayWords в 0 байт
	}

	void DevisionIntoWords()         //разбиение строки на слова
	{
		char* newString = _strdup(sentence);                             //копируем в newString sentence(необходима, т.к. функция strtok обрезает исходную строчку
		//char* newString = (char*)malloc(strlen(sentence));             //создаем новую строку newString и выделяем ей память
		//strcpy(newString, sentence);                                   //копируем в newString sentence
																      
		char* word = strtok(newString, " ");                           //word = newString поделенная по разделителю " "
		while (word != NULL)                                           //проход по всем словам
		{
			arrayWords = (char**)realloc(arrayWords, sizeof(char*) * (wordCount + 1));  //изменяем величину выделенной памяти в arrayWords
			arrayWords[wordCount] = word;                              //записываем в массив слов(arrayWords) слово(word) под указанным индексом wordCount
			wordCount++;                                               //увеличиваем счетчик слов
			word = strtok(NULL, " ");                                  //функция запускается с места последнего успешного запуска => word = следущее слово
		}
	}


	Sentence& Transcription()
	{
		Sentence* newSentence = (Sentence*)malloc(sizeof(Sentence));                            //создаем новую строку newSentence и выделяем ей память
		newSentence->wordCount = wordCount;                                                     //wordCount у newSentence = wordCount(59)
		newSentence->arrayWords = (char**)malloc(sizeof(char*) * wordCount);                    //выделяем память для ArrayWords
		newSentence->sentence = (char*)malloc(sizeof(char) * (strlen(sentence) + 1) * 4);             //выделяем память для sentence в 4 раза больше изначального предложения
		*(newSentence->sentence) = '\0';                                                        //sentence у newSentence = '\0'
		for (int i = 0; i < newSentence->wordCount; i++)                                        //проход по каждоve слову
		{
			char simvol;                                                                        //объявление переменной simvol
			int j = 0;                                                                          //счетчик букв в слове
			char* newWord = (char*)malloc(sizeof(char) * (strlen(arrayWords[i]) + 1) * 4);      //выделяем память для нового слова (word)в 4араза больше изначального слова
			newWord[0] = '\0';                                                                  //новое слово = '\0'
			while ((simvol = arrayWords[i][j]) != '\0') // кодировка символа
			{
				int codeOfAscii = (int)simvol;                                                  //узнаем код Ascii символа
				if ((codeOfAscii > -33) && (codeOfAscii < -24))                                 //проверка на нужный символ
				{
					strcat(newWord, transcription[codeOfAscii + 32]);                           //добавляем в новое слово соответствующий закодированный символ
				}
				else
				{
					strcat(newWord, transcription[8]);                                          //добавляем в новое слово закодированный символ
				}
				j++;                                                                            //увеличиваем счетчик букв

			}
			newSentence->arrayWords[i] = newWord;                             //записываем закодированное слово(newWord) в массив слов(arrayWords)
			strcat(newSentence->sentence, newSentence->arrayWords[i]);        //добавляем в новое предложение(newSentence) слово из массива слов
			strcat(newSentence->sentence, " ");                               //добавляем в новое предложение пробел
			free(newWord);                                                    //освобождаем память
		}
		return *newSentence;                                                  //возвращаем новое предложение

	}
	void PrintRazmerPamyaty()
	{
		cout << sizeof(char) * (strlen(sentence) + 1) << endl;
	}

	void OutputSentence()  //метод вывода строки на консоль
	{
		puts(this->sentence);
	}
	~Sentence()          //деструктор
	{
		free(sentence);
		free(arrayWords);
	}

};

