using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofTrade;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofTrade
{
    public class EmployeeSTCommodityValidator : STCommodityValidator<EmployeeSTCommodity>
    {
        public EmployeeSTCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeSTCommodity>.CreateWithOptions((EmployeeSTCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}