using System.Reflection;
using System.Text.Json;
using JsonParser.Models;

namespace JsonParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseAstronauts();
        }

        

        // Parses and displays astronauts data
        private static void ParseAstronauts()
        {
            string jsonFilePath = Path.Combine("Datasets", "Astronauts.json");
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                List<Astronaut>? astronauts = JsonSerializer.Deserialize<List<Astronaut>>(json);
                DisplayAstronauts(astronauts);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }



        // Displays the list of astronauts
        private static void DisplayAstronauts(List<Astronaut>? astronauts)
        {
            if (astronauts == null)
            {
                Console.WriteLine("No astronauts data found or data is not in the expected format.");
                return;
            }

            Console.WriteLine("Astronauts:");
            int astronautNumber = 1;
            foreach (var astronaut in astronauts)
            {
                Console.WriteLine($"Astronaut #{astronautNumber}");
                Console.WriteLine($"ID: {astronaut.AstronautId} Name: {astronaut.AstronautName}, Age: {astronaut.Age}");
                Console.WriteLine($"Profession: {astronaut.Profession} YearsExperience: {astronaut.YearsExperience}");
                Console.WriteLine($"Current Mission: {astronaut.Missions.Current}");
                string pastMissions = String.Join(", ", astronaut.Missions.Past);
                Console.WriteLine($"Past Missions: {pastMissions}");
                astronautNumber++;
            }
        }

        // Handles errors that occur during JSON parsing
        private static void HandleError(Exception e)
        {
            if (e is JsonException)
            {
                Console.WriteLine($"JSON Parsing Error: {e.Message}");
            }
            else
            {
                Console.WriteLine($"An unexpected error occurred: {e.Message}");
            }
        }
    }
}