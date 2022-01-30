using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(x, op, y));
        }

        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / (double)b;
                    break;
                default:
                    break;
            }

            return Math.Round(result, 2);
        }
    }
}
