using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessView.ofDTO.ofWarehouse.ofEmployer;

namespace BusinessView.ofValidator.ofEmployer.ofWarehouse
{
    public class EmployerWCommodityValidator : WCommodityValidator<EmployerWCommodity>
    {
        public EmployerWCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerWCommodity>.CreateWithOptions((EmployerWCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}