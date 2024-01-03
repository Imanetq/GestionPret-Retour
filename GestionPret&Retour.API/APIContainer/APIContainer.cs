using Asp.Versioning;
using GestionPret_Retour.Application.Loans.Services;
using MediatR;
using System.Reflection;

namespace GestionPret_Retour.API.APIContainer
{
    public static class APIContainer
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.ReportApiVersions = true;
                opt.ApiVersionReader = ApiVersionReader.Combine(new HeaderApiVersionReader("x-api-version"), new QueryStringApiVersionReader("api-version"));
            });



            services
                 .AddApiVersioning()
                .AddApiExplorer(options =>
                {

                    options.GroupNameFormat = "'v'VVV";
                    options.SubstituteApiVersionInUrl = true;
                });
            return services;
        }
    }
}
