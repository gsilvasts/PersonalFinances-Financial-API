using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalFinances.Financial.Application.Commands;
using PersonalFinances.Financial.Application.InputModel;

namespace PersonalFinances.Financial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpensesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] ExpenseInputModel model)
        {
            var command = new AddExpenseCommand(model);

            return Ok(await _mediator.Send(command));
        }
    }
}
