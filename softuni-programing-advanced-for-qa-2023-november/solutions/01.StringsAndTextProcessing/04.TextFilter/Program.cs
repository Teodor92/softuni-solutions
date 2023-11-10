string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
    //string censorWord = "".PadLeft(bannedWord.Length, '*');
    string censorWord = new string('*', bannedWord.Length);

    if (text.Contains(bannedWord))
    {
        text = text.Replace(bannedWord, censorWord);
    }
}

Console.WriteLine(text);
