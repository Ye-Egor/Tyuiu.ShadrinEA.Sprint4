﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShadrinEA.Sprint4.Task0.V7.Lib
{
    public class DataService : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int p = 1;

            for (int i =0; i<= array.Length -1; i++)
            {
                if (array[i]%2!=0)
                { 
                    p = p * array[i];
                }
            }
            return p;
        }
    }
}
