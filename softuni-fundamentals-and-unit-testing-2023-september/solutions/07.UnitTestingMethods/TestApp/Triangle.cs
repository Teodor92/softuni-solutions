using System;

namespace TestApp;

public class Triangle
{
    public static string PrintTriangle(int size)
    {
        string triangle = string.Empty;

        for (int row = 1; row <= size; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                triangle += col == row ? col.ToString() : col + " ";
            }

            triangle += Environment.NewLine;
        }

        for (int row = size - 1; row >= 1; row--)
        {
            for (int col = 1; col <= row; col++)
            {
                triangle += col == row ? col.ToString() : col + " ";
            }

            triangle += Environment.NewLine;
        }

        return triangle.Trim();
    }
}
