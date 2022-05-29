using BusinessView.ofValidator.ofCommon.ofWarehouse;
using FluentValidation;
using BusinessView.ofDTO.ofWarehouse.ofPlatform;

namespace BusinessView.ofValidator.ofPlatform.ofWarehouse
{
    public class PlatformLoadFrameValidator : LoadFrameValidator<PlatformLoadFrame>
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