using System;

namespace TestApp;

public class Factorial
{
    public static int CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        if (n == 0)
        {
            return 1;
        }

        return n * CalculateFactorial(n - 1);
    }
}
