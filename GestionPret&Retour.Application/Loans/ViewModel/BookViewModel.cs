using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.ViewModel
{
    public class BookViewModel
    {
        public BookViewModel(int id, int quantity, int loanId)
        {
            Id = id;
            Quantity = quantity;
            LoanId = loanId;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int LoanId { get; set; }
    }
}
