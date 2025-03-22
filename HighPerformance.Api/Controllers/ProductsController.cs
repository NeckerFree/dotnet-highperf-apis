using HighPerformance.Application.DTOs;
using HighPerformance.Application.Products.Commands;
using HighPerformance.Application.Products.Queries;
using HighPerformance.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HighPerformance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMediator mediator) : ControllerBase
    {

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts(CancellationToken cancellationToken, [FromQuery] int pageNumber=1, [FromQuery] int pageSize=10)
        {
            var query = new GetProductsQuery { PageNumber=pageNumber, PageSize=pageSize};
            var products = await mediator.Send(query, cancellationToken);
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id, CancellationToken cancellationToken)
        {
            var query = new GetProductByIdQuery { Id = id };
            var product = await mediator.Send(query, cancellationToken);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostProduct(CreateProductCommand command)
        {
            var product = await mediator.Send(command);
            return CreatedAtAction(nameof(GetProduct), new { id = product }, product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var result = await mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            var result = await mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
