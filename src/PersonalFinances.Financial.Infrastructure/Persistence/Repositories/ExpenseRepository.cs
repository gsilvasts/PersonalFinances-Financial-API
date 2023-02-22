using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;

namespace PersonalFinances.Financial.Infrastructure.Persistence.Repositories
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public Task GetExpensePaymentAsync(Guid userId, int month, int year)
        {
            throw new NotImplementedException();
        }
        public Task AddPaymentAsync(Payment payment)
        {
            throw new NotImplementedException();
        }

    }
}
