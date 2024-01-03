using AutoMapper;
using GestionPret_Retour.Application.Contracts;
using GestionPret_Retour.Application.Loans.Services;
using GestionPret_Retour.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.Dommands.CreateLoan
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand,int>
    {
        
        private readonly ICreateLoanService _service;

        public CreateLoanCommandHandler(ICreateLoanService createLoanService)
        {
            _service = createLoanService;
        }

         public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            return await _service.CreateLoan(request);
        }
    }
}
