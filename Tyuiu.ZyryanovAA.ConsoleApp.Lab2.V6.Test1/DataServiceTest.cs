using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZyryanovAA.ConsoleApp.Lab2.V6.Lib;



namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspressionV_6()
        {
            double x = 2;
            double y = 4;

            DataService ds = new DataService();

            double res = ds.SolveExpressV_6(x, y);

            res = Math.Round(res, 3);
            double wait = -190.438;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExspressionV_6_1()
        {
            double x = 2;

             DataService ds = new DataService();

            double res1 = ds.SolveExpressV_6_1(x);

            res1 = Math.Round(res1, 3);
            double wait = -0.105;

            Assert.AreEqual(wait, res1);
        }
    }
}

