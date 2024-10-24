using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using Tyuiu.OvsepyanAA.Sprint1.Task4.V21.Lib;

namespace Tyuiu.OvsepyanAA.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 60;
            double y = 30;
            double wait = 41.011;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}