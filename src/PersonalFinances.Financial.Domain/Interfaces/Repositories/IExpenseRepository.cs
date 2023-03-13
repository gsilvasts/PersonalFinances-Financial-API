using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Services;

namespace PersonalFinances.Financial.Domain.Interfaces.Repositories
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        Task<List<Expense>> GetExpensePaymentAsync(Guid userId, int month, int year);
        Task AddPaymentAsync(Payment payment);
    }
}
