using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofHR
{
    public class EmployerHRRoleValidator : HRRoleValidator<EmployerHRRole>
    {
        public EmployerHRRoleValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerHRRole>.CreateWithOptions((EmployerHRRole)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}