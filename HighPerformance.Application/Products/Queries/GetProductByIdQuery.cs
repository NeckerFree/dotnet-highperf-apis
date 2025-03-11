using HighPerformance.Domain.Entities;
using MediatR;

namespace HighPerformance.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
