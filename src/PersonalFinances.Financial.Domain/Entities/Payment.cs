namespace PersonalFinances.Financial.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public long ExpenseId { get; set; }
        public DateOnly PayDay { get; set; }
        public decimal Price { get; set; }
    }
}
