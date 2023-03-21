#include <iostream>
#include <iomanip>
#include <windows.h>
using namespace std;

//y = ((-1)^(n-1) / (n * (n-1)) ) * x^n

double calc_cpp(double x, double N)
{
    double f = 0, res = 0;
    for (int n = 2; n <= N; n++)
    {
        f = ((pow(-1, n - 1)) / (n * (n - 1))) * pow(x, n);
        res += f;
    }
    return res;
}



double calc_asm(double x, int N)          
{
    int counter = 1;                                                                    //counter - счетчик циклов
    double res; const double c5 = -0.5; const int c1 = -1;
    __asm 
    {
                                    //st0         st1       st2         st3       st4
        mov ecx, N                                                                       //в ecx - счетчик N
        finit                                                                            //инициализация сопроцессора  

        fld qword ptr[x]             //x                                                 //st(0) = x
        fld c5                      //-0.5         x                                     //st(0) = c5 = -0.5
        fmul st(0), st(1)          //-0.5x         x                                     //умножаем st(0) на st(1) = -0.5 * x = -0.5x
        fmul st(0), st(1)         //-0.5x*x        x                                     //умножаем st(0) на st(1) = -0.5x * x = -0.5x*x
        fldz                      //sum = 0     -0.5x*x      x                           //st(0) = 0 (отвечает за сумму ряда)
        fld st(1)                //s=-0.5x*x     sum=0    -0.5x*x         x              //s = st(1) = -0.5x*x (s - значение очередного члена ряда) 
    calc : 
        fadd st(1), st(0)            //s         sum+s                                   //добавляем в сумму текущий элемент
        inc counter                                                                      //увеличиваем счётчик
        fld qword ptr[x]             //x           s        sum+s                        //st(0) = x
        fmul                        //s*x        sum+s                                   //умножаем st(0) на st(1) = s * x = s*x
        fild counter                 //n          s*x      sum+s                         //st(0) = counter
        fld1                         //1           n        s*x      sum+s               //st(0) = 1
        fsubp st(1), st(0)          //n-1         s*x      sum+s                         //вычитаем из st(1) st(0) и записываем в st(0) st(0) = st(1)-st(0) = n-1 
        fmul                     //s*x*(n-1)     sum+s                                   //умножаем st(0) на st(1) = s*x * (n-1) = s*x*(n-1)
        fild counter                 //n        s*x*(n-1)  sum+s                         //st(0) = n
        fld1                         //1          n       s*x*(n-1)   sum+s              //st(0) = 1
        fadd                        //1+n       s*x*(n-1)  sum+s                         //складываем st(0) и st(1) = n + 1
        fdivp st(1), st(0)  //(s*x*(n-1))/(n+1)   sum+s                                  //делим st(1) на st(0) и записываем в st(0)
        fchs               //-(s*x*(n-1))/(n+1)   sum+s                                  //меняем знак у st(0)

        cmp ecx, counter                                                                 //сравниваем N и counter на достижение количества членов
        jg calc                                                                          //переход на началo
    endcalc: fstp st(0)                                                                  //сброс с вершины стека текущего члена s
        fstp res                                                                         //сохранение результата sum
    }
    return res;
}



int main()
{
    setlocale(LC_ALL, "Russian");
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    std::cout << "Лабораторная работа № 8. Выполнила студентка группы 6103-020302D Зиновьева Полина" << std::endl << "Вариант 7.  Определить значениe некоторой элементарной функции (от 2 до бесконечности)" << endl << "y = ((-1)^(n-1) / (n * (n-1)) ) * x^n " << std::endl;
    double x;
    int N;
    cout << "Введите значение аргумента x: ";
    cin >> x;
    cout << "Введите максимальное количество членов ряда N: ";
    cin >> N;
    cout << endl;
    try
    {
        if (N > 0)
        {
            cout << "N" << setw(15) << "sum_asm" << setw(15) << "sum_cpp" << endl;
            for (int i = 2; i < 2 + N; i++)
            {
                cout << i - 1 << setw(15) << calc_asm(x, i) << setw(15) << calc_cpp(x, i) << endl;
            }
            cout << endl;
            cout << "Сумма ряда на с++ = " << calc_cpp(x, N + 1) << endl;
            cout << "Сумма ряда на ассемблере = " << calc_asm(x, N + 1);
            cout << endl;
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