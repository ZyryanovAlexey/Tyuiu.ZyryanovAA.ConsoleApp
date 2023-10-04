using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1.Lib
{
    public class DataService
    {
        public double SolveExpressV_1_1(double x, double y, double a)
        {

            double result = (3 + x / y) / (2 * a / x) - (3 * x * a + 2 * a + a * y) / (3 * a + 2 * x - y) + 10 * y * a;
            return result;

        }

        public double SolveExpressV_1_2(double x, double y, double a)
        {
            double result1 = 3 * x + (3 * x + y - 4 * a) / (a + 2 * x + 7 * y) + 5 + ((a / y) + 1) / (2 * a / x);
            return result1;

        }

        public double SolveExpressV_6_1(double x, double y, double a)
        {
            double result2 = 6 * y - (((a + 3) / x) / (2 - x * a) / (x * y)) + (2 + 3 * a) / (10 * x + 3 * a) + 4 * y;
            return result2;

        }

        public double SolveExpressV_6_2(double x, double y, double a)
        {
            double result3 = 2 * y + (2 + 3 * a) / (10 * x - 3 * a) + 2 * a + ((a / y) / (3 * a / x));
            return result3;
        }
    }
}
