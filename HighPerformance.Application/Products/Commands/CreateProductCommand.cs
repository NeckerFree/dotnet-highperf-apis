using HighPerformance.Application.DTOs;
using MediatR;

namespace HighPerformance.Application.Products.Commands
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
   
}
