using System;

namespace _002.Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            int shiftIndex = 1;
            int[] shiftedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                // 0 -> (0 + 1) % 4 = 1 
                // 1 -> (1 + 1) % 4 = 2
                // 2 -> (2 + 1) % 4 = 3
                // 3 -> (3 + 1) % 4 = 0
                int normalizedShift = (i + shiftIndex) % array.Length;
                shiftedArray[normalizedShift] = array[i]; 
            }

            Console.WriteLine(string.Join(",", shiftedArray));
        }
    }
}
