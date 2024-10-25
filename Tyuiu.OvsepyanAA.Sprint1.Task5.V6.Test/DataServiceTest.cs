using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using Tyuiu.OvsepyanAA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.OvsepyanAA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 5;
            DataService ds = new DataService();
            int res = ds.Calculate(k);
            int wait = 5;
            Assert.AreEqual(wait, res);
           
        }
    }
}