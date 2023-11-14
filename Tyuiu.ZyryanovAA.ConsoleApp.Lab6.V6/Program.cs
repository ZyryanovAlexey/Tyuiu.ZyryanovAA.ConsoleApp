﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZyryanovAA.ConsoleApp.Lab6.V6.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = -5;

            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------------------+");

            for (int i = 0; i <= len - 1; i++)
            
                {
             Console.WriteLine("|   {0,3:d}    | {1, 8:f2}  |", startValue, valueArray[i]);
             startValue++;
                }

            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}