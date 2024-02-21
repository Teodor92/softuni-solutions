using System.Text.Json;
using JsonParser.Models;

namespace JsonParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseMusicians();
        }

        

        // Parses and displays musicians data
        private static void ParseMusicians()
        {
            string jsonFilePath = Path.Combine("Datasets", "Musicians.json");
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                List<Musician>? musicians = JsonSerializer.Deserialize<List<Musician>>(json);
                DisplayMusicians(musicians);
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }



        // Displays the list of musicians
        private static void DisplayMusicians(List<Musician>? musicians)
        {
            if (musicians == null)
            {
                Console.WriteLine("No musicians data found or data is not in the expected format.");
                return;
            }

            Console.WriteLine("Musicians:");
            int musicianNumber = 1;
            foreach (var musician in musicians)
            {
                Console.WriteLine($"Musician #{musicianNumber}");
                Console.WriteLine($"ID: {musician.ParticipantId} Name: {musician.ParticipantName}, Date of Birth: {musician.DateOfBirth.ToString("yyyy-MM-dd")}");

                int instrumentNumber = 1;
                foreach (var instrument in musician.InstrumentSkills)
                {
                    

                    Console.WriteLine($"Instrument #{instrumentNumber}: {instrument.InstrumentName}, Skill level: {instrument.ExperienceLevel}");
                    instrumentNumber++;
                }
                musicianNumber++;
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