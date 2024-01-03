using GestionPret_Retour.Application.Contracts;
using GestionPret_Retour.Domain.Entities;
using GestionPret_Retour.Infrastructure.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Infrastructure.Repositories
{
    public class LoanRepository : ILoanRepository 
    {
        private readonly AppDbContext _context;

        public LoanRepository(AppDbContext context)
        {
            _context = context;
        }
      

        public async Task<IEnumerable<Loan>> GetLoansByUserIdAsync(int userId)
        {
            return await _context.Loans.Where(loan => loan.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Loan>> GetOverdueLoansAsync()
        {
            DateTime currentDate = DateTime.Now;
            return await _context.Loans.Where(loan => loan.ReturnDate < currentDate && !loan.IsReturned).ToListAsync();
        }
        public async Task<IEnumerable<Loan>> GetUnreturnedLoansAsync()
        {
            return await _context.Loans
                .Where(loan => loan.ReturnDate == null)
                .ToListAsync();
        }
        public virtual async Task<Loan> GetByIdAsync(int id)
        {
            return await _context.Set<Loan>().FindAsync(id);
        }

        public async Task<IReadOnlyList<Loan>> ListAllAsync()
        {
            return await _context.Set<Loan>().ToListAsync();
        }

        public async Task<Loan> AddAsync(Loan entity)
        {
            await _context.Set<Loan>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(Loan entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Loan entity)
        {
            _context.Set<Loan>().Remove(entity);
            await _context.SaveChangesAsync();
        }


    }

}
