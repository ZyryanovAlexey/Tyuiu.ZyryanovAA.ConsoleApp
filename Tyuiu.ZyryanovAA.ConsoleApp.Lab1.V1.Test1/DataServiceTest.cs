using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1.Test1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspressionV_1_1()
        {
            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double res = ds.SolveExpressV_1_1(x, y, a);

            res = Math.Round(res, 3);
            double wait = 534.387;

            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidExspressionV_1_2()
        {
            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double res1 = ds.SolveExpressV_1_2(x, y, a);

            res1 = Math.Round(res1, 3);
            double wait = 20.449;

            Assert.AreEqual(wait, res1);
        }


        [TestMethod]
        public void ValidExspressionV_6_1()
        {
            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double res2 = ds.SolveExpressV_6_1(x, y, a);

            res2 = Math.Round(res2, 3);
            double wait = 60.378;

            Assert.AreEqual(wait, res2);
        }

        [TestMethod]
        public void ValidExspressionV_6_2()
        {
            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double res3 = ds.SolveExpressV_6_2(x, y, a);

            res3 = Math.Round(res3, 3);
            double wait = 31.539;

            Assert.AreEqual(wait, res3);
        }
    }
}
