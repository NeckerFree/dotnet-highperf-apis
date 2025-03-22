using HighPerformance.Domain.Entities;
using MediatR;

namespace HighPerformance.Application.Products.Commands
{
    public class GetProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
