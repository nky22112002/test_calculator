using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using System.Linq;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c;
        public TestContext TestContext
        {
            get;
            set;
        }
        [TestInitialize]
        public void SetUp()
        {
            c = new Caculation(10, 5);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestPTBH.csv", "TestPTBH#csv", DataAccessMethod.Sequential)]
        public void TestDataWithSource()
        {
            double a, b, c, expected, expected1;
            double[] actual;
            a = double.Parse(TestContext.DataRow[0].ToString());
            b = double.Parse(TestContext.DataRow[1].ToString());
            c = double.Parse(TestContext.DataRow[2].ToString());
            expected = double.Parse(TestContext.DataRow[3].ToString());
            expected1 = double.Parse(TestContext.DataRow[4].ToString());
            PTBH ca = new PTBH(a, b, c);
            actual = ca.Giai();
            double actual1 = actual[1]; // Lấy nghiệm thứ hai từ mảng actual
            actual = actual.Take(1).ToArray(); // Lấy nghiệm thứ nhất từ mảng actual
            Assert.AreEqual(expected, actual[0]);
            Assert.AreEqual(expected1, actual1);
            Console.WriteLine("Giá trị của TestContext.DataRow[3].ToString(): " + TestContext.DataRow[3].ToString());
        }
        

    }
}