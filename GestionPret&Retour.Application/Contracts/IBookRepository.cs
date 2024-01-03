using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Contracts
{
    public interface IBookRepository
    {
        Task<Book> GetByIdAsync(int id);

        Task<IReadOnlyList<Book>> ListAllAsync();

        Task AddAsync(Book entity);

        Task UpdateAsync(Book entity);
    }
}
