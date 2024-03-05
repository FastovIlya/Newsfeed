using NewsFeed.Contracts;
using NewsFeed.Models.DTO;
using System.Threading.Tasks;

namespace NewsFeed.Interfaces.Services
{
    public interface IAuthService
    {
        Task<LoginUserDto> RegisterUserAsync(RegisterUserDto registerUserDto);

        Task<CustomSuccessResponse> LoginUserAsync(AuthDto registerUserDto);
    }
}
