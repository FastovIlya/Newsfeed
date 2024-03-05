using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NewsFeed.Models.DTO
{

    public class RegisterUserDto
    {
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
        [MinLength(3)]
        [MaxLength(100)]
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [MinLength(3)]
        [MaxLength(25)]
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [MinLength(3)]
        [MaxLength(100)]
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        [MinLength(3)]
        [MaxLength(25)]
        [JsonPropertyName("role")]
        public string? Role { get; set; }        
    }
}
