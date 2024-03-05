using NewsFeed.Interfaces.Repositories;
using NewsFeed.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsFeed.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private NewsFeedContext _context;
        public UserRepository(NewsFeedContext context) 
        {
            _context = context;
        }
        public async Task<User> CreateEntityAsync(User entity)
        {
            var user = await _context.Users.AddAsync(entity);
            if (user == null)
                throw new Exception("Не удалось сохранить нового пользователя");
            await _context.SaveChangesAsync();
            return user.Entity;
        }

        public async Task<bool> DeleteEntityAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetEntityByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateEntityAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
