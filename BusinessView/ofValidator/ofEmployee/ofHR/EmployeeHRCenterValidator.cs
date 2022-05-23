using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofEmployee;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofHR
{
    public class EmployeeHRCenterValidator : EmployeeCenterValidator<EmployeeHRCenter>
    {
        public EmployeeHRCenterValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeHRCenter>.CreateWithOptions((EmployeeHRCenter)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}