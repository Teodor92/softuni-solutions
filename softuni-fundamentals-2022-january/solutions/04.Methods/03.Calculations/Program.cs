using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int firstNimber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(firstNimber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNimber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNimber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNimber, secondNumber);
                    break;
                default:
                    break;
            }
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
