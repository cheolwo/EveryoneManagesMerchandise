using BusinessView.ofValidator.ofCommon.ofHR;
using FluentValidation;
using BusinessData.ofPresentationLayer.ofDTO.ofHR.ofPlatform;
namespace BusinessView.ofValidator.ofPlatform.ofHR
{
    public class PlatformHRBusinessPartValidator : HRBusinessPartValidator<PlatformHRBusinessPart>
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