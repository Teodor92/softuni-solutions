namespace _001.MethodOverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddMessage(""));
        }

        static string AddMessage(string message)
        {
            return message + "!";
        }

        static string AddMessage(int count, int moreCount)
        {
            return count.ToString();
        }
    }
}
