﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OvsepyyanAA.Sprint1.Task3.V4.Lib
{
    public class DataService : ISprint1Task3V4
    {
        public double PurchaseAmount(double priceNotebook, double priceCover, int quantity)
        {
            var res = quantity * (priceNotebook + priceCover);
            return Math.Round(res, 3);





        }
    }
}
