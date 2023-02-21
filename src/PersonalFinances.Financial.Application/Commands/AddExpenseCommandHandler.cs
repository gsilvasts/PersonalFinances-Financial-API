using AutoMapper;
using MediatR;
using PersonalFinances.Financial.Domain.Entities;
using PersonalFinances.Financial.Domain.Interfaces.Services;

namespace PersonalFinances.Financial.Application.Commands
{
    public class AddExpenseCommandHandler : IRequestHandler<AddExpenseCommand, Unit>
    {
        private readonly IExpenseService _service;
        private readonly IMapper _mapper;

        public AddExpenseCommandHandler(IExpenseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(AddExpenseCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = _mapper.Map<Expense>(request.InputModel);

                await _service.AddAsync(entity);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
