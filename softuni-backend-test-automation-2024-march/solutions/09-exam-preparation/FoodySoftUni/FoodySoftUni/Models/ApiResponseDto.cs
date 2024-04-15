using System.Text.Json.Serialization;

namespace FoodySoftUni.Models
{
    public class ApiResponseDto
    {
        [JsonPropertyName("msg")]
        public string Message { get; set; }

        [JsonPropertyName("foodId")]
        public string? FoodId { get; set; }
    }
}
