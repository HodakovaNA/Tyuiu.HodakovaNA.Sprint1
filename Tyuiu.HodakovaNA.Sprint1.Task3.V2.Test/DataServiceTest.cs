using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.HodakovaNA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2; //цена тетради
            int amountNotebook = 50;  //кол-во тетрадей
            double pricePencil = 5;   //цена ручек
            int amountPencil = 10;    //кол-во ручек
            double wait = 150;        // Иоговая сумма
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);
        }
    }
}
