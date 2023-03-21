// подключаем необходимые библиотеки

#include <stdio.h> // стандартный ввод/вывод
#include <iostream> // потоковый ввод/вывод
#include <Windows.h>

//Задание: В одномерном массиве A={a[i]} целых чисел вычислить произведение четных элементов.

int calc_cpp(int mass[], int size)
{
	int result = 1;
	for (int i = 0; i < size; i++)
	{
		if (mass[i] % 2 == 0)
		{
			result *= mass[i];
		}
	}
	return result;
}

int calc_asm(int mass[], int sizee)
{
	int result = 1;
	__asm {
		xor esi, esi  //подготовим регистр индекса в массиве
		mov edi, result  //счётчик произведения элементов
		mov	ebx, mass  //ebx указывает на начало массива
		mov ecx, sizee  //счётчик цикла по всем элементам массива
		jcxz exit_1  //завершить если длина массива 0
	begin_loop:  //цикл
		mov	eax, [ebx + esi * 4] // определяем текущий элемент   (достать число из массива)(*4 потому что в ячейке 32 бита = 4 байта)
		test eax, 1  //проверка числа на четность
		jnp end_loop  //если не четно, то переходим в end_loop
		mov edx, eax
		mov eax, edi
		imul edx  // если четно, то edi = edi * eax
		mov edi, eax
		mov eax, edx
	end_loop :
		inc	esi //переходим к следующему элементу
		loop begin_loop  //повторяем цикл для всех элементов массива
	exit_1:
		mov result, edi  //возвращаем произведение
	}
	return result;
}


int main()
{
	setlocale(LC_ALL, "russian");
	std::cout << "Лабораторная работа 3. Выполнила студентка группы 6103 Зиновьева Полина \nВариант 37. Задание:\n В одномерном массиве A={a[i]} целых чисел вычислить произведение четных элементов." << std::endl;// потоковый вывод
	int size;
	std::cout << "Введите размер массива: "; // потоковый вывод
	std::cin >> size;
	if (size <= 0)
	{
		std::cout << "Error! Wrong length!" << std::endl;
	}
	else
	{
		int* mass = new int[size];
		for (int i = 0; i < size; i++)
		{
			int chislo;
			std::cout << "Введите " << i << "число: "; // потоковый вывод
			std::cin >> chislo;
			mass[i] = chislo;
		}
		int res = calc_asm(mass, size);// вычисление выражения
		printf("result asm: %d\n", res);// вывод результата вычисления выражения
		res = calc_cpp(mass, size);// вычисление выражения
		printf("result c++: %d\n", res);// вывод результата вычисления выражения
		//delete mass;
		system("PAUSE");
		return 0;
	}
}