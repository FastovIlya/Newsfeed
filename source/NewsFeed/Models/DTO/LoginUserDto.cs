using System.Text.Json.Serialization;

namespace NewsFeed.Models.DTO
{    
    public class LoginUserDto
    {
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
