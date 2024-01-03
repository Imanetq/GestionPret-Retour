using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Domain.Entities
{
    public class UserRestriction
    {
        public int UserRestrictionId { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public User User { get; set; }

        public DateTime EndDate { get; set; }
    }
}
