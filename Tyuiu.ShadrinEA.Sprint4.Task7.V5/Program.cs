using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint4.Task7.V5.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема:                                                                        *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, преобразующую строку с числами в матрицу 3х3,            *");
            Console.WriteLine("* а затем подсчитать количество четных чисел матрицы.                          *");

            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("* Cтрока из одноразрядных цифр [246813579].                                    *");
            Console.WriteLine("********************************************************************************");

            string str = "246813579";
          
            int n = 3;
            int m = 3;
            int[,] mx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mx[i, j] = int.Parse(str.Substring(i * m + j, 1));
                }
            }

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");


            Console.WriteLine("Kоличество четных чисел матрицы = " + ds.Calculate(n, m, str));
            Console.ReadKey();
        }
    }
}
