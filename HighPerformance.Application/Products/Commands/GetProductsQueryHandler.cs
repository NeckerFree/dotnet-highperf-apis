using HighPerformance.Application.Interfaces;
using HighPerformance.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HighPerformance.Application.Products.Queries
{

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
