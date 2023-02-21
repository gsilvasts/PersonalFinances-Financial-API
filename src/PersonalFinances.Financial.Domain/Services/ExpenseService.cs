using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;
using PersonalFinances.Financial.Domain.Interfaces.Services;

namespace PersonalFinances.Financial.Domain.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task AddAsync(Expense expense)
        {
            await _expenseRepository.CreateAsync(expense);

            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Expense>> GetExpensesByUserAsync(Guid userId)
        {
            return await _expenseRepository.GetByQueryAsync(x=>x.UserId.Equals(userId));
        }

        public Task<IEnumerable<Expense>> GetExpensesByUserAsync(Guid userId, int month)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Expense expense)
        {
            await _expenseRepository.UpdateAsync(expense);

            await Task.CompletedTask;
        }
    }
}
