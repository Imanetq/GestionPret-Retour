using Asp.Versioning;
using GestionPret_Retour.Application.Loans.Dommands.CreateLoan;
using GestionPret_Retour.Application.Loans.Queries.FindLoan;
using GestionPret_Retour.Application.Loans.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GestionPret_Retour.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoanController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [MapToApiVersion("1.0")]
        [HttpGet("{id}")]
        public async Task<ActionResult<FindLoanViewModel>> GetLoanById(int id)
        {
            var getEventDetailQuery = new FindLoanQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }
        [MapToApiVersion("1.0")]
        [HttpPost()]
        public async Task<ActionResult<int>> Create([FromBody] CreateLoanCommand createLoanCommand)
        {
            int id = await _mediator.Send(createLoanCommand);
            return Ok(id);
        }

    }
}
