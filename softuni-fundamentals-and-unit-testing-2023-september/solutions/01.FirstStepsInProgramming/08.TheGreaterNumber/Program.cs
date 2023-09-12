namespace _08.TheGreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Greater number: " + firstNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("Greater number: " + secondNumber);
            }
            else
            {
                Console.WriteLine("The two numbers are equal.");
            }
        }
    }
}
