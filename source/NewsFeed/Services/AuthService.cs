using NewsFeed.Contracts;
using NewsFeed.Interfaces.Services;
using NewsFeed.Models.DTO;
using System.Threading.Tasks;

namespace NewsFeed.Services
{
    public class AuthService : IAuthService
    {
        public async Task<CustomSuccessResponse> LoginUserAsync(AuthDto registerUserDto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<LoginUserDto> RegisterUserAsync(RegisterUserDto registerUserDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
