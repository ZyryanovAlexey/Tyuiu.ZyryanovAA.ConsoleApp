using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZyryanovAA.ConsoleApp.Lab2.V6.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab2.V6
{
    internal class Program 
    {

        static void Main(string[] args)
        {
            //Console.Title = "Лабораторная работа #2 | Выполнил: Зырянов А. А.| НТм-22-1";
            
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

            double x = 2;
            double y = 4;
         
            DataService ds = new DataService();

            double res = ds.SolveExpressV_6(x, y);
            double res1 = ds.SolveExpressV_6_1(x);

            res = Math.Round(res, 12);
            res1 = Math.Round(res1, 12);

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine(res);
            Console.WriteLine(res1);

            Console.ReadKey();
        }
    }
}
