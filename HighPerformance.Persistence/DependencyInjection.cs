using HighPerformance.Application.Interfaces;
using HighPerformance.Persistence.Contexts;
using HighPerformance.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HighPerformance.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the DbContext with SQLite
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            // Register repositories (if not already registered in Infrastructure)
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}