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
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Book entity)
        {
            await _context.Set<Book>().AddAsync(entity);
            await _context.SaveChangesAsync();

            
        }

        public Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Book>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
