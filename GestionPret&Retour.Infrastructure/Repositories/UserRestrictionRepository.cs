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
    public class UserRestrictionRepository : IUserRestrictionRepository
    {
        private readonly AppDbContext _context;

        public UserRestrictionRepository(AppDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        public virtual async Task<UserRestriction> GetByIdAsync(Guid id)
        {
            return await _context.Set<UserRestriction>().FindAsync(id);
        }

        public async Task<IReadOnlyList<UserRestriction>> ListAllAsync()
        {
            return await _context.Set<UserRestriction>().ToListAsync();
        }

        public async Task<UserRestriction> AddAsync(UserRestriction entity)
        {
            await _context.Set<UserRestriction>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(UserRestriction entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(UserRestriction entity)
        {
            _context.Set<UserRestriction>().Remove(entity);
            await _context.SaveChangesAsync();
        }

    }
}
