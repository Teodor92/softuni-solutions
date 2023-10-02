namespace _04.NumbersEndingInSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 7; i <= n; i += 10)
            {
                Console.WriteLine(i);
            }

            // Alternative soltuion 1

            //for (int i = 0; i <= n; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // Alternative soltuion 2

            //for (int i = 0; i <= n; i++)
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
