using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofMarket
{
    public class EmployeeMCommodityValidator : MCommodityValidator<EmployeeMCommodity>
    {
        public EmployeeMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeMCommodity>.CreateWithOptions((EmployeeMCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}