using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofMarket
{
    public class EmployerMarketValidator : EmployerCenterValidator<EmployerMarket>
    {
        public EmployerMarketValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerMarket>.CreateWithOptions((EmployerMarket)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}