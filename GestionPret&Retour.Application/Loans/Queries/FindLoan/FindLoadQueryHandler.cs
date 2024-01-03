using AutoMapper;
using GestionPret_Retour.Application.Contracts;
using GestionPret_Retour.Application.Loans.ViewModel;
using GestionPret_Retour.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.Queries.FindLoan
{
    public class FindLoadQueryHandler : IRequestHandler<FindLoanQuery,FindLoanViewModel>
    {
        private readonly IMapper _mapper;
        private readonly ILoanRepository _postRepository;
        public FindLoadQueryHandler(ILoanRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<FindLoanViewModel> Handle(FindLoanQuery request, CancellationToken cancellationToken)
        {
            var loan = await _postRepository.GetByIdAsync(request.Id);
           
            return _mapper.Map<FindLoanViewModel>(loan);

        }
    }
}
