﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.OvsepyanAA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.OvsepyanAA.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите целое число k от 1 до 365: ");
            if (int.TryParse(Console.ReadLine(), out int k))
            {
                try //предназначен для перехвата и обработки исключений, происходящих в исполняемом коде
                {
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");

                    int n = ds.Calculate(k);                    // Получаем день недели
                    Console.WriteLine($" День года соответствует: {n} день недели.");
                    switch (n)
                    //оператор управления, который в зависимости от значения параметра (который указывается в switch) выполняет определенный блок операторов.
                    {
                        case 1:
                            Console.WriteLine("Понедельник"); break;
                        case 2:
                            Console.WriteLine("Вторник"); break;
                        case 3:
                            Console.WriteLine("Среда"); break;
                        case 4:
                            Console.WriteLine("Четверг"); break;
                        case 5:
                            Console.WriteLine("Пятница"); break;
                        case 6:
                            Console.WriteLine("Суббота"); break;
                        case 7:
                            Console.WriteLine("Воскресенье"); break;
                    }
                }
                catch (ArgumentOutOfRangeException e) //обработчик исключений. Если для созданного исключения не существует обработчиков, выполнение программы прекращается с сообщением об ошибке.
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Ощибка, введите целое число.");
            }
        }
    }
}
