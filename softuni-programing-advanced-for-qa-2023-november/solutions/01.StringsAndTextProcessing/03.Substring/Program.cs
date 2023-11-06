string wordToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(wordToRemove))
{
    int indexOfWord = text.IndexOf(wordToRemove);
    text = text.Remove(indexOfWord, wordToRemove.Length);
}

Console.WriteLine(text);

