using HighPerformance.Domain.Entities;

namespace HighPerformance.Domain.Events
{

    public class ProductCreatedEvent
    {
        public Product Product { get; }

        public ProductCreatedEvent(Product product)
        {
            Product = product;
        }
    }
}