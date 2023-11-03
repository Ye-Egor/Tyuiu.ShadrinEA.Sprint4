using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint4.Task3.V24.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task3.V24.Tast
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = { { 3, 6, 1, 7, 3}, { 2, 3, 7, 1, 1 }, { 1, 2, 5, 5, 1 }, { 7, 6, 7, 6, 2 }, { 7, 6, 4, 5, 8 } };
            int res = ds.Calculate(array);
            int result = 2;
            Assert.AreEqual(result, res);
        }
    }
}
