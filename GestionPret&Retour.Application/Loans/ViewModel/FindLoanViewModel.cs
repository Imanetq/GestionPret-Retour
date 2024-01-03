using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.ViewModel
{
    public class FindLoanViewModel
    {
        public int LoanId { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public bool LateReturn { get; set; }
    }
}
