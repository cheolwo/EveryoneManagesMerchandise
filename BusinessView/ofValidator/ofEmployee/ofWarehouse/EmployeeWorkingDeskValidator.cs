using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessView.ofDTO.ofWarehouse.ofEmployee;

namespace BusinessView.ofValidator.ofEmployee.ofWarehouse
{
    public class EmployeeWorkingDeskValidator : WorkingDeskValidator<EmployeeWorkingDesk>
    {
        public EmployeeWorkingDeskValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeWorkingDesk>.CreateWithOptions((EmployeeWorkingDesk)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}