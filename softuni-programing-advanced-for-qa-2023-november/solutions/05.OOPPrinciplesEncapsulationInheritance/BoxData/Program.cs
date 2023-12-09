using System;

using BoxData;

double l = double.Parse(Console.ReadLine()!);
double w = double.Parse(Console.ReadLine()!);
double h = double.Parse(Console.ReadLine()!);

try
{
    Box box = new Box(l, w, h);
    Console.WriteLine();
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
