using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShadrinEA.Sprint4.Task6.V20.Lib;

namespace Tyuiu.ShadrinEA.Sprint4.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #4 | Выполнил: Шадрин Е.А | ИСТНб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Класc Array                                                            *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #20                                                                  *");
            Console.WriteLine("* Выполнил: Шадрин Егор Андреевич | ИСТНб-23-1                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, выводящую из строкового массива элементы, длина          *");
            Console.WriteLine("* которых меньше 10.                                                           *");

            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string[] z = { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            Console.WriteLine("Исходный массив: ");
            Console.WriteLine("[{0}]", string.Join(", ", z));


            string[] res = ds.Calculate(z);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Элементы, длина которых меньше 10: " + "[{0}]", string.Join(", ", res));

            Console.ReadKey();
        }
    }
}
