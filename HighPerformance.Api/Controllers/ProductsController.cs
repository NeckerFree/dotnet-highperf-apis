using HighPerformance.Application.Products.Commands;
using HighPerformance.Application.Products.Queries;
using HighPerformance.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HighPerformance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var query = new GetProductsQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var query = new GetProductByIdQuery { Id = id };
            var product = await _mediator.Send(query);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(CreateProductCommand command)
        {
            var product = await _mediator.Send(command);
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

            var result = await _mediator.Send(command);

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
            var result = await _mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
