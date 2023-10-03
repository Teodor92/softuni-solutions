namespace _04.NumbersEndingInSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // 7, 17, 27, 37... 97

            for (int i = 7; i <= n; i += 10)
            {
                Console.WriteLine(i);
            }

            // Alternative solution 1

            //for (int i = 7; i <= n; i += 1)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Alternative solution 2

            //for (int i = 7; i <= n; i += 1)
            //{
            //    string numberAsString = i.ToString();
            //    char lastDigit = numberAsString[numberAsString.Length - 1];

            //    if (lastDigit == '7')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
