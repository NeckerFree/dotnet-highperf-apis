using HighPerformance.Application.DTOs;
using MediatR;

namespace HighPerformance.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }
    }
}
