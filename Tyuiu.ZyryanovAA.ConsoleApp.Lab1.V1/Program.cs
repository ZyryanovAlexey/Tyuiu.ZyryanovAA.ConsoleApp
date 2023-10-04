using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.Title = "Лабораторная работа #1 | Выполнил: Зырянов А. А.| НТм-22-1";
            //
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #1                                                  *");
            Console.WriteLine("* Тема: Расчеты арифметических и математических выражений C#              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Зырянов А. А.|НТм-22-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double res = ds.SolveExpressV_1_1(x, y, a);
            double res1 = ds.SolveExpressV_1_2(x, y, a);
            double res2 = ds.SolveExpressV_6_1(x, y, a);
            double res3 = ds.SolveExpressV_6_2(x, y, a);

            res = Math.Round(res, 12);
            res1 = Math.Round(res1, 12);
            res2 = Math.Round(res2, 12);
            res3 = Math.Round(res3, 12);

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);

            Console.ReadKey();
        }
    }
}
