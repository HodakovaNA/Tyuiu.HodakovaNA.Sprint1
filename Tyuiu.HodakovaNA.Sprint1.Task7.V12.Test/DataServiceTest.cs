using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint1.Task7.V12.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2.0;
            double y = 3.0;

            double wait = 333;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(z, wait);
        }
    }
}
