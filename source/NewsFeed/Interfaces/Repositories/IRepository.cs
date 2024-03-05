using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsFeed.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable 
                     where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetEntityByIdAsync(Guid id);
        public Task<T> CreateEntityAsync(T entity);
        public Task<T> UpdateEntityAsync(T entity);
        public Task<bool> DeleteEntityAsync(Guid id);
    }
}
