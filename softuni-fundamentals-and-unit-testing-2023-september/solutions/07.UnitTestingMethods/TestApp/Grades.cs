namespace TestApp;

public class Grades
{
    public static string GradeAsWords(double grade)
    {
        switch (grade)
        {
            case >= 2.00 and < 3.00:
                return "Fail";
            case >= 3.00 and < 3.50:
                return "Average";
            case >= 3.50 and < 4.00:
                return "Good";
            case >= 4.00 and < 4.50:
                return "Very Good";
            case >= 4.50 and <= 5.00:
                return "Excellent";
            default:
                return "Invalid!";
        }
    }
}
