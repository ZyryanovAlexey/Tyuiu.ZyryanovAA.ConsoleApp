using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab5.V6.Lib
{
    public class DataService
    {
        public double GetSum(int n)
        {
            double S = 0;
            for (int x = 1; x <= n; x++)
            {
                S = S + ((Math.Cos(x * x) + Math.Sin(x * x)) / (Math.Sin(x) - 1));
            }
            return Math.Round(S, 3);
        }
    }
}
