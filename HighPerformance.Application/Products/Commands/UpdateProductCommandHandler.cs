using HighPerformance.Application.Interfaces;
using HighPerformance.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HighPerformance.Application.Products.Commands
{
    public class UpdateProductCommandHandler(IProductRepository repository) : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _repository = repository;

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            if (product == null)
            {
                return false;
            }

            product.Name = request.Name;
            product.Price = request.Price;

            await _repository.UpdateAsync(product);
            return true;
        }
    }
}
