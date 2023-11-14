using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab6.V6.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)

        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
                           
                {
                
                y = Math.Round((1 + (Math.Sin(Math.Pow((Math.Pow(x, 2)+ 1),(1/2))))) / (Math.Cos(12 * x - 4)),2);
                    valueArray[count] = y;
                
                   
                    count++;
                }
                return valueArray;

        }
    }
}