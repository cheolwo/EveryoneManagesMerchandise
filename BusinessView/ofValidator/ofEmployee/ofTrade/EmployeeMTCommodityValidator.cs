using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofTrade
{
    public class EmployeeMTCommodityValidator : MTCommodityValidator<EmployeeMTCommodity>
    {
        public EmployeeMTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeMTCommodity>.CreateWithOptions((EmployeeMTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}