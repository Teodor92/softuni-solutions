using System;

namespace _08.GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int course = 1;
            double averageGrade = 0;
            int cutCounter = 0;
            bool hasBeenCut = false;

            while (course <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                //averageGrade = averageGrade + grade;

                if (grade < 4)
                {
                    cutCounter++;

                    if (cutCounter == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {course - 1} grade");
                        hasBeenCut = true;
                        break;
                    }
                }

                course++;
            }

            if (!hasBeenCut)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {(averageGrade / 12):F2}");
            }

        }
    }
}
