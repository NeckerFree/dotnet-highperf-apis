using HighPerformance.Application.DTOs;
using MediatR;
using System.Collections.Generic;
namespace HighPerformance.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductDto>>
    {
    }
}
