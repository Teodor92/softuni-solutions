namespace _04.EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPower = int.Parse(Console.ReadLine());
            for (int power = 0; power <= maxPower; power += 2)
            {
                if (power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }
            }
        }
    }
}
