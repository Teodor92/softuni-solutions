namespace _01.NumbersFromNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
