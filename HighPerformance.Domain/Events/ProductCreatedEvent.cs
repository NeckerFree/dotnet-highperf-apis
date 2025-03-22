using HighPerformance.Domain.Entities;

namespace HighPerformance.Domain.Events
{

    public class ProductCreatedEvent(Product product)
    {
        public Product Product { get; } = product;
    }
}