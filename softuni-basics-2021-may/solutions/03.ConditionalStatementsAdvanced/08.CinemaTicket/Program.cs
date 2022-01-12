using System;

namespace _08.CinemaTicket
{
    class Program
    {
        //Monday Tuesday Wednesday Thursday    Friday Saturday    Sunday
        //    12	12	14	14	12	16	16


        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();

            if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                Console.WriteLine(16);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            //switch (dayOfTheWeek)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Friday":
            //        Console.WriteLine(12);
            //        break;
            //    case "Wednesday":
            //    case "Thursday":
            //        Console.WriteLine(14);
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        Console.WriteLine(16);
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}
        }
    }
}
