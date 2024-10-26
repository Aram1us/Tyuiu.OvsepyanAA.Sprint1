using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using Tyuiu.OvsepyanAA.Sprint1.Task7.V2.Lib;

namespace Tyuiu.OvsepyanAA.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 60;
            double wait = 0.564;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}