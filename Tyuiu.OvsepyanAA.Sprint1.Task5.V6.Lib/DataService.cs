using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OvsepyanAA.Sprint1.Task5.V6.Lib

{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            
            if (k < 1 || k > 365)
            {
                throw new ArgumentOutOfRangeException(nameof(k), "k дожно быть от 1 до 365.");
            }
            int[] n = [0, 1, 2, 3, 4, 5, 6, 7];
            return n[((k - 1) % 7) + 1];
        }
    }
}