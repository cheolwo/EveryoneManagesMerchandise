using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofValidator.ofCommon.ofEmployer;
using FluentValidation;
namespace BusinessView.ofValidator.ofEmployer.ofHR
{
    public class EmployerHRBusinessPartValidator : EmployerEntityValidator<EmployerHRBusinessPart>
    {
        public EmployerHRBusinessPartValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EmployerHRBusinessPart>.CreateWithOptions((EmployerHRBusinessPart)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}