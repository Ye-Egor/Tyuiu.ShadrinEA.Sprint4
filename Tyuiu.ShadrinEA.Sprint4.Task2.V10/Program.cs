using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint4.Task2.V10.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Одномерные массивы                                                     *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант 10                                                                   *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива                           *");
            Console.WriteLine("* заполненного случайными числами в диапазоне от 1 до 6.                       *");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");


            int len;
            Console.WriteLine("Ввидите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                array[i] = rnd.Next(1,7);
            }

            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
