using MongoDB.Driver;
using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace PersonalFinances.Financial.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly IMongoCollection<T> _collection;
        public Repository(IMongoDatabase mongoDataBase)
        {
            _collection = mongoDataBase.GetCollection<T>(typeof(T).Name);
        }
        public async Task CreateAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _collection.FindAsync(Builders<T>.Filter.Empty).Result.ToListAsync();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await _collection.FindAsync(x=>x.Id.Equals(id)).Result.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetByQueryAsync(Expression<Func<T, bool>> func)
        {
            return await _collection.FindAsync(Builders<T>.Filter.Where(func)).Result.ToListAsync();            
        }

        public async Task DeleteAsync(long id)
        {
            await _collection.DeleteOneAsync(x=>x.Id.Equals(id));
        }

        public async Task UpdateAsync(T entity)
        {
            await _collection.ReplaceOneAsync(x=>x.Id.Equals(entity.Id), entity);
        }
    }
}
