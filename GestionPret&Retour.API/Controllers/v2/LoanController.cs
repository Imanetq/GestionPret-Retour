using Asp.Versioning;
using GestionPret_Retour.Application.Loans.Dommands.CreateLoan;
using GestionPret_Retour.Application.Loans.Queries.FindLoan;
using GestionPret_Retour.Application.Loans.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GestionPret_Retour.API.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
       
        [MapToApiVersion("2.0")]
        [HttpGet("{id}", Name = "FindLoanById")]
        public async Task<int> GetLoanById(int id)
        {
          
            return id+100;
        }
       

    }
}
