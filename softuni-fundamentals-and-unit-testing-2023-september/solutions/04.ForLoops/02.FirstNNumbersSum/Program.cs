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

            //int sum = 0;

            //for (int index = 1; index <= n; index += 1)
            //{
            //    if (index == 1)
            //    {
            //        Console.Write(index);
            //    }
            //    else
            //    {
            //        Console.Write("+" + index);
            //    }

            //    sum += index;
            //}

            //Console.WriteLine("=" + sum);
        }
    }
}
