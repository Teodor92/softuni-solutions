using System;

namespace _04.PersonalTitles
{
    class Program
    {
//        •	"Mr." – мъж(пол 'm') на 16 или повече години
//•	"Master" – момче(пол 'm') под 16 години
//•	"Ms." – жена(пол 'f') на 16 или повече години
//•	"Miss" – момиче(пол 'f') под 16 години


        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
        }
    }
}
