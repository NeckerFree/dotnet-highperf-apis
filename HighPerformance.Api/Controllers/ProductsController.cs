using HighPerformance.Api.Controllers.HighPerformance.Api.Controllers;
using HighPerformance.Application.DTOs;
using HighPerformance.Application.Products.Commands;
using HighPerformance.Application.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HighPerformance.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController(IMediator mediator, ILogger<ProductsController> logger) : BaseController(mediator)
    {
        private readonly ILogger<ProductsController> _logger = logger;

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts(
            CancellationToken cancellationToken, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            _logger.LogInformation($"Fetching all products");
            var query = new GetProductsQuery { PageNumber = pageNumber, PageSize = pageSize };
            return await HandleRequest(query, cancellationToken);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct( int id, CancellationToken cancellationToken)
        {
            var query = new GetProductByIdQuery { Id = id };
            var product = await HandleRequest(query, cancellationToken);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // POST: api/Products
        
        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostProduct(CreateProductCommand command)
        {
            var product = await base.Mediator.Send(command); // product is of type ProductDto
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            return await HandleNoContentRequest(command);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            return await HandleNoContentRequest(command);
        }
    }
}