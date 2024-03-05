using NewsFeed.Models.DTO;
using System.Text.Json.Serialization;

namespace NewsFeed.Contracts
{
    public class CustomSuccessResponse
    {
        [JsonPropertyName("data")]
        public LoginUserDto Data {  get; set; }
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
