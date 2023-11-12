﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint4.Task4.V6.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task4.V6
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
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, обнуляющую нечётные элементы матрицы 5х5,                *");
            Console.WriteLine("* заполненной значениями с клавиатуры в диапазоне от 4 до 9.                   *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int[,] mx = new int[rows, col];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mx[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{mx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            int[,] res = ds.Calculate(mx);

            Console.WriteLine("Матрица с обнулёнными нечётными элементами: \n");
            for (int i = 0; i < mx.GetLength(0); i++)
            {
                for (int j = 0; j < mx.GetLength(1); j++)
                    Console.Write("{0} ", mx[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
