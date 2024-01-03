using GestionPret_Retour.Application.Contracts;
using GestionPret_Retour.Domain.Entities;
using GestionPret_Retour.Infrastructure.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task  AddAsync(User entity)
        {
            await _context.Set<User>().AddAsync(entity);
            await _context.SaveChangesAsync();

           
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Set<User>().FindAsync(id);
        }

        Task<IReadOnlyCollection<User>> IUserRepository.ListAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<User> IUserRepository.UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
