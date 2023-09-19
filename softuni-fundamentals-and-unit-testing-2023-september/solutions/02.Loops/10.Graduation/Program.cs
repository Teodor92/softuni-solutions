namespace _10.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();
            int classNumber = 1;
            double totalGrades = 0;
            int expelledCounter = 0;

            while (classNumber <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    expelledCounter += 1;
                }

                if (expelledCounter >= 2)
                {
                    Console.WriteLine($"{nameOfStudent} has been excluded at {classNumber - 1} grade");
                    break;
                }

                totalGrades += grade;

                classNumber += 1;
            }

            double averageGrade = totalGrades / 12;

            if (expelledCounter <= 1)
            {
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
