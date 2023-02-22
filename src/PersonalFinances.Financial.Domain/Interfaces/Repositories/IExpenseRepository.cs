using PersonalFinances.Financial.Domain.Entities;

namespace PersonalFinances.Financial.Domain.Interfaces.Repositories
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        Task GetExpensePaymentAsync(Guid userId, int month, int year);
        Task AddPaymentAsync(Payment payment);
    }
}
