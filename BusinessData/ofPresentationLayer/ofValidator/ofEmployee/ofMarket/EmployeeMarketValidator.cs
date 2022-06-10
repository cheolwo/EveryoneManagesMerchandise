using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofMarket
{
    public class EmployeeMarketValidator : MarketValidator<EmployeeMarket>
    {
        public EmployeeMarketValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeMarket>.CreateWithOptions((EmployeeMarket)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}