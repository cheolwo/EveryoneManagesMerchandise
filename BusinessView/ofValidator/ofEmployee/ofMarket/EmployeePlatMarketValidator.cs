using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofMarket
{
    public class EmployeePlatMarketValidator : PlatMarketValidator<EmployeePlatMarket>
    {
        public EmployeePlatMarketValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeePlatMarket>.CreateWithOptions((EmployeePlatMarket)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}