using GestionPret_Retour.Application.Loans.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.Queries.FindLoan
{
    public class FindLoanQuery: IRequest<FindLoanViewModel>
    {
        public int Id { get; set; }
    }
}
