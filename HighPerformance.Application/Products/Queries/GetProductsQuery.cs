using HighPerformance.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace HighPerformance.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
