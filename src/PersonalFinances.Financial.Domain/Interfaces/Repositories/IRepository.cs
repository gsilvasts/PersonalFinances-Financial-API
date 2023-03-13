using PersonalFinances.Financial.Domain.Entities;
using System.Linq.Expressions;

namespace PersonalFinances.Financial.Domain.Interfaces.Repositories
{
    public interface IRepository<T>: IDisposable where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetByQueryAsync(Expression<Func<T, bool>> func);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(long id);
    }
}
