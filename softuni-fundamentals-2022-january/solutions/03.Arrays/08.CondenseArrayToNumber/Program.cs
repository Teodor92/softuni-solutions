using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int finalResult = 0;

            if (input.Length == 1)
            {
                finalResult = input[0];
            }
            else
            {
                int originalLength = input.Length - 1;

                for (int i = 0; i < originalLength; i++)
                {
                    int[] modifiedArray = new int[input.Length - 1];
                    for (int j = 0; j < modifiedArray.Length; j++)
                    {
                        modifiedArray[j] = input[j] + input[j + 1];
                    }
                    input = modifiedArray;
                    finalResult = modifiedArray[0];
                }
            }

            Console.WriteLine(finalResult);
        }
    }
}
