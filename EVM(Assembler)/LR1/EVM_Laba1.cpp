// подключаем необходимые библиотеки

#include <stdio.h> // стандартный ввод/вывод
#include <iostream> // потоковый ввод/вывод
#include <Windows.h>
// функция вычисления выражения (21 - a*c/4)/(1 +c/a + b);


int calc_cpp(int a, int b, int c) 
{
	return (21 - a * c / 4) / (1 + c / a + b);
}

int calc_asm(int a, int b, int c)
{
	int result = 0;
	__asm {
		mov	eax, c
		mov ebx, a
		cdq
		idiv ebx // eax=eax/ebx=c/a
		inc eax  // 1 + c / a
		mov ebx, b
		add eax, ebx //1 + c / a + b
		push eax //в стеке 1 + c / a + b

		mov eax, a //< eax >= a
		mov ecx, c
		imul ecx // a * c
		//готовимся к делению
		mov ebx, 4
		cdq //==> edx:eax
		idiv ebx// a* c / 4
		mov ebx, 21 // ebx = 21
		sub ebx, eax //21 - a * c / 4
		mov eax, ebx

		//готовимся к делению
		pop ebx// < ebx >= 1 + c / a + b
		cdq; //eax ==> < edx:eax >= 21 - a * c / 4
		idiv ebx //(21 - a * c / 4) / (1 + c / a + b);
		mov result, eax//result = eax
	}
	return result;
}

int main()
{
	setlocale(LC_ALL, "russian");
	std::cout << "тестовый пример";
	std::cout << "Лабораторная работа 1. Выполнила студентка группы 6103 Зиновьева Полина \n Задание: (21 - a*c/4)/(1 +c/a + b) " << std::endl;// потоковый вывод
	int a, b, c;
	std::cout << "a = " << std::endl;// потоковый вывод
	std::cin >> a;// потоковый ввод
	printf("b = \n");// стандартный вывод
	scanf_s("%d", &b);// стандартный ввод
	std::cout << "c = " << std::endl;
	std::cin >> c;
	if (a != 0 && (1 + c / a + b) != 0)
	{
		int res = calc_asm(a, b, c);// вычисление выражения
		printf("result asm: %d\n", res);// вывод результата вычисления выражения
		res = calc_cpp(a, b, c);// вычисление выражения
		printf("result c++: %d\n", res);// вывод результата вычисления выражения
	}
	else 
	{
		std::cout << "Error! Division by zero!" << std::endl;
	}
	system("PAUSE");
	return 0;
}