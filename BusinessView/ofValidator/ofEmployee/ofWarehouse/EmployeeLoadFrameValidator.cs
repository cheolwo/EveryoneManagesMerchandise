using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofValidator.ofEmployee.ofWarehouse
{
    public class EmployeeLoadFrameValidator : LoadFrameValidator<EmployeeLoadFrame>
    {
        public EmployeeLoadFrameValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeLoadFrame>.CreateWithOptions((EmployeeLoadFrame)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}