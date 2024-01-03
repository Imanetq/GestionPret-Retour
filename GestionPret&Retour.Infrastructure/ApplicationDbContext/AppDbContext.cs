using GestionPret_Retour.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Infrastructure.ApplicationDbContext
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
        {
        }
        public virtual DbSet<Loan> Loans { get; set; }
    }
}
