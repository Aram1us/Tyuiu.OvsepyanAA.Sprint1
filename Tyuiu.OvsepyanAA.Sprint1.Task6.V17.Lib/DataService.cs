using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OvsepyanAA.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            char[] stringArray = value.ToCharArray();
            Array.Reverse(stringArray);
            string res = new string(stringArray);
            if (res == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
