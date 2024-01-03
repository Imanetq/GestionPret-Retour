using GestionPret_Retour.Application.Loans.ViewModel;
using GestionPret_Retour.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.Dommands.CreateLoan
{
    public class CreateLoanCommand:IRequest<int>
    {
        public int LoanId { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Boolean IsReturned { get; set; }
        public Boolean LateReturn { get; set; }
        public IEnumerable<BookViewModel> Books { get; set; }
    }
}
