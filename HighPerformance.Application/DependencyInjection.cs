using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Products.Commands;
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
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetProductCommand).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateProductCommand).Assembly));
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
