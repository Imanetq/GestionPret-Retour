using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Contracts
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<IReadOnlyCollection<User>> ListAllAsync();
        Task AddAsync(User entity);
        Task<User> UpdateAsync(User entity);
       
    }
}
