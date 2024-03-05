using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NewsFeed.Models.DTO
{
    public class AuthDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        [Required]
        public string Password { get; set; }
    }
}
