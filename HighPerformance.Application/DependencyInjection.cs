using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HighPerformance.Application
{
    public static class DependencyInjection
        {
            public static IServiceCollection AddApplication(this IServiceCollection services)
            {
                // Register MediatR (if using CQRS)
                services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

                // Register application services
                services.AddScoped<IProductService, ProductService>();

                return services;
            }
        }
    }
