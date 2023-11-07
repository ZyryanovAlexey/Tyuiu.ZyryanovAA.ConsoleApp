using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZyryanovAA.ConsoleApp.Lab5.V6.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n;
            double s;
            Console.WriteLine("Введите число N:");
            n = Convert.ToInt32(Console.ReadLine());
            s = ds.GetSum(n);
            Console.WriteLine("Конечная сумма равна " + s);
            Console.ReadKey();
        }
    }
}
