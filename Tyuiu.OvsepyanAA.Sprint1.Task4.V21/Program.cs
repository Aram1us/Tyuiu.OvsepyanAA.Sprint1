﻿using Tyuiu.OvsepyanAA.Sprint1.Task4.V21.Lib;
namespace Tyuiu.OvsepyanAA.Sprint1.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(sin(x) + cos(y) / sin(x) - cos(y)) *tg(xy) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
