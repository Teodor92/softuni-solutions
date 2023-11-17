//List<string> exampleList = new();
//Dictionary<string, string> phoneBook = new();

//phoneBook.Add("Teodor Kurtev", "+359 88 88 888");
//phoneBook.Add("John Smith", "999999999");
//phoneBook.Add("John Smith1", "88888888");

//phoneBook["Jane Doe"] = "89898989";
//phoneBook["Jane Doe"] = "0000000";

//phoneBook.Remove("Teodor Kurtev");

//phoneBook.Add("Jane Doe", "89898989");

//string value = phoneBook["Teodor Kurtev"];

//Console.WriteLine(value);

//phoneBook["Teodor Kurtev"] = "00000000";

//Console.WriteLine(phoneBook["Teodor Kurtev"]);

//Dictionary<string, double> fruits = new()
//{
//    { "strawberry", 22.2 },
//    { "cherry", 23.2 }
//};


//fruits["kiwi"] = 4.50;
//fruits["orange"] = 2.50;
//fruits["banana"] = 2.20;

//foreach (KeyValuePair<string, double> item in fruits)
//{
//    Console.WriteLine($"{item.Key} - {item.Value}");
//}


//List<int> testList = new() { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine(testList.Min());
//Console.WriteLine(testListStrings.Min());

//Console.WriteLine(testList.Max());
//Console.WriteLine(testList.Sum());
//Console.WriteLine(testList.Average());


List<string> testListStrings = new() { "hello", "world", "Maybe?", "a" };


// "hello" -> "hello!"
// "world" -> "world!"
// "hey!" -> "hey!!"

// x => x + "!"



// 2 -> 5
// 5 -> 8
// 7 -> 10

// x => x + 3

//List<string> names = new() { "Teodor", "Ivan", "John" };

//List<string> result = names.Select(x => x + "!").ToList();
//Console.WriteLine(string.Join(", ", result));

//string[] result1 = names.Select(x => x.ToLower()).ToArray();
//Console.WriteLine(string.Join(", ", result1));

//var result2 = names.Select(x => $"{x}!?ddd");
//Console.WriteLine(string.Join(", ", result2));
//int[] result3 = names.Select(x => int.Parse(x)).ToArray();

var input = new List<string> { "1", "2", "3", "33", "3", "3" };

var orderedInput = input.OrderByDescending(x => x.ToLower());

bool hasItem = input.Any(x => x == "44");
Console.WriteLine(hasItem);

var result = input.Distinct();
Console.WriteLine(string.Join(", ", result));

var result1 = input.Take(4);
Console.WriteLine(string.Join(", ", result1));

var result2 = input.Skip(4);
Console.WriteLine(string.Join(", ", result2));

var result3 = input
    .GroupBy(x => x.ToLower())
    .ToDictionary(x => x.Key, x => x.Count());

var countResult = input.Count(x => x.Length < 2);

Console.WriteLine(countResult);

Func<string, bool> filterFunc = x => x.Length < 2;

//var result4 = input.Where(x =>
//{


//    return x.Length == 2;
//});
//Console.WriteLine(string.Join(", ", result4));


//List<int> numbers = new() { 1, 3, 56, 44, 33, 100 };
//var result = numbers.Where(x => x % 2 != 0 && x != 3).ToList();

//Console.WriteLine(string.Join(", ", result));

