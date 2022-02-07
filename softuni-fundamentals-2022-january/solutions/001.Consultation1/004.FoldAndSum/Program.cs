using System;
using System.Linq;

namespace _004.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = array.Length / 4;

            int[] lowerRow = new int[k * 2];
            int lowerRowIndex = 0;

            int[] upperRow = new int[k * 2];
            int upperRowIndex = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                upperRow[upperRowIndex] = array[i];
                upperRowIndex++;
            }

            for (int i = 4 * k - 1; i > (k * 3) - 1; i--)
            {
                upperRow[upperRowIndex] = array[i];
                upperRowIndex++;
            }

            for (int i = k; i < (k * 3); i++)
            {
                lowerRow[lowerRowIndex] = array[i];
                lowerRowIndex++;
            }

            for (int i = 0; i < upperRow.Length; i++)
            {
                Console.Write($"{upperRow[i] + lowerRow[i]} ");
            }

            Console.WriteLine();
        }
    }
}
