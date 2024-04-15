using System.Text.Json.Serialization;

namespace FoodySoftUni.Models
{
    public class AuthenticationRequest
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
