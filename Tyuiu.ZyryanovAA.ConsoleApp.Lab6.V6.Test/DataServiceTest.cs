using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZyryanovAA.ConsoleApp.Lab6.V6.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;

            valueWaitArray = new double[len];

            valueWaitArray[0] = 4.70;
            valueWaitArray[1] = -11.30;
            valueWaitArray[2] = -2.76;
            valueWaitArray[3] = -1.91;
            valueWaitArray[4] = -1.92;
            valueWaitArray[5] = -2.82;
            valueWaitArray[6] = -12.66;
            valueWaitArray[7] = 4.51;
            valueWaitArray[8] = 2.21;
            valueWaitArray[9] = 1.84;
            valueWaitArray[10] = 2.16;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}