﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShadrinEA.Sprint4.Task7.V5.Lib
{
    public class DataService : ISprint4Task7V5
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mx[i, j] = int.Parse(value.Substring(i * m + j, 1));

                }
            }
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mx[i, j] % 2 == 0)
                    {
                        c ++;
                    }

                }
            }
            return c;
        }
    }
}
