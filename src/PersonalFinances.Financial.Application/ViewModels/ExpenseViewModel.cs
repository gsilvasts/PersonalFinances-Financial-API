namespace PersonalFinances.Financial.Application.ViewModels
{
    public class ExpenseViewModel
    {
        public string Summary { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public int DueDate { get; set; }
        public string Category { get; set; }
    }
}
