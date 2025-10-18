using System;
using Tyuiu.ZelenovaIV.Sprint1.Task4.V18.Lib;

DataService ds = new DataService();

double x = Convert.ToInt32(Console.ReadLine());
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.Calculate(x, y));