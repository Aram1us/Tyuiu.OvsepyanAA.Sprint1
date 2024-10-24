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
            double x = 3;
            double y = 5;
            double wait = 15.375;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}