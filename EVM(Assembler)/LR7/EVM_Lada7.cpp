#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>
#include<cmath>
#include <iomanip>
#include <windows.h>
using namespace std;

//(от -2 до 1) f(x)= 1 / sqrt(x+3) + sqrt((x+3)^2)

double FCplus(double x)
{ 
    return 1 / (sqrt(x + 3) + sqrt(pow((x + 3), 2)));
}

//(от -2 до 1) f(x)= 1 / sqrt(x+3) + sqrt((x+3)^2)

double FAsm(double x)
{
    double f;
    const int c1 = 1;
    const int c3 = 3;
    __asm {               //st(0)             st(1)            st(2)  
        finit                                                                          //инициализация сопроцессора

        fild c3             //3                                                        //st(0) = 3
        fld x               //x                 3                                      //st(0) = x
        fadd                //x + 3                                                    //складываем st(0) и st(1)
        fsqrt             //sqrt(x+3)                                                  //корень квадратный из st(0)
        fstp f                                                                         //сохранение результата, запись st(0) в f

        fild c3             //3                                                        //st(0) = 3
        fld x               //x                 3                                      //st(0) = x
        fadd                //x + 3                                                    //складываем st(0) и st(1)
        fld st(0)           //x + 3           x + 3                                    //st(0) = бывшее st(0) = x + 3
        fmul              //(x + 3) ^ 2                                                //умножаем st(0) на st(1)
        fsqrt             //sqrt((x + 3) ^ 2)                                          //корень квадратный из st(0)
        
        fld f            //sqrt(x+3)      sqrt((x + 3) ^ 2)                            //st(0) = f
        fadd             //sqrt(x+3)+sqrt((x + 3) ^ 2)                                 //складываем st(0) и st(1)

        fild c1          //1            sqrt(x+3)+sqrt((x + 3) ^ 2)                    //st(0) = 1
        fdiv st(0), st(1) //1/sqrt(x+3)+sqrt((x + 3) ^ 2)                              //деление st(0) на st(1)
        fstp f                                                                         //сохранение результата, запись st(0) в f
    }
    return f;
}


int main()
{
    setlocale(LC_ALL, "Russian");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    std::cout << "Лабораторная работа № 7. Выполнила студентка группы 6103-020302D Зиновьева Полина" << std::endl << "Вариант 55. Вычислить определённый интеграл (от -2 до 1) f(x)= 1 / sqrt(x+3) + sqrt(x+3)^2" << std::endl;
    double a = -2; double b = 1;
    int n;
    cout << "Введите чётное число интервалов: ";
    cin >> n;
    cout << endl;
    try
    {
        if (n > 0 && n % 2 == 0)
        {
            double h = (b - a) / n;
            cout << "Шаг интегрирования: " << h << endl;
            cout << "№" << setw(20) << "x" << setw(20) << "f(x)(с++)" << setw(20) << "f(x)(asm)" <<  endl;
            double sumC = 0;
            double sumA = 0;
            int k;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    k = 1;
                    sumC += k * FCplus(a + i * h);
                    sumA += k * FAsm(a + i * h);
                    cout << i << setw(20) << (a + i * h) << setw(20) << FCplus(a + i * h) << setw(20) << FAsm(a + i * h) << endl;
                }
                else
                {
                    k = 2 + 2 * (i % 2);
                    sumC += k * FCplus(a + i * h);
                    sumA += k * FAsm(a + i * h);
                    cout << i << setw(20) << (a + i * h) << setw(20) << FCplus(a + i * h) << setw(20) << FAsm(a + i * h) <<  endl;
                }

            }
            sumC = sumC * h / 3;
            sumA = sumA * h / 3;
            cout << "Ответ  на с++: " << sumC << endl;
            cout << "Ответ: на Ассемблере: " << sumC << endl;
        }
        else
        {
            throw ("Неправильное число!");
        }
    }
    catch (const char* msg)
    {
        std::cout << msg << std::endl;
    }
    system("PAUSE");
}