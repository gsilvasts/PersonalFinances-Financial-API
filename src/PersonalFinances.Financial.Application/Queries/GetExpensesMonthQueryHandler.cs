using MediatR;
using PersonalFinances.Financial.Application.ViewModels;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;

namespace PersonalFinances.Financial.Application.Queries
{
    public class GetExpensesMonthQueryHandler : IRequestHandler<GetExpensesMonthQuery, List<ExpenseMonthViewModel>>
    {
        private readonly IExpenseRepository _expenseRepository;

        public GetExpensesMonthQueryHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<List<ExpenseMonthViewModel>> Handle(GetExpensesMonthQuery request, CancellationToken cancellationToken)
        {
            var expenses = await _expenseRepository.GetExpensePaymentAsync(request.UserId, request.Month, request.Year);
            var viewModel = new List<ExpenseMonthViewModel>();

            expenses.ToList().ForEach(expense =>
            {
                viewModel.Add(new ExpenseMonthViewModel
                {
                    Summary = expense.Summary,
                    Price = expense.Price,
                    DueDate = new DateOnly(request.Year, request.Month, expense.DueDay),
                    PaymentDate = expense.Payments.FirstOrDefault(x => x.DueDate.Year.Equals(request.Year) && x.DueDate.Month.Equals(request.Month)).PayDay
                });
            });

            return viewModel;

        }
    }
}
