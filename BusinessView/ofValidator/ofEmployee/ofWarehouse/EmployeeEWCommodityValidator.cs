using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofWarehouse
{
    public class EmployeeEWCommodityValidator : EmployeeStatusValidator<EmployeeEWCommodity>
    {
        public EmployeeEWCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeEWCommodity>.CreateWithOptions((EmployeeEWCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}