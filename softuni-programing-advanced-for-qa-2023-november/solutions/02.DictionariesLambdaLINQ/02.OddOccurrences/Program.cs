string[] words = Console.ReadLine()
    .Split(" ")
    .Select(x => x.ToLower())
    .ToArray();

Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
    if (wordsCount.ContainsKey(word))
    {
        wordsCount[word] += 1;
    }
    else
    {
        wordsCount.Add(word, 1);
    }
}

string[] result = wordsCount
    .Where(x => x.Value % 2 != 0)
    .Select(x => x.Key)
    .ToArray();

Console.WriteLine(string.Join(" ", result));

//foreach (KeyValuePair<string, int> pair in wordsCount)
//{
//    if (pair.Value % 2 != 0)
//    {
//        Console.Write($"{pair.Key} ");
//    }
//}


// key -> value
