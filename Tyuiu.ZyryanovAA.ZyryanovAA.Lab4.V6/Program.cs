﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZyryanovAA.ConsoleApp.Lab4.V6.Lib;

namespace Tyuiu.ZyryanovAA.ZyryanovAA.Lab4.V6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool res;
            double x;
            double y;
            Console.WriteLine("Введите значения переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения переменной y: ");
            y = Convert.ToDouble(Console.ReadLine());

            res = ds.GetPointShape(x, y);
            if (res)
            {
                Console.WriteLine("Точка находится в границах фигуры");
            }
            else
            {
                Console.WriteLine("Точка находится за пределами границ фигуры");
            }
            Console.ReadKey();

        }
    }
}
