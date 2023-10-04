using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab2.V6.Lib
{
    public class DataService
    {
        public double SolveExpressV_6(double x, double y)
        {

            double result = Math.Pow((1 + (1/Math.Pow(x, 2))), x) - 12 * (Math.Pow(x, 2)) * y;
            return result;

        }
        public double SolveExpressV_6_1(double x)
        {

            double result1 = Math.Sin(Math.Sqrt(Math.Pow(x, 2))) + Math.Cos(Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1));
            return result1;

        }

    }
}
