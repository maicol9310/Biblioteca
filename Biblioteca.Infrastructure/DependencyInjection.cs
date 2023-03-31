using Biblioteca.Application.Interfaces;
using Biblioteca.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Add framework services.
            services.AddDbContext<LibraryDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ConnectionBiblioteca"),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(LibraryDbContext).GetTypeInfo().Assembly.GetName().Name);

                    sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                });
            }, ServiceLifetime.Scoped);


            services.AddScoped<ILibraryDbContext>(provider => provider.GetService<LibraryDbContext>());


            return services;
        }

    }
}
