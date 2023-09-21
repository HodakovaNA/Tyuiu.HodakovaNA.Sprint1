using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint1.Task2.V13.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2; //Миля 
            //Миля в км
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(3218, res);
        }
    }
}
