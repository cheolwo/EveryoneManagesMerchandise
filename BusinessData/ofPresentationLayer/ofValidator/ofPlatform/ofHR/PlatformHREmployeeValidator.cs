using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofHR
{
    public class PlatformHREmployeeValidator : HREmployeeValidator<PlatformHREmployee>
    {
        public PlatformHREmployeeValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformHREmployee>.CreateWithOptions((PlatformHREmployee)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}