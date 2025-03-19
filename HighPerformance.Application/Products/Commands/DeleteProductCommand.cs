using MediatR;

namespace HighPerformance.Application.Products.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }

    }
}
