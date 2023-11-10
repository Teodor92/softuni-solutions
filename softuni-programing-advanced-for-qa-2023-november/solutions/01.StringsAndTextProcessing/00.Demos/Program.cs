//string firstWord = "Hey!";
//string secondWord = "World?";

//Console.WriteLine(firstWord + secondWord);

//firstWord += secondWord;

//Console.WriteLine(firstWord);
//Console.WriteLine(string.Concat(firstWord, secondWord));


//string wordA = "Hey!";
//string wordB = "Hello!";
//string wordC = "Hola!";


//Console.WriteLine(string.Join("|", wordA, wordB, wordC));

//string s = "abc";
//string[] arr = new string[3];

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = s;
//}

//string repeated = string.Join("|", arr); // "abcabcabc"
//Console.WriteLine(repeated);


//string alphabet = "abcdefjgk";
//Console.WriteLine(alphabet.Substring(3, 3));

//string text = "Hello, john@softuni.org, you have been using john@softuni.org in your registration";

//string[] words = text.Split(new char[] { ' ', ',', '.', '@' }, StringSplitOptions.RemoveEmptyEntries);

//Console.WriteLine(string.Join("|", words));

//string result = "".PadRight(3, '*');
//Console.WriteLine(result);


//static string AddMessage(string message)
//{
//    return message + "!";
//}

//static string AddMessage(string message, int count)
//{
//    return message + new string('!', count);
//}


//"asdasd".Substring()

//Console.WriteLine(new string('*', 10));

using System.Diagnostics;
using System.Text;

//StringBuilder output = new StringBuilder();

//output.Append("Hello!");
//output.Append("World?");

//Console.WriteLine(output.ToString());

//Console.WriteLine("Hello!" + "World!");

//Stopwatch sw = new Stopwatch();
//sw.Start();
//string text = "";
//for (int i = 0; i < 200000; i++)
//{
//    text += i;
//}   
//sw.Stop();
//Console.WriteLine(sw.ElapsedMilliseconds);


//Stopwatch sw1 = new Stopwatch();
//sw1.Start();
//StringBuilder sb = new();
//for (int i = 0; i < 2000000; i++)
//{
//    sb.Append(i);
//}

//string result = sb.ToString();
//sw1.Stop();
//Console.WriteLine(sw1.ElapsedMilliseconds);


//StringBuilder sb = new();

//sb.Append("Hello!");
//sb.AppendLine("World?");
//sb.AppendLine("World?!");
////sb.Clear();
////sb.Insert(10, "INSERTED!");

//string result = sb.ToString();

//Console.WriteLine(sb);

//Console.WriteLine(Enumerable.Repeat("ASD", 2));


Console.WriteLine("asd".ToUpper());
Console.WriteLine("ASD".ToLower());
