using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZyryanovAA.ConsoleApp.Lab3.V0.Lib1;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool res;
            int x;
            int y;
            Console.WriteLine("Введите значения переменной x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения переменной y: ");
            y = Convert.ToInt32(Console.ReadLine());

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
