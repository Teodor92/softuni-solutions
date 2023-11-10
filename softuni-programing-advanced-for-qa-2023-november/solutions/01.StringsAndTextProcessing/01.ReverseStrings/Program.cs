string word = Console.ReadLine();

while (word != "end")
{
    //string reversedWord = "";
    //for (int i = word.Length - 1; i >= 0; i -= 1)
    //{
    //    reversedWord += word[i];
    //}

    //char[] wordAsCharArray = word.ToCharArray();
    //Array.Reverse(wordAsCharArray);
    //string reversedWord = string.Join("", wordAsCharArray);

    string reversedWord = string.Join("", word.ToCharArray().Reverse());
    //string newString = new string(word.ToCharArray().Reverse().ToArray());

    Console.WriteLine($"{word} = {reversedWord}");

    word = Console.ReadLine();
}
