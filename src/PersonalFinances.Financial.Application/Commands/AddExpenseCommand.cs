using MediatR;
using PersonalFinances.Financial.Application.InputModel;
using PersonalFinances.Financial.Domain.Entities;

namespace PersonalFinances.Financial.Application.Commands
{
    public class AddExpenseCommand : IRequest<Unit>
    {
        public AddExpenseCommand(ExpenseInputModel inputModel)
        {
            InputModel = inputModel;
        }

        public ExpenseInputModel InputModel { get; set; }
    }
}
