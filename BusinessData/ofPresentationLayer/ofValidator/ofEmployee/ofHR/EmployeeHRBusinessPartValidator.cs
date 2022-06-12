using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployee;
using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployee.ofHR
{
    public class EmployeeHRBusinessPartValidator : HRBusinessPartValidator<EmployeeHRBusinessPart>
    {
        public EmployeeHRBusinessPartValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployeeHRBusinessPart>.CreateWithOptions((EmployeeHRBusinessPart)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}