using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            var res = ds.Calculate(x);
            int d = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, d);
        }
    }
}
