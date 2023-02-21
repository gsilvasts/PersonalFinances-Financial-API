using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;

namespace PersonalFinances.Financial.Infrastructure.Persistence.Repositories
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
    }
}
