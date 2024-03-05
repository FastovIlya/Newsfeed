using Microsoft.AspNetCore.Mvc;
using NewsFeed.Interfaces.Services;
using NewsFeed.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsFeed.Services
{
    public class UserService : IUserService
    {
        
        public UserService() { }

        public async Task<bool> DeleteUserAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetUserInfoAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> GetUserInfoByIdAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> ReplaceUserDataAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
