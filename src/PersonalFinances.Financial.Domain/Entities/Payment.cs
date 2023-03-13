namespace PersonalFinances.Financial.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Payment(long expenseId, DateOnly dueDate, DateOnly payDay, decimal price)
        {
            ExpenseId = expenseId;
            DueDate = dueDate;
            PayDay = payDay;
            Price = price;
        }

        public long ExpenseId { get; private set; }
        public DateOnly DueDate { get; private set; }
        public DateOnly PayDay { get; private set; }        
        public decimal Price { get; private set; }
    }
}
