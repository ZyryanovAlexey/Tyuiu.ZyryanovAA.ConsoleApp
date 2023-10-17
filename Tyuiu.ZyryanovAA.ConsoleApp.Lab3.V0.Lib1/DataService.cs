using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab3.V0.Lib1
{
    public class DataService
    {
        public bool GetPointShape(int x, int y)
        {
            bool res;
            if ((x >= -3 && x <= 3) && (y >= -3 && y <= 3))
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