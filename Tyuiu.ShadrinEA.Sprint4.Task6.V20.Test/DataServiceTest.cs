using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShadrinEA.Sprint4.Task6.V20.Lib;


namespace Tyuiu.ShadrinEA.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] city = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] res = ds.Calculate(city);
            string[] wait = { "Физика", "Химия", "Биология", "География", "История" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
