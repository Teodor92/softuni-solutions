using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            // 111 | "Stop"
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNumber);

            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if (input == "Stop")
            //    {
            //        break;
            //    }
            //}
        }
    }
}
