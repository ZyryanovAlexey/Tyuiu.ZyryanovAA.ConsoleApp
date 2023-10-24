using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab4.V6.Lib
{
    public class DataService
    {
        public bool GetPointShape(double x, double y)
        {
            bool res;
            if

                (
                  ((x * x + y * y <= 4) && (x >= -2 && x <= 2) && (y >= 0 && y <= 2))
                  &&
                  (x * x + y * y >= 1)
                )

            {
                res = true;
            }

            else
            {
                res = false;
            }

            return res;
        }
    }
}