using System;
using System.Linq;
using System.Text;

namespace _003._MaxSeq
{
    internal class Program
    {
        // Create a program that finds the longest sequence of equal elements in an array of integers. If several equal sequences are present in the array, print out the leftmost one.
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 2 2 2

            int maxSeqCount = 0;
            int maxSeqElement = 0;

            int currentSeqCount = 1;
            int currentSeqElement = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentSeqCount++;
                    currentSeqElement = array[i];
                }
                else
                {
                    if (maxSeqCount < currentSeqCount)
                    {
                        maxSeqCount = currentSeqCount;
                        maxSeqElement = currentSeqElement;
                    }

                    currentSeqCount = 1;
                }
            }

            if (maxSeqCount < currentSeqCount)
            {
                maxSeqCount = currentSeqCount;
                maxSeqElement = currentSeqElement;
            }

            Console.WriteLine(RepeatStringFast(maxSeqElement.ToString(), maxSeqCount));
        }

        static string RepeatStringFast(string inputString, int repeatNumber)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < repeatNumber; i++)
            {
                builder.Append($"{inputString} ");
            }

            return builder.ToString();
        }
    }
}
