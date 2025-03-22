using MediatR;
using HighPerformance.Application.DTOs;
using HighPerformance.Application.Interfaces;
using AutoMapper;
using System.Threading.Tasks;
using System.Threading;
using HighPerformance.Application.Products.Queries;
using System.Collections.Generic;

namespace HighPerformance.Application.Products.Handlers
{
    public class GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        
        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);
           var productDto= mapper.Map<ProductDto>(product);
            return productDto;
        }
    }
}

