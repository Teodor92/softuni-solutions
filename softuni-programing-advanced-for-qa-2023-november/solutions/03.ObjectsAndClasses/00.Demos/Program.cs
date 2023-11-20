using _00.Demos;

//Dog puppy = new Dog
//{
//    Name = "Sparky",
//    Breed = "Corgi",
//    Age = 3,
//};

//puppy.Bark();

//Dog friend = new Dog();
//friend.Name = "Ivan";
//friend.Breed = "Unknown";
//friend.Age = 3;

//friend.Bark();

Dog dog1 = new Dog();
Dog dog = new Dog("John", "Corgi");
Dog dog2 = new Dog("John", "Corgi1", 12);

Console.WriteLine(dog2.Name);


//Dog test = null;

//Console.WriteLine(test.Name);


// PascalCase
// camelCase
// kebab-case
// underscore_case
// ALL_UPPER_CASE


Random dice = new Random();
int roll1 = dice.Next(1, 6);
Console.WriteLine($"First roll: {roll1}");
