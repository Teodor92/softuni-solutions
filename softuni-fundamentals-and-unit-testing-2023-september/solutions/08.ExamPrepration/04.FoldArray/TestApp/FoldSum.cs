using System.Linq;

namespace TestApp;

public class FoldSum
{
    public static string FoldArray(int[] arr)
    {
        int k = arr.Length / 4;

        int[] topRow = arr
            .Take(k)
            .Reverse()
            .Concat(arr.Skip(arr.Length - k).Reverse())
            .ToArray();

        int[] bottomRow = arr
            .Skip(k)
            .Take(k * 2)
            .ToArray();

        string result = string.Empty;
        for (int i = 0; i < topRow.Length; i++)
        {
            result += $"{topRow[i] + bottomRow[i]} ";
        }

        return result.Trim();
    }
}
