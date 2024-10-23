using Tyuiu.OvsepyyanAA.Sprint1.Task2.V2.Lib;

namespace Tyuiu.OvsepyanAA.Sprint1.Task2.V2
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Овсепян Арам Андраникович | СМАРТб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известен угол в градусах. Перевести угол в радианы.                     *");
            Console.WriteLine("*Ответ округлите до 3 знаков после запятой. используйте Math.Round(res,3))*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value;

            Console.WriteLine("Введите количество градусов, чтобы их перевести в радианы:");
            value = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ConvertAngleToRad(value));
            Console.ReadLine();
        }
    }
}
