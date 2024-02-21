using System.Text.Json.Serialization;


namespace JsonParser.Models
{

    public class Musician
    {
        [JsonPropertyName("participantId")]
        public int ParticipantId { get; set; }

        [JsonPropertyName("participantName")]
        public string ParticipantName { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonPropertyName("instrumentSkills")]
        public List<InstrumentSkill> InstrumentSkills { get; set; }

        [JsonPropertyName("preferredGenres")]
        public List<string> PreferredGenres { get; set; }
    }

    public class InstrumentSkill
    {
        [JsonPropertyName("instrumentName")]
        public string InstrumentName { get; set; }

        [JsonPropertyName("experienceLevel")]
        public double ExperienceLevel { get; set; }
    }
}

