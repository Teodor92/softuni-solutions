using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _00.Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////char[] myArray = new char[] { 'H', 'e', 'y' };
            //List<char> myList = new List<char> { 'H', 'e', 'y', 'a' };

            //char[] arr = myList.ToArray();
            //List<char> mySecondList = arr.ToList();
            //mySecondList.Add('T');



            //string greeting = new string(myList.ToArray());
            //char[] newCharArray = greeting.ToCharArray();

            //Console.WriteLine(greeting);

            //char[] separators = new char[] { ' ', ',', '.' };
            //string text = "Hello, I am John.";
            //string[] words = text.Split(new string[] { ",", "  " }, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine(new string('*', 6));

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello\r\n");
            //Console.WriteLine(sb.Length);

            //string finalString = sb.ToString(0, 2);

            //Console.WriteLine(finalString);

            //Stopwatch sw = new Stopwatch();

            //sw.Start();
            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < 200000; i++)
            //{
            //    sb.Append(i);
            //}

            //string finalString = sb.ToString();
            //Console.WriteLine(finalString);

            //sw.Stop();

            //Console.WriteLine(sw.ElapsedMilliseconds);

            //string[] test = "1 2 3".Split(',', '.', ',');

            //string test = "! test !";

            //Console.WriteLine(test.Trim(new char[] { ' ', '!' }));
            //Console.WriteLine(test.TrimEnd());
            //Console.WriteLine(test.ToUpper());
            //Console.WriteLine(test.);

            string test = "abcdefgh";
            Console.WriteLine(test.Substring(2));
        }
    }
}
