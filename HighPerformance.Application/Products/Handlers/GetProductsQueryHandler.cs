using AutoMapper;
using HighPerformance.Application.DTOs;
using HighPerformance.Application.Interfaces;
using HighPerformance.Application.Products.Queries;
using HighPerformance.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HighPerformance.Application.Products.Handlers
{

    public class GetProductsQueryHandler(IProductRepository repository, IMapper mapper) : IRequestHandler<GetProductsQuery, IEnumerable<ProductDto>>
    {
        public async Task<IEnumerable<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await repository.GetAllAsync();
        return mapper.Map<List<ProductDto>>(products);
        }
    }
}
