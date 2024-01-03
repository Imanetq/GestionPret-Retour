using GestionPret_Retour.Application.Loans.Dommands.CreateLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.Services
{
    public interface ICreateLoanService
    {
        Task<int> CreateLoan(CreateLoanCommand request);
    }
}
