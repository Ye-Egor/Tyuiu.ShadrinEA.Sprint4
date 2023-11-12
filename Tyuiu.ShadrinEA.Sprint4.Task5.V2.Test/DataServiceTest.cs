using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint4.Task5.V2.Lib;


namespace Tyuiu.ShadrinEA.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mat = { {7, -6, 6, 6, 9 },
                           {4, 4, 4, 9, -4 },
                           {5, -5, 5, 6, 5 },
                           {4, 9, -5, 9, 7 },
                           {6, -9, 5, 6, -7 } };

            int res = ds.Calculate(mat);

            int wait = 6;

          Assert.AreEqual(wait, res);
        }
    }
}
