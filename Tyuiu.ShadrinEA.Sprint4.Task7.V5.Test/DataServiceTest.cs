using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint4.Task7.V5.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            int[,] mx = new int[n, m];
            string str = "246813579";
            int wait = 4;
            int res = ds.Calculate(n, m, str);
            Assert.AreEqual(res, wait);
        }
    }
}
