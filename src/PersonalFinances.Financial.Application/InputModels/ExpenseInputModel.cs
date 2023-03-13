using PersonalFinances.Financial.Domain.Enums;

namespace PersonalFinances.Financial.Application.InputModel
{
    public class ExpenseInputModel
    {
        public ExpenseInputModel(Guid userId, string summary, string description, decimal price, int dueDay, DateOnly startDate, DateOnly? endDate, long categoryId)
        {
            UserId = userId;
            Summary = summary;
            Description = description;
            Price = price;
            DueDay = dueDay;
            StartDate = startDate;
            EndDate = endDate;
            CategoryId = categoryId;
        }

        public Guid UserId { get; private set; }
        public string Summary { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }        
        public int DueDay { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public long CategoryId { get; set; }        
    }
}
