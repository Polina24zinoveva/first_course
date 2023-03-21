
#include <iostream>
#include <iostream>
#include <math.h>
#include<cmath>
#include <iomanip>

double calc_cpp(double e, int a, int b)
{
    double x = a;
    double f, f_, p = a;
    std::cout << " №" << std::setw(20) << "x" << std::setw(20) << "f(x)" << std::setw(20) << "f'(x)" << std::setw(20) << "Погрешность" << std::endl;
    int count = 1;
    while ((abs(p) > e) || (count == 1))
    {
        if (x < a || x > b)
        {
            throw "Нет корней на заданном промежутке";
        }
        f = 228 * pow(x, 10) + 3099 * pow(x, 8) + 1175 * pow(x, 5) + 2537 * pow(x, 3) - 4308;
        f_ = 2280 * pow(x, 9) + 3099 * 8 * pow(x, 7) + 1175 * 5 * pow(x, 4) + 2537 * 3 * pow(x, 2);
        if (f_ == 0)
        {
            throw "Производная = 0. Ошибка деление на 0";
        }
        p = f / f_;
        std::cout.precision(4);
        std::cout << count << std::setw(20) << x << std::setw(20) << f << std::setw(20) << f_ << std::setw(20) << abs(p) << std::endl;
        count++;
        x = x - p;     
    }
    return x+p;
}

double calc_asm(double e, int a, int b)
{
    double x = a; double p = a; int status; double exit1 = 0; double status1; int count = 1;
    double f_; const int c2280 = 2280; const int c24792 = 24792; const int c5875 = 5875; const int c7611 = 7611;
    double f; const int c228 = 228; const int c3099 = 3099; const int c1175 = 1175; const int c2537 = 2537; const int c4308 = 4308;
    std::cout << " №" << std::setw(20) << "x" << std::setw(20) << "f(x)" << std::setw(20) << "f'(x)" << std::setw(20) << "Погрешность" << std::endl;

    while((abs(p) > e) || (count == 1))
    {
        if (exit1 == 1)
        {
            throw "Нет корней на заданном промежутке";
        }
        __asm {
            //нахождение производной 
                                   //st0       st1       st2       st3       st4       st5     st6     st7
            finit                                                                                            //инициализация сопроцессора
            fld x                   //x                                                                        st(0) = x
            fld st(0)               //x        x                                                               st(0) = бывшее st(0) = x
            fmul st(0), st(1)     //x^2        x                                                               умножаем st(0) на st(1) = x*x = x^2
            fld st(0)             //x^2       x^2        x                                                     st(0) = бывшее st(0) = x^2
            fmul st(0), st(1)     //x^4       x^2        x                                                     умножаем st(0) на st(1) = x^2*x^2 = x^4
            fld st(0)             //x^4       x^4       x^2        x                                           st(0) = бывшее st(0) = x^4
            fmul st(0), st(2)     //x^6       x^4       x^2        x                                           умножаем st(0) на st(2) = x^4*x^2 = x^6
            fmul st(0), st(3)     //x^7       x^4       x^2        x                                           умножаем st(0) на st(3) = x^6*x = x^7
            fld st(0)             //x^7       x^7       x^4       x^2        x                                 st(0) = бывшее st(0) = x^7
            fmul st(0), st(3)     //x^9       x^7       x^4       x^2        x                                 умножаем st(0) на st(3) = x^7*x^2 = x^9

                                  //st(0)                         st(1)        st(2)    st(3)      st(4)     st(5)    st(6)     st(7)
            fild c2280            //2280                          x^9          x^7       x^4       x^2        x                                                  st(0)=c2280=2280
            fmul st(0), st(1)  //2280*x^9                         x^9          x^7       x^4       x^2        x                                                  умножаем st(0) на st(1) = 2280*x^9
            fild c24792          //24792                        2280*x^9       x^9       x^7       x^4       x^2        x                                        st(0)=c24792=24792
            fmul st(0), st(3) //24792*x^7                       2280*x^9       x^9       x^7       x^4       x^2        x                                        умножаем st(0) на st(3) = 24792*x^7
            fild c5875           //5875                        24792*x^7     2280*x^9    x^9       x^7       x^4       x^2        x                              st(0)=c5875=5875
            fmul st(0), st(5) //5875*x^4                       24792*x^7     2280*x^9    x^9       x^7       x^4       x^2        x                              умножаем st(0) на st(5) = 5875*x^4
            fadd st(0), st(1)//(5875*x^4+24792*x^7)            24792*x^7     2280*x^9    x^9       x^7       x^4       x^2        x                              st(0) = st(0) + st(1) = (5875*x^4+24792*x^7) 
            fadd st(0), st(2)//(5875*x^4+24792*x^7+2280*x^9)   24792*x^7     2280*x^9    x^9       x^7       x^4       x^2        x                              st(0) = st(0) + st(2) = (5875*x^4+24792*x^7+2280*x^9)
            fxch st(1)     //  24792*x^7      (5875*x^4+24792*x^7+2280*x^9)  2280*x^9    x^9       x^7       x^4       x^2        x                              меняем местами st(0) и st(1)
            fstp f_      //(5875*x^4+24792*x^7+2280*x^9)        2280*x^9       x^9       x^7       x^4       x^2        x                                        запись st(0) в f_
            fild c7611        //7611           (5875*x^4+24792*x^7+2280*x^9) 2280*x^9    x^9       x^7       x^4       x^2        x                              st(0)=c7611=7611
            fmul st(0), st(6)//7611*x^2        (5875*x^4+24792*x^7+2280*x^9) 2280*x^9    x^9       x^7       x^4       x^2        x                              умножаем st(0) на st(6) = 7611*x^2
            fadd st(0), st(1)//(7611*x^2+5875*x^4+24792*x^7+2280*x^9)  (5875*x^4+24792*x^7+2280*x^9)  2280*x^9    x^9       x^7       x^4       x^2        x     st(0) = st(0) + st(1) = (7611*x^2+5875*x^4+24792*x^7+2280*x^9)
            fstp f_           //запись st(0) в f_

            //проверка деления на 0
            ftst                                                         //сравнение st(0) с 0
            fstsw status                                                 //сохраняем регистр флагов сопроцессора
            mov ah, byte ptr[status + 1]                                 //переопределяет тип данных на byte
            sahf                                                         //записываем в регистр флагов процессора
            je div_null                                                  //переход если a = 0


            //нахождение функции
                                   //st0       st1       st2       st3       st4       st5     st6
            finit                                                                                        //инициализация сопроцессора
            fld x                   //x                                                                    st(0) = x                                           
            fild c4308              //4308      x                                                          st(0) = c4308 = 4308
            fld x                   //x        4308      x                                                 загружаем вещественное число x st(0) = x
            fmul st(0), st(2)       //x^2      4308      x                                                 умножаем st(0) на st(0) = x*x
            fld st(0)               //x^2       x^2      4308       x                                      st(0) = бывшее st(0) = x^2
            fmul st(0), st(3)       //x^3       x^2      4308       x                                      умножаем st(0) на st(3) = x^2*x = x^3
            fxch st(1)              //x^2       x^3      4308       x                                      меняем местами st(0) и st(1)
            fmul st(0), st(1)       //x^5       x^3      4308       x                                      умножаем st(0) на st(1) = x^2 * x^3 = x^5 
            fld st(0)               //x^5       x^5       x^3      4308      x                             st(0) = бывшее st(0) = x^5
            fmul st(0), st(2)       //x^8       x^5       x^3      4308      x                             умножаем st(0) на st(2) = x^2 * x^3 = x^5 
            fld st(0)               //x^8       x^8       x^5      x^3       4308     x                    st(0) = бывшее st(0) = x^8
            fmul st(0), st(5)       //x^9       x^8       x^5       x^3      4308      x                   умножаем st(0) на st(5) = x^8 *x = x^9 
            fmul st(0), st(5)      //x^10       x^8       x^5       x^3      4308      x                   умножаем st(0) на st(5) = x^9 * x = x^10 

                                      //st0               st1          st2       st3       st4       st5     st6      st7
            fild c228                 //288               x^10         x^8       x^5       x^3      4308       x             st(0) = c228 = 288 
            fmul st(0), st(1)      //288*x^10             x^10         x^8       x^5       x^3      4308       x             умножаем st(0) на st(1) = 288 * x^10
            fild c3099             //3099                288*x^10      x^10      x^8       x^5       x^3      4308      x    st(0) = c3099 = 3099 
            fmul st(0), st(3)   //3099*x^8               288*x^10      x^10      x^8       x^5       x^3      4308      x    умножаем st(0) на st(3) = 3099 * x^8
            fadd st(0), st(1) //(3099*x^8+288*x^10)      288*x^10      x^10      x^8       x^5       x^3      4308      x    сумма st(0) и st(1) = 3099*x^8+288*x^10 
            fxch st(1)          //288*x^10        (3099*x^8+288*x^10)  x^10      x^8       x^5       x^3      4308      x    меняем местами st(0) и st(1)
            fstp f          //(3099*x^8+288*x^10)          x^10        x^8       x^5       x^3      4308      x              запись st(0) в f

                                   //st0                            st1                st2      st3      st4      st5      st6      st7
            fild c1175             //1175                   (3099*x^8+288*x^10)        x^10     x^8      x^5      x^3      4308      x     st(0) = c1175 = 1175 
            fmul st(0), st(4)   //1175*x^5                  (3099*x^8+288*x^10)        x^10     x^8      x^5      x^3      4308      x      умножаем st(0) на st(4) = 1175 * x^5
            fadd st(0), st(1)//(1175*x^5+3099*x^8+288*x^10) (3099*x^8+288*x^10)        x^10     x^8      x^5      x^3      4308      x      сумма st(0) и st(1) = 1175*x^5+3099*x^8+288*x^10
            fxch st(1)        //(3099*x^8+288*x^10)      (1175*x^5+3099*x^8+288*x^10)  x^10     x^8      x^5      x^3      4308      x      меняем местами st(0) и st(1)
            fstp f          //(1175*x^5+3099*x^8+288*x^10)         x^10                x^8      x^5      x^3      4308      x               запись st(0) в f

                                 //st0                             st1                                   st2     st3    st4    st5     st6    st7                                                                          
            fild c2537           //2537                 (1175*x^5+3099*x^8+288*x^10)                     x^10    x^8    x^5    x^3    4308     x     st(0) = c2537 = c2537 
            fmul st(0), st(5)  //2537*x^3               (1175*x^5+3099*x^8+288*x^10)                     x^10    x^8    x^5    x^3    4308     x     умножаем st(4) на st(0) = 2537 * x^3
            fadd st(0), st(1) //(2537*x^3+1175*x^5+3099*x^8+288*x^10) (1175*x^5+3099*x^8+288*x^10)       x^10    x^8    x^5    x^3    4308     x     сумма st(0) и st(1) = 2537*x^3+1175*x^5+3099*x^8+288*x^10
            fsub st(0), st(6) //(2537*x^3+1175*x^5+3099*x^8+288*x^10-4308) (1175*x^5+3099*x^8+288*x^10)  x^10    x^8    x^5    x^3    4308     x     вычитание из st(0) st(1) = 2537*x^3+1175*x^5+3099*x^8+288*x^10-4308

            fstp f                                                       //запись st(0) в f


            ffree st(6)
            //вычисление x
            fld f                                                        //st(0) = f
            fld f_                                                       //st(0) = f_, st(1) = f
            fdivp st(1), st(0)                                           //st(0) = st(1) / st(0) = f / f_
            fst p                                                        //запись st(0) в p
            fld x                                                        //st(0) = x
            fsub st(0), st(1)                                            //st(0) = st(0) - st(1) = x - p
            fstp x                                                       //запись st(0) в x

            ffree st(6)
            //проверка вхождения корня в заданные границы
            fild a                                                       //st(0) = a
            fcomp st(1)	                                                 //сравнение st(0) и st(1), т.е. x с a
            fstsw status                                                 //сохраняем регистр флагов сопроцессора
            mov ah, byte ptr[status + 1]                                 //переопределяет тип данных на byte
            sahf                                                         //записываем в регистр флагов процессора
            ja exit_                                                     //переход если a если больше x

            fild b                                                       //st(0) = b    
            fcomp st(1)	                                                 //сравнение st(0) и st(1), т.е. x с b
            fstsw status                                                 //сохраняем регистр флагов сопроцессора
            mov ah, byte ptr[status + 1]                                 //переопределяет тип данных на byte
            sahf                                                         //записываем в регистр флагов процессора
            jb exit_                                                     //переход если b меньше x


            jmp endcalc                                                  //переход в метку endcalc


            div_null :                                                   //деление на ноль
            fld1                                                         //st(0) = 1
            fstp status1                                                 //status1 = st(0) = 1
            jmp endcalc                                                  //переход в метку endcalc
            exit_ :                                                      //выход за границы 
            fld1                                                         //st(0) = 1 
            fstp exit1                                                   //exit = st(0) = 1
            jmp endcalc                                                  //переход в метку endcalc
            endcalc :                                                    //конец цикла 
        }
        if (status1 == 1)
        {
            throw "Производная = 0. Ошибка деление на 0";
        }
        std::cout.precision(4);
        std::cout << count << std::setw(20) << x + p << std::setw(20) << f << std::setw(20) << f_ << std::setw(20) << abs(p) << std::endl;
        
        count++;
    }
    return x + p;
}



int main()
{
    std::cout << "Лабораторная работа № 5. Выполнила студентка группы 6103-020302D Зиновьева Полина" << std::endl << "Вариант 55. Задание 228x^10 + 3099x^8 + 1175x^5 + 2537x^3- 4308 = 0" << std::endl;
    int a, b;
    double e;
    std::cout << "Введите границы [a, b]:" << std::endl;
    std::cout << "Введите целое число a:" << std::endl;
    std::cin >> a;
    std::cout << "Введите целое число b:" << std::endl;
    std::cin >> b;
    std::cout << "Введите точность" << std::endl;
    std::cin >> e;
    try
    {
        std::cout << "Вычисление на C++:" << std::endl;
        std::cout << "Результат на С++: " << calc_cpp(e, a, b) << std::endl;
    }
    catch (const char* msg)
    {
        std::cout << msg << std::endl;
    }

    try
    {
        std::cout << "Вычисление на Asm:" << std::endl;
        std::cout << "Результат на Asm: " << calc_asm(e, a, b);
    }
    catch (const char* msg)
    {
        std::cout << msg << std::endl;
    }
}
    

