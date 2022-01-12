using System;

namespace _10.InvalidNumber
{
    class Program
    {
        //Дадено число е валидно, ако е в диапазона[100…200] или е 0. Да се напише програма, която чете цяло число, въведено от потребителя, и печата "invalid" ако въведеното число не е валидно.

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isValid = (number >= 100 && number <= 200) || number == 0;

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
