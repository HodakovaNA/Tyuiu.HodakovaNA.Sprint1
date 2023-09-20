using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.HodakovaNA.Sprint1.Task1.V3.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.125, res);

        }
    }
}