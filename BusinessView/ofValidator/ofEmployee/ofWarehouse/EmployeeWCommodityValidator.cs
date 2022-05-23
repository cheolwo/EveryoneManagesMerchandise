using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofWarehouse
{
    public class EmployeeWCommodityValidator : EmployeeCommodityValidator<EmployeeWCommodity>
    {
        public EmployeeWCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeWCommodity>.CreateWithOptions((EmployeeWCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}