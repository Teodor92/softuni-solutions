using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double result = CalculateArea(width, hight);
            Console.WriteLine(result);
        }

        static double CalculateArea(double width, double hight)
        {
            return width * hight;
        }
    }
}
