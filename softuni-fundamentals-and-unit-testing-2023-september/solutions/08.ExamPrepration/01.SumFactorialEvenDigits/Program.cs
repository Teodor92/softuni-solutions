int inputNumber = int.Parse(Console.ReadLine());
int totalResult = 0;

while (inputNumber != 0)
{
    int digit = inputNumber % 10;

    if (digit % 2 == 0)
    {
        totalResult += CalucateFactorial(digit);
    }

    inputNumber = inputNumber / 10;
}

Console.WriteLine(totalResult);

int CalucateFactorial(int number)
{
    int result = 1;
    while (number != 1)
    {
        result = result * number;
        number = number - 1;
    }
    return result;
}
