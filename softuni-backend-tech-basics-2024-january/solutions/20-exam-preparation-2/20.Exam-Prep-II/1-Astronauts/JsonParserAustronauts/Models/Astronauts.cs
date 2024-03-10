using System.Text.Json.Serialization;


namespace JsonParser.Models
{

    public class Astronaut
    {
        [JsonPropertyName("astronautId")]
        public int AstronautId { get; set; }

        [JsonPropertyName("astronautName")]
        public string AstronautName { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("profession")]
        public string Profession { get; set; }

        [JsonPropertyName("yearsExperience")]
        public int YearsExperience { get; set; }

        [JsonPropertyName("missions")]
        public Missions Missions { get; set; }
    }

    public class Missions
    {
        [JsonPropertyName("current")]
        public string Current { get; set; }

        [JsonPropertyName("past")]
        public List<string> Past { get; set; }
    }
}

