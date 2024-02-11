namespace GetGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingProvider greetingProvider = new GreetingProvider(new FakeTimeProvider(new DateTime(2000, 2, 2)));
            string greeting = greetingProvider.GetGreeting();
            Console.WriteLine(greeting);
        }
    }

}