string[] banList = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

for (int i = 0; i < banList.Length; i++)
{
    string word = banList[i];
    string someSort = string.Empty;

    while (text.Contains(word))
    {
        string wordWithCensor = someSort.PadLeft(word.Length, '*');
        text = text.Replace(word, wordWithCensor);
    }
}

Console.WriteLine(text);
