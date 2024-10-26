using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.OvsepyanAA.Sprint1.Task6.V17.Lib;

    internal class Program
    {
        static void Main(string[] args)
        {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Овсепян А.А | СМАРТб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил:Овсепян Арам Андраникович | СМАРТб-24-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("* Проверить, что строка является перевертышем.                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        string value;
        Console.WriteLine("Введите строку:");
        value = Convert.ToString(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.CheckPalindrome(value));
        Console.ReadKey();
    }
    }

