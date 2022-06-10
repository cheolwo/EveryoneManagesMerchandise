using BusinessData.ofPresentationLayer.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofOrder;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofOrder
{
    public class EmployeeMOCommodityValidator : MOCommodityValidator<EmployeeMOCommodity>
    {
        public EmployeeMOCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeMOCommodity>.CreateWithOptions((EmployeeMOCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}