using System;

namespace TestApp;

public class CenterPoint
{
    public static string GetClosest(double x1, double y1, double x2, double y2)
    {
        double pointOne = Math.Abs(x1) + Math.Abs(y1);
        double pointTwo = Math.Abs(x2) + Math.Abs(y2);

        string firstPointReport = $"({string.Join(", ", x1, y1)})"; // (x, y)
        string secondPointReport = $"({string.Join(", ", x2, y2)})";

        if (pointOne > pointTwo)
        {
            return secondPointReport;
        }
        else if (pointOne < pointTwo)
        {
            return firstPointReport;
        }
        else
        {
            if( x2 < 0 || y2 < 0)
            {
                return secondPointReport;
            }

            return firstPointReport;
        }
    }
}
