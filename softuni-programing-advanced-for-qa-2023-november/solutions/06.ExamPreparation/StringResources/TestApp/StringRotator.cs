using System;

namespace TestApp;

public class StringRotator
{
    public static string RotateRight(string input, int positions)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        int length = input.Length;
        positions = Math.Abs(positions);
        positions %= length;

        return input.Substring(length - positions) + input.Substring(0, length - positions);
    }
}
