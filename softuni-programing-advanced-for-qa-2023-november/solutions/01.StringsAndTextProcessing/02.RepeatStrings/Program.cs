using System.Text;

//string result = string.Concat(
//    Console.ReadLine()
//    .Split(" ")
//    .Select(x => string.Concat(Enumerable.Repeat(x , x.Length))));

//Console.WriteLine(result);

string[] input = Console.ReadLine().Split();

StringBuilder output = new StringBuilder();

foreach (var word in input)
{
    for (int i = 0; i < word.Length; i++)
    {
        output.Append(word);
    }
}

Console.WriteLine(output);
