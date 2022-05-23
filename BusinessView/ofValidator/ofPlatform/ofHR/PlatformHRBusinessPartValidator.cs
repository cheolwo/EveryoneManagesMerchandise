using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofHR
{
    public class PlatformHRBusinessPartValidator : PlatformEntityValidator<PlatformHRBusinessPart>
    {
        public PlatformHRBusinessPartValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformHRBusinessPart>.CreateWithOptions((PlatformHRBusinessPart)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}