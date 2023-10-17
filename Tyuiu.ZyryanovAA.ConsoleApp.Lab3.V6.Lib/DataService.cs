using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab3.V6.Lib
{
    public class DataService
    {
        public bool GetPointShape(int x, int y)
        {
            bool res;
            if (
                ((x >= 3 && x <= 5) && (y >= 3 && y <= 4))
                ||
                ((x >= 6 && x <= 9) && (y == 5 || y == 10))
                ||
                ((x == 9) && (y == 3 || y == 4))
                ||
                ((x == 11 || x == 12) && (y == 5 || y == 11))
                ||
                ((x == 2 || x == 5) && (y == 7 ))
                ||
                ((x == 13) && (y == 8))
                ||
                ((x == 10) && (y >= 8 && y <= 10))
                ||
                ((x >= 3 && x <= 7) && (y == 11))
                ||
                ((x == 7) && (y == 12))
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