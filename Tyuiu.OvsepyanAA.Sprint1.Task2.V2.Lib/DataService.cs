using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OvsepyyanAA.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public double ConvertAngleToRad(int value)
        {
            var res = value * (Math.PI / 180);
            return Math.Round(res, 3);

        }
    }
}
