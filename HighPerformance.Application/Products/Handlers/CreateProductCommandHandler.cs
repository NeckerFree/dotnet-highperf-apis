using AutoMapper;
using HighPerformance.Application.DTOs;
using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Products.Commands;
using HighPerformance.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HighPerformance.Application.Products.Handlers
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<CreateProductCommand, ProductDto>
    {
        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            await productRepository.AddAsync(product);
            return mapper.Map<ProductDto>(product);
        }
    }
}