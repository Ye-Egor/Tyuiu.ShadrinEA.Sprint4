using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint4.Task0.V7.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Одномерные массивы                                                     *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #7                                                                   *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                          *");
            Console.WriteLine("*   {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}.                                            *");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

           
            Console.WriteLine("Массив = { 9,8,7,9,5,4,3,2,3,7}");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива = " + ds.GetMultOddArrEl(array));
            Console.ReadKey();
        }
    }
}
