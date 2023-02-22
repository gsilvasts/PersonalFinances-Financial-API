using PersonalFinances.Financial.Domain.Enums;

namespace PersonalFinances.Financial.Domain.Entities
{
    public class Expense : BaseEntity
    {
        public Expense(Guid userId, string summary, string description, decimal price, int dueDate, DateOnly startDate, DateOnly? endDate, long categoryId)
        {
            UserId = userId;
            Summary = summary;
            Description = description;
            Price = price;            
            DueDate = dueDate;
            StartDate = startDate;
            EndDate = endDate;
            CategoryId = categoryId;
        }

        public Guid UserId { get; private set; }
        public string Summary { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int DueDate { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }        
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public List<Payment> Payments { get; set; }

        public void Update(string summary, string description, decimal price, int dueDate, DateOnly startDate, DateOnly? endDate, long categoryId)
        {
            Summary = summary;
            Description = description;
            Price = price;            
            DueDate = dueDate;
            StartDate = startDate;
            EndDate = endDate;
            CategoryId = categoryId;
        }
    }
}
