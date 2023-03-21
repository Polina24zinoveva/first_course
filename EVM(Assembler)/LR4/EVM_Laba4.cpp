// подключаем необходимые библиотеки

#include <stdio.h> // стандартный ввод/вывод
#include <iostream> // потоковый ввод/вывод
#include <Windows.h>


double calc_cpp(double a, double b)
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

double calc_asm(double a, double b)
{
	double res; int status; const int c1 = 1; const int c5 = 5; const int c25 = -25;
	__asm {
		                       //st0  st1  st2  st3  st4
		finit                                                       //инициализация сопроцессора
		fld qword ptr[b]       //b                                  //загружаем вещественное число a
		fld qword ptr[a]	   //a	   b                            //загружаем вещественное число b
		fcom st(1)                                                  //сравнение st(0) и st(1) = сравниваем a и b
		fstsw status                                                //сохраняем регистр флагов сопроцессора
		mov ah, byte ptr[status + 1]                                //переопределяет тип данных на byte
		sahf                                                        //записываем в регистр флагов процессора
		ja a_bigger                                                 //переход если a больше
		jb b_bigger                                                 //переход если b больше
		// если равны
		fild c25	           //-25   a    b                       //st(0) = c25 = -25
		jmp	endcalc                                                 //переход в endcalc
	a_bigger : 
		ftst                                                         //сравнение a с 0
		fstsw status                                                 //сохраняем регистр флагов сопроцессора
		mov ah, byte ptr[status + 1]                                 //переопределяет тип данных на byte
		sahf                                                         //записываем в регистр флагов процессора
		je error                                                     //переход если a = 0
		fdivp st(1), st        //b/a                                 //деление st(1) на st(0)
		fild c1 	           //1     b/a                           //st(0) = c1
		faddp st(1), st        //b / a + 1                           //прибавляем st в st(1)
		jmp	endcalc
	b_bigger :
		fld st                 //a	    b                              //st(0) = a
		fmul st(1), st     	   //a	   a*a	  b                        //умножаем st(0) на st(1) = a * a 
		fmulp st(1), st	       //a*a*a	b                              //st(0) на st(1) = (a * a) * a
		fsub st, st(1)	      //a*a*a-b                                //st(0) = st(0)-st(1) = a*a*a-b  
		fild c5                //5    a*a*a-b                          //st(0) = c5 = 5
		fdivp st(1), st     //(a*a*a-b) / 5                            //st(0) = st(1) / st(0) = (a*a*a-b) / 5  
		jmp	endcalc                                                    //переход в endcalc
	error : fldz                                                       //формируем результат ошибки
	endcalc : fstp 	res                                                //сохранение результата
	}
	return res;
}

int main()
{
	setlocale(LC_ALL, "russian");
	std::cout << "тестовый пример";
	std::cout << "Лабораторная работа 4. Выполнила студентка группы 6103 Зиновьева Полина \nВариант 37. Задание:\n X = b / a + 1, если a > b\n X = -25, если a = b\n X = (a * a * a - b ) / 5, если a < b" << std::endl;// потоковый вывод
	double a, b;
	std::cout << "a = " << std::endl;// потоковый вывод
	std::cin >> a;// потоковый ввод
	std::cout << "b = " << std::endl;// потоковый вывод
	std::cin >> b;// потоковый ввод
	if (a > b && a == 0)
	{
		std::cout << "Error! Division by zero!" << std::endl;
	}
	else
	{
		double res = calc_asm(a, b);// вычисление выражения
		std::cout << "result asm: " << res << std::endl;// вывод результата вычисления выражения
		res = calc_cpp(a, b);// вычисление выражения
		std::cout << "result c++: " << res << std::endl;// вывод результата вычисления выражения
		//printf("result c++: %d\n", res);// вывод результата вычисления выражения
	}
	system("PAUSE");
	return 0;
}