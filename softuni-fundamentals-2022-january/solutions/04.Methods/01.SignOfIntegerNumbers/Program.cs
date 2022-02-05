using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string greetingText = "Hello world";
            //char[] chars = greetingText.ToCharArray();

            ////for (int i = 0; i < greetingText.Length; i++)
            ////{
            ////    char currentChar = greetingText[i];
            ////    Console.WriteLine(currentChar);
            ////}

            //foreach (char currentChar in greetingText)
            //{
            //    Console.WriteLine(currentChar);
            //}

            // System.LINQ

            int grade = 33;
            Console.WriteLine(grade);
            grade = Decrement(grade);
            Console.WriteLine(grade);

            // Reference 333
            int[] array = { 33 };

            bool isInArray = IsInArray(array, 3);
            Console.WriteLine(IsInArray(array, 3));

            //Console.WriteLine(string.Join(",", array));
            //DecrementFirstElement(array);
            //Console.WriteLine(string.Join(",", array));
        }

        static int Decrement(int grade)
        {
            grade--;
            Console.WriteLine(grade);

            return grade;
        }

        static bool IsInArray(int[] array, int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Reference 333
        static void DecrementFirstElement(int[] grade)
        {
            if (grade.Length == 0)
            {
                return;
            }

            //// Reference 444
            //grade = new int[44];

            grade[0]--;
            Console.WriteLine(grade);
        }
    }
}
