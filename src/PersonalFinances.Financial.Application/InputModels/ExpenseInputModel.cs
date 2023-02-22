using PersonalFinances.Financial.Domain.Enums;

namespace PersonalFinances.Financial.Application.InputModel
{
    public class ExpenseInputModel
    {
        public Guid UserId { get; private set; }
        public string Summary { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public Recurrence Recurrence { get; set; }
        public int DueDate { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public long CategoryId { get; set; }        
    }
}
