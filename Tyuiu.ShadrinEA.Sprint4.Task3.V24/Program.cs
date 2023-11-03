using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint4.Task3.V24.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы                                                      *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #24                                                                  *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Найти минимальный элемент во втором столбце массива.                         *");
            
            Console.WriteLine("* 3, 6, 1, 7, 3                                                                *");
            Console.WriteLine("* 2, 3, 7, 1, 1                                                                *");
            Console.WriteLine("* 1, 2, 5, 5, 1                                                                *");
            Console.WriteLine("* 7, 6, 7, 6, 2                                                                *");
            Console.WriteLine("* 7, 6, 4, 5, 8                                                                *");


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            int[,] array = { { 3, 6, 1, 7, 3 }, { 2, 3, 7, 1, 1 }, { 1, 2, 5, 5, 1 }, { 7, 6, 7, 6, 2 }, { 7, 6, 4, 5, 8 } };


           
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Минимальный элемент во втором столбце массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
