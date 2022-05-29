using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofTrade
{
    public class EmployeeTCommodityValidator : TCommodityValidator<EmployeeTCommodity>
    {
        public EmployeeTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeTCommodity>.CreateWithOptions((EmployeeTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}