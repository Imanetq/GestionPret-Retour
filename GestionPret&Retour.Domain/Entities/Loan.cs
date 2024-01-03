using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Domain.Entities
{
    public class Loan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoanId { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Boolean IsReturned { get; set; }
        public Boolean LateReturn { get; set; }
        public User User { get; set; }
        public virtual ICollection<Book> books { get; set; }
       
    }
}
