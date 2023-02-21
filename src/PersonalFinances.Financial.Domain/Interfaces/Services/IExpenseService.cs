using PersonalFinances.Financial.Domain.Entities;

namespace PersonalFinances.Financial.Domain.Interfaces.Services
{
    public interface IExpenseService
    {
        public Task<IEnumerable<Expense>> GetExpensesByUserAsync(Guid userId);
        public Task<IEnumerable<Expense>> GetExpensesByUserAsync(Guid userId, int month);
        public Task AddAsync(Expense expense);
        public Task UpdateAsync(Expense expense);
    }
}
