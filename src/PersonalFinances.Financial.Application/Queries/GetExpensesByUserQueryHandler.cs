using AutoMapper;
using MediatR;
using PersonalFinances.Financial.Application.ViewModels;
using PersonalFinances.Financial.Domain.Interfaces.Services;

namespace PersonalFinances.Financial.Application.Queries
{
    public class GetExpensesByUserQueryHandler : IRequestHandler<GetExpensesByUserQuery, List<ExpenseViewModel>>
    {
        private readonly IExpenseService _service;
        private readonly IMapper _mapper;

        public GetExpensesByUserQueryHandler(IExpenseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<ExpenseViewModel>> Handle(GetExpensesByUserQuery request, CancellationToken cancellationToken)
        {
            var entity = await _service.GetExpensesByUserAsync(request.UserId);

            if (!entity.Any())
                return null;

            return  _mapper.Map<IEnumerable<ExpenseViewModel>>(entity).ToList();
        }
    }
}
