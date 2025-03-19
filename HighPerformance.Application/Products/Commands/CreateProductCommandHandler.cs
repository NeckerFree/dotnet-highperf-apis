using HighPerformance.Application.Interfaces;
using HighPerformance.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HighPerformance.Application.Products.Commands
{
    public class CreateProductCommandHandler(IProductRepository repository) : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository = repository;

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product { Name = request.Name, Price = request.Price };
            await _repository.AddAsync(product);
            return product.Id;
        }
    }
}
