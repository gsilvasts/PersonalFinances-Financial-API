using MongoDB.Driver;
using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;

namespace PersonalFinances.Financial.Infrastructure.Persistence.Repositories
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(IMongoDatabase mongoDataBase) : base(mongoDataBase)
        {
            
        }
        public async Task<List<Expense>> GetExpensePaymentAsync(Guid userId, int month, int year)
        {
            return await _collection.FindAsync(Builders<Expense>.Filter.Where(x => x.UserId.Equals(userId))).Result.ToListAsync();
        }
        public Task AddPaymentAsync(Payment payment)
        {
            throw new NotImplementedException();
        }

    }
}
