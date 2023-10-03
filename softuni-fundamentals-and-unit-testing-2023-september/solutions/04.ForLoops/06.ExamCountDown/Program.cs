namespace _06.ExamCountDown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToExam = int.Parse(Console.ReadLine());

            for (int currentDay = daysToExam; currentDay > 0; currentDay -= 1)
            {
                Console.WriteLine($"{currentDay} days before the exam");
            }

            Console.WriteLine("The exam has come");
        }
    }
}
