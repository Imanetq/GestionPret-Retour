using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Contracts
{
    public interface IUserRestrictionRepository 
    {
        Task<UserRestriction> GetByIdAsync(Guid id);

        Task<IReadOnlyList<UserRestriction>> ListAllAsync() ;

         Task<UserRestriction> AddAsync(UserRestriction entity);

         Task UpdateAsync(UserRestriction entity);

        Task DeleteAsync(UserRestriction entity) ;
    }
}
