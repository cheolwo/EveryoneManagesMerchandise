using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofHR
{
    public class PlatformHRRoleValidator : HRRoleValidator<PlatformHRRole>
    {
        public PlatformHRRoleValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformHRRole>.CreateWithOptions((PlatformHRRole)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}