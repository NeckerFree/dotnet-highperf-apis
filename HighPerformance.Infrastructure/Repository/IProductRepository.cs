using HighPerformance.Domain.Entities;

namespace HighPerformance.Infrastructure.Repository
{
    public interface IProductRepository
    {
        // Get a product by its ID
        Task<Product?> GetByIdAsync(int id);


        // Add a new product
        Task AddAsync(Product product);
    }
}