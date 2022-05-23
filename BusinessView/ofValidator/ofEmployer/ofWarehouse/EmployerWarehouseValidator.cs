using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofWarehouse
{
    public class EmployerWarehouseValidator : EmployerCenterValidator<EmployerWarehouse>
    {
        public EmployerWarehouseValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerWarehouse>.CreateWithOptions((EmployerWarehouse)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}