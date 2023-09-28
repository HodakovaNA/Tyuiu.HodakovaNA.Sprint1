using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint1.Task6.V14.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "cъешь ещё этих мягких французских булок, да выпей же чаю";
            DataService ds = new DataService();
            bool res = ds.CheckLowerCaseRusLetters(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
