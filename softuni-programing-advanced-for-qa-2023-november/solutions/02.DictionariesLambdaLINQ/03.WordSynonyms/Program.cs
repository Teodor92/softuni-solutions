int numberOfPairs = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> synonyms = new();

for (int i = 0; i < numberOfPairs; i += 1)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if(synonyms.ContainsKey(word))
    {
        synonyms[word].Add(synonym);
    }
    else
    {
        synonyms.Add(word, new List<string> { synonym });
    }
}

// Dictonary<string, string>
// KeyValuePair<string, string>

// Dictonary<string, List<string>>
// KeyValuePair<string, List<string>>

foreach (KeyValuePair<string, List<string>> pair in synonyms)
{
    Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
}
