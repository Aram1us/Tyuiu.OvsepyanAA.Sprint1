using Tyuiu.OvsepyyanAA.Sprint1.Task3.V4.Lib;

namespace Tyuiu.OvsepyanAA.Sprint1.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Овсепян А. А. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Овсепян Арам Андраникович | СМАРТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости покупки, " +
                "состоящей из нескольких тетрадей и такого же количества обложек к ним.                  *");
            Console.WriteLine("*Ответ округлите до 3 знаков после запятой.                               *");
   
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

   
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int quantity;

            Console.WriteLine("Введите количество комплектов");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine (ds.PurchaseAmount(priceNotebook: priceNotebook, priceCover, quantity));
            Console.ReadKey();
        }
    }
}
