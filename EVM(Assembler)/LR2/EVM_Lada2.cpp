// подключаем необходимые библиотеки

#include <stdio.h> // стандартный ввод/вывод
#include <iostream> // потоковый ввод/вывод
#include <Windows.h>


int calc_cpp(int a, int b)
{
	if (a > b)
	{
		return b / a + 1;
	}
	else if (a == b)
	{
		return -25;
	}
	else if (a < b)
	{
		return (a * a * a - b) / 5;
	}
}

int calc_asm(int a, int b)
{
	__asm {
		mov ecx, a  //ecx = a
		mov ebx, b  //ebx = b
		cmp	ecx, ebx  //сравнение a и b
		jg	l_bigger  //переход если a > b
		jl	l_smaller  //переход если a < b
		mov	eax, -25  // eax = 25
		jmp	exit_1  //переход на конец программы
	l_bigger :
		mov eax, b  //eax = b
		mov ebx, a  //ebx = a
		//готовимся к делению
		cdq  //расширили  eax
		idiv ebx  // eax = eax / ebx = b / a
		inc eax  //eax + 1
		jmp exit_1  //переход на конец программы
		l_smaller :
	mov eax, a  //eax = a
		mov ebx, a  //ebx = a
		imul ebx //<edx:eax> = a*a
		imul ebx //<edx:eax> = a * a * a
		mov ebx, b  //ebx = b
		sub eax, ebx  //pow(a, 3) - b
		mov ebx, 5  //ebx = 5
		//готовимся к делению
		cdq  //расширили  eax
		idiv ebx  // eax = eax / ebx = pow(a, 3) - b / 5
		jmp exit_1  //переход на конец программы
	exit_1 :
	}
}

int main()
{
	setlocale(LC_ALL, "russian");
	std::cout << "тестовый пример";
	std::cout << "Лабораторная работа 2. Выполнила студентка группы 6103 Зиновьева Полина \nВариант 37. Задание:\n X = b / a + 1, если a > b\n X = -25, если a = b\n X = (a * a * a - b ) / 5, если a < b" << std::endl;// потоковый вывод
	int a, b;
	std::cout << "a = " << std::endl;// потоковый вывод
	std::cin >> a;// потоковый ввод
	printf("b = \n");// стандартный вывод
	scanf_s("%d", &b);// стандартный ввод
	if (a > b && a == 0)
	{
		std::cout << "Error! Division by zero!" << std::endl;
	}
	else
	{
		
		int res = calc_asm(a, b);// вычисление выражения
		printf("result asm: %d\n", res);// вывод результата вычисления выражения
		res = calc_cpp(a, b);// вычисление выражения
		printf("result c++: %d\n", res);// вывод результата вычисления выражения
	}
	system("PAUSE");
	return 0;
}