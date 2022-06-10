using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofValidator.ofEmployee.ofWarehouse
{
    public class EmployeeDividedTagValidator : DividedTagValidator<EmployeeDividedTag>
    {
        public EmployeeDividedTagValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeDividedTag>.CreateWithOptions((EmployeeDividedTag)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}