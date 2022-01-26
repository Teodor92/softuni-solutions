using System;
using System.Linq;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lengthOfArray = int.Parse(Console.ReadLine());
            //int[] numbersArray = new int[lengthOfArray];
            //Console.WriteLine(numbersArray.Length);

            //numbersArray[3] = 88;

            //Console.WriteLine(numbersArray[0]);
            //Console.WriteLine(numbersArray[3]);
            //Console.WriteLine(numbersArray[10]);

            //int indexToSearch = 6;
            //// 0 1 2 3 4 5
            //bool inArray = indexToSearch >= 0 && indexToSearch < numbersArray.Length;
            //Console.WriteLine(numbersArray[indexToSearch]);


            //string[] stringArray = new string[3];

            //float[] floatArray = new float[8];

            //int[] testArray = new int[3];
            //testArray[2] = 44;

            //int[] anotherTestArray = new int[6];
            //anotherTestArray[1] = 55;

            //testArray = anotherTestArray;



            //string[] names = new string[3];
            //names[0] = "Ivan";
            //names[1] = "Stoian";
            //names[2] = "Stamat";

            //string[] anotherNames = new []
            //{
            //    "Ivan", // 0
            //    "Stoian", // 1
            //    "Stamat" // 2
            //};

            string[] anotherNamesSecond =
            {
                "Ivan",
                "Stoian",
                "Stamat"
            };

            string output = string.Join(",", anotherNamesSecond);
            Console.WriteLine(output);

            //int numberOfItems = int.Parse(Console.ReadLine());
            //int[] items = new int[numberOfItems];

            //for (int i = 0; i < numberOfItems; i++)
            //{
            //    items[i] = int.Parse(Console.ReadLine());
            //}

            //string[] rawItems = Console.ReadLine().Split(',');
            //int[] items = new int[rawItems.Length];

            //for (int i = 0; i < rawItems.Length; i++)
            //{
            //    items[i] = int.Parse(rawItems[i]);
            //}

            //Console.WriteLine(items);

            //var test = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //int[] items = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine($"index: {i} value: {items[i]}");
            //}

            string[] names =
            {
                "Ivan",
                "Stoian",
                "Stamat"
            };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // "11 11 111 11 33"
            // .Split(' ')
            // ["11", "11", "111", "11", "33"]


            // ["11", "11", "111", "11", "33"]
            // string.Join("|", )
            // "11|11|111|11|33"

            // "11,11,111,11,33"
            // .Split(',')
            // ["11", "11", "111", "11", "33"]
            // [11, 11, 111, 11, 33]


        }
    }
}
