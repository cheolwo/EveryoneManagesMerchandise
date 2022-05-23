using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofTrade
{
    public class EmployeeETCommodityValidator : EmployeeStatusValidator<EmployeeETCommodity>
    {
        public EmployeeETCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeETCommodity>.CreateWithOptions((EmployeeETCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}