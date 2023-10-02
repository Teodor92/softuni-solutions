namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            Console.Write(1);

            for (int i = 2; i <= n; i += 1)
            {
                Console.Write("+" + i);
                sum += i;
            }

            Console.WriteLine("=" + sum);
        }
    }
}
