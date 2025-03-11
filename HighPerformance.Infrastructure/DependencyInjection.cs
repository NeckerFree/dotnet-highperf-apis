using HighPerformance.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace HighPerformance.Infrastructure
{
    namespace MyApp.Infrastructure
    {
        public static class DependencyInjection
        {
            public static IServiceCollection AddInfrastructure(this IServiceCollection services)
            {
                services.AddScoped<IProductRepository, ProductRepository>();
                return services;
            }
        }
    }
}
