using FluentValidation;
using HighPerformance.Application.Products.Queries;

namespace HighPerformance.Application.Products.Validators
{
    public class GetProductByIdQueryValidator: AbstractValidator<GetProductByIdQuery>
    {
        public GetProductByIdQueryValidator() {
            RuleFor(x=> x.Id).GreaterThan(0).WithMessage("Id must be greater than 0.");
        }
    }
}
