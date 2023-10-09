namespace _01.NumbersFromNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = n; number >= 1; number--)
            {
                Console.WriteLine(number);
            }
        }
    }
}
