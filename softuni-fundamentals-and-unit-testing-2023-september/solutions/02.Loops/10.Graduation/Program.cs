namespace _10.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double totalGradeSum = 0;
            bool hasBeenExpelled = false;

            for (int classNumber = 1; classNumber <= 12; classNumber++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {classNumber} grade");
                    hasBeenExpelled = true;
                    break;
                }

                totalGradeSum += grade;
            }

            if (!hasBeenExpelled)
            {
                double averageGrade = totalGradeSum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
