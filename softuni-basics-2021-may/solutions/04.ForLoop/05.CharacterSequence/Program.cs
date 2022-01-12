using System;

namespace _05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "!@#$%^&*()asdasd asdad   asdasd";
            //Console.WriteLine(word[0]);
            //Console.WriteLine(word[1]);
            //Console.WriteLine(word[2]);
            //Console.WriteLine(word[3]);
            //Console.WriteLine(word[word.Length - 1]);

            string word = Console.ReadLine();

            for (int index = 0; index <= word.Length - 1; index++)
            {
                Console.WriteLine(word[index]);
            }
        }
    }
}
