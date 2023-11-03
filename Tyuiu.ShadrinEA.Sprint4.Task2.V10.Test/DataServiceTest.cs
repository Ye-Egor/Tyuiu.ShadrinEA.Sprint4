using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint4.Task2.V10.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.Calculate(array);
            int result = 178605;
            Assert.AreEqual(result, res);
        }
    }
}
