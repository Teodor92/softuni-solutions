using System.Text;

string text = Console.ReadLine();

StringBuilder digits = new();
StringBuilder letters = new();
StringBuilder otherSymbols = new();

foreach (char symbol in text)
{
    if(char.IsDigit(symbol))
    {
        digits.Append(symbol);
    }
    else if (char.IsLetter(symbol))
    {
        letters.Append(symbol);
    }
    else
    {
        otherSymbols.Append(symbol);
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(otherSymbols);
