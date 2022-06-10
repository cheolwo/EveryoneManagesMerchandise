using BusinessData.ofPresentationLayer.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofMarket;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofMarket
{
    public class EmployeeSMCommodityValidator : SMCommodityValidator<EmployeeSMCommodity>
    {
        public EmployeeSMCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeSMCommodity>.CreateWithOptions((EmployeeSMCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}