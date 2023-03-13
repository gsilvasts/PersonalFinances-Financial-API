namespace PersonalFinances.Financial.Application.ViewModels
{
    public class ExpenseMonthViewModel
    {
        public string Summary { get; set; }
        public decimal Price { get; set; }
        public DateOnly DueDate { get; set; }
        public DateOnly? PaymentDate { get; set; }
    }
}
