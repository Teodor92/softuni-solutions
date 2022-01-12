using System;

namespace _04.CmToInches
{
    class Program
    {
        static void Main(string[] args)
        {
            int cm = int.Parse(Console.ReadLine());
            double inch = cm * 2.54;
            Console.WriteLine(inch);
        }
    }
}
