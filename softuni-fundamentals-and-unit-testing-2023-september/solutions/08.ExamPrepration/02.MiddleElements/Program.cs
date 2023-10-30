double[] inputArray = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

if (inputArray.Length == 0)
{
    Console.WriteLine(0);
}

int leftMiddleElementIndex = inputArray.Length / 2;
double middleElementsSum = (inputArray[leftMiddleElementIndex] + inputArray[leftMiddleElementIndex - 1]) / 2;
Console.WriteLine($"{middleElementsSum:F2}");
