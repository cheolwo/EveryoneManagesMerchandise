using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using BusinessView.ofValidator.ofCommon.ofPlatform;
using FluentValidation;
namespace BusinessView.ofValidator.ofPlatform.ofWarehouse
{
    public class PlatformLoadFrameValidator : PlatformEntityValidator<PlatformLoadFrame>
    {
        public PlatformLoadFrameValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PlatformLoadFrame>.CreateWithOptions((PlatformLoadFrame)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}