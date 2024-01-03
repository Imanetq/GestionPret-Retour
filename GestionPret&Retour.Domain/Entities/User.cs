using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Domain.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public Boolean IsBanned { get; set; }
        public int CountPenalties { get; set; }
        public virtual ICollection<Loan>  Loans { get; set; }
        public virtual ICollection<UserRestriction> UserRestrictions { get; set; } 
        public User()
        {
            CountPenalties = 0;
        }
    }
}
