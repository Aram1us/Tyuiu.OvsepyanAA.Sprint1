using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using Tyuiu.OvsepyyanAA.Sprint1.Task2.V2.Lib;

namespace Tyuiu.OvsepyyanAA.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 100;
            var res = ds.ConvertAngleToRad(value);
            Assert.AreEqual(1.745, res);


        }
    }
}