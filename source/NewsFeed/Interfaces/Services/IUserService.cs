using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NewsFeed.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsFeed.Interfaces.Services
{
    /// <summary>
    /// Интерфейс сервиса для работы с пользователями.
    /// </summary>
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> ReplaceUserDataAsync();
        Task<bool> DeleteUserAsync();
        Task<User> GetUserInfoByIdAsync();
        Task<User> GetUserInfoAsync();
    }
}
