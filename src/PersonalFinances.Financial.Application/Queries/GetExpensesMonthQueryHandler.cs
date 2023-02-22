using MediatR;
using PersonalFinances.Financial.Application.ViewModels;
using PersonalFinances.Financial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinances.Financial.Application.Queries
{
    public class GetExpensesMonthQueryHandler : IRequestHandler<GetExpensesMonthQuery, List<ExpenseMonthViewModel>>
    {
        private readonly IExpenseService _service;

        public GetExpensesMonthQueryHandler(IExpenseService service)
        {
            _service = service;
        }

        public async Task<List<ExpenseMonthViewModel>> Handle(GetExpensesMonthQuery request, CancellationToken cancellationToken)
        {
            
        }
    }
}
