using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofMarket
{
    public class EmployerMCommodityValidator : MCommodityValidator<EmployerMCommodity>
    {
        public EmployerMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerMCommodity>.CreateWithOptions((EmployerMCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}