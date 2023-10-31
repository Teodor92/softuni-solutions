// Read an array of integers

//int[] inputArray = Console.ReadLine()
//    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse)
//    .ToArray();

string[] rawArray = Console.ReadLine().Split(' ');
int[] inputArray = new int[rawArray.Length];

for (int i = 0; i < rawArray.Length; i += 1)
{
    inputArray[i] = int.Parse(rawArray[i]);
}

// Find the middle numbers

int middleRightElementIndex = inputArray.Length / 2;
int middleLeftElementIndex = middleRightElementIndex - 1;

int sumOfMiddleElements = inputArray[middleRightElementIndex] + inputArray[middleLeftElementIndex];

double middleElementsAverage = sumOfMiddleElements / 2.0;

Console.WriteLine($"{middleElementsAverage:F2}");

// 2 2
// 2 3 4 5
// 2 3 4 5 6 7
