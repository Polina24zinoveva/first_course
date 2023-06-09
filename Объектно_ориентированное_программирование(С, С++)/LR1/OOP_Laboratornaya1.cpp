﻿#define _CRT_SECURE_NO_WARNINGS
#pragma once
#pragma 
#include <iostream>
#include <string.h>
#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>
#include "Sentence.h"
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    cout << "Лабораторная работа 1. Выполнила студентка группы 6103-020302D Зиновьева Полина" << endl;
    cout << "Задание: Ввести с клавиатуры произвольное абстрактное предложение длиной не более 80 символов, состоящее из абстрактных слов." << endl;
    cout << "Слова в предложении отделяются друг от друга как минимум одним символом 'пробел'. Предложение должно быть введено с помощью функции getchar()." << endl;
    cout << "Используя введённое предложение как исходное, построить новое предложение, в котором каждая буква исходного предложения аменена транскрипцией произношения этой буквы, заключённой в квадратные скобки." << endl;

    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    puts("Введите строку:");
    Sentence sentence(80);
    puts("Исходная строка:");
    sentence.OutputSentence(); // вывод начальной строки
    sentence.DevisionIntoWords();  // разбиение строки
    if (sentence.Length() > 0) {
        Sentence result = sentence.Transcription(); // транскрипция
        puts("Закодировання строка:");
        result.OutputSentence();// вывод результата
    }
    else {
        puts("Закодировання строка:\n");
    }
    system("pause");
    return 0;
}

//_getch() функция ждёт нажатия любой клавиши, и возвращает её код
//cgets Эти функции считывают строку символов из консоли и хранят строку и ее длину в расположении, указанном buffer
//get_s считывание строки с пробелами
//puts вывод строки
//malloc Функция malloc выделяет блок памяти, размером sizemem байт, и возвращает указатель на начало блока
//strtok Функции разбивает строку string на лексемы, которые представляют собой последовательности символов, разделенных символами разделителями.
//atrchr  Функция strchr выполняет поиск первого вхождения символа symbol в строку string
//strrev переворачивает строку
//strcpy Функция strcpy() используется для копирования содержимого str2 в str1.
//strcmp Сравнивает строки
//strncmp Функция сравнивает первые num символов строки string1 с первыми num символами строки string2
//strstr Функция ищет первое вхождение подстроки string2 в строке string1
//strcat объединение строк
//strspn Функция выполняет поиск символов строки string2 в строке string1
//strdup Функция strdup() путем обращения к функции malloc() выделяет память, достаточную для хранения дубликата строки, на которую указывает str, а затем производит копирование этой строки в выделенную область и возвращает указатель на нее.
//realloc Функция realloc() изменяет величину выделенной памяти, на которую указывает ptr, на новую величину, задаваемую параметром newsize
//int main()
//{
//	char c[] = "dhsj rrrr ssss";
//	cout << c << endl;
//	char* p = strtok(c, " ");
//	cout << p << endl;
//	cout << c << endl;
//}