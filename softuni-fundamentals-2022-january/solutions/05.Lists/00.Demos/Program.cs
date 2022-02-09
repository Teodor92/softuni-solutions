using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOfElements = int.Parse(Console.ReadLine());
            //List<int> elements = new List<int>();

            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    int currentNumber = int.Parse(Console.ReadLine());
            //    elements.Add(currentNumber);
            //}

            //Console.WriteLine(string.Join(",", elements));

            //List<string> rawInput = Console.ReadLine().Split().ToList();
            //List<int> numbers = new List<int>();

            //for (int i = 0; i < rawInput.Count; i++)
            //{
            //    int currentElement = int.Parse(rawInput[i]);
            //    numbers.Add(currentElement);
            //}


            //Console.WriteLine(string.Join(",", numbers));

            //List<int> numbers = Console.ReadLine()
            //        .Split()
            //        .Select(int.Parse)
            //        .ToList();

            List<int> numbers1 = new List<int> { 1, 2, 3, 3, 4, 5 };
            List<int> numbers2 = new List<int> { 5, 6, 7, 3, 4 };
            int[] numbers3 = new int[] { 8, 9, 10 };

            //numbers1.AddRange(numbers2);
            //numbers1.AddRange(numbers3);

            //Console.WriteLine(numbers1);
            GetRemainingElements(numbers1, numbers2);
        }

        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
                nums.Add(longerList[i]);
            return nums;
        }

    }
}
