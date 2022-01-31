using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            foreach (int item in items)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            //for (int i = 0; i < items.Length; i++)
            //{
            //    int currentValue = items[i];
            //    if (currentValue % 2 == 0)
            //    {
            //        sum += currentValue;
            //    }
            //}

            Console.WriteLine(sum);
        }
    }
}
