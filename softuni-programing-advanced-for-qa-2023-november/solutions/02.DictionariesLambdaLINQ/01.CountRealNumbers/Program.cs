int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

SortedDictionary<int, int> numbersFrequency = new();

foreach (int number in numbers)
{
    if (numbersFrequency.ContainsKey(number))
    {
        numbersFrequency[number] = numbersFrequency[number] + 1;
    }
    else
    {
        numbersFrequency.Add(number, 1);
        //numbersFrequency[number] = 1;
    }
}

foreach (KeyValuePair<int, int> pair in numbersFrequency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
