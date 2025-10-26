﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZelenovaIV.Sprint1.Task7.V28.Lib
{
    public class DataService : ISprint1Task7V28
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Pow(Math.Cos(Math.Sin(1 / x)), 2) + Math.Pow(y, x), 3);
            return res;
        }
    }
}
