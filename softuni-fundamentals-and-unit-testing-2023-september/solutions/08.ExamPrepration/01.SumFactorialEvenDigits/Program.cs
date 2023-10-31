// Read a number from the console and analyse digits
//int result = int.Parse(Console.ReadLine());

//while (result != 0)
//{
//    int digit = result % 10;

//    if (digit % 2 == 0)
//    {
//        //int resultFactorial = CalucateFactorial(digit);
//        totalResult += CalucateFactorial(digit);
//    }

//    result = result / 10;
//}

//string input = Console.ReadLine();
//int totalResult = 0;

foreach (char rawDigit in input)
{
    //int digit = rawDigit - '0';
    int digit = (int)char.GetNumericValue(rawDigit);

    if (digit % 2 == 0)
    {
        totalResult += CalucateFactorial(digit);
    }
}

//Console.WriteLine(totalResult);

//List<int> digits = Console.ReadLine().ToCharArray().Select(c => c - '0').ToList();
//int totalResult = 0;

//foreach (int digit in digits)
//{
//    if (digit % 2 == 0)
//    {
//        totalResult += CalucateFactorial(digit);
//    }
//}

//Console.WriteLine(totalResult);

int totalResult = Console.ReadLine()
    .ToCharArray()
    .Select(c => c - '0')
    .Where(digit => digit % 2 == 0)
    .Select(digit => CalucateFactorial(digit))
    .Sum();

Console.WriteLine(totalResult);

//1234
// 1234 % 10 = 4
// 1234 / 10 = 123

// 123 % 10 = 3
// 123 / 10 = 12

// 12 % 10 = 2
// 12 / 10 = 1

// 1 % 10 = 1
// 1 / 10 = 0

// '0' - 50
// '4' - 54
// '4' - '0' = 4

// Calucate Factorial
static int CalucateFactorial(int number)
{
    int result = 1;

    while(number > 0)
    {
        result = result * number;
        number -= 1;
    }

    return result;
}
