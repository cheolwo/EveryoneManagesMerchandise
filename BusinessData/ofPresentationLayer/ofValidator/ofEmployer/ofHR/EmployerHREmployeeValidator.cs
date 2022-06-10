using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofHR
{
    public class EmployerHREmployeeValidator : HREmployeeValidator<EmployerHREmployee>
    {
        public EmployerHREmployeeValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerHREmployee>.CreateWithOptions((EmployerHREmployee)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}