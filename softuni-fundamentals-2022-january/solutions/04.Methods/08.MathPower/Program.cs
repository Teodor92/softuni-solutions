using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetPow(number, power);
            Console.WriteLine(result);
        }

        static double GetPow(double number, int power)
        {
            double result = 1.0;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
