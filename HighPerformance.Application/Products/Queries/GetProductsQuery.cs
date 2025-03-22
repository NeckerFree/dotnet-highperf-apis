using HighPerformance.Application.DTOs;
using MediatR;
using System.Collections.Generic;
namespace HighPerformance.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<ProductDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
