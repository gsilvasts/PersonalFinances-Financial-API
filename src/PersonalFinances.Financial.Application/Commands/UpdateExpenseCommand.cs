using MediatR;
using PersonalFinances.Financial.Application.InputModel;

namespace PersonalFinances.Financial.Application.Commands
{
    public class UpdateExpenseCommand : IRequest<Unit>
    {
        public UpdateExpenseCommand(long id, ExpenseInputModel inputModel)
        {
            Id = id;
            InputModel = inputModel;
        }

        public long Id { get; set; }
        public ExpenseInputModel InputModel{ get; set; }
    }
}
