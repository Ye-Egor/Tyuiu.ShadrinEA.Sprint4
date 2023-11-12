﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShadrinEA.Sprint4.Task5.V2.Lib
{
    public class DataService : ISprint4Task5V2
    {
        public int Calculate(int[,] matrix)
        {
            int c = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] <0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
