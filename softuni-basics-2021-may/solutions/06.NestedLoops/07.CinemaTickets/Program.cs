using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double studentTicketCount = 0;
            double standardTicketCount = 0;
            double kidTicketCount = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                double ticketsSoldForMovie = 0;

                for (int i = 0; i < availableSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicketCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketCount++;
                    }

                    ticketsSoldForMovie++;
                }

                //while (ticketType != "End")
                //{                   
                //    if (ticketType == "student")
                //    {
                //        studentTicketCount++;
                //    }
                //    else if (ticketType == "standard")
                //    {
                //        standardTicketCount++;
                //    }
                //    else if (ticketType == "kid")
                //    {
                //        kidTicketCount++;
                //    }

                //    ticketsSoldForMovie++;

                //    if (ticketsSoldForMovie == availableSeats)
                //    {
                //        break;
                //    } 

                //    ticketType = Console.ReadLine();
                //}

                double seatsTakenPercentage = ticketsSoldForMovie / availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTakenPercentage:F2}% full.");

                movie = Console.ReadLine();
            }

            double totalTickets = standardTicketCount + studentTicketCount + kidTicketCount;
            double standardTicketPercent = (standardTicketCount / totalTickets) * 100;
            double stundetTicketPercent = (studentTicketCount / totalTickets) * 100;
            double kidsTicketPercent = (kidTicketCount / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{stundetTicketPercent:F2}% student tickets.");
            Console.WriteLine($"{standardTicketPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidsTicketPercent:F2}% kids tickets.");
        }
    }
}
