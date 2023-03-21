#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>
#include<cmath>
#include <iomanip>
#include <windows.h>


//y = (-sin(3x)+e^3x - 3x + cos(3x))^0.5

double calc_cpp(double x)
{
    double f = pow( (-1 * sin(3 * x) + pow(M_E, 3 * x) - 3 * x + cos(3 * x) ), 0.5);
    return f;
}



//y = (-sin(3x)+e^3x - 3x + cos(3x))^0.5
double calc_asm(double x)
{
    double f;
    const int c3 = 3;
    __asm {               //st(0)             st(1)            st(2)  
        finit                                                                          //инициализация сопроцессора
        //-sin(3x)
        fld x               //x                                                        //st(0) = x
        fild c3             //3                 x                                      //st(0) = 3
        fmul                //3x                                                       //умножаем st(0) на st(1) = 3*x= 3x
        fsin              //sin(3x)                                                    //sin(st(0))
        fchs              //-sin(3x)                                                   //меняем знак у st(0)
        fstp f                                                                         //сохранение результата, запись st(0) в f
    
        //e^3x
        fld x               //x                                                        //st(0) = x
        fild c3             //3             x                                          //st(0) = 3
        fmul                //3x                                                       //умножаем st(0) на st(1)
        fldl2e             //log2(e)        3x                                         //st(0) = log2(e)
        fmul             //3x*log2(e)                                                  //умножаем st(0) на st(1)
        fld st(0)        //3x*log2(e)    3x*log2(e)                                    //st(0) = бывшее st(0)
        frndint         //[3x*log2(e)]   3x*log2(e)                                    //округляет к целому st(0)
        fsub st(1), st(0)//[3x*log2(e)]  {3x*log2(e)}                                  //к st(1) прибавляем st(0)
        fxch st(1)      //{3x*log2(e)}   [3x*log2(e)]                                  //меняем местами st(0) и st(1)
        f2xm1        //2^{3x*log2(e)}-1  [3x*log2(e)]                                  //st(0)=2 возводим в степень бывшее st(0) и вычитаем 1
        fld1             //1             2^{3x*log2(e)}-1      [3x*log2(e)]            //st(0) = 1
        fadd          //2^{3x*log2(e)}   [3x*log2(e)]                                  //к st(0) прибавляем st(1)
        fscale  //2^{3x*log2(e)} * 2^[3x*log2(e)] =  2^(3x*log2(e)) = e^3x             //умножаем ST(0) на 2 в степени ST(1)
        fld f            //-sin(3x)        e^3x                                        //st(0) = f
        fadd          //-sin(3x)+e^3x                                                  //прибавляем к st(0) st(1) 
        fstp f                                                                         //сохранение результата, запись st(0) в f
    
    
        //3x
        fld x                //x                                                       //st(0) = x
        fild c3              //3              x                                        //st(0) = 3
        fmul                 //3x                                                      //умножаем st(0) на st(1) = 3*x= 3x
        fld f              //-sin(3x)+e^3x    3x                                       //st(0) = f
        fsub st(0), st(1) //-sin(3x)+e^3x-3x  3x                                       //вычитаем из f 3x
        fstp f                                                                         //сохранение результата, запись st(0) в f
    
        //cos(3x)
        fld x                  //x                                                     //st(0) = x
        fild c3                //3             x                                       //st(0) = 3
        fmul                   //3x                                                    //умножаем st(0) на st(1) = 3*x= 3x
        fcos                 //cos(3x)                                                 //sin(st(0))
        fld f             //-sin(3x)+e^3x-3x  cos(3x)                                  //st(0) = f
        fadd st(0), st(1) //-sin(3x)+e^3x-3x+cos(3x)  cos(3x)                          //вычитаем из f 3x
        fstp f                                                                         //сохранение результата, запись st(0) в f
    
        //возведение в степень
        fld f         //-sin(3x)+e^3x-3x+cos(3x)
        fsqrt         //(-sin(3x)+e^3x-3x+cos(3x))^0,5                                 //корень квадратный из f
        fstp f
        
    }
    return f;
}


int main()
{
    setlocale(LC_ALL, "Russian");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    std::cout << "Лабораторная работа № 6. Выполнила студентка группы 6103-020302D Зиновьева Полина" << std::endl << "Вариант 55. y = (-sin(3x)+e^3x - 3x + cos(3x))^0.5    Диапазон [-5; 5]" << std::endl;
    double h;
    std::cout << "Введите шаг: ";
    std::cin >> h;
    
    try
    {
        if (h == 0)
        {
            std::cout << " Шаг 0. Будет выведено только одно значение!" << std::endl;
            h = 1000;
        }
        if (h < 0)
        {
            throw "Введен отрицательный шаг!";
        }
        double a = -5;
        double b = 5;
        int count = 0;
        std::cout << " №" << std::setw(20) << "x" << std::setw(20) << "f(x)(c++)" << std::setw(20) << "f(x)(asm)" << std::endl;
        for (double x = a; x <= b; x += h)
        {
            std::cout << count << std::setw(20) << x << std::setw(20) << calc_cpp(x) << std::setw(20) << calc_asm(x) << std::endl;
            count++;
        }
    }
    catch (const char* msg)
    {
        std::cout << msg << std::endl;
    }
}


