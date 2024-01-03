using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Contracts
{
    public interface ILoanRepository
    {
        Task<Loan> GetByIdAsync(int id);

        Task<IReadOnlyList<Loan>> ListAllAsync();

        Task<Loan> AddAsync(Loan entity);

        Task UpdateAsync(Loan entity);

        Task DeleteAsync(Loan entity);
        Task<IEnumerable<Loan>> GetLoansByUserIdAsync(int userId);
        Task<IEnumerable<Loan>> GetOverdueLoansAsync();
       
        Task<IEnumerable<Loan>> GetUnreturnedLoansAsync();
    }
}
