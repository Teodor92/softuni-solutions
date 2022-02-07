using System;
using System.Linq;

namespace _001.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 33, 44 };

            // 1. For Loop

            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            //Console.WriteLine(sum);

            // 2. ForEach

            //int sum = 0;
            //foreach (int item in array)
            //{
            //    sum += item;
            //}

            //Console.WriteLine(sum);

            // 3. System.Linq

            //int sum = array.Sum();
            //int max = array.Max();
            //int min = array.Min();
            //Console.WriteLine(sum);

            string message = GetMessage();
        }

        static string GetMessage()
        {
            return "Test";
        }
    }
}
