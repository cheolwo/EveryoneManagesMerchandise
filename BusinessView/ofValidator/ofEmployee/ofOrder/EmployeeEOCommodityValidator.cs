using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofOrder
{
    public class EmployeeEOCommodityValidator : EOCommodityValidator<EmployeeEOCommodity>
    {
        public EmployeeEOCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeEOCommodity>.CreateWithOptions((EmployeeEOCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}