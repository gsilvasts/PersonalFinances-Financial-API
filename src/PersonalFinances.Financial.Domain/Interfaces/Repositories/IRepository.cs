using PersonalFinances.Financial.Domain.Entities;

namespace PersonalFinances.Financial.Domain.Interfaces.Repositories
{
    public interface IRepository<T>: IDisposable where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetByQueryAsync(Func<T, object> func);
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task TaskDeleteAsync(long id);
    }
}
