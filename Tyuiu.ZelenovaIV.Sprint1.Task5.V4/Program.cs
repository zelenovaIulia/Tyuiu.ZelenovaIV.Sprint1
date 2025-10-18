using System;
using Tyuiu.ZelenovaIV.Sprint1.Task5.V4.Lib;

DataService ds = new DataService();

int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.SecondsToHours(x));