using MediatR;
using PersonalFinances.Financial.Application.ViewModels;

namespace PersonalFinances.Financial.Application.Queries
{
    public class GetExpensesByUserQuery : IRequest<List<ExpenseViewModel>>
    {
        public GetExpensesByUserQuery(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; set; }
    }
}
