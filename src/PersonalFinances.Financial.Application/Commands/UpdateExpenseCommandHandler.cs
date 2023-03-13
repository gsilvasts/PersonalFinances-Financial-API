using AutoMapper;
using MediatR;
using PersonalFinances.Financial.Domain.Interfaces.Repositories;
using PersonalFinances.Financial.Domain.Interfaces.Services;

namespace PersonalFinances.Financial.Application.Commands
{
    public class UpdateExpenseCommandHandler : IRequestHandler<UpdateExpenseCommand, Unit>
    {
        private readonly IExpenseService _service;
        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;

        public UpdateExpenseCommandHandler(IExpenseService service, IMapper mapper, IExpenseRepository expenseRepository)
        {
            _service = service;
            _mapper = mapper;
            _expenseRepository = expenseRepository;
        }

        public async Task<Unit> Handle(UpdateExpenseCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var entity = await _expenseRepository.GetByIdAsync(request.Id);

                if (entity == null)
                    return Unit.Value;

                var model = request.InputModel;

                entity.Update(model.Summary, model.Description, model.Price, model.DueDay, model.StartDate, model.EndDate, model.CategoryId);

                await _service.UpdateAsync(entity);

                return Unit.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
