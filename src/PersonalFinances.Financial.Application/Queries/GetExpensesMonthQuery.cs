using MediatR;
using PersonalFinances.Financial.Application.ViewModels;

namespace PersonalFinances.Financial.Application.Queries
{
    public class GetExpensesMonthQuery : IRequest<List<ExpenseMonthViewModel>>
    {
        public GetExpensesMonthQuery(Guid userId, int month, int year)
        {
            UserId = userId;
            Month = month;
            Year = year;
        }

        public Guid UserId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
