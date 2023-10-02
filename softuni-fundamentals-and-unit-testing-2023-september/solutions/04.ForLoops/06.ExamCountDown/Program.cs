namespace _06.ExamCountDown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            for (int dayNumber = days; dayNumber >= 1; dayNumber -= 1)
            {
                Console.WriteLine($"{dayNumber} days before the exam", dayNumber);
            }

            Console.WriteLine("The exam has come");
        }
    }
}
