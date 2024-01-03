using GestionPret_Retour.Application.Contracts;
using GestionPret_Retour.Infrastructure.ApplicationDbContext;
using GestionPret_Retour.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Infrastructure.PersistenceContainer
{
    public static class PersistenceServicesExtensions
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("default"), b => b.MigrationsAssembly("GestionPret&Retour.Infrastructure")));

            services.AddScoped(typeof(IUserRestrictionRepository), typeof(UserRestrictionRepository));
            services.AddScoped(typeof(ILoanRepository), typeof(LoanRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));
            return services;
        }
    }
}