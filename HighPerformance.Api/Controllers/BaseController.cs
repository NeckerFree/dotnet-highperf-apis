namespace HighPerformance.Api.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    namespace HighPerformance.Api.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public abstract class BaseController : ControllerBase
        {
            protected readonly IMediator Mediator;
            private readonly ILogger _logger;

            // Constructor to accept IMediator and ILogger
            protected BaseController(IMediator mediator, ILogger logger)
            {
                Mediator = mediator;
                _logger = logger;
            }

            /// <summary>
            /// Handles sending a MediatR request and returning an appropriate response.
            /// </summary>
            /// <typeparam name="TResponse">The type of the response.</typeparam>
            /// <param name="request">The MediatR request.</param>
            /// <param name="cancellationToken">The cancellation token.</param>
            /// <returns>An ActionResult containing the response.</returns>
            protected async Task<ActionResult<TResponse>> HandleRequest<TResponse>(
                IRequest<TResponse> request, CancellationToken cancellationToken = default)
            {
                _logger.LogInformation($"Handling request of type {request.GetType().Name}");
                var response = await Mediator.Send(request, cancellationToken);
                return Ok(response);
            }

            /// <summary>
            /// Handles sending a MediatR request and returning a CreatedAtAction response.
            /// </summary>
            /// <typeparam name="TResponse">The type of the response.</typeparam>
            /// <param name="request">The MediatR request.</param>
            /// <param name="actionName">The name of the action to use for generating the URL.</param>
            /// <param name="routeValues">The route values to include in the URL.</param>
            /// <param name="cancellationToken">The cancellation token.</param>
            /// <returns>A CreatedAtActionResult containing the response.</returns>
            protected async Task<ActionResult<TResponse>> HandleCreateRequest<TResponse>(
                IRequest<TResponse> request, string actionName, object routeValues, CancellationToken cancellationToken = default)
            {
                _logger.LogInformation($"Handling request of type {request.GetType().Name}");
                var response = await Mediator.Send(request, cancellationToken);
                return CreatedAtAction(actionName, routeValues, response);
            }

            /// <summary>
            /// Handles sending a MediatR request and returning a NoContent response.
            /// </summary>
            /// <param name="request">The MediatR request.</param>
            /// <param name="cancellationToken">The cancellation token.</param>
            /// <returns>A NoContentResult.</returns>
            protected async Task<IActionResult> HandleNoContentRequest(
                IRequest<bool> request, CancellationToken cancellationToken = default)
            {
                _logger.LogInformation($"Handling no-content request of type {request.GetType().Name}");
                var result = await Mediator.Send(request, cancellationToken);
                return result ? NoContent() : NotFound();
            }
        }
    }
}
